using System;

namespace OOP_ShapesProject {
    class Program {
        static void Main(string[] args) {
            var quad1 = new Quad(5, 7, 13, 6);


            
            var perimeter = quad1.Perimeter();
            Console.WriteLine($"The quad perimeter is {perimeter}.");



            var rect1 = new Rect(5, 13);
            var area = rect1.Area();
            perimeter = rect1.Perimeter();
            Console.WriteLine($"The rect perimeter is {perimeter}. Area is {area}.");

            var square1 = new Square(8);
            perimeter = square1.Perimeter();
            area = square1.Area();
            Console.WriteLine($"The square perimeter is {perimeter}. Area is {area}.");

        }
    }
}
