using System;
using System.IO;

namespace Task1
{
    /// <summary>
    /// Создайте свой тип исключения.
    /// Сделайте массив из пяти различных видов исключений, включая собственный тип исключения.Реализуйте конструкцию TryCatchFinally,
    /// в которой будет итерация на каждый тип исключения (блок finally по желанию).
    /// В блоке catch выведите в консольном сообщении текст исключения.
    /// </summary>
    class Program
    {
        public class DevExeption : Exception
        {
            public DevExeption(string message) : base(message) { }
        }
        static void Main(string[] args)
        {
            Exception[] exeptions = new Exception[5];

            exeptions[0] = new DivideByZeroException("Делить на ноль нельзя!");
            exeptions[1] = new StackOverflowException("Переполнение стека!");
            exeptions[2] = new FileNotFoundException("Указанный файл не существует!");
            exeptions[3] = new TimeoutException("Время ожидания операции истекло!");
            exeptions[4] = new DevExeption("Исключение разработчика!");

            foreach (var item in exeptions)
            {
                try
                {
                    throw item;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
