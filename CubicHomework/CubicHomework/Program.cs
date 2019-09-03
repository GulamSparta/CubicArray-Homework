using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsHomeWork
{
    class Program : cubicArray
    {
        static void Main(string[] args)
        {
            object CubicArray = new cubicArray();
            cubicArray();
        }
    }

    class cubicArray
    {
        //Lab 1 : Cubic Array 10x10x10  Build a three dimensional array and populate it with numbers which are 
        //products of the input numbers.Make the size of the cube to be 10x10x10 and your 
        //numbers will run from 1 at(1,1,1) through 1000 at(10,10,10). Numbering starts at 1 here instead of 0.
        public void CubicArray()
        {
            // Create a three-dimensional array.
            int[,,] cubeArray = new int[3, 5, 4];
            cubeArray[0, 0, 0] = 1;
            cubeArray[0, 1, 0] = 2;
            cubeArray[0, 2, 0] = 3;
            cubeArray[0, 3, 0] = 4;
            cubeArray[0, 4, 0] = 5;
            cubeArray[1, 1, 1] = 2;
            cubeArray[2, 2, 2] = 3;
            cubeArray[2, 2, 3] = 4;

            // Loop over each dimension's length.
            for (int i = 0; i < cubeArray.GetLength(2); i++)
            {
                for (int y = 0; y < cubeArray.GetLength(1); y++)
                {
                    for (int x = 0; x < cubeArray.GetLength(0); x++)
                    {
                        Console.Write(cubeArray[x, y, i]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}