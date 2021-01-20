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
        /// Метод сортирующий массив в порядке возрастания или убывания в зависимости от option
        /// </summary>
        /// <param name="array">Массив строк для сортировки</param>
        /// <param name="option"> 1- сортировка по возрастанию; 2 - сортировка по убыванию </param>
        /// <returns>Отсортированный массив array</returns>
        public static string[] SortArray(string[] array, int option)
        {
            if (option == 1)
            {
                Array.Sort(array);
                return array;
            }
            else
            {
                Array.Sort(array);
                Array.Reverse(array);
                return array;
            }
            
        }
        /// <summary>
        /// Собственный класс исключения
        /// </summary>
        public class IncorrectActionException : Exception
        {
            public static string Message { get; set; }
            public IncorrectActionException(string message, string val) : base(Message)
            {
                Message = message + "Полученный параметр: " + val ;
            }
        }
        public static void PrintArray(string[] array)
        {
            Console.WriteLine("Массив:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            
            
            string[] data = new string[5]
            {
                "Иванов",
                "Петров",
                "Алексеев",
                "Сидоров",
                "Борисов"
            };

            bool exit = false;
            do
            {
                try
                {
                    Console.WriteLine();
                }
                catch (Exception)
                {

                    throw;
                }
                Console.WriteLine("_________________________\n");
                
                Console.WriteLine("Для выхода нажмите ESC, для продолжения - любую клавишу");

                if (Console.ReadKey().Key == ConsoleKey.Escape) exit = true;

            } while (!exit);


            Console.ReadKey();


        }
    }
}
