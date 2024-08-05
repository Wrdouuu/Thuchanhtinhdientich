using System;

namespace THUCHANHTINHDIENTICH
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            int width;
            int area;

            Console.WriteLine("Enter height: ");
            height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            width = Int32.Parse(Console.ReadLine());

            area = width * height;
            Console.WriteLine("Area is: " + area);


        }
    }
}

