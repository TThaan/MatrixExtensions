using MatrixExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixExtensionsTest
{
    [TestClass]
    public class PerformanceInclScalarTest
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

        #region fields & ctor

        const float X = 2, Y = 10;
        static float[] v4;
        static float[,] v4T, v4TT, m41, m41T, m32, m32T;
        static float[,,] t235, t235T;

        const float magnitudeOfV4 = 4, magnitudeOfV4T = 4, magnitudeOfV4TT = 4,
            magnitudeOfM32 = 43, magnitudeOfM32T = 43;
        static float[] add_V4andX, subtract_V4andX, multiply_V4andX, divide_V4andX;
        static float[,] transposeOfV4, transposeOfV4T, transposeOfM32, transposeOfM32T,
            add_V4TandX, add_V4TTandX, add_M32andX, add_M32TandX,
            subtract_V4TandX, subtract_V4TTandX, subtract_M32andX, subtract_M32TandX,
            multiply_V4TandX, multiply_V4TTandX, multiply_M32andX, multiply_M32TandX,
            divide_V4TandX, divide_V4TTandX, divide_M32andX, divide_M32TandX;

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

        // ctor

        static PerformanceInclScalarTest()
        {
            ReSetSampleData();
            SetExpectedValues();
        }

        #endregion


        // Cheating a bit here since I do multiple asserts per test method.
        // I decided it to be ok though in this case.
        // It's still one and the same method that is tested just with different values.

        #region Vector / Matrix (1D) Tests (v4, v4T, v4TT)

        [TestMethod]
        public void Test_Vector_Magnitude()
        {
            var expect = magnitudeOfV4;
            var actual = v4.Magnitude();

            Assert.AreEqual(expect, actual);

            var expect2 = magnitudeOfV4T;
            var actual2 = v4T.Magnitude();

            Assert.AreEqual(expect2, actual2);

            var expect3 = magnitudeOfV4TT;
            var actual3 = v4TT.Magnitude();

            Assert.AreEqual(expect3, actual3);
        }
        [TestMethod]
        public void Test_Vector_Transpose()
        {
            var expect = transposeOfV4;
            var actual = v4.Transpose();

            CollectionAssert.AreEqual(expect, actual);

            var expect2 = transposeOfV4T;
            var actual2 = v4T.Transpose();

            CollectionAssert.AreEqual(expect2, actual2);
            ReSetSampleData();
        }
        [TestMethod]
        public void Test_Vector_Add()
        {
            var expect = add_V4andX;
            var actual = v4.Add(X);

            CollectionAssert.AreEqual(expect, actual);

            var expect2 = add_V4TandX;
            var actual2 = v4T.Add(X);

            CollectionAssert.AreEqual(expect2, actual2);

            var expect3 = add_V4TTandX;
            var actual3 = v4TT.Add(X);

            CollectionAssert.AreEqual(expect3, actual3);
            ReSetSampleData();
        }
        [TestMethod]
        public void Test_Vector_Subtract()
        {
            var expect = subtract_V4andX;
            var actual = v4.Subtract(X);

            CollectionAssert.AreEqual(expect, actual);

            var expect2 = subtract_V4TandX;
            var actual2 = v4T.Subtract(X);

            CollectionAssert.AreEqual(expect2, actual2);

            var expect3 = subtract_V4TTandX;
            var actual3 = v4TT.Subtract(X);

            CollectionAssert.AreEqual(expect3, actual3);
            ReSetSampleData();
        }
        [TestMethod]
        public void Test_Vector_Multiply()
        {
            var expect = multiply_V4andX;
            var actual = v4.Multiply(X);

            CollectionAssert.AreEqual(expect, actual);

            var expect2 = multiply_V4TandX;
            var actual2 = v4T.Multiply(X);

            CollectionAssert.AreEqual(expect2, actual2);

            var expect3 = multiply_V4TTandX;
            var actual3 = v4TT.Multiply(X);

            CollectionAssert.AreEqual(expect3, actual3);
            ReSetSampleData();
        }
        [TestMethod]
        public void Test_Vector_Divide()
        {
            var expect = divide_V4andX;
            var actual = v4.Divide(X);

            CollectionAssert.AreEqual(expect, actual);

            var expect2 = divide_V4TandX;
            var actual2 = v4T.Divide(X);

            CollectionAssert.AreEqual(expect2, actual2);

            var expect3 = divide_V4TTandX;
            var actual3 = v4TT.Divide(X);

            CollectionAssert.AreEqual(expect3, actual3);
            ReSetSampleData();
        }

        #endregion

        #region Matrix (2D) Tests (m32, m32T)

        [TestMethod]
        public void Test_2DMatrix_Magnitude()
        {
            var expect = magnitudeOfM32;
            var actual = m32.Magnitude();

            Assert.AreEqual(expect, actual);

            var expect2 = magnitudeOfM32T;
            var actual2 = m32T.Magnitude();

            Assert.AreEqual(expect2, actual2);
        }
        [TestMethod]
        public void Test_2DMatrix_Transpose()
        {
            var expect = transposeOfM32;
            var actual = m32.Transpose();

            CollectionAssert.AreEqual(expect, actual);

            var expect2 = transposeOfM32T;
            var actual2 = m32T.Transpose();

            CollectionAssert.AreEqual(expect2, actual2);
            ReSetSampleData();
        }
        [TestMethod]
        public void Test_2DMatrix_Add()
        {
            var expect = add_M32andX;
            var actual = m32.Add(X);

            CollectionAssert.AreEqual(expect, actual);

            var expect2 = add_M32TandX;
            var actual2 = m32T.Add(X);

            CollectionAssert.AreEqual(expect2, actual2);

            ReSetSampleData();
        }
        [TestMethod]
        public void Test_2DMatrix_Subtract()
        {
            var expect = subtract_M32andX;
            var actual = m32.Subtract(X);

            CollectionAssert.AreEqual(expect, actual);

            var expect2 = subtract_M32TandX;
            var actual2 = m32T.Subtract(X);

            CollectionAssert.AreEqual(expect2, actual2);

            ReSetSampleData();
        }
        [TestMethod]
        public void Test_2DMatrix_Multiply()
        {
            var expect = multiply_M32andX;
            var actual = m32.Multiply(X);

            CollectionAssert.AreEqual(expect, actual);

            var expect2 = multiply_M32TandX;
            var actual2 = m32T.Multiply(X);

            CollectionAssert.AreEqual(expect2, actual2);

            ReSetSampleData();
        }
        [TestMethod]
        public void Test_2DMatrix_Divide()
        {
            var expect = divide_M32andX;
            var actual = m32.Divide(X);

            CollectionAssert.AreEqual(expect, actual);

            var expect2 = divide_M32TandX;
            var actual2 = m32T.Divide(X);

            CollectionAssert.AreEqual(expect2, actual2);

            ReSetSampleData();
        }

        #endregion

        #region helpers

        private static void ReSetSampleData()
        {
            // Vectors/Matrices
            // For now I define a vector as a one-dimensional array having one row with 'n' values.
            v4 = new float[4]
                {
                1, 2, -3, 4
                };
            // For now I define the transpose of a vector as a matrix with one column and 'm' rows (m = vector's n).
            // I could define the transpose of this 'm x 1' matrix again as either a vector or a '1 x n' matrix (n = untransposed matrix' m).
            v4T = new float[4, 1]
                {
                {1}, {2}, {-3}, {4}
                };
            // For now I define the transpose of any one dimensional matrix, ie a vector, depicted as a two-dimensional array with one dimension sized 1,
            // as a two-dimensional array as well, just with the other dimension sized 1.
            v4TT = new float[1, 4]
            {
                { 1, 2, -3, 4 }
            };
            /// <summary>
            /// Don't get confused:
            /// The defined values form a 41-matrix interpretable as a vector with 4 elements.
            /// But the definition as float[,] determines a 2-dimensional array
            /// that has only one column due to a single value 'per row'.
            /// That means each value is adressed by 2 parameters, like value v = M24[row-index, 0]!
            /// </summary>
            m41 = new float[4, 1]
                {
                    {1},
                    {2},
                    {-3},
                    {4}
                };
            m41T = new float[1, 4]
                {
                    { 1, 2, -3, 4 }
                };
            m32 = new float[3, 2]
                {
                    {2, 9},
                    {-3, 18},
                    {7, 10}
                };
            m32T = new float[2, 3]
                {
                    {2, -3, 7},
                    {9, 18, 10}
                };
            t235 = new float[2, 3, 5]
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
            t235T = new float[5, 3, 2]
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
        }
        private static void SetExpectedValues()
        {
            #region v4..

            transposeOfV4 = (float[,])v4T.Clone();
            transposeOfV4T = (float[,])v4TT.Clone();

            add_V4andX = new float[]
            {
                3, 4, -1, 6
            };
            add_V4TandX = new float[,]
            {
                {3}, {4}, {-1}, {6}
            };
            add_V4TTandX = new float[,]
            {
                {3, 4, -1, 6}
            };

            subtract_V4andX = new float[]
            {
                -1, 0, -5, 2
            };
            subtract_V4TandX = new float[,]
            {
                {-1}, {0}, {-5}, {2}
            };
            subtract_V4TTandX = new float[,]
            {
                {-1, 0, -5, 2}
            };

            multiply_V4andX = new float[]
            {
                2, 4, -6, 8
            };
            multiply_V4TandX = new float[,]
            {
                {2}, {4}, {-6}, {8}
            };
            multiply_V4TTandX = new float[,]
            {
                {2, 4, -6, 8}
            };

            divide_V4andX = new float[]
            {
                .5f, 1, -1.5f, 2
            };
            divide_V4TandX = new float[,]
            {
                {.5f}, {1}, {-1.5f}, {2}
            };
            divide_V4TTandX = new float[,]
            {
                {.5f, 1, -1.5f, 2}
            };

            #endregion

            #region m32..

            transposeOfM32 = (float[,])m32T.Clone();
            transposeOfM32T = (float[,])m32.Clone();

            add_M32andX = new float[,]
            {
                {4, 11},
                {-1, 20},
                {9, 12}
            };
            add_M32TandX = new float[,]
            {
                {4, -1, 9},
                {11, 20, 12}
            };

            subtract_M32andX = new float[,]
            {
                {0, 7},
                {-5, 16},
                {5, 8}
            };
            subtract_M32TandX = new float[,]
            {
                {0, -5, 5},
                {7, 16, 8}
            };

            multiply_M32andX = new float[,]
            {
                {4, 18},
                {-6, 36},
                {14, 20}
            };
            multiply_M32TandX = new float[,]
            {
                {4, -6, 14},
                {18, 36, 20}
            };

            divide_M32andX = new float[,]
            {
                {1, 4.5f},
                {-1.5f, 9},
                {3.5f, 5}
            };
            divide_M32TandX = new float[,]
            {
                {1, -1.5f, 3.5f},
                {4.5f, 9, 5}
            };

            #endregion
        }

        #endregion
    }
}
