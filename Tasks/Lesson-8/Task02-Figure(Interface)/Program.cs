using System;

namespace Task02_Figure_Interface_
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec1 = new Rectangle();
            rec1.CalculateArea(4, 5);
            rec1.CalculatePerimeter(4, 5);
        }
    }
    interface IFigure
    {
        void CalculateArea(int a, int b);
        void CalculatePerimeter(int a, int b);

    }
    class Rectangle : IFigure
    {
        public void CalculateArea(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Area of rectangle: " + result);
        }

        public void CalculatePerimeter(int a , int b)
        {
            int result = 2 * (a + b);
            Console.WriteLine("Perimeter of rectangular is: " + result);
        }
    }

    //class Circle : IFigure
    //{
    //    public void CalculateArea()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void CalculatePerimeter()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //class Triangle : IFigure
    //{
    //    public void CalculateArea()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void CalculatePerimeter()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //class Square : IFigure
    //{
    //    public void CalculateArea()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void CalculatePerimeter()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
