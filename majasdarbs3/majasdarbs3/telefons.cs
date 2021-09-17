using System;


namespace majasdarbs3
{
    public class Owner
    {

        public Owner(string name)
        {
            Phone = name;
        }

        public string Phone { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Size { get; set; }


        public string GetGreeting()
        {
            string greeting = "Hello, you have " + Brand + Model + ", congrats";

            return greeting;
        }
        public void Call()
        {
            Console.WriteLine("calling");
        }
        public void SendMessage()
        {
            Console.WriteLine("sending message");
        }

    }
}
//----------------------------------------------------