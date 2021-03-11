using System;

namespace DegerVeRefaransTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            ///DeğerTipleri

            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2; ///sayi2'nin değerini sayi1'e eşitler ve bağlantı biter.
            sayi2 = 100;
            Console.WriteLine("Sayi1 : "+ sayi1);

            ///ReferansTipleri

            int[] sayilar1 = new int[] {10,20,30};
            int[] sayilar2 = new int[] {100,200,300 };

            sayilar1 = sayilar2; ///sayilar2'nin referansını sayilar1'e eşitle
            sayilar2[0] = 999;
            Console.WriteLine("Sayilar1[0] : "+ sayilar1[0]);

            Console.WriteLine("--------------------------------------------------------------------");

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName="Elif";

            person2 = person1;
            person1.FirstName = "Ayşe";
            Console.WriteLine("Person1 : "+ person2.FirstName);

            Console.WriteLine("--------------------------------------------------------------------");

            Customer customer = new Customer();
            customer.FirstName = "Ahmet";
            customer.CrediCardNumber = 1234567890;

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;
            customer.FirstName = "Eyüp";
            Console.WriteLine(person3.FirstName);
            

            Console.WriteLine(((Customer)person3).CrediCardNumber);

            Console.WriteLine("--------------------------------------------------------------------");

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
         
        }

        class Customer:Person
        {
            public int CrediCardNumber { get; set; }

        }

        class Employee: Person
        {
            public int EmployeeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
