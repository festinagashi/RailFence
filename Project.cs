using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailFence
{
    class Program
    {

        private static char[][] BuildMatrix(int rows, int cols)
        {
            char[][] result = new char[rows][];

            for (int row = 0; row < result.Length; row++)
            {
                result[row] = new char[cols];
            }

            return result;

        }
        
        private static string MatrixtoString(char[][] matrix)
        {
            string result = string.Empty;

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] != '\0')
                    {
                        result += matrix[row][col];
                    }
                }
            }

            return result;
        }

        private static char[][] Transpose(char[][] matrix)
        {
            char[][] result = BuildMatrix(matrix[0].Length, matrix.Length);

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    result[col][row] = matrix[row][col];
                }
            }

            return result;
        }

        private static string Enrypt(string text, int key)
        {
            string result = string.Empty;

            char[][] matrix = BuildMatrix(key, text.Length);

            int rowIncrement = 1;
            for (int row = 0, col = 0; col < matrix[row].Length; col++)
            {
                if (row + rowIncrement == matrix.Length || row + rowIncrement == -1)
                {
                    rowIncrement *= -1;
                }

                matrix[row][col] = text[col];
                row += rowIncrement;
            }

            result = MatrixtoString(matrix);

            return result;
        }

        private static string Decrypt(string ciphertext, int key)
        {
            string result = string.Empty;

            char[][] matrix = BuildMatrix(key, ciphertext.Length);

            int rowIncrement = 1;
            int textIdx = 0;

            for (int selectedRow = 0; selectedRow < matrix.Length; selectedRow++)
            {
                for (int row = 0, col = 0; col < matrix[row].Length; col++)
                {
                    if (row + rowIncrement == matrix.Length || row + rowIncrement == -1)
                    {
                        rowIncrement *= -1;
                    }

                    if (row == selectedRow)
                    {
                        matrix[row][col] = ciphertext[textIdx++];
                    }

                    row += rowIncrement;
                }

            }

            matrix = Transpose(matrix);
            result = MatrixtoString(matrix);

            return result;

        }

        public static void Main()
        {
            string text;

            Console.Write("Jepni fjalen qe doni te enkriptoni: ");
            text = Console.ReadLine();

            Console.Write("Jepni qelsin: ");
            int key = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enkriptimi: ");
            Console.WriteLine(Enrypt(text, key));


            string ciphertext = Enrypt(text, key);
            
            Console.Write("Dekriptimi: ");
            Console.WriteLine(Decrypt(ciphertext, key));
            Console.Write("\n");

            Main();
        }
    }
}
