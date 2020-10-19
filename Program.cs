using System;


namespace CapstonePigLatin


{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
                Console.WriteLine("Give me a word.");
                string userInput = Console.ReadLine();
                string pigLatin = userInput;


                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };

                string[] parts = userInput.Split(vowels, StringSplitOptions.RemoveEmptyEntries); //consonants saved here
                string[] parts2 = userInput.Split(consonants, StringSplitOptions.RemoveEmptyEntries); //vowels saved here 

                int vowelCut = pigLatin.IndexOfAny(vowels) +1;
                
                int consonantCut = pigLatin.IndexOfAny(consonants)+1;
                string thisIsCut = pigLatin.Substring(0, Math.Max(0,vowelCut));
                int thisIsLength = thisIsCut.Length;

                string endCut = pigLatin.Substring(0, consonantCut);
                string extractedText = userInput.Substring(vowelCut);
                string extractedText2 = userInput.Substring(consonantCut);


                for (int i = 0; i < parts.Length; i++)
                {
                    if (thisIsLength > 0)
                    {
                        Console.WriteLine(extractedText.ToLower() + thisIsCut.ToLower() + "ay");
                    }
                    else

                    {
                        Console.WriteLine(endCut.ToLower() + extractedText2.ToLower() + "way");
                    }
                }
                Console.WriteLine("Would you like to translate another word? y/n");
                string yesNo = Console.ReadLine();
                if (yesNo == "n")
                {
                    Console.WriteLine("Bye");
                    break;
                }
                else if (yesNo == "y")
                {
                    continue;
                }
            }
        }

    }
}
