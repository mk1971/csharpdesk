// File name: SimpleParser.csx
// Author: Jesus Kevin Morales
// Date Created: 06/09/2017
// Purpose: To store a simple parser for later loading while using the C# REPL.
// Date last modified: 07/08/2017

// Modification history:
// 06/09/2017: Original build;
// 06/09/2017: Added a SimpleParser class with a .Parse method (see member documentation for details).

using System;

/*
 * 
 * Represents a simple parser that showcases the use of the array data structure.
 * 
 */
 
public class SimpleParser
{

/*

Parses a given piece of text.

Parameter: text: The text to parse.

Returns: None.

Preconditions: The string given to this method should not be empty or null, and should contain HTML <p> tags.

Postconditions: The method will print to the screen.

This is an O(1) algorithm.

*/

	public static void Parse(string text)
    {

        // The following line creates an array of strings (HTML tags in this case), with 2 elements.
        // It is an O(1) operation.

        string[] tags = new string[] { "<p>", "</p>"};

        // The following line is also an O(1) operation.

        if (text.StartsWith(tags[0]) && text.EndsWith(tags[1])  )
        {
            Console.Write("\r\rYour paragraph is valid HTML.\r\r");
        }

    }
}
