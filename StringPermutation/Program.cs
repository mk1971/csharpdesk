using System;
using System.Linq;

namespace StringPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter first string to be processed: ");
            var firstInputString = Console.ReadLine();

            Console.Write("Please enter second string to be processed: ");
            var secondInputString = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(firstInputString) && !string.IsNullOrWhiteSpace(secondInputString))
            {
                //assumption : comparison is case sensitive and whitespace is significant  
                Console.WriteLine(IsPermutation(firstInputString, secondInputString) ? "Given strings are permutation of each other"
                    : "Given strings are not permutation of each other");
            }

            Console.ReadLine();
        }

        private static bool IsPermutation(string firstInputString, string secondInputString)
        {
            //Compare Length of two strings, if they do not match then it concludes that the given strings are not permutation   
            if (firstInputString.Length != secondInputString.Length)
            {
                return false;
            }

            //Convert string into an array  
            char[] firstInputStringCharacterSet = firstInputString.ToCharArray();
            char[] secondInputStringCharacterSet = secondInputString.ToCharArray();
            //declare an array of integer type with size 128 because as per the ASCII standard character set  
            //there are 128 characters for electronic communication.  
            int[] characterSetMappingTable = new int[128];

            //Iterate through first array and for the index matching with the character ASCII value,  
            //set the value in the integer array to 1 if the value is 0 OR set the value in the integer array to 0 if the value is 1   
            PrepareCharacterSetMappingTable(firstInputStringCharacterSet, characterSetMappingTable);
            //Iterate through second array and for the index matching with the character ASCII value,  
            //set the value in the integer array to 1 if the value is 0 OR set the value in the integer array to 0 if the value is 1   
            PrepareCharacterSetMappingTable(secondInputStringCharacterSet, characterSetMappingTable);

            //After iterating over both the arrays, the resultant value in the integer array for each of the index should be 0.  
            //In case we see any index with odd value i.e., i then it concludes that the given strings are not permutation.  

            return IsOddOneFound(characterSetMappingTable);
        }

        private static void PrepareCharacterSetMappingTable(char[] inputStringCharacterSet, int[] characterSetMappingTable)
        {
            foreach (char inputStringCharacter in inputStringCharacterSet)
            {
                var characterIndex = (int)inputStringCharacter;

                switch (characterSetMappingTable[characterIndex])
                {
                    case 0:
                        characterSetMappingTable[characterIndex] = 1;
                        break;
                    case 1:
                        characterSetMappingTable[characterIndex] = 0;
                        break;
                }
            }
        }

        /// <summary>  
        /// Check if any index contains odd value in the integer array or not  
        /// </summary>  
        /// <param name="characterSetMappingTable">array of integer type with size 128 </param>  
        /// <returns></returns>  
        private static bool IsOddOneFound(int[] characterSetMappingTable)
        {
            return characterSetMappingTable.All(index => index != 1);
        }
    }
}
