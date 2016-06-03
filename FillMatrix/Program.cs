using System;

namespace FillMatrix
{
    class Program
    {
        static int number = 1;

        static void Spiral(int[,] matrix, int row, int col, int n)
        {

            if (number > n * n)
            {
                return;
            }
            else
            {
                // down
                while ((row < n) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    row++;
                    number++;
                }
                row--;
                col++;
                // left
                while ((col < n) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    col++;
                    number++;
                }
                col--;
                row--;
                // up
                while ((row >= 0) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    row--;
                    number++;
                }
                row++;
                col--;
                // left
                while ((col > 0) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    col--;
                    number++;
                }

                if (matrix[row, col] != 0)
                {
                    row++;
                    col++;
                    Spiral(matrix, row, col, n);
                }
            }
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int[,] matrix = new int[n, n];
            if(str=="a")
            {
                for(int i=0;i< n;i++)
                {
                    for(int j= 0;j< n;j++)
                    {
                        if (j == 0)
                        {
                            matrix[i, j] = i+1;
                        }
                        else
                        {
                            matrix[i, j] =matrix[i, j-1] + n;
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j < n - 1)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(matrix[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
            }
            if(str=="b")
            {
                int coef = 2*n; //get reversed value from previous col
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (col == 0)
                        {
                            matrix[row, col] = row + 1;
                        }
                        if(col==1)
                        {
                            matrix[row, col] =coef;
                            coef--;
                        }
                        if(col!=0&&col!=1)
                        {
                            matrix[row, col] = matrix[row, col - 2] + 2*n;
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {

                        if (j < n - 1)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(matrix[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
            }
            if(str=="c")
            {
                int row = n - 1;
                int col = 0;
                int data = 0;
                for (int i = 0; i < n; i++)
                {
                    do
                    {
                        data++;
                        if (row < 0) { row = 0; }
                        matrix[row, col] = data;
                        row++;
                        col++;
                    } while (row < n);

                    row -= col + 1;
                    col = 0;
                }

                row = 0;
                col = 1;
                for (int i = 0; i < n - 1; i++)
                {
                    do
                    {
                        data++;
                        matrix[row, col] = data;
                        row++;
                        col++;
                    } while (col < n);

                    col -= row - 1;
                    row = 0;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {

                        if (j < n - 1)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(matrix[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
            }
            if(str=="d")
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[j, i] = 0;
                    }
                }

                Spiral(matrix, 0, 0, n);
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {

                        if (j < n - 1)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(matrix[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
