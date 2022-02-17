using System;

namespace Name
{
    class Name
    {
        public static void Main(string[] args)
        {
                Console.WriteLine("helooo");
                Console.WriteLine("İsim:");
                string name = Console.ReadLine();
                Console.WriteLine("Soyisim:");
                string surName = Console.ReadLine();
                Console.WriteLine("Yaş:");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(name + " " + surName + " " + age + " yaşında");
        }
    }
}
