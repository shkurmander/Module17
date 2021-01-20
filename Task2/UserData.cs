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
        public string[] Data { get; set; }
        public UserData()
        {
            Data = new string[5]
            {
                    "Иванов",
                    "Петров",
                    "Алексеев",
                    "Сидоров",
                    "Борисов"
            };
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
            }
            else
            {
                Array.Sort(Data);
                Array.Reverse(Data);
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
        }
        public void MakeSort(int option)
        {
            Sort(option);
            Print();

        }
    }
}
