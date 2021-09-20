using System;

namespace ConsoleApp1
{
    public class Product
    {

        private double _length;
        private double _width;
        private double _height;
        private double _weight;

        public Product(double length, double width, double height, double weight)
        {
            _length = length;
            _width = width;
            _height = height;
            _weight = weight;
        }

        public double Length { 
            get 
            { 
                return _length; 
            }
        }
        public double Width { 
            get 
            { 
                return _width; 
            } 
        }
        public double Height { 
            get 
            { 
                return _height; 
            } 
        }
        public double Weight {
            get
            {
                return _height;
            }
        }

        public void Print(double length, double width, double height, double weight)
        {
            Console.WriteLine($"Length: {length}, \nWidth: {width}, \nHeight: {height}, \nWeight: {weight}");
        }
    }
}
