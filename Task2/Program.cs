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

        static void Main(string[] args)
        {
            //string path = @"c:\test\students.dat";
            string path = "";


            bool exit = false;
            do
            {
                //проверка на пустой ввод
                do
                {
                    Console.WriteLine("введите путь к файлу с данными:");
                    path = Console.ReadLine();
                    if (path == "") Console.WriteLine("вы ничего не ввели!!!");

                } while (path.Length < 1);

                

                Console.WriteLine("_________________________\n");
                
                Console.WriteLine("Для выхода нажмите ESC, для продолжения - любую клавишу");

                if (Console.ReadKey().Key == ConsoleKey.Escape) exit = true;

            } while (!exit);


            Console.ReadKey();


        }
    }
}
