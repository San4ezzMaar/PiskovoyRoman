using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace PiskovoyRoman
{
    class Box
    {
        public float Height;
        public float Width;
        public float Length;

        public void Show()
        {
            Console.WriteLine("Данные о коробке");
            Console.WriteLine($"Высота: {Height}");
            Console.WriteLine($"Ширина: {Width}");
            Console.WriteLine($"Длина: {Length}");
        }

        // Метод расчёта объёма коробки
        public float Volume()
        {
            return Height * Width * Length;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Box box = new Box();

            box.Width = 2;
            box.Height = 3;
            box.Length = 5;

            box.Show();

            float volume = box.Volume();
            Console.WriteLine($"Объем коробки: {volume}");
            Console.ReadKey();
        }
    }
}