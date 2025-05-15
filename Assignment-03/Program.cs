//using Console = Colorful.Console;
using System;
//using System.Drawing;
using System.Collections.Generic;

namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = [];
            char input;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n\t\t╔=== Main Screen ======================╗\n" +
                                      "\t\t║                                      ║\n" +
                                      "\t\t║   A - Add Number                     ║\n" +
                                      "\t\t║   P - Print Number                   ║\n" +
                                      "\t\t║   M - Display mean of the number     ║\n" +
                                      "\t\t║   S - Display the smallest number    ║\n" +
                                      "\t\t║   L - Display the largest number     ║\n" +
                                      "\t\t║   F - Find a number                  ║\n" +
                                      "\t\t║   O - Sort List                      ║\n" +
                                      "\t\t║   W - Swap two number                ║\n" +
                                      "\t\t║   C - Clear the list                 ║\n" +
                                      "\t\t║   Q - Quit                           ║\n" +
                                      "\t\t║                                      ║\n" +
                                      "\t\t╚======================================╝\n\n");
                Console.Write("\t\tEnter Your Choise ^_^ ==>: ");
                Console.ResetColor();
                input = Convert.ToChar(Console.ReadLine().ToUpper());
                Console.ForegroundColor = ConsoleColor.Red;
                switch (input)
                {
                    case 'P':
                        if (myList.Count() < 1)
                        {
                            Console.WriteLine("\t\t╔========================╗\n" +
                                              "\t\t║ [] - the list is empty ║\n" +
                                              "\t\t╚========================╝\n");


                        }
                        else
                        {
                            string roof = new string('=', (myList.Count*4)+1);
                            Console.WriteLine($"\t\t╔{roof}╗");
                            Console.Write("\t\t║ [");
                            int x = 0;
                            for (int i = 0; i < myList.Count; i++)
                            {
                                if (i > 0)
                                    Console.Write(" ");
                                if (myList[i] > 9)
                                {
                                    x = x + myList[i].ToString().Length-1;
                                }
                                Console.Write($"{myList[i]}");
                            }
                            string spaces = new string( ' ', (myList.Count+myList.Count-1)>x ? (myList.Count + myList.Count - 1) - x : myList.Count + myList.Count - 1 );
                            Console.Write($"]{spaces}║\n");
                            Console.WriteLine($"\t\t╚{roof}╝\n\n");
                        }
                        break;
                    case 'A':
                        bool inList = false;
                        Console.Write("\t\t╔====================================╗\n"+
                                      "\t\t║ Which you will add to the list ^_^ ║\n"+
                                      "\t\t╚====================================╝\n" );
                        Console.Write("\t\t==>: ");
                        int inputNum = Convert.ToInt32(Console.ReadLine());
                        // don't allow duplicate entries
                        for (int i = 0; i<myList.Count; i++)
                        {
                            if (inputNum == myList[i])
                                inList = true;
                        }
                        if (inList)
                        {
                            Console.WriteLine("\t\t╔============================================╗\n" +
                                              "\t\t║   This number already exists in the list   ║\n" +
                                              "\t\t╚============================================╝");
                        }
                        else
                        {
                            myList.Add(inputNum);
                            Console.WriteLine("\t\t╔==============================╗\n" + 
                                             $"\t\t║          {inputNum} added :/          ║\n" +
                                              "\t\t╚==============================╝\n\n");
                        }
                        break;
                    case 'C':
                        myList.Clear();
                        Console.WriteLine("\t\t╔==============================╗\n" +
                                          "\t\t║   The List is Clear Now :/   ║\n" +
                                          "\t\t╚==============================╝\n\n");
                        break;

                    case 'M':
                        if (myList.Count() < 1)
                        {
                            Console.WriteLine("\t\t╔==========================================╗\n"+
                                              "\t\t║  Unable to calculate the mean - no data  ║\n"+
                                              "\t\t╚==========================================╝\n\n");
                            
                        }
                        else
                        {
                            int sum = 0;
                            for (int i=0; i<myList.Count; i++)
                            {
                                sum += myList[i];
                            }
                            Console.WriteLine("\t\t╔=======================╗\n" +
                                             $"\t\t║    the avrege is { sum / myList.Count }    ║\n" +
                                              "\t\t╚=======================╝\n\n");
                        }
                        break;               
                    case 'S':
                        if (myList.Count() < 1)
                        {
                            Console.WriteLine("\t\t╔===========================================================╗\n" +
                                              "\t\t║  Unable to determine the smallest number - list is empty  ║\n" +
                                              "\t\t╚===========================================================╝\n\n");
 
                        }
                        else
                        {
                            int smallest = myList[0];
                            for (int i=1; i<myList.Count; i++)
                            {
                                if (myList[i] < smallest)
                                {
                                    smallest = myList[i]; 
                                }
                            }
                            Console.WriteLine("\t\t╔==============================╗\n" +
                                             $"\t\t║   The smallest number is {smallest}   ║\n" +
                                              "\t\t╚==============================╝\n\n");
                        }
                        break;                    
                    case 'L':
                        if (myList.Count() < 1)
                        {
                            Console.WriteLine("\t\t╔==========================================================╗\n" +
                                              "\t\t║  Unable to determine the largest number - list is empty  ║\n" +
                                              "\t\t╚==========================================================╝\n\n");
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
                            Console.WriteLine("\t\t╔=============================╗\n" +
                                             $"\t\t║   The Largest number is {largest}   ║\n" +
                                              "\t\t╚=============================╝\n\n");
                        }
                        break;
                    case 'F':
                        bool found = false;
                        int index=0;
                        Console.Write("\t\t╔======================================╗\n"+
                                      "\t\t║  Which you will Find to the list ^_- ║\n" +
                                      "\t\t╚======================================╝\n");
                        Console.Write("\t\t==>: ");
                        int fNumber = Convert.ToInt32(Console.ReadLine());
                        for(int i = 0; i<myList.Count&&!found; i++)
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
                        }
                        else
                        {
                            Console.WriteLine("\t\t╔===================================╗\n" +
                                              "\t\t║   Number is not found - no data   ║\n" +
                                              "\t\t╚===================================╝\n\n");
                        }

                            break;
                    case 'O':

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
                        Console.WriteLine("\t\t╔=====================╗\n" +
                                          "\t\t║   List Sorted ~_~   ║\n" +
                                          "\t\t╚=====================╝\n\n");
                        break;
                    case 'W':
                        int firstNum = 0, secondNum = 0;
                        int firstIndex = -1, secondIndex = -1;

                        Console.Write("\t\t╔==================================╗\n"+
                                      "\t\t║   Enter thie First Number *_*    ║\n"+
                                      "\t\t╚==================================╝\n");
                        Console.Write("\t\t==>: ");
                        firstNum = Convert.ToInt32(Console.ReadLine());


                        Console.Write("\t\t╔==================================╗\n" +
                                      "\t\t║   Enter thie Second Number *_*   ║\n" +
                                      "\t\t╚==================================╝\n");
                        Console.Write("\t\t==>: ");
                        secondNum = Convert.ToInt32(Console.ReadLine());


                        // get indexes
                        for (int i=0; i<myList.Count; i++)
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
                        Console.WriteLine("\t\t╔========================╗\n" +
                                          "\t\t║   Swaped is Done ^_~   ║\n" +
                                          "\t\t╚========================╝\n\n");
                        }
                        else if (firstIndex >= 0)
                        {
                            Console.Write("\t\t╔=======================╗\n"+
                                         $"\t\t║  {secondNum} is not found O_O   ║\n"+
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
                        }
                        break;
                    case 'Q':
                        Console.WriteLine("\t\t╔=========================╗\n" +
                                          "\t\t║   See You Later ＞__＜    ║\n" +
                                          "\t\t╚=========================╝\n\n");
                        break;
                    default:
                        Console.WriteLine("Unknown selection, please try again");
                        break;
                        
                }
                Console.ResetColor();
            } while (input != 'Q');
        }
    }
}
