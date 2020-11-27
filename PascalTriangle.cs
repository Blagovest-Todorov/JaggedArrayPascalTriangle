using System;

namespace _07.multiDimArrays
{
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            int height = 10;
            int[][] triangle = new int[height][];  //declaring a jagged array, we know rows , but we dont know columns

            triangle[0] = new int[1]; ///one row , array with one element one dimensional
            triangle[0][0] = 1;  //jagged array initialization a value on the cell with index [0,0]

            

            for (int row = 1; row < height; row++)  //we start form row index 1 to fill , becasuse row index 0 is 1 given ;
            {
                
                triangle[row] = new int[row + 1];
                triangle[row][0] = 1; //this value 1 is  given by task condition of Pascals triagle;

                for (int col = 1; col < row; col++)
                {
                    triangle[row][col] = triangle[row-1][col - 1] + triangle[row - 1][col];
                }
                triangle[row][row] = 1; //we take here one each row the last column, it is =1 again given by task condition

            }
            int count = 18;
            
            for (int row = 0; row < triangle.Length; row++)
            {
                Console.Write("".PadLeft(count));

                for (int col = 0; col < triangle[row].Length; col++)
                {
                    Console.Write("{0, 3} ", triangle[row][col]);
                }
                Console.WriteLine();
                count -= 2;
            }

            Console.WriteLine(triangle.Rank);

        }
    }
}
