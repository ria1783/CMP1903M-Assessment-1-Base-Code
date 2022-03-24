//Base code project for CMP1903M Assessment 1

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {

        static public void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            var input = new Input();
            //Create an 'Analyse' object
            var analyse = new Analyse();
            //Create a 'Report' object
            var report = new Report();
            //Get either manually entered text, or text from a file
            Console.WriteLine("HELLO TO THE FUCKING WORLD, FUCK YOU C#");
            Console.WriteLine("1. Do you want to enter the text via the keyboard? ");
            Console.WriteLine("2. Do you want to read in the text from a file? ");
            Console.WriteLine("Please enter 1 or 2:");
            string text = "";
            string option = Console.ReadLine();
            if (option == "1")
            {
                text = input.manualTextInput();
                Console.WriteLine(text);
            }
            else if (option == "2")
            {
                Console.WriteLine("Please enter the filepath to your text file: ");
                string fileName = @""+Console.ReadLine();
                text = input.fileTextInput(fileName);
                Console.WriteLine(text);
                analyse.analyseLongWords(text);
            }
            else
            {
                Console.WriteLine("False input...");
            }

            //Pass the text input to the 'analyseText' method
            //Receive a list of integers back
            parameters = analyse.analyseText(text);
            Dictionary<char,int> dic = analyse.letterFreq(text);

            //Report the results of the analysis
            report.reportAnalysis(parameters);
            report.reportFreq(dic);



        }



    }
}
