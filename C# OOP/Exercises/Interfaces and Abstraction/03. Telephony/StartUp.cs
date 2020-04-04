using System;

namespace _03._Telephony
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split();
            string[] urlInput = Console.ReadLine().Trim().Split();

            ICallable smartphone = new Smartphone();
            ICallable stationaryPhone = new StationaryPhone();
            IBrowsable browsable = new Smartphone();
            

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length <10)
                {
                    Console.WriteLine(stationaryPhone.Call(input[i])); 
                }
                else
                {
                    Console.WriteLine(smartphone.Call(input[i]));
                }
            }

            for (int i = 0; i < urlInput.Length; i++)
            {
                Console.WriteLine(browsable.Browse(urlInput[i])); 
            }
        }
    }
}
