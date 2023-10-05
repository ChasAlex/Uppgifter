using static lab7.Program;

namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Räknar ut area för dem olika geomentri objekten

            Cirkel minCirkel = new Cirkel(3.11);
            Console.WriteLine(minCirkel.Area());

            Fyrkant minFyrkant = new Fyrkant(5.1343, 4.234);
            Console.WriteLine(minFyrkant.Area());

            Rektangel minRektangel = new Rektangel(1.22, 99.4);
            Console.WriteLine(minRektangel.Area());

            Parallelogram minParallelogram = new Parallelogram(4.33, 23.4);
            Console.WriteLine(minParallelogram.Area());

            Elips minElips = new Elips(3.3, 5.3);
            Console.WriteLine(minElips.Area());





        }
        //Abstract bas klass för alla geometri objekt
        public abstract class Geometri
        {

            public abstract double Area();

        }
        //Subklass av Geometri med override metod som räknar ut area av en cirkel
        public class Cirkel : Geometri
        {
            public double _radius { get; set; }

            public Cirkel(double radius)
            {
                _radius = radius;
            }

            public override double Area()
            {

                return Math.PI * Math.Pow(_radius, 2);
            }

        }

        //Subklass av Geometri med override metod som räknar ut area av en fyrkant
        public class Fyrkant : Geometri
        {
            public double _bas { get; set; }
            public double _height { get; set; }
            public Fyrkant(double bas, double height)
            {
                _height = height;
                _bas = bas;
            }

            public override double Area()
            {

                return _bas * _height;
            }

        }
        //Subklass av Geometri med override metod som räknar ut area av en Rektangel
        public class Rektangel : Geometri
        {
            public double _bas { get; set; }
            public double _height { get; set; }
            public Rektangel(double bas, double height)
            {
                _height = height;
                _bas = bas;
            }

            public override double Area()
            {

                return (_bas * _height) / 2;
            }

        }
        //Subklass av Geometri med override metod som räknar ut area av en Parallelogram
        public class Parallelogram : Geometri
        {
            public double _bas { get; set; }
            public double _height { get; set; }
            public Parallelogram(double bas, double height)
            {
                _height = height;
                _bas = bas;
            }

            public override double Area()
            {

                return _bas * _height;
            }

        }
        //Subklass av Geometri med override metod som räknar ut area av en Elips
        public class Elips : Geometri
        {
            public double _radie1 { get; set; }
            public double _radie2 { get; set; }
            public Elips(double radie1, double radie2)
            {
                _radie1 = radie1;
                _radie2 = radie2;
            }

            public override double Area()
            {

                return Math.PI * _radie1 * _radie2;
            }

        }








    }
}