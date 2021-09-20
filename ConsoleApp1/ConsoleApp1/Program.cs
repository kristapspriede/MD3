using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            var phone = new Phone();
            Console.Write("Ievadiet telefona marku: ");
            phone.Brand = Console.ReadLine();

            Console.Write("Ievadiet telefona modeli: ");
            phone.Model = Console.ReadLine();

            Console.Write("Ievadiet telefona garumu: ");
            phone.Size.Length = double.Parse(Console.ReadLine());

            Console.Write("Ievadiet telefona platumu: ");
            phone.Size.Width = double.Parse(Console.ReadLine());

            Console.Write("Ievadiet telefona augstumu: ");
            phone.Size.Height = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Brand: {phone.Brand}, \nModel: {phone.Model}, \nSize (L x W x H): {phone.Size.Length} x {phone.Size.Width} x {phone.Size.Height}, \nSend message: {phone.SendSMS()}, \nCall: {phone.Call()}");

            //Exercise 2

            var car = new Car();
            Console.Write("Ievadiet automašīnas marku: ");
            car.Brand = Console.ReadLine();

            Console.Write("Ievadiet automašīnas numurzīmi: ");
            car.PlateNumber = Console.ReadLine();

            Console.Write("Ievadiet automašīnas maksimālo ātrumu: ");
            car.MaxSpeed = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Brand: {car.Brand}, \nPlate number: {car.PlateNumber}, \nMaksimālais ātrums: {car.MaxSpeed} km/h, \nSākam braukt: {car.Start()}, \nPalielinam ātrumu: {car.SpeedUp()}, \nUztaurējam: {car.Beep()}, \nApstājamies: {car.Stop()}");


            //Exercise 3

            Console.Write("Ievadiet produkta garumu: ");
            var length = double.Parse(Console.ReadLine());

            Console.Write("Ievadiet produkta platumu: ");
            var width = double.Parse(Console.ReadLine());

            Console.Write("Ievadiet produkta augstumu: ");
            var height = double.Parse(Console.ReadLine());

            Console.Write("Ievadiet produkta svaru: ");
            var weight = double.Parse(Console.ReadLine());

            var product = new Product(length, width, height, weight);

            product.Print(length, width, height, weight);

            // Exercise 4

            Console.Write("Jūsu vārds: ");
            var firstName = Console.ReadLine();

            Console.Write("Jūsu uzvārds: ");
            var lastName = Console.ReadLine();

            Console.Write("Ievadiet dzimšanas datumu (dd.mm.yyyy): ");
            var dateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Jūsu hobijs: ");
            var hobby = Console.ReadLine();

            Console.Write("Jūsu dzimums (V/S): ");
            var sex = Char.Parse(Console.ReadLine());

            var person = new Person() { 
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                Hobby = hobby,
                Sex = sex
            };

            string yearsOld = person.CountAge(person.DateOfBirth);
            person.Greeting(firstName, lastName, yearsOld);
        }
    }
}
