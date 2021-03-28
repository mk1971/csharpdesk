using System;
using System.Collections.Generic;
using System.Text;

namespace BlacktrackingAlgorithm
{
    class WordSearch
    {
        private readonly List<List<char>> Board;

        public WordSearch(List<List<char>> board)
        {
            this.Board = board;
        }

        private bool ExistCharacter(int i, int j, int searchIndex, string searchWord)
        {
            //when reached outside the board
            if (i < 0 || i >= Board.Count || j < 0 || j >= Board[i].Count)
                return false;

            // when index character does not match  
            if (Board[i][j] != searchWord[searchIndex])
                return false;

            // when completely matched  
            if (searchIndex == searchWord.Length - 1)
                return true;

            // mark the current character  
            Board[i][j] = '#';

            // check every direction  
            bool found = ExistCharacter(i, j - 1, searchIndex + 1, searchWord) ||
                ExistCharacter(i, j + 1, searchIndex + 1, searchWord) ||
                ExistCharacter(i - 1, j, searchIndex + 1, searchWord) ||
                ExistCharacter(i + 1, j, searchIndex + 1, searchWord);

            // unmark the current character  
            Board[i][j] = searchWord[searchIndex];
            return found;
        }

        public bool Exist(string searchWord)
        {
            if (searchWord == "")
                return false;

            // iterate over the board  
            for (int i = 0; i < Board.Count; i++)
            {
                for (int j = 0; j < Board[i].Count; j++)
                {
                    // check first character  
                    if (ExistCharacter(i, j, 0, searchWord))
                        return true;
                }
            }
            return false;
        }
    }
}
