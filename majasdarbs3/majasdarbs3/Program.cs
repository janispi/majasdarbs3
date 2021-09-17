using System;

namespace majasdarbs3
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner("Jānis");
            

            owner.Phone = "Jānis";
            Console.WriteLine("Kāda ir Jūsu telefona marka?");
            owner.Brand = Console.ReadLine();
            Console.WriteLine("Kāds ir Jūsu telefona modelis?");
            owner.Model = Console.ReadLine();
            Console.WriteLine("Ievadiet telefona garumu, platumu un augstumu centimetros");
            owner.Size = Console.ReadLine();
            


            string greeting = owner.GetGreeting();

            Console.WriteLine(greeting);
        }
    }
}
//-------------------------------------------------------------------