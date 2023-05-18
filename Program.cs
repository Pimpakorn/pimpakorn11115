using System;

class Program
{
    static void Main()
    {
        bool validInput = false;

        while (!validInput)
        {
            Console.Write("กรุณากรอกอักขระ: ");
            string input = Console.ReadLine();

            if (input == "+" || input == "-")
            {
                validInput = true;
                Console.Write("กรุณากรอกขนาดของเมทริกซ์: ");
                int size = int.Parse(Console.ReadLine());

                Console.Write("กรุณากรอกสมาชิกของเมทริกซ์: ");
                double element = double.Parse(Console.ReadLine());

                double result = 0;

                if (input == "+")
                    result = size + element;
                else if (input == "-")
                    result = size - element;

                Console.WriteLine("ผลลัพธ์: " + result);
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("โปรแกรมจบการทำงาน");
    }
}
