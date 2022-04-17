using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            int[] sayilar3 = new int[] { 50, 60, };
            string[] sayilar4 = new string[] { "sayi1", "sayi2", };

            sayilar1 = sayilar2;
            sayilar2[0] = 100;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sayilar1[i]);



            }
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine(sayilar2[i]);

            }


            foreach (string sayilar in sayilar4)
            {
                Console.WriteLine(sayilar);
            }

            foreach (int xyz in sayilar3)
            {
                Console.WriteLine(xyz);
            }

            Console.WriteLine("bittiii");


            Person person1 = new Person();
            person1.ID = 1234;

            //Person person2 = new Person();

            Employee employee1 = new Employee();
            employee1.Ages = 25;
            employee1.ID = 4546;

            Person person2 = employee1;
            Console.WriteLine(person2.ID);
            Console.WriteLine(((Employee)person2).Ages);


        }
    }

    


    class Person
    {
        public int ID { get; set; }


    }

    class Employee:Person
    {
        public int Ages { get; set; }

    }
}
