using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    /// <summary>
    /// Класс данных с методами печати и сортировки массива строк
    /// </summary>
    public class UserData
    {
        /// <summary>
        /// массив данных
        /// </summary>
        public string[] Data 
        {
            get
            {
                return new string[]  {"Иванов", "Петров", "Алексеев", "Сидоров", "Борисов"};
            }
        }  
        /// <summary>
        /// Лог действий
        /// </summary>
        private List<string> Log { get; set; }
        public UserData()
        {            
            Log = new List<string>();
        }

        /// <summary>
        /// Метод сортирующий массив в порядке возрастания или убывания в зависимости от option
        /// </summary>           
        /// <param name="option"> 1- сортировка по возрастанию; 2 - сортировка по убыванию </param>            
        public void Sort(int option)
        {
            if (option == 1)
            {
                Array.Sort(Data);
                LogIt("Массив отсортирован по возрастанию");
            }
            else
            {
                Array.Sort(Data);
                Array.Reverse(Data);
                LogIt("Массив отсортирован по убыванию");
            }
            
        }
        /// <summary>
        /// Метод печати массива строк
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Массив данных:\n");
            foreach (var item in Data)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n_________________________\n");
            LogIt("Массив выведен на экран пользователю");
        }

        /// <summary>
        /// добавляет строку в лог
        /// </summary>
        /// <param name="message"></param>
        private void LogIt(string message)
        {
            Log.Add(message);
        }
        /// <summary>
        /// выводит лог
        /// </summary>
        public void PrintLog()
        {
            Console.WriteLine("Лог работы программы:\n");
            foreach (var item in Log)
            {
                Console.WriteLine(item);
            }
        }
       
    }
}
