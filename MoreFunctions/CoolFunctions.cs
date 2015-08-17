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

        public int[] swapInPlace(int[] inputs, int left_most_index, int right_most_index)
        {
            return null;
        }

        public static bool isSorted(int[] inputs)
        {
            for (int i = 0; i < inputs.Length -1; i++)
            {
                if (inputs[i] > inputs[i+1])
                {
                    return false;
                }
            }
            return true;
        }

        public static string PrintArray(int[] inputs)
        {
            var output = "[ ";
            for(var i = 0; i < inputs.Length;i++)
            {
                output += inputs[i];
                if (i != (inputs.Length-1))
                {
                    output += ", ";
                }
            }
            output += " ]";
            return output;
        }

        public static int[] InsertionSort(int[] inputs)
        {
            var answer = new int[inputs.Length];
            var temp = new int[inputs.Length];
            // Get a forreal clone of this array.
            int[] copy_of_inputs = inputs.Clone() as int[];
            var i = 0;
            var j = i+1; // ????
            var swapped = false;
            var end = false;
            while (!CoolFunctions.isSorted(copy_of_inputs)) // swapped == false
            {
                // What's the job of the outer loop?
                // Answer: Tells us when to stop resetting 'i' and return results;
                swapped = false;
                while(j < copy_of_inputs.Length) // 
                {
                    // What's the job of the inner loop?
                    // Answer: increment 'i', compare items and swap
                    var item = copy_of_inputs[i];
                    var second_item = copy_of_inputs[j];
                    if (item > second_item) {
                        // Let's Swap. Seems useful...
                        var tmpa = item;
                        var tmpb = second_item;
                        copy_of_inputs[i] = tmpb; // The item located at 'j'
                        copy_of_inputs[j] = tmpa;
                        swapped = true;
                    }
                   
                    if (j == copy_of_inputs.Length - 1)
                    {
                        i = 0;
                    } else if (CoolFunctions.isSorted(copy_of_inputs))
                    {
                        break;
                    }
                    else {
                        i++;
                    }
                    j = i + 1; //
                    Console.WriteLine(CoolFunctions.PrintArray(copy_of_inputs));
                }// End of the INNER while loop
                if (swapped == false)
                {
                    break; // IF the inner while loop does not swap any items, we're done done.
                }
            }
            return copy_of_inputs;
        }
    }
}
