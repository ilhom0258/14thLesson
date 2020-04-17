using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlClient;

namespace _14thLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            bool working = true;

            string[] array = new string[]{"1", "2", "3"}; 

            System.Console.WriteLine("Welcome to ArrayHelper:");
            
            
            while ( working ){

                    System.Console.Write(@"
                    Please choose function: 
                    1. Pop(array)
                    2. Push(array, element)
                    3. Shift(array)
                    4. UnShift(array, element)
                    5. Slice(array, beginIndex, end Index)
                    6. Exit
                    Please choose reference number: ");
                    int choice = int.Parse(Console.ReadLine());
                    
                    switch(choice){
                        case 1:{
                            System.Console.WriteLine("Popped element: "+ArrayHelper.Pop(ref array));
                            ArrayHelper.show(array); 
                        }break; 
                        case 2:{
                            string element = Console.ReadLine();
                            System.Console.WriteLine("Size of Array: " + ArrayHelper.Push(ref array, element));
                            ArrayHelper.show(array); 
                        }break; 
                        case 3:{
                            System.Console.WriteLine("Shifted element: " + ArrayHelper.Shift(ref array));
                            ArrayHelper.show(array); 
                        }break; 
                        case 4:{
                            string element = Console.ReadLine(); 
                            System.Console.WriteLine("Size of Array: " + ArrayHelper.UnShift(ref array, element));
                            ArrayHelper.show(array); 
                        }break;
                        case 5:{   
                            Console.Write("Begin Index: ");
                            int begin = int.Parse(Console.ReadLine());

                            Console.Write("End Index: ");
                            int end = int.Parse(Console.ReadLine());

                            string[] tempArray = ArrayHelper.Slice(array, begin, end);
                            System.Console.Write("Sliced array: ");
                            foreach( var item in tempArray ){
                                System.Console.Write(item + " ");
                            }

                        }break; 
                        case 6:{
                            working = false; 
                        }break; 
                    } 
            }
        }
        
    }

}
