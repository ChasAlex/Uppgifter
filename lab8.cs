namespace lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Skapar 5st Employee objekt
            Employee emp1 = new Employee("1","Lars","Man","30000");
            Employee emp2 = new Employee("2", "Eva", "Kvinna", "35000");
            Employee emp3 = new Employee("3", "Linda", "Kvinna", "20000");
            Employee emp4 = new Employee("4", "Knut", "Man", "56000");
            Employee emp5 = new Employee("5", "Max", "Man", "16000");
            
            //Skapar en stack och lägger till alla objekten med push metoden
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(emp1);
            stack.Push(emp2);
            stack.Push(emp3);
            stack.Push(emp4);
            stack.Push(emp5);


            //Printar ut all information om employees i stacken
            foreach (Employee emp in stack)
            {
                Console.WriteLine(emp.printInfo());
                Console.WriteLine("The amount left in the stack is: "+stack.Count());
            }

            //Tar bort en employee frpn stacken och printar informationen
            while (stack.Count > 0)
            {
                Employee emp = stack.Pop();
                Console.WriteLine(emp.printInfo());
                Console.WriteLine("The amount left in the stack is: " + stack.Count);
            }

            stack.Push(emp1);
            stack.Push(emp2);
            stack.Push(emp3);
            stack.Push(emp4);
            stack.Push(emp5);



            //Använder Peek metoden för att ta fram information från två employees
            for(int i = 0; i < 2; i++) {
            
            Employee emp = stack.Peek();
            Console.WriteLine(emp.printInfo());
            Console.WriteLine($"Items left in the stack: {stack.Count}");
            
            }
            //Tittar om emp3 är i stacken
            if (stack.Contains(emp3))
            {
                Console.WriteLine("Emp3 is in stack");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack");
            }



            //Skapar en ny lista med Employee objekt
            List<Employee> list = new List<Employee>();

            list.Add(emp1);
            list.Add(emp2);
            list.Add(emp3);
            list.Add(emp4);
            list.Add(emp5);

            //Använder Find metoden för att hitta första instansen av gender=Man
            Employee firstMaleEmployee = list.Find(emp => emp._gender == "Man");

            //Tittar det finns några employees i variabeln och printar ut det
            if (firstMaleEmployee != null)
            {
                Console.WriteLine("The first male employee is: " + firstMaleEmployee.printInfo());
            }
            else
            {
                Console.WriteLine("No male employee found in the list.");
            }

            // Skapar en list av male employees och använder en lambda funktion för att ta reda på vart gender = man
            List<Employee> maleEmployees = list.FindAll(emp => emp._gender == "Man");

            // Print ut alla male employees
            if (maleEmployees.Count > 0)
            {
                Console.WriteLine("Male employees:");
                foreach (Employee emp in maleEmployees)
                {
                    Console.WriteLine(emp.printInfo());
                }
            }
            else
            {
                Console.WriteLine("No male employees found in the list.");
            }








        }

        //Class för employees med properties
        public class Employee
        {
            public string _id { get; set; }
            public string _name { get; set; }
            public string _gender { get; set; }
            public string _salery { get; set; }

            //Konstruktör för employee klassen
            public Employee(string id,string name,string gender,string salery)
            {
                _id = id;
                _name = name;
                _gender = gender;
                _salery = salery;
                 
            }
            //Printar ut information om objekten
            public string printInfo()
            {
                return $"{_id} - {_name} - {_gender} - {_salery}";
            }
            




        }






    }
}