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
            Matrix<double> input = DenseMatrix.OfArray(new double[,] {
                {0,0,1},
                {0,1,1},
                {1,0,1},
                {1,1,1}
            });

            Matrix<double> output = DenseMatrix.OfArray(new double[,] {
                {0,0,1,1}
            }).Transpose();

            var m = CreateRandomMatrix(3, 1);
            var syn0 = 2 * m - 1;

            Train(input, output, syn0, trainCount);

            //Console.WriteLine(m);
            Console.WriteLine(syn0);
            Console.ReadKey();
        }

        private static void Train(Matrix<double> input, Matrix<double> output, Matrix<double> syn0, int trainCount)
        {
            throw new NotImplementedException();
        }

        public static Matrix<double> CreateRandomMatrix(int x, int y)
        {

            var dblArray = new double[x][];
            var rnd = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < x; i++)
            {
                dblArray[i] = new double[y];
                for (int j = 0; j < y; j++)
                {
                    dblArray[i][j] = rnd.NextDouble();
                }
            }

            return DenseMatrix.OfColumnArrays(dblArray);
        }

        public static Matrix<double> Sigmoid(Matrix<double> m, bool deriv = false)
        {
            if (deriv)
            {
                return (1 - m);
            }

            return 1 / (1 + (-m).PointwiseExp());
        }
    }


}
