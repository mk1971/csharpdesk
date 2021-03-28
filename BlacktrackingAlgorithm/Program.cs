using System;
using System.Collections.Generic;

namespace BlacktrackingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new WordSearch(new List<List<char>>
            {
                new List<char>{'A','B','C','E'},
                new List<char>{'S','F','C','S'},
                new List<char>{'A','D','E','E'}
            });

            var result = game.Exist("ABCCED");  //true
            result = game.Exist("SEE");    //true
            result = game.Exist("ABCB");    //true
        }
    }
}
