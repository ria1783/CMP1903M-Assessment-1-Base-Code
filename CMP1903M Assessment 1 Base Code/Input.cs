using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: list
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.WriteLine("Please enter your text, and enter * in a new line when over!");
            List<string> textList = new List<string>();
            string line = Console.ReadLine();

            while (line != "*")
            {
                textList.Add(line);
                line = Console.ReadLine();
            }
            string text = string.Join(" ", textList);
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: list
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            List<string> fileList = new List<string>();
            fileList = File.ReadAllLines(fileName).ToList();
            string text = string.Join(" ", fileList);
            string[] textList = text.Split("*");
            text = textList[0];
            return text;
        }

    }
}
