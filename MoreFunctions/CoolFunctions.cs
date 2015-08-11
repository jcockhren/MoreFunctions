using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreFunctions
{
    public class CoolFunctions
    {
        public static int iterfactorial(int n)
        {
            int answer = 1;
            for (var i = n; i >= 1; i--)
            {
                answer *= i;
            }
            return answer;
        }

        public static int recurfactorial(int n)
        {
            if (n != 1)
            {
                return n*recurfactorial(n - 1);
            } else
            {
                // This is the base case
                return n;
            }
        }

        public static int[] InsertionSort(int[] inputs)
        {
            var answer = new int[inputs.Length];
            var temp = new int[inputs.Length];
            // Get a forreal clone of this array.
            int[] copy_of_inputs = inputs.Clone() as int[];
            for (var i = 0;i < inputs.Length; i++) {
                var item = inputs[i];
                var j = 0;

                while (j < temp.Length)
                {
                    var second_item = inputs[j];
                    if (j == temp.Length - 1) // let's include item < second_item
                    {
                        // We've reached the end!!
                        answer[j-i] = item;
                        j = i+1;
                        continue;
                        // Start inner loop at current index + 1
                    } else if (item < second_item)
                    {

                    }
                    j += 1;
                }

                //var item2 = inputs[i+1];
            }
            return answer;
        }
    }
}
