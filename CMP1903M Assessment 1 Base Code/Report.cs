using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        public void reportAnalysis(List<int> input)
        {
            //prints out the analysis of the input
            Console.WriteLine("The number of sentences: {0}", input[0]);
            Console.WriteLine("The number of vowels: {0}", input[1]);
            Console.WriteLine("The number of consonants: {0}", input[2]);
            Console.WriteLine("The number of upper case letters: {0}", input[3]);
            Console.WriteLine("The number of lower case letters: {0}", input[4]);
        }

        public void reportFreq(Dictionary<char, int> dic)
        {
            foreach (var pair in dic)
            {
                //prints the frequency of the letters
                Console.WriteLine("There is {0} {1}'s", pair.Value, pair.Key);
            }
        }
    }
}
