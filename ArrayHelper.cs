using System;
using System.Collections.Generic;
using System.Linq;

namespace _14thLesson
{
    public static class ArrayHelper
    {

        
        public static void show<T>(T[] array){
            System.Console.Write("Current Elements: ");
            foreach( var item in array ){
                System.Console.Write(item + " ");
            }
        }


        /// <summary>
        /// Pop Method
        /// </summary>
        /// <param name="array">Takes an array of undefined Type</param>
        /// <typeparam name="T">Generic named "T"</typeparam>
        /// <returns>returns an object of undefined Type</returns>
        public static T Pop<T>(ref T[] array){
            
            /// <summary>
            /// Taking last element of array
            /// </summary>
            
            T last = array[array.Length-1]; 

            /// <summary>
            /// Creating new tempArray to push values of "array" except last value
            /// And iterating through "array"
            /// </summary>
            
            T[] tempArray = new T[array.Length-1];
            for ( int i = 0; i < array.Length-1; i++ )
            {   
                tempArray[i] = array[i]; 
            }

            array = tempArray; 
            return last;  
        }

        /// <summary>
        /// Pushes an element to the end
        /// </summary>
        /// <param name="array">Array Type of T</param>
        /// <param name="elementToPush">Element Type of T </param>
        /// <typeparam name="T">Type of Object</typeparam>
        /// <returns>size of new "array"</returns>
        public static int Push<T>(ref T[] array, T elementToPush ){
            
            int lenghtOfNewArray = array.Length - 1; ; 

            var tempList = array.ToList();
            tempList.Add(elementToPush);
            array = tempList.ToArray();
            
            return lenghtOfNewArray; 
        }

        /// <summary>
        /// Takes out first element of "array"
        /// </summary>
        /// <param name="array">Array type of T</param>
        /// <typeparam name="T">Type of Object</typeparam>
        /// <returns>First element of "array"</returns>
        public static T Shift<T>(ref T[] array){
                
                T firstElement; 

                firstElement = array[0]; 
                
                T[] tempArray = new T[array.Length-1]; 

                for ( int i = 0; i < array.Length - 1; i++ ){
                    tempArray[i] = array[i+1]; 
                }

                array = tempArray; 
                return firstElement; 
       }

        public static int UnShift<T>(ref T[] array, T elementToPush ){

            int lenghtOfNewArray = array.Length + 1; 

            var tempArray = array.ToList();
            tempArray.Reverse();
            tempArray.Add(elementToPush);
            tempArray.Reverse(); 
            array = tempArray.ToArray();

            return lenghtOfNewArray; 
        }
        public static T[] Slice<T>(T[] array, int begin = 0, int end = 0){
            
            List<T> tempArray = new List<T>();
            
            int arraySize = array.Length;
            if(end == 0){
                end = array.Length;
            }
            if(begin > array.Length - 1){
                return tempArray.ToArray();
            }
            else{
                if(begin >= 0){
                    if(end > 0){
                        for(int i = begin; i < end; i++){
                            tempArray.Add(array[i]);
                        }
                    }
                    else if (end < 0){
                        for(int i = begin; i < arraySize + end; i++){
                            tempArray.Add(array[i]);
                        }
                    }
                }
                else if(begin < 0){
                        for(int i = 0; i < (arraySize + begin); i++){
                            tempArray.Add(array[i]);
                        }
                }
                return tempArray.ToArray();
            }
        }

    }
}