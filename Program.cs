using System;
using System.Data.Sql;
using System.Data.SqlClient;

namespace _14thLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[]{1,2,3,4}; 

            ArrayHelper.Pop(ref array);
             
        }
    }

}
