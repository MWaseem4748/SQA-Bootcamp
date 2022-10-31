using System;

namespace HelloWorld1
{
    class Program1
    {
      public static void Main(string[] args)
        {
            //task1
            Console.WriteLine("\nTASK1");
            Console.WriteLine("Hello World!");

            //Task2
            Console.WriteLine("\n\nTASK2");
            String fName, lName;

            Console.Write("Enter Details: \n");
            Console.Write("Enter First Name: "); fName = Console.ReadLine();
            Console.Write("Enter Last Name: "); lName = Console.ReadLine();

            Console.WriteLine("Output is: " + fName + " "+lName);

            //TASK3
            Console.WriteLine("\n\nTASK3");

            const String x= "Comsats"; //We have restricted input values therefore we will use const here
            const String y = "Lahore";
            Console.WriteLine("Output= "+ x +" "+ y);


            //TASK4
            Console.WriteLine("\n\nTASK4");
            const int z = 10;
            Console.WriteLine("Output is: " + z);


            //TASK5;
            Console.WriteLine("\n\nTASK5");
            String name, school, degree;


            Console.WriteLine("Enter your Details:");
            Console.Write("Name: "); name = Console.ReadLine();
            Console.Write("School: "); school = Console.ReadLine();
            Console.Write("Degree: "); degree = Console.ReadLine();

            Console.WriteLine("\n\n\nYou entered the following: " + "" +
                "\nName: " + name + "\n School: " + school + "\n Degree: " + degree);


            //TASK6
            String Name, School, Degree;
            Console.WriteLine("\n\n TASK6");

            Console.WriteLine("Input= ");
             Name = Console.ReadLine();  School = Console.ReadLine(); Degree = Console.ReadLine();

            Console.WriteLine("\n\n\nYou entered the following: " + "" +
                "\nName = " + Name + "\nSchool = " + School + "\nDegree = " + Degree);

            //TASK7
            Console.WriteLine("\n\n TASK7");
            String input = "Muhammad Waseem";
            String output = input.ToUpper();

            Console.WriteLine("Output = " +output);
        }
    }
}
