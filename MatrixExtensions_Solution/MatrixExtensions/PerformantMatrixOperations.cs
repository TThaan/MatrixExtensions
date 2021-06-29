using System;

// Focusing on performance I decided to totally ignore DRY.
// Each method should do its job without further method calls, no if clauses etc.

// Furthermore I don't include any checks here, neither for nulled parameters or apropriate array sizes to perform certain matrix operations.
// If you want all of this you can use my IMatrix library at a (pretty high) cost of performance though.

// Each kind of array gets its own method. I did not use generic collections/interfaces or the Array class to reduce code.
// This way there is no casting needed anywhere.

namespace MatrixExtensions
{
    public static class PerformantMatrixOperations
    {
        public static void Add(this float[] arr, float[] summand, float[] result)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                result[i] = arr[i] + summand[i];
            }
        }
        public static void Add(this float[,] arr, float[,] summand, float[,] result)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    result[i, j] = arr[i, j] + summand[i, j];
                }
            }
        }

        public static void Subtract(this float[] arr, float[] subtrahend, float[] result)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                result[i] = arr[i] - subtrahend[i];
            }
        }
        public static void Subtract(this float[,] arr, float[,] subtrahend, float[,] result)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    result[i, j] = arr[i, j] - subtrahend[i, j];
                }
            }
        }

        public static void Divide(this float[] arr, float[] divisor, float[] result)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                result[i] = arr[i] / divisor[i];
            }
        }
        public static void Divide(this float[,] arr, float[,] divisor, float[,] result)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    result[i, j] = arr[i, j] / divisor[i, j];
                }
            }
        }

        /// <summary>
        /// Hadamard Product
        /// </summary>
        public static void Multiply_Elementwise(this float[] arr, float[] multiplier, float[] result)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                result[i] = arr[i] * multiplier[i];
            }
        }
        /// <summary>
        /// Hadamard Product
        /// </summary>
        public static void Multiply_Elementwise(this float[,] arr, float[,] multiplier, float[,] result)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    result[i, j] = arr[i, j] * multiplier[i, j];
                }
            }
        }

        public static void Multiply_ScalarProduct_ColumnWithRow(this float[] columnVector, float[] multipliedRowVector, float[,] result)
        {
            int a = columnVector.Length;
            int b = multipliedRowVector.Length;

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    result[j, i] = columnVector[j] * multipliedRowVector[i];
                }
            }
        }
        /// <summary>
        /// Matrix Product
        /// Check the dot product of two vectors, each defined as a 2D-array!
        /// </summary>
        public static void Multiply_MatrixProduct(this float[,] arr, float[,] multiplier, float[,] result) // Pass result either (vgl IMartix.PerformantOperations) so there is no need to instantiate a new array here?
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);   // arr.GetLength(1) = multiplier.GetLength(0)
            int b2 = multiplier.GetLength(1);

            // For each column of multiplier
            for (int y = 0; y < b2; y++)
            {
                // and each row of arr
                for (int i = 0; i < a; i++)
                {
                    // get the scalar product between that i-th row of arr and the i-th column of multiplier.
                    for (int j = 0; j < b; j++)
                    {
                        result[i, y] += arr[i, j] * multiplier[j, y];
                    }
                }
            }
        }
        /// <summary>
        /// 'arr' is used as column vector here, i.e. a 'm x 1' matrix.
        /// Thus 'multiplier' must have one row only, i.e. be a '1 x n' matrix, to allow a matrix product between the two.
        /// </summary>        
        public static void Multiply_ColumnVectorWithMatrix(this float[] arr, float[,] multiplier, float[,] result)
        {
            int a = arr.GetLength(0);
            int b2 = multiplier.GetLength(1);

            // For each column of multiplier
            for (int y = 0; y < b2; y++)
            {
                // get the scalar product between arr and the y-th column of multiplier.
                for (int j = 0; j < a; j++)
                {
                    result[j, y] = arr[j] * multiplier[0, y];
                }
            }
        }
        /// <summary>
        /// 'arr' is used as row vector here, i.e. a '1 x n' matrix.
        /// 'multiplier' can have multiple rows, each representing .. check: a row of the resulting vector/'1 x n' matrix (where n = m).
        /// </summary>
        public static void Multiply_RowVectorWithMatrix(this float[] arr, float[,] multiplier, float[,] result)
        {
            int a = arr.Length;
            int b2 = multiplier.GetLength(1);

            // For each column of multiplier
            for (int y = 0; y < b2; y++)
            {
                // get the scalar product between arr and the y-th column of multiplier.
                for (int j = 0; j < a; j++)
                {
                    result[0, y] += arr[j] * multiplier[j, 0];
                }
            }
        }
        /// <summary>
        /// 'multiplier' is used as column vector here, i.e. a 'm x 1' matrix.
        /// 'arr' can have multiple rows, each representing a row of the resulting vector/'1 x n' matrix (where n = m).
        /// </summary>
        public static void Multiply_MatrixWithColumnVector(this float[,] arr, float[] multiplier, float[] result)
        {
            // Don't just call above method but repeat code here due to the performance drop of method calls. So ignore DRY!

            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            // For each row of arr
            for (int i = 0; i < a; i++)
            {
                // for each col of arr
                for (int j = 0; j < b; j++)
                {
                    result[i] += arr[i, j] * multiplier[j];
                }
            }
        }
        /// <summary>
        /// 'multiplier' is used as row vector here, i.e. a '1 x n' matrix.
        /// Thus 'arr' must have one column only, i.e. be a 'm x 1' matrix, to allow a matrix product between the two.
        /// </summary>
        public static void Multiply_MatrixWithRowVector(this float[,] arr, float[] multiplier, float[,] result)
        {
            // Don't just call above method but repeat code here due to the performance drop of method calls. So ignore DRY!

            int a = arr.GetLength(0);
            int b2 = multiplier.Length;

            // For each column of multiplier
            for (int y = 0; y < b2; y++)
            {
                // get the scalar product between arr and the y-th column of multiplier.
                for (int i = 0; i < a; i++)
                {
                    result[i, y] = arr[i, 0] * multiplier[y];
                }
            }
        }

        /// <summary>
        /// Cross/Vector - Product. Use only with 3 dimensional vectors!
        /// </summary>
        public static void Multiply_Crosswise(this float[] arr, float[] multiplier, float[] result)
        {
            result[0] = arr[1] * multiplier[2] - arr[2] * multiplier[1];
            result[1] = arr[2] * multiplier[0] - arr[0] * multiplier[2];
            result[2] = arr[0] * multiplier[1] - arr[1] * multiplier[0];
        }

        public static void ForEach(this float[] arr, Func<float, float> func, float[] result)
        {
            int a = arr.Length;
            
            for (int i = 0; i < a; i++)
            {
                result[i] = func(arr[i]);
            }
        }
        public static void ForEach(this float[,] arr, Func<float, float> func, float[,] result)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    result[i, j] = func(arr[i, j]);
                }
            }
        }
    }
}
