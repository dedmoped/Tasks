using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTask.HelpClass
{
    public class WorkWithNumbers
    {
        public static int Count(int[] array)
        {
            Random rand = new Random();
            for (int x = 0; x < array.Length; x++)
            {
                array[x] = rand.Next(20);
            }
            var count = array.Where(t => t % 2 == 0).Sum();
            return count;
        }
        public static IEnumerable<int> Delete(List<int> array)
        {
            var data = from t in array where t % 2 == 0 select t;

            return data;
        }
    }
}