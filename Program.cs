﻿
using System;

namespace 가위바위보
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int aiChoice = rand.Next(0, 3);

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {

                case 0:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;

                case 1:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;

                case 2:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;

            }

            switch (aiChoice)
            {

                case 0:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다.");
                    break;

                case 1:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;

                case 2:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;

            }

            if (choice == aiChoice)
            {

                Console.WriteLine("무승부입니다.");

            }

            if (choice == 0)
            {

                if (aiChoice == 1)

                {

                    Console.WriteLine("컴퓨터의 승리입니다.");

                }

                else if (aiChoice == 2)

                {

                    Console.WriteLine("당신의 승리입니다.");

                }

            }

            else if (choice == 1)
            {

                if (aiChoice == 0)

                {
                    Console.WriteLine("당신의 승리입니다.");
                }
                else if (aiChoice == 2)

                {
                    Console.WriteLine("컴퓨터의의 승리입니다.");
                }
            }

            else
            {

                if (aiChoice == 0)
                {
                    Console.WriteLine("컴퓨터의 승리입니다.");
                }
                else if (aiChoice == 1)
                {
                    Console.WriteLine("당신의 승리입니다.");
                }


            }
        }
    }
}
