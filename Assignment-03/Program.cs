//using Console = Colorful.Console;
using System;
using System.Collections;
using System.Collections.Generic;


namespace Assignment_03
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> myList = [];
            char input;
            string mainScreen = "\n\n\t\t╔=== Main Screen ======================╗\n" +
                                      "\t\t║                                      ║\n" +
                                      "\t\t║   A - Add Number                     ║\n" +
                                      "\t\t║   P - Print Number                   ║\n" +
                                      "\t\t║   M - Display mean of the number     ║\n" +
                                      "\t\t║   D - Delete a Numbe                 ║\n" +
                                      "\t\t║   S - Display the smallest number    ║\n" +
                                      "\t\t║   L - Display the largest number     ║\n" +
                                      "\t\t║   F - Find a number                  ║\n" +
                                      "\t\t║   O - Sort List                      ║\n" +
                                      "\t\t║   R - Revers List                    ║\n" +
                                      "\t\t║   W - Swap two number                ║\n" +
                                      "\t\t║   C - Clear the list                 ║\n" +
                                      "\t\t║   Q - Quit                           ║\n" +
                                      "\t\t║                                      ║\n" +
                                      "\t\t╚======================================╝\n\n";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(mainScreen);
            Console.ResetColor();

            do
            {

                Console.Write("\t\tEnter Your Choise ^_^ ==>: ");
                input = Convert.ToChar(Console.ReadLine().ToUpper());
                Console.ForegroundColor = ConsoleColor.Red;
                switch (input)
                {
                    case 'P':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();
                        if (myList.Count() < 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\t╔========================╗\n" +
                                              "\t\t║ [] - the list is empty ║\n" +
                                              "\t\t╚========================╝\n");


                        }
                        else
                        {
                            string roof = new string('=', (myList.Count * 4) + 1);
                            Console.WriteLine($"\t\t╔{roof}╗");
                            Console.Write("\t\t║ [");
                            int scap = 0;
                            for (int i = 0; i < myList.Count; i++)
                            {
                                if (i > 0)
                                    Console.Write(" ");
                                if (myList[i] > 9)
                                {
                                    scap = scap + myList[i].ToString().Length - 1;
                                }
                                Console.Write($"{myList[i]}");
                            }
                            string spaces = new string(' ', (myList.Count + myList.Count - 1) > scap ? (myList.Count + myList.Count - 1) - scap : myList.Count + myList.Count - 1);
                            Console.Write($"]{spaces}║\n");
                            Console.WriteLine($"\t\t╚{roof}╝\n\n");
                            Console.ResetColor();

                        }
                        break;
                    case 'A':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();
                        bool inList = false;
                        Console.Write("\t\t╔====================================╗\n" +
                                      "\t\t║ Which you will add to the list ^_^ ║\n" +
                                      "\t\t╚====================================╝\n");
                        Console.Write("\t\t==>: ");
                        int inputNum = Convert.ToInt32(Console.ReadLine());

                        // don't allow duplicate entries
                        for (int i = 0; i < myList.Count; i++)
                        {
                            if (inputNum == myList[i])
                                inList = true;
                        }
                        if (inList)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t\t╔============================================╗\n" +
                                              "\t\t║   This number already exists in the list   ║\n" +
                                              "\t\t╚============================================╝");
                            Console.ResetColor();
                        }
                        else
                        {
                            myList.Add(inputNum);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\t╔==============================╗\n" +
                                             $"\t\t║          {inputNum} added :/          ║\n" +
                                              "\t\t╚==============================╝\n\n");
                            Console.ResetColor();

                        }
                        break;
                    case 'C':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();
                        myList.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t╔==============================╗\n" +
                                          "\t\t║   The List is Clear Now :/   ║\n" +
                                          "\t\t╚==============================╝\n\n");
                        Console.ResetColor();

                        break;
                    case 'D':
                        Console.Write("\t\t╔=======================================╗\n" +
                                      "\t\t║ Which you will Delete to the list ^_^ ║\n" +
                                      "\t\t╚=======================================╝\n");
                        Console.Write("\t\t==>: ");
                        int deleteNum = Convert.ToInt32(Console.ReadLine());
                        List<int> x = [];
                        for (int i = 0; i < myList.Count(); i++)
                        {
                            if (myList[i] == deleteNum)
                            {
                                continue;
                            }
                            x.Add(myList[i]);
                        }
                        myList.Clear();
                        myList.AddRange(x);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t╔============================╗\n" +
                                         $"\t\t║   {deleteNum} is Delete Success :/   ║\n" +
                                          "\t\t╚============================╝\n\n");
                        Console.ResetColor();
                        break;
                    case 'M':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();
                        if (myList.Count() < 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t\t╔==========================================╗\n" +
                                              "\t\t║  Unable to calculate the mean - no data  ║\n" +
                                              "\t\t╚==========================================╝\n\n");
                            Console.ResetColor();

                        }
                        else
                        {
                            int sum = 0;
                            for (int i = 0; i < myList.Count; i++)
                            {
                                sum += myList[i];
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\t╔=======================╗\n" +
                                             $"\t\t║    the avrege is {sum / myList.Count}    ║\n" +
                                              "\t\t╚=======================╝\n\n");
                            Console.ResetColor();

                        }
                        break;
                    case 'S':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();
                        if (myList.Count() < 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t\t╔===========================================================╗\n" +
                                              "\t\t║  Unable to determine the smallest number - list is empty  ║\n" +
                                              "\t\t╚===========================================================╝\n\n");
                            Console.ResetColor();


                        }
                        else
                        {
                            int smallest = myList[0];
                            for (int i = 1; i < myList.Count; i++)
                            {
                                if (myList[i] < smallest)
                                {
                                    smallest = myList[i];
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\t╔==============================╗\n" +
                                             $"\t\t║   The smallest number is {smallest}   ║\n" +
                                              "\t\t╚==============================╝\n\n");
                            Console.ResetColor();

                        }
                        break;
                    case 'L':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();
                        if (myList.Count() < 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t\t╔==========================================================╗\n" +
                                              "\t\t║  Unable to determine the largest number - list is empty  ║\n" +
                                              "\t\t╚==========================================================╝\n\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            int largest = myList[0];
                            for (int i = 1; i < myList.Count; i++)
                            {
                                if (myList[i] > largest)
                                {
                                    largest = myList[i];
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\t╔=============================╗\n" +
                                             $"\t\t║   The Largest number is {largest}   ║\n" +
                                              "\t\t╚=============================╝\n\n");
                            Console.ResetColor();

                        }
                        break;
                    case 'F':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();
                        bool found = false;
                        int index = 0;
                        Console.Write("\t\t╔======================================╗\n" +
                                      "\t\t║  Which you will Find to the list ^_- ║\n" +
                                      "\t\t╚======================================╝\n");
                        Console.Write("\t\t==>: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        int fNumber = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < myList.Count && !found; i++)
                        {
                            if (myList[i] == fNumber)
                            {
                                index = i;
                                found = true;

                            }
                        }
                        if (found)
                        {
                            Console.WriteLine("\t\t╔=============================╗\n" +
                                             $"\t\t║  The number indxe is ==> {index}  ║\n" +
                                              "\t\t╚=============================╝\n\n");
                            Console.ResetColor();

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("\t\t╔===================================╗\n" +
                                              "\t\t║   Number is not found - no data   ║\n" +
                                              "\t\t╚===================================╝\n\n");
                            Console.ResetColor();

                        }

                        break;
                    case 'O':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();

                        if (myList.Count() < 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t\t╔==============================╗\n" +
                                              "\t\t║   List is So lower ~_~       ║\n" +
                                              "\t\t║   use A to add some number   ║\n" +
                                              "\t\t╚==============================╝\n\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            // sorting
                            for (int i = 0; i < myList.Count - 1; i++)
                            {
                                for (int j = 0; j < myList.Count - i - 1; j++)
                                {
                                    if (myList[j] > myList[j + 1])
                                    {
                                        // swap 
                                        int storge = myList[j];
                                        myList[j] = myList[j + 1];
                                        myList[j + 1] = storge;

                                    }
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\t╔=====================╗\n" +
                                              "\t\t║   List Sorted ^_-   ║\n" +
                                              "\t\t╚=====================╝\n\n");
                            Console.ResetColor();
                        }

                        break;
                    case 'W':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();
                        int firstNum = 0, secondNum = 0;
                        int firstIndex = -1, secondIndex = -1;

                        Console.Write("\t\t╔==================================╗\n" +
                                      "\t\t║   Enter thie First Number *_*    ║\n" +
                                      "\t\t╚==================================╝\n");
                        Console.Write("\t\t==>: ");
                        firstNum = Convert.ToInt32(Console.ReadLine());


                        Console.Write("\t\t╔==================================╗\n" +
                                      "\t\t║   Enter thie Second Number *_*   ║\n" +
                                      "\t\t╚==================================╝\n");
                        Console.Write("\t\t==>: ");
                        secondNum = Convert.ToInt32(Console.ReadLine());


                        // get indexes
                        for (int i = 0; i < myList.Count; i++)
                        {
                            if (firstNum == myList[i])
                            {
                                firstIndex = i;
                            }
                            else if (secondNum == myList[i])
                            {
                                secondIndex = i;
                            }
                        }
                        // swap 
                        if (firstIndex >= 0 && secondIndex >= 0)
                        {
                            int memory = myList[firstIndex];
                            myList[firstIndex] = myList[secondIndex];
                            myList[secondIndex] = memory;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\t╔========================╗\n" +
                                              "\t\t║   Swaped is Done ^_~   ║\n" +
                                              "\t\t╚========================╝\n\n");
                            Console.ResetColor();

                        }
                        else if (firstIndex >= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.Write("\t\t╔=======================╗\n" +
                                         $"\t\t║  {secondNum} is not found O_O   ║\n" +
                                          "\t\t╚=======================╝\n\n");
                        }
                        else if (secondIndex >= 0)
                        {
                            Console.Write("\t\t╔=======================╗\n" +
                                         $"\t\t║  {firstNum} is not found O_O   ║\n" +
                                          "\t\t╚=======================╝\n\n");
                        }
                        else
                        {
                            Console.Write("\t\t╔=====================================================╗\n" +
                                         $"\t\t║   Both of the number is not found try again !! +_+  ║\n" +
                                          "\t\t╚=====================================================╝\n\n");
                            Console.ResetColor();

                        }
                        break;
                    case 'R':
                        if (myList.Count() < 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t\t╔==============================╗\n" +
                                              "\t\t║   List is So lower ~_~       ║\n" +
                                              "\t\t║   use A to add some number   ║\n" +
                                              "\t\t╚==============================╝\n\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            for (int i = 0; i < myList.Count(); i++)
                            {
                                for (int j = 0; j < myList.Count() - i - 1; j++)
                                {
                                    // swap
                                    int sw = myList[j];
                                    myList[j] = myList[j + 1];
                                    myList[j + 1] = sw;
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\t╔=======================╗\n" +
                                              "\t\t║   List Reversed ^_-   ║\n" +
                                              "\t\t╚=======================╝\n\n");
                            Console.ResetColor();
                        }
                        break;
                    case 'Q':
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\t\t╔=========================╗\n" +
                                          "\t\t║   See You Later ＞__＜    ║\n" +
                                          "\t\t╚=========================╝\n\n");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\t╔=========================================╗\n" +
                                          "\t\t║   Unknown selection, please try again   ║\n" +
                                          "\t\t╚=========================================╝");
                        Console.ResetColor();
                        break;

                }
                Console.ResetColor();
            } while (input != 'Q');
        }


    }
}

