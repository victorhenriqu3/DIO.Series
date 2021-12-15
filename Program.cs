using System;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Serie serie = new Serie(1, Genero.Acao, "Duro de matar", "John Maclane", 1989);
            Console.WriteLine(serie.ToString());
        }
    }
}
