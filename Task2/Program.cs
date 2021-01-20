using System;

namespace Task2
{
    /// <summary>
    /// Создайте консольное приложение, в котором будет происходить 
    /// сортировка списка фамилий из пяти человек. Сортировка должна происходить при помощи события. 
    /// Сортировка происходит при введении пользователем либо числа 1 (сортировка А-Я), либо числа 2 (сортировка Я-А).
    /// Дополнительно реализуйте проверку введённых данных от пользователя через конструкцию TryCatchFinally с 
    /// использованием собственного типа исключения.
    /// </summary>
    
    class Program
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
            private void Sort(int option)
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
            public  void Print()
            {
                Console.WriteLine("Массив:");
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

        static void Main(string[] args)
        {
            var ui = new ConsoleUI();
            ui.Start();            


        }
    }
}
