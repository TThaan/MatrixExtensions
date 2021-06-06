using MatrixExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixExtensionsTest
{
    /// <summary>
    /// CollectionAssert considers { x, y } equal to  { x }, { y }!
    /// Change that!
    /// </summary>
    [TestClass]
    public class Performance_InclMatrix_Test
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

        static float[] v4;
        static float[,] m4Col, m4Row, m4DoubleRow, m42, m42T;
        // static float[,,] t235;

        static float multiplyScalarProduct_V4andV4;
        static float[] add_V4andV4, subtract_V4andV4, multiplyElementwise_V4andV4, multiplyCrosswise_V4andV4, divide_V4andV4;
        static float[,] add_M42andM42, subtract_M42andM42, multiplyElementwise_M42andM42, multiplyCrosswise_M42andM42, divide_M42andM42,
            multiply_MatrixWithMatrix_M42andM42T, multiply_MatrixWithMatrix_M42TandM42,
            multiply_ColumnVectorWithMatrix_V4andM4Row, multiply_MatrixWithColumnVector_M42RowAndV4, multiply_MatrixWithColumnVector_M42DoubleRowAndV4,
            multiply_RowVectorWithMatrix_V4andM42Col, multiply_MatrixWithRowVector_M42ColAndV4;

        static Performance_InclMatrix_Test()
        {
            ReSetSampleData();
            SetExpectedValues();
        }

        #endregion

        #region Two Vectors / Matrices (1D) Tests (v4)

        [TestMethod]
        public void Test_TwoVectors_Add()
        {
            var expect = add_V4andV4;
            var actual = v4.Add(v4);

            CollectionAssert.AreEqual(expect, actual);
            ReSetSampleData();
        }
        [TestMethod]
        public void Test_TwoVectors_Subtract()
        {
            var expect = subtract_V4andV4;
            var actual = v4.Subtract(v4);

            CollectionAssert.AreEqual(expect, actual);
            ReSetSampleData();
        }
        [TestMethod]
        public void Test_TwoVectors_MultiplyElementwise()
        {
            var expect = multiplyElementwise_V4andV4;
            var actual = v4.Multiply_Elementwise(v4);

            CollectionAssert.AreEqual(expect, actual);
            ReSetSampleData();
        }
        [TestMethod]
        public void Test_TwoVectors_MultiplyScalarProduct()
        {
            var expect = multiplyScalarProduct_V4andV4;
            var actual = v4.Multiply_ScalarProduct(v4);

            Assert.AreEqual(expect, actual);
            ReSetSampleData();
        }
        //[TestMethod]
        //public void Test_TwoVectors_MultiplyCrosswise()
        //{
        //    var expect = multiplyCrosswise_V4andV4;
        //    var actual = v4.Multiply_Crosswise(v4);

        //    CollectionAssert.AreEqual(expect, actual);

        //    ReSetSampleData();
        //}
        [TestMethod]
        public void Test_TwoVectors_Divide()
        {
            var expect = divide_V4andV4;
            var actual = v4.Divide(v4);

            CollectionAssert.AreEqual(expect, actual);
            ReSetSampleData();
        }

        #endregion

        #region Two Matrices (2D) Tests (m42)

        [TestMethod]
        public void Test_TwoMatrices_Add()
        {
            var expect = add_M42andM42;
            var actual = m42.Add(m42);

            CollectionAssert.AreEqual(expect, actual);
            ReSetSampleData();
        }
        [TestMethod]
        public void Test_TwoMatrices_Subtract()
        {
            var expect = subtract_M42andM42;
            var actual = m42.Subtract(m42);

            CollectionAssert.AreEqual(expect, actual);
            ReSetSampleData();
        }
        [TestMethod]
        public void Test_TwoMatrices_MultiplyElementwise()
        {
            var expect = multiplyElementwise_M42andM42;
            var actual = m42.Multiply_Elementwise(m42);

            CollectionAssert.AreEqual(expect, actual);
            ReSetSampleData();
        }
        [TestMethod]
        public void Test_TwoMatrices_MultiplyMatrixProduct()
        {
            var expect = multiply_MatrixWithMatrix_M42andM42T;
            var actual = m42.Multiply_MatrixProduct(m42T);

            CollectionAssert.AreEqual(expect, actual);

            var expect2 = multiply_MatrixWithMatrix_M42TandM42;
            var actual2 = m42T.Multiply_MatrixProduct(m42);

            CollectionAssert.AreEqual(expect2, actual2);

            ReSetSampleData();
        }
        //[TestMethod]
        //public void Test_TwoMatrices_MultiplyCrosswise()
        //{
        //    var expect = multiplyCrosswise_M42andM42;
        //    var actual = m42.Multiply_MatrixProduct(m42);

        //    CollectionAssert.AreEqual(expect, actual);
        //    ReSetSampleData();
        //}
        [TestMethod]
        public void Test_TwoMatrices_Divide()
        {
            var expect = divide_M42andM42;
            var actual = m42.Divide(m42);

            CollectionAssert.AreEqual(expect, actual);
            ReSetSampleData();
        }

        #endregion

        #region Vector And Matrix (1D and 2D) Tests (v4, m42)

        //[TestMethod]
        //public void Test_VectorAndMatrix_Add()
        //{
        //    var expect = add_V4andM32;
        //    var actual = v4.Add(m32);

        //    CollectionAssert.AreEqual(expect, actual);

        //    var expect2 = add_M32andV4;
        //    var actual2 = m32.Add(v4);

        //    CollectionAssert.AreEqual(expect2, actual2);

        //    ReSetSampleData();
        //}
        //[TestMethod]
        //public void Test_VectorAndMatrix_Subtract()
        //{
        //    var expect = subtract_V4andM32;
        //    var actual = v4.Subtract(m32);

        //    CollectionAssert.AreEqual(expect, actual);

        //    var expect2 = subtract_M32andV4;
        //    var actual2 = m32.Subtract(v4);

        //    CollectionAssert.AreEqual(expect2, actual2);

        //    ReSetSampleData();
        //}
        //[TestMethod]
        //public void Test_VectorAndMatrix_MultiplyElementwise()
        //{
        //    var expect = multiply_V4andM32;
        //    var actual = v4.Multiply(m32);

        //    CollectionAssert.AreEqual(expect, actual);

        //    var expect2 = multiply_M32andV4;
        //    var actual2 = m32.Multiply(v4);

        //    CollectionAssert.AreEqual(expect2, actual2);

        //    ReSetSampleData();
        //}
        [TestMethod]
        public void Test_VectorAndMatrix_MultiplyMatrixProduct()
        {
            var expect = multiply_RowVectorWithMatrix_V4andM42Col;
            var actual = v4.Multiply_RowVectorWithMatrix(m4Col);

            CollectionAssert.AreEqual(expect, actual);
            ReSetSampleData();

            var expect2 = multiply_ColumnVectorWithMatrix_V4andM4Row;
            var actual2 = v4.Multiply_ColumnVectorWithMatrix(m4Row);

            CollectionAssert.AreEqual(expect2, actual2);
            ReSetSampleData();

            var expect3 = multiply_MatrixWithColumnVector_M42RowAndV4;
            var actual3 = m4Row.Multiply_MatrixWithColumnVector(v4);

            CollectionAssert.AreEqual(expect3, actual3);
            ReSetSampleData();

            var expect3b = multiply_MatrixWithColumnVector_M42DoubleRowAndV4;
            var actual3b = m4DoubleRow.Multiply_MatrixWithColumnVector(v4);

            CollectionAssert.AreEqual(expect3b, actual3b);
            ReSetSampleData();

            var expect4 = multiply_MatrixWithRowVector_M42ColAndV4;
            var actual4 = m4Col.Multiply_MatrixWithRowVector(v4);

            CollectionAssert.AreEqual(expect4, actual4);
            ReSetSampleData();
        }
        //[TestMethod]
        //public void Test_VectorAndMatrix_MultiplyCrosswise()
        //{
        //    var expect = multiply_V4andM32;
        //    var actual = v4.Multiply(m32);

        //    CollectionAssert.AreEqual(expect, actual);

        //    var expect2 = multiply_M32andV4;
        //    var actual2 = m32.Multiply(v4);

        //    CollectionAssert.AreEqual(expect2, actual2);

        //    ReSetSampleData();
        //}
        //[TestMethod]
        //public void Test_VectorAndMatrix_Divide()
        //{
        //    var expect = divide_V4andM32;
        //    var actual = v4.Divide(m32);

        //    CollectionAssert.AreEqual(expect, actual);

        //    var expect2 = divide_M32andV4;
        //    var actual2 = m32.Divide(v4);

        //    CollectionAssert.AreEqual(expect2, actual2);

        //    ReSetSampleData();
        //}

        #endregion

        #region helpers

        private static void ReSetSampleData()
        {
            //t235 = new float[2, 3, 5]
            //    {
            //        {
            //            { 1, 2, 3, 4, 5 },
            //            { 1, 2, 3, 4, 5 },
            //            { 1, 2, 3, 4, 5 }
            //        },
            //        {
            //            { 1, 2, 3, 4, 5 },
            //            { 1, 2, 3, 4, 5 },
            //            { 1, 2, 3, 4, 5 }
            //        }
            //    };

            // Vectors/Matrices
            // For now I define a vector as a one-dimensional array having one row with 'n' values.
            v4 = new float[4]
                {
                    1, 2, -3, 4
                };
            m4Col = new float[4, 1]
                {
                    {1}, {2}, {-3}, {4}
                };
            m4Row = new float[1, 4]
            {
                { 1, 2, -3, 4 }
            };
            m4DoubleRow = new float[2, 4]
            {
                { 1, 2, -3, 4 },
                { 1, 2, -3, 4 }
            };
            m42 = new float[4, 2]
                {
                    {2, 9},
                    {-3, 18},
                    {7, 10},
                    {5, -1}
                };
            m42T = new float[2, 4]
                {
                    {2, -3, 7, 5},
                    {9, 18, 10,-1}
                };

            
        }
        private static void SetExpectedValues()
        {
            #region v4

            add_V4andV4 = new float[]
            {
                2, 4, -6, 8
            };
            subtract_V4andV4 = new float[]
            {
                0, 0, 0, 0
            };
            multiplyElementwise_V4andV4 = new float[]
            {
                1, 4, 9, 16
            };
            multiplyScalarProduct_V4andV4 = 30;
            multiplyCrosswise_V4andV4 = new float[]
            {
                2, 4, -6, 8
            };
            divide_V4andV4 = new float[]
            {
                1, 1, 1, 1
            };

            #endregion

            #region m42

            add_M42andM42 = new float[,]
            {
                {4, 18},
                {-6, 36},
                {14, 20},
                {10, -2}
            };
            subtract_M42andM42 = new float[,]
            {
                {0, 0},
                {0, 0},
                {0, 0},
                {0, 0}
            };
            divide_M42andM42 = new float[,]
            {
                {1, 1},
                {1, 1},
                {1, 1},
                {1, 1}
            };
            multiplyElementwise_M42andM42 = new float[,]
            {
                {4, 81},
                {9, 324},
                {49, 100},
                {25, 1}
            };
            multiplyCrosswise_M42andM42 = new float[,]
            {
                {4, 18},
                {-6, 36},
                {14, 20}
            };

            #region Matrix Product: Matrix with Matrix

            multiply_MatrixWithMatrix_M42TandM42 = new float[2,2]
            {
                {87, 29},
                {29, 506}
            };
            multiply_MatrixWithMatrix_M42andM42T = new float[4,4]
            {
                {85, 156, 104, 1},
                {156, 333, 159, -33},
                {104, 159, 149, 25},
                {1, -33, 25, 26}
            };

            #endregion

            #region Matrix Product: Row(s) with Column

            multiply_RowVectorWithMatrix_V4andM42Col = new float[1,1]
            {
                { 30 }
                // {-5, 11},
            };
            multiply_MatrixWithColumnVector_M42RowAndV4 = new float[1, 1]
            {
                { 30 }
            };

            multiply_MatrixWithColumnVector_M42DoubleRowAndV4 = new float[2, 1]
            {
                { 30 }, {30 }
            };

            #endregion

            #region Matrix Product: Column with Row

            multiply_MatrixWithRowVector_M42ColAndV4 = new float[4, 4]
            {
                {1, 2, -3, 4},
                {2, 4, -6, 8},
                {-3, -6, 9, -12},
                {4, 8, -12, 16}
            };
            // Also test with diff m & n here:
            multiply_ColumnVectorWithMatrix_V4andM4Row = new float[4,4]
            {
                {1, 2, -3, 4},
                {2, 4, -6, 8},
                {-3, -6, 9, -12},
                {4, 8, -12, 16}
            };

            #endregion

            #endregion
        }

        #endregion
    }
}
