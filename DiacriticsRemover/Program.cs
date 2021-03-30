using System;

namespace DiacriticsRemover
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringWithDiacritics = "!@# $% ¨&* ºª' aáã eéè iíì oóõ uúù";
            Console.WriteLine(DiacriticsMarksRemoval.DiacriticsClearString(stringWithDiacritics));
        }
    }
}
