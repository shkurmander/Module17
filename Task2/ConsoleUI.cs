using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class ConsoleUI
    {
        delegate void ChangeDataHandler(int option);
        delegate void UserDataActionHandler();

        event ChangeDataHandler ChangeDataNotify;
        event UserDataActionHandler UserDataActionNotify;
        /// <summary>
        /// Собственный класс исключения
        /// </summary>
        public class IncorrectActionException : Exception
        {
           
            public IncorrectActionException(string message, int val) : base(message + "Полученный параметр: " + val + " Возможные варианты ввода \"1\",\"2\"")
            {
                
            }
        }

        
        
        public void Start()
        {
            var data = new UserData();
            ChangeDataNotify += data.Sort;
            UserDataActionNotify += data.Print;
            UserDataActionNotify += data.PrintLog;
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
                        UserDataActionRequest("print");
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
        /// <summary>
        /// вызов события к которому прикручена сортировка
        /// </summary>
        /// <param name="option">Параметр сортировки</param>
        protected virtual void DataChangeRequest(int option)
        {
            ChangeDataNotify?.Invoke(option);
        }
        /// <summary>
        /// вызов события к которому прикручена печать массива и лога действий
        /// </summary>
        
        protected virtual void UserDataActionRequest(string key)
        {
            UserDataActionNotify?.Invoke();             
        }
    }
}
