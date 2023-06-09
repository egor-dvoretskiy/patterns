using Patterns.Iterator.Source.Models;

namespace Patterns.Iterator
{
    internal class Program
    {
        /// <summary>
        /// Когда необходимо осуществить обход объекта без раскрытия его внутренней структуры
        /// Когда имеется набор составных объектов, и надо обеспечить единый интерфейс для их перебора
        /// Когда необходимо предоставить несколько альтернативных вариантов перебора одного и того же объекта
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Library library = new Library();
            Reader reader = new Reader();
            reader.SeeBooks(library);

            Console.ReadKey();
        }
    }
}