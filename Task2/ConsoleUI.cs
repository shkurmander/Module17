using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class ConsoleUI
    {
        /// <summary>
        /// Собственный класс исключения
        /// </summary>
        public class IncorrectActionException : Exception
        {
           
            public IncorrectActionException(string message, int val) : base(message + "Полученный параметр: " + val + " Возможные варианты ввода \"1\",\"2\"")
            {
                
            }
        }

        delegate void ChangeDataHandler(int option);
       
        event ChangeDataHandler ChangeDataNotify;
        
        public void Start()
        {
            var data = new UserData();
            ChangeDataNotify += data.Sort;
            data.Print();

            bool exit = false;
            do
            {
                try
                {
                    Console.WriteLine("Введите параметр сортировки:");
                    Console.WriteLine("1- сортировка по возрастанию; 2 - сортировка по убыванию");
                    var option = Convert.ToInt32(Console.ReadLine());
                    if (option < 1 || option > 2)
                    {
                        throw new IncorrectActionException("Такого параметра не существует! ", option);
                    }
                    else
                    {
                        DataChangeRequest(option);
                        data.Print();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не целое число, либо символ! Возможные варианты ввода \"1\",\"2\"");
                }
                catch (IncorrectActionException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {

                    Console.WriteLine("_________________________\n");

                    Console.WriteLine("Для выхода нажмите ESC, для продолжения - любую клавишу");

                    if (Console.ReadKey().Key == ConsoleKey.Escape) exit = true;
                }

            } while (!exit);
        }
        protected virtual void DataChangeRequest(int option)
        {
            ChangeDataNotify?.Invoke(option);
        }
    }
}
