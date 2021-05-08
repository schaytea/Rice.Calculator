using System;

namespace ricecalculator
{
        class Calculator
        {
            class Ricecalc //Welcomes the user to the rice calculator
            {
                public string ricecalcintro;
                public Ricecalc()
                {
                    ricecalcintro = "( / *^*)/ ** ~WELCOME TO THE RICE CALCULATOR!~ ( / *^*)/ **"; //constructor with the welcome to the user. Two emojis that are throwing rice (*).
                }
            }

            class Intro //Gives a "slogan" for the calculator
            {
                public string introduction;
                public Intro()
                {
                    introduction = "Did you eat yet? :)"; //Constructor with "slogan"
                }
            }

            class End //Thanks the user for using the rice calculator
            {
                public string conclusion;
                public End()
                {
                    conclusion = "Thank you for using the rice calculator! Make sure you eat well! !( ^ 0 ^ )!"; //Shows after the result is shown. Thanks the user for using the calculator with another emoji
                }
            }

            private static bool endApp;

            public static void Main(string[] args)
            {
                int people;
                int rice = 2; // 2 is the amount of cups per rice
                double result;
                while (!endApp)
                {
                    Console.WriteLine("------------------------\n");

                    Ricecalc Calcintro = new Ricecalc(); //constructor being put into the calculator
                    Console.WriteLine(Calcintro.ricecalcintro);

                    Intro RiceIntro = new Intro();
                    Console.WriteLine(RiceIntro.introduction); //constructor being put into the calculator

                    Console.WriteLine("------------------------\n");

                    // Ask the user to type in how many people are eating.
                    Console.Write("How many people are eating? ");
                    people = Convert.ToInt32(Console.ReadLine()); //User puts in the amount of people eating

                    result = people * rice; //multiply the number to get how many cups

                    Console.WriteLine("The number of cups needed is: " + result + " cups."); //show the result
                    Console.WriteLine("------------------------\n");

                    Console.WriteLine("To calculate how much water you need, place your pointer finger on the surface of the rice and fill the water up to the first knuckle"); //Directions on how much water to use
                    Console.WriteLine("------------------------\n");

                    End Done = new End(); //constructor being put into the code
                    Console.WriteLine(Done.conclusion);

                    // Wait for the user to respond before closing.
                    Console.Write("Press 'f' and Enter to close the app, or press any other key and Enter to continue: ");
                    if (Console.ReadLine() == "f") endApp = true;

                    Console.WriteLine("\f"); // Friendly linespacing.
                }
                return;
            }
        }
    }
