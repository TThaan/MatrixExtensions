using MatrixExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixExtensionsTest
{
    [TestClass]
    public class PerformanceTest
    {
        #region Ignore this comment until it actually is true or delete it after you eventually made a final decision about naming conventions.

        // I named the matrices according to the convention (at least the one I learned)
        // to call m the number of rows and n the number of columns in a m x n matrix.
        // That is contradictory (and maybe confusing) to the way you typically define an array and the sizes of it's dimensions.
        // There the last value in the square bracket defines the number of elements per row (i.e. columns), 
        // the second last value defines the number of rows and
        // the third last dimension defines the number of dimensions that contain rows as elements. 

        // If you don't understand this explanation don't feel bad, that happened to me as well. I'm with you!
        // I explicitely defined the example arrays including the sizes of their dimensions.
        // There you can see that the orders of the sizes in those definitions are reversed to their names. 

        #endregion

        #region Example Data

        // Scalars
        const float X = 2, Y = 10;

        // Vectors/Matrices
        static readonly float[] V4 = new float[4]
            {
                1, 2, -3, 4
            };
        /// <summary>
        /// Don't get confused:
        /// The defined values form a 41-matrix interpretable as a vector with 4 elements.
        /// But the definition as float[,] determines a 2-dimensional array
        /// that has only one column due to a single value 'per row'.
        /// That means each value is adressed by 2 parameters, like value v = M24[row-index, 0]!
        /// </summary>
        static readonly float[,] M41 =  new float[4,1]
            {
                {1},
                {2},
                {-3},
                {4,}
            };
        static readonly float[,] M41T = new float[1,4]
            {
                { 1, 2, -3, 4 }
            };
        static readonly float[,] M32 =  new float[3,2]
            {
                {2, 9},
                {-3, 18},
                {7, 10}
            };
        static readonly float[,] M32T = new float[2, 3]
            {
                {2, -3, 7},
                {9, 18, 10}
            };
        static readonly float[,,] T235 = new float[2, 3, 5]
            {
                {
                    { 1, 2, 3, 4, 5 },
                    { 1, 2, 3, 4, 5 },
                    { 1, 2, 3, 4, 5 }
                },
                {
                    { 1, 2, 3, 4, 5 },
                    { 1, 2, 3, 4, 5 },
                    { 1, 2, 3, 4, 5 }
                }
            };
        static readonly float[,,] T235T = new float[5, 3, 2]
            {
                {
                    { 1, 1 },
                    { 1, 1 },
                    { 1, 1 }
                },
                {
                    { 2, 2 },
                    { 2, 2 },
                    { 2, 2 }
                },
                {
                    { 3, 3 },
                    { 3, 3 },
                    { 3, 3 }
                },
                {
                    { 4, 4 },
                    { 4, 4 },
                    { 4, 4 }
                },
                {
                    { 5, 5 },
                    { 5, 5 },
                    { 5, 5 }
                }
            };

        #endregion

        #region Expected Results

        static readonly float[] Expected_TransposeOfV4 = new float[]
                {
                    {2, -3, 7 },
                    {9, 18, 10}
                };
        //static readonly Matrix Expected_AdditionOfA32AndA32 = new Matrix(
        //        new float[,]
        //        {
        //            {4, 18},
        //            {-6, 36},
        //            {14, 20}
        //        });
        //static readonly Matrix Expected_SubtractionOfA32AndA32 = new Matrix(
        //        new float[,]
        //        {
        //            {0, 0},
        //            {0, 0},
        //            {0, 0}
        //        });
        //static readonly Matrix Expected_MultiplicationOfA32AndX = new Matrix(
        //        new float[,]
        //        {
        //            {4, 18},
        //            {-6, 36},
        //            {14, 20}
        //        });
        //static readonly Matrix Expected_DivisionOfA32ByY = new Matrix(
        //        new float[,]
        //        {
        //            {.2f, .9f},
        //            {-.3f, 1.8f},
        //            {.7f, 1}
        //        });
        //static readonly Matrix Expected_ScalarProductOfA32WithA32Transpose = new Matrix(
        //        new float[,]
        //        {
        //            {85f, 156f, 104f },
        //            {156f, 333f, 159f },
        //            {104f, 159f, 149f }
        //        });
        //static readonly Matrix Expected_HadamarProductOfA32AndA32 = new Matrix(
        //        new float[,]
        //        {
        //            {4, 81 },
        //            {9, 324 },
        //            {49,100 }
        //        });


        //static Matrix KroneckerProductOfA32AndA32Transpose = new Matrix(
        //        new float[,]
        //        {
        //            {0, 0},
        //            {0, 0},
        //            {0, 0}
        //        });

        #endregion

        [TestMethod]
        public void Test_TransposeOfV4()
        {
            var expect = Expected_TransposeOfV4;
            var actual = V4.Transpose();

            Assert.AreEqual(expect, actual);
        }
    }
}
