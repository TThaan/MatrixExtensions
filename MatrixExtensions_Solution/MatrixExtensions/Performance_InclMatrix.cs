using System;

// Focusing on performance I decided to totally ignore DRY.
// Each method should do its job without further method calls, no if clauses etc.

// Furthermore I don't include any checks here, neither for nulled parameters or apropriate array sizes to perform certain matrix operations.
// If you want all of this you can use my IMatrix library at a (pretty high) cost of performance though.

// Each kind of array gets its own method. I did not use generic collections/interfaces or the Array class to reduce code.
// This way there is no casting needed anywhere.

namespace MatrixExtensions
{
    public static partial class Performance
    {
        public static float[] Add(this float[] arr, float[] summand)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                arr[i] += summand[i];
            }

            return arr;
        }
        public static float[,] Add(this float[,] arr, float[,] summand)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] += summand[i, j];
                }
            }

            return arr;
        }
        public static float[,,] Add(this float[,,] arr, float[,,] summand)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            int c = arr.GetLength(2);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        arr[k, j, i] += summand[k, j, i];
                    }
                }
            }

            return arr;
        }
        public static float[,,,] Add(this float[,,,] arr, float[,,,] summand)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            int c = arr.GetLength(2);
            int d = arr.GetLength(3);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        for (int l = 0; l < d; k++)
                        {
                            arr[l, k, j, i] += summand[l, k, j, i];
                        }
                    }
                }
            }

            return arr;
        }

        public static float[] Subtract(this float[] arr, float[] subtrahend)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                arr[i] -= subtrahend[i];
            }

            return arr;
        }
        public static float[,] Subtract(this float[,] arr, float[,] subtrahend)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] -= subtrahend[i, j];
                }
            }

            return arr;
        }
        public static float[,,] Subtract(this float[,,] arr, float[,,] subtrahend)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            int c = arr.GetLength(2);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        arr[k, j, i] -= subtrahend[k, j, i];
                    }
                }
            }

            return arr;
        }
        public static float[,,,] Subtract(this float[,,,] arr, float[,,,] subtrahend)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            int c = arr.GetLength(2);
            int d = arr.GetLength(3);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        for (int l = 0; l < d; k++)
                        {
                            arr[l, k, j, i] -= subtrahend[l, k, j, i];
                        }
                    }
                }
            }

            return arr;
        }

        /// <summary>
        /// Hadamard Product
        /// </summary>
        public static float[] Multiply_Elementwise(this float[] arr, float[] multiplier)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                arr[i] *= multiplier[i];
            }

            return arr;
        }
        /// <summary>
        /// Hadamard Product
        /// </summary>
        public static float[,] Multiply_Elementwise(this float[,] arr, float[,] multiplier)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] *= multiplier[i, j];
                }
            }

            return arr;
        }
        /// <summary>
        /// Hadamard Product
        /// </summary>
        public static float[,,] Multiply_Elementwise(this float[,,] arr, float[,,] multiplier)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            int c = arr.GetLength(2);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        arr[k, j, i] *= multiplier[k, j, i];
                    }
                }
            }

            return arr;
        }
        /// <summary>
        /// Hadamard Product
        /// </summary>
        public static float[,,,] Multiply_Elementwise(this float[,,,] arr, float[,,,] multiplier)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            int c = arr.GetLength(2);
            int d = arr.GetLength(3);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        for (int l = 0; l < d; k++)
                        {
                            arr[l, k, j, i] *= multiplier[l, k, j, i];
                        }
                    }
                }
            }

            return arr;
        }

        /// <summary>
        /// Scalar Product, DotProduct
        ///  - (The second vector is automatically considered as its transpose.)
        ///  or 
        /// (If vectors are identified with row matrices, the dot product is the 'Matrix Product' (a*b = AB^T).)
        /// ?
        /// </summary>
        public static float Multiply_ScalarProduct(this float[] arr, float[] multiplier)
        {
            float result = default;
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                result += arr[i] * multiplier[i];
            }

            return result;
        }
        /// <summary>
        /// Matrix Product
        /// Check the dot product of two vectors, each defined as a 2D-array!
        /// </summary>
        public static float[,] Multiply_MatrixProduct(this float[,] arr, float[,] multiplier) // Pass result either (vgl IMartix.PerformantOperations) so there is no need to instantiate a new array here?
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);   // arr.GetLength(1) = multiplier.GetLength(0)
            int b2 = multiplier.GetLength(1);

            var result = new float[a, b2];

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

            return result;
        }
        /// <summary>
        /// 'arr' is used as column vector here, i.e. a 'm x 1' matrix.
        /// Thus 'multiplier' must have one row only, i.e. be a '1 x n' matrix, to allow a matrix product between the two.
        /// </summary>
        public static float[,] Multiply_ColumnVectorWithMatrix(this float[] arr, float[,] multiplier)
        {
            int a = arr.GetLength(0);
            int b2 = multiplier.GetLength(1);

            var result = new float[a, b2];

            // For each column of multiplier
            for (int y = 0; y < b2; y++)
            {
                // get the scalar product between arr and the y-th column of multiplier.
                for (int j = 0; j < a; j++)
                {
                    result[j, y] = arr[j] * multiplier[0, y];
                }
            }

            return result;
        }
        /// <summary>
        /// 'arr' is used as row vector here, i.e. a '1 x n' matrix.
        /// 'multiplier' can have multiple rows, each representing .. check: a row of the resulting vector/'1 x n' matrix (where n = m).
        /// </summary>
        public static float[,] Multiply_RowVectorWithMatrix(this float[] arr, float[,] multiplier)
        {
            int a = arr.Length;
            int b2 = multiplier.GetLength(1);

            var result = new float[1, b2];

            // For each column of multiplier
            for (int y = 0; y < b2; y++)
            {
                // get the scalar product between arr and the y-th column of multiplier.
                for (int j = 0; j < a; j++)
                {
                    result[0, y] += arr[j] * multiplier[j, 0];
                }
            }

            return result;
        }
        /// <summary>
        /// 'multiplier' is used as column vector here, i.e. a 'm x 1' matrix.
        /// 'arr' can have multiple rows, each representing a row of the resulting vector/'1 x n' matrix (where n = m).
        /// </summary>
        public static float[,] Multiply_MatrixWithColumnVector(this float[,] arr, float[] multiplier)
        {
            // Don't just call above method but repeat code here due to the performance drop of method calls. So ignore DRY!

            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            var result = new float[a, 1];

            // For each row of arr
            for (int i = 0; i < a; i++)
            {
                // for each col of arr
                for (int j = 0; j < b; j++)
                {
                    result[i, 0] += arr[i, j] * multiplier[j];
                }
            }

            return result;
        }
        /// <summary>
        /// 'multiplier' is used as row vector here, i.e. a '1 x n' matrix.
        /// Thus 'arr' must have one column only, i.e. be a 'm x 1' matrix, to allow a matrix product between the two.
        /// </summary>
        public static float[,] Multiply_MatrixWithRowVector(this float[,] arr, float[] multiplier)
        {
            // Don't just call above method but repeat code here due to the performance drop of method calls. So ignore DRY!

            int a = arr.GetLength(0);
            int b2 = multiplier.Length;

            var result = new float[a, b2];

            // For each column of multiplier
            for (int y = 0; y < b2; y++)
            {
                // get the scalar product between arr and the y-th column of multiplier.
                for (int i = 0; i < a; i++)
                {
                    result[i, y] = arr[i, 0] * multiplier[y];
                }
            }

            return result;
        }
        public static float[,,] Multiply(this float[,,] arr, float[,,] multiplier)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            int c = arr.GetLength(2);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        throw new NotImplementedException();
                    }
                }
            }

            return arr;
        }
        public static float[,,,] Multiply(this float[,,,] arr, float[,,,] multiplier)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            int c = arr.GetLength(2);
            int d = arr.GetLength(3);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        for (int l = 0; l < d; k++)
                        {
                            throw new NotImplementedException();
                        }
                    }
                }
            }

            return arr;
        }

        /// <summary>
        /// Cross/Vector - Product. Use only with 3 dimensional vectors!
        /// </summary>
        public static float[] Multiply_Crosswise(this float[] arr, float[] multiplier)
        {
            arr[0] = arr[1] * multiplier[2] - arr[2] * multiplier[1];
            arr[1] = arr[2] * multiplier[0] - arr[0] * multiplier[2];
            arr[2] = arr[0] * multiplier[1] - arr[1] * multiplier[0];

            return arr;
        }
        /// <summary>
        /// Matrix Product
        /// </summary>
        public static float[,] Multiply_Crosswise(this float[,] arr, float[,] multiplier)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    throw new NotImplementedException();
                }
            }

            return arr;
        }
        public static float[,,] Multiply_Crosswise(this float[,,] arr, float[,,] multiplier)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            int c = arr.GetLength(2);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        throw new NotImplementedException();
                    }
                }
            }

            return arr;
        }
        public static float[,,,] Multiply_Crosswise(this float[,,,] arr, float[,,,] multiplier)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            int c = arr.GetLength(2);
            int d = arr.GetLength(3);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        for (int l = 0; l < d; k++)
                        {
                            throw new NotImplementedException();
                        }
                    }
                }
            }

            return arr;
        }

        public static float[] Divide(this float[] arr, float[] divisor)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                arr[i] /= divisor[i];
            }

            return arr;
        }
        public static float[,] Divide(this float[,] arr, float[,] divisor)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] /= divisor[i, j];
                }
            }

            return arr;
        }
        public static float[,,] Divide(this float[,,] arr, float[,,] divisor)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            int c = arr.GetLength(2);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        throw new NotImplementedException();
                    }
                }
            }

            return arr;
        }
        public static float[,,,] Divide(this float[,,,] arr, float[,,,] divisor)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            int c = arr.GetLength(2);
            int d = arr.GetLength(3);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        for (int l = 0; l < d; k++)
                        {
                            throw new NotImplementedException();
                        }
                    }
                }
            }

            return arr;
        }

        public static float[] ForEach(this float[] arr, Func<float, float> func)
        {
            int a = arr.GetLength(0);
            
            for (int i = 0; i < a; i++)
            {
                arr[i] = func(arr[i]);
            }

            return arr;
        }
        public static float[,] ForEach(this float[,] arr, Func<float, float> func)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] = func(arr[i, j]);
                }
            }

            return arr;
        }
        public static float[,,] ForEach(this float[,,] arr, Func<float, float> func)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            int c = arr.GetLength(2);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        arr[i, j, k] = func(arr[i, j, k]);
                    }
                }
            }

            return arr;
        }
        public static float[,,,] ForEach(this float[,,,] arr, Func<float, float> func)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            int c = arr.GetLength(2);
            int d = arr.GetLength(3);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        for (int l = 0; l < c; l++)
                        {
                            arr[i, j, k, l] = func(arr[i, j, k, l]);
                        }
                    }
                }
            }

            return arr;
        }

        //public static bool Equals(this float[] arr, float[] other)
        //{

        //}
        public static float[,] AsMatrixWithOneColumn(this float[] arr)
        {
            int arrLength = arr.Length;
            float[,] result = new float[arrLength, 1];

            for (int i = 0; i < arrLength; i++)
            {
                result[i, 0] = arr[i];
            }

            return result;
        }
        public static float[,] AsMatrixWithOneRow(this float[] arr)
        {
            int arrLength = arr.Length;
            float[,] result = new float[1, arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                result[0, i] = arr[i];
            }

            return result;
        }
    }
}
