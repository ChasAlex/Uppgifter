using System.Security.Cryptography.X509Certificates;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Creating 4 different objects of different classes
            Dog goodDog = new Dog("Dogge",10,"Labrador");
            Cat niceCat = new Cat("Bjorne", 5, "Bond Katt");
            Chicken aChicken = new Chicken("El Pollo", 5,true);
            Bulldog myBulldog = new Bulldog("Lego",15,"Bulldog",true);
            //Using some of the method for dogs, chickens and cats
            goodDog.PrintBreed();
            goodDog.makeSound();
            myBulldog.HasFlatFace();

            aChicken.LayedEgg();
            aChicken.makeSound();

            niceCat.FatCat();
            niceCat.makeSound();





        }
    }

    //Declaring a base clase for Animal with 5 properties
    public class Animal
    {
        public int _legs { get; set; }
        public string _name { get; set; }
        public bool _isMammal { get; set; }
        public double _weight { get; set; }
        public bool _canFly { get; set; }

        //Class constructor for the animal class
        public Animal(int legs, string name, bool isMammal, double weight, bool canFly) {
        
            _legs = legs;
            _name = name;
            _canFly = canFly;
            _weight = weight;
            _isMammal = isMammal;

        }
        // Three methods shared among all animals in the animal class
        public void makeSound ()
        {
            Console.WriteLine($"{_name} :***Loud animal scream***");
        }

        public string IsSneaky()
        {
            string isNinja;
            
            if (_weight > 50)
            {
                return isNinja = $"{_name} is a larger animal and cannot sneak up on you";
            }
            else
            {
                return isNinja = $"{_name} is a smaller animal and can sneak up on you! Watch out";
            }
        }


        public bool LaysEggs()
        {
            if (_isMammal)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
    //Subclass of of the Animal class
    public class Dog : Animal
    {
    public string _breed { get; set; }
    public Dog( string name, double weight, string breed)
           : base(4, name, true, weight, false)
        {
            _breed = breed;
        }

        // Unique method of the dog class
        public void PrintBreed()
        {
            Console.WriteLine($"This dog is of the breed {_breed}");
        }




    }
    //Declaring a subclass of the Animal class for chickens
    public class Chicken : Animal
    {
        public bool _layeggs { get; set; }
        public Chicken(string name, double weight, bool layeggs)
               : base(2, name, false, weight, true)
        {
            _layeggs = layeggs;
        }
        // Unique method for chickens
        public void LayedEgg()
        {
            if( _layeggs)
            {
                Console.WriteLine($"The chicken namned {_name} layed an egg!");
            }
            else
            {
                Console.WriteLine("This chicken did not lay an egg");
            }
        }




    }

    //Subclass of Animals for cats
    public class Cat : Animal
    {
        public string _breed { get; set; }
        public Cat(string name, double weight, string breed)
               : base(4, name, true, weight, false)
        {
            _breed = breed;
        }
        // Unique methods for the Cat class
        public void FatCat()
        {
            if(_weight > 20)
            {
                Console.WriteLine($"{_name} is a fat cat");
            }
            else
            {
                Console.WriteLine($"{_name} is not a fat cat");
            }
        }




    }

    // Subclass of Dog for bulldogs
    public class Bulldog : Dog
    {
        public bool _flatface { get; set; }
        public Bulldog(string name, double weight,string breed, bool flatface)
               : base(name, weight,breed)
        {
            _flatface = flatface;
        }
        // Unique Subclass for bulldogs
        public void HasFlatFace()
        {
            if (_flatface)
            {
                Console.WriteLine("Cute bulldog");
            }
            else {
                Console.WriteLine("Is this a bulldog reall?");
            }
        }




    }

    // Subclass of the Dog class for Chihuahuas
    public class Chihuahua : Dog
    {
        public bool _angry { get; set; }
        public Chihuahua(string name, double weight, string breed, bool angry)
               : base(name, weight, breed)
        {
            _angry = angry;
        }
        //Unique method for Chihuahuas
        public void Angry()
        {
            if (_angry)
            {
                Console.WriteLine($"This {_breed} needs to calm down");
            }
            else
            {
                Console.WriteLine($"This {_breed} is fine... FOR NOW!");
            }
        }




    }






}