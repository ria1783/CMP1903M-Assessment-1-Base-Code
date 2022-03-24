using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'

            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }

            //splits the sentences into an array
            string[] textList = input.Split(".");
            //calculates the number of sentences
            int sentences = textList.Length;
            if (sentences > 1)
            {
                sentences--;
            }
            //replaces the 0 in the list
            values.RemoveAt(0);
            values.Insert(0, sentences);

            string lowerInput = input.ToLower();

            //calculates the number of vowels
            int vowelCount = 0;
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < lowerInput.Length; i++)
            {
                if (vowels.Contains(lowerInput[i]))
                {
                    vowelCount++;
                }
            }
            //replaces the 0 in the list
            values.RemoveAt(1);
            values.Insert(1, vowelCount);

            //calculates the number of consonants
            int consonantCount = 0;
            var consonant = new HashSet<char> { 'q', 'w', 'r', 't', 'y', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

            for (int i = 0; i < lowerInput.Length; i++)
            {
                if (consonant.Contains(lowerInput[i]))
                {
                    consonantCount++;
                }
            }
            //replaces the 0 in the list
            values.RemoveAt(2);
            values.Insert(2, consonantCount);

            //counts the number of uppercase characters
            int upperCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    upperCount++;
                }
            }
            //replaces the 0 in the list
            values.RemoveAt(3);
            values.Insert(3, upperCount);

            //counts the number of lowercase characters
            int lowerCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                {
                    lowerCount++;
                }
            }
            //replaces the 0 in the list
            values.RemoveAt(4);
            values.Insert(4, lowerCount);

            return values;
        }
        public void analyseLongWords(string input)
        {
            List<string> words = new List<string>();
            input = input.Replace(".", "");
            input = input.Replace(",", "");
            input = input.Replace("?", "");
            input = input.Replace("!", "");
            string[] wordsList = input.Split(" ");
            for (int i = 0; i < wordsList.Length; i++)
            {
                if (wordsList[i].Length > 7)
                {
                    words.Add(wordsList[i]);
                }
            }

            // asks for a path to store text file
            Console.WriteLine("Please enter the filepath to your text file to store the long words list: ");
            string fileName = @""+Console.ReadLine();

            File.Delete(fileName);
            File.AppendAllLines(fileName, words);

            //display current contents of the file
            Console.WriteLine(File.ReadAllText(fileName));
        }

        public Dictionary<char,int> letterFreq(string input)
        {
            //get the frequencies of individual letters
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var letter in input)
            {
                if (char.IsLetter(letter))
                {
                    if (dic.ContainsKey(letter))
                        dic[letter] = dic[letter] + 1;
                    else
                        dic.Add(letter, 1);
                }
                
            }

            return dic;
        }
    }
}
