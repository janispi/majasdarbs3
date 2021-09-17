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
    //--------------------------------------------------------
    public class Car
    {
        public Car(string name)
        {
            CarBrand = name;
        }
        public string CarBrand { get; set; }
        public string Plate { get; set; }
        public string Speed { get; set; }

        public void StartDriving ()
        {
            Console.WriteLine("Driving");
        }
        public void IncreaseSpeed ()
        {
            Console.WriteLine("Speed increased");
        }
        public void StopDriving ()
        {
            Console.WriteLine("Driving stopped");
        }
        public string StartBeeping()
        {
            string beeping = "beep beep";
            return beeping;
        }
    }
}
//----------------------------------------------------