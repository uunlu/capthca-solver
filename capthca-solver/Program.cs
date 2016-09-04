using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capthca_solver
{
    class Program
    {
        static void Main(string[] args)
        {
            float[][] array2D = new float[][]
            { new float[]{ 1, 2 },
              new float[]{ 3, 4 },
              new float[]{ 5, 6 },
              new float[]{ 7, 8 } };

            //var matrix = new Matrix(array2D);

            //Console.WriteLine(matrix);
            //Console.WriteLine(MatrixUtilities.Transpose(matrix));

            Matrix<double> matrix = DenseMatrix.OfArray(new double[,] {
                {1,1,1,1},
                {1,2,3,4},
                {4,3,2,1}
            });

            Console.WriteLine(matrix);
            Console.WriteLine(matrix.Transpose());

            var matrix2 = matrix.Multiply(2);
            Console.WriteLine(matrix2);

            var matrix2matrix = matrix.Multiply(matrix.Transpose());
            Console.WriteLine(matrix2matrix);
        }
    }
}
