using System;
using System.Collections.Generic;
using System.Linq;

namespace _14thLesson
{
    public static class ArrayHelper
    {
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
        public static int Push<T>(ref T[] array, T elementToPush ){
            
            int lenghtOfNewArray; 

            var tempList = array.ToList();
            tempList.Add(elementToPush);
            array = tempList.ToArray();

            lenghtOfNewArray = array.Length; 
            
            return lenghtOfNewArray; 
        }
    }
}