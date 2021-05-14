using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Net;
using System.Data.SqlClient;

namespace Project
{
  class Program
  {
        public static class GlobalMembers
        {

            // function to encrypt a message
            public static string encryptRailFence(string text, int key)
            {
                // create the matrix to cipher plain text
                // key = rows , length(text) = columns
                char[][] rail = RectangularArrays.RectangularCharArray(key, (text.Length));

                // filling the rail matrix to distinguish filled
                // spaces from blank ones
                for (int i = 0; i < key; i++)
                {
                    for (int j = 0; j < text.Length; j++)
                    {
                        rail[i][j] = '\n';
                    }
                }

                // to find the direction
                bool dir_down = false;
                int row = 0;
                int col = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    // check the direction of flow
                    // reverse the direction if we've just
                    // filled the top or bottom rail
                    if (row == 0 || row == key - 1)
                    {
                        dir_down = !dir_down;
                    }

                    // fill the corresponding alphabet
                    rail[row][col++] = text[i];

                    // find the next row using direction flag
                    dir_down ? row++: row--;
                }

                //now we can construct the cipher using the rail matrix
                string result;
                for (int i = 0; i < key; i++)
                {
                    for (int j = 0; j < text.Length; j++)
                    {
                        if (rail[i][j] != '\n')
                        {
                            result.push_back(rail[i][j]);
                        }
                    }
                }

                return result;
            }

            // This function receives cipher-text and key
            // and returns the original text after decryption
            public static string decryptRailFence(string cipher, int key)
            {
                // create the matrix to cipher plain text
                // key = rows , length(text) = columns
                char[][] rail = RectangularArrays.RectangularCharArray(key, cipher.Length);

                // filling the rail matrix to distinguish filled
                // spaces from blank ones
                for (int i = 0; i < key; i++)
                {
                    for (int j = 0; j < cipher.Length; j++)
                    {
                        rail[i][j] = '\n';
                    }
                }

                // to find the direction
                bool dir_down;

                int row = 0;
                int col = 0;

                // mark the places with '*'
                for (int i = 0; i < cipher.Length; i++)
                {
                    // check the direction of flow
                    if (row == 0)
                    {
                        dir_down = true;
                    }
                    if (row == key - 1)
                    {
                        dir_down = false;
                    }

                    // place the marker
                    rail[row][col++] = '*';

                    // find the next row using direction flag
                    dir_down ? row++: row--;
                }

                // now we can construct the fill the rail matrix
                int index = 0;
                for (int i = 0; i < key; i++)
                {
                    for (int j = 0; j < cipher.Length; j++)
                    {
                        if (rail[i][j] == '*' && index < cipher.Length)
                        {
                            rail[i][j] = cipher[index++];
                        }
                    }
                }


                string result;

                row = 0, col = 0;
                for (int i = 0; i < cipher.Length; i++)
                {
                    if (row == 0)
                    {
                        dir_down = true;
                    }
                    if (row == key - 1)
                    {
                        dir_down = false;
                    }

                    if (rail[row][col] != '*')
                    {
                        result.push_back(rail[row][col++]);
                    }


                    dir_down ? row++: row--;
                }
                return result;
            }


            internal static void Main()
            {
                string text;
                int key;
                string ciphertext;
                ciphertext = encryptRailFence(text, key);

                Console.Write("Jepni fjalen qe doni te enkriptoni: ");
                text = ConsoleInput.ReadToWhiteSpace(true);
                Console.Write("Jepni qelsin: ");
                key = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
                Console.Write(encryptRailFence(text, key));
                Console.Write("\n");


                Console.Write("Dekriptimi: ");
                Console.Write("\n");
                Console.Write(decryptRailFence(ciphertext, key));
                Console.Write("\n");


            }
        }
    }
}    
