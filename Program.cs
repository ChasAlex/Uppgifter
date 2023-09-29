using System.Formats.Asn1;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Räknar ut arean,volym,omkrets av cirkel med radie 5 avrundat till 2 decimaler
            Circle Circle1 = new Circle(5);  
            Console.WriteLine("Area of circle with radius 5:" + Math.Round(Circle1.GetArea(),2));
            Console.WriteLine("Volume of circle with radius 5:" + Math.Round(Circle1.GetVolume(), 2));
            Console.WriteLine("Circumference of circle with radius 5:" + Math.Round(Circle1.GetCircum(), 2));
            // Räknar ut arean,volym,omkrets av cirkel med radie 6 avrundat till 2 decimaler
            Circle Circle2 = new Circle(6);
            Console.WriteLine("Area of circle with radius 6:" + Math.Round(Circle2.GetArea(), 2));
            Console.WriteLine("Volume of circle with radius 6:" + Math.Round(Circle2.GetVolume(), 2));
            Console.WriteLine("Circumference of circle with radius 6:" + Math.Round(Circle2.GetCircum(), 2));
        }
    }

    public class Circle
    {
        // Deklarera fält varibler 
        private double _radius;


        // Konstruktören tar värdet inmatat i instancen och sätter den lika med varibeln som senare kan användas för metoder
        public Circle(double radius) {

            _radius = radius;
                
        }

        // Metoder som räknar ut area för en cirkel.
        public double GetArea(){
            return _radius * _radius * Math.PI; 
        
        
        }
        // Metod som räknar ut volymen för ett klot
        public double GetVolume()
        {
            return (4 * Math.PI * Math.Pow(_radius,3))/3;
        }

        //Metod som räknar ut omkretsen av en cirkel
        public double GetCircum()
        {
            return (2 * Math.PI) * _radius;
        }

    }


    public class Triangle {

        private double _side;
        private double _height;


        public Triangle(double side, double height) {
        
            _side = side;
            _height = height;
  
        
        
        }
        
        public double GetArea() {
        
            return (_side * _height) / 2; 
        
        }



    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }















}