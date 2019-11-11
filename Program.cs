using System;
using runLED;
namespace Homework5
{

    class Program
    {
        static void Main(string[] args)
        {
            int raw = 1;
            IHomework05 inputkey = new Homework0();
            var NumberLed = inputkey.LED();
            var led = inputkey.Leds();

            void PrintLed()
            {
                foreach (var item in led)

                    Console.Write(item);
                Console.WriteLine();
                Console.WriteLine(NumberLed);
            }

            PrintLed();
            Console.WriteLine("Keynumber ON/OOF");

            while (raw < 2)
            {
                string KeyLed = Console.ReadLine();
                var statusLed = inputkey.DisplayLEDOnScreen(KeyLed);

                try
                {
                    if (statusLed == "A" || statusLed == "a")
                    {
                        var A = led.Length - 1;
                        led[A] = led[A] == "[ ]" ? "[!]" : "[ ]";
                    }
                    else
                    {
                        int index = int.Parse(statusLed);
                        index--;
                        led[index] = led[index] == "[!]" ? "[ ]" : "[!]";
                    }
                    PrintLed();
                    Console.WriteLine(" NumberLed " + statusLed);
                }
                catch (System.Exception)
                {
                    PrintLed();
                    Console.WriteLine("Error!! notlednumber  " + statusLed);

                }

            }
        }
    }
}