using System;

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
        public static float[,] Add(float[,] arr, float[,] summand)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[j, i] += summand[j, i];
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

        public static float[] Subtract(float[] arr, float[] subtrahend)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                arr[i] -= subtrahend[i];
            }

            return arr;
        }
        public static float[,] Subtract(float[,] arr, float[,] subtrahend)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[j, i] -= subtrahend[j, i];
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
        public static float[] Multiply_Elementwise(float[] arr, float[] multiplier)
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
        public static float[,] Multiply_Elementwise(float[,] arr, float[,] multiplier)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[j, i] *= multiplier[j, i];
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
        /// (If vectors are identified with row matrices, the dot product is the 'Matrix Product' (a*b = AB^T).)
        /// </summary>
        public static float[] Multiply(float[] arr, float[] multiplier)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                arr[i] *= multiplier[i];
            }

            return arr;
        }
        /// <summary>
        /// Matrix Product
        /// </summary>
        public static float[,] Multiply(float[,] arr, float[,] multiplier)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[j, i] *= multiplier[j, i];
                }
            }

            return arr;
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
        /// Cross Product, Vector Product
        /// 'Cross-multiplication' always starts with the second items, even if you don't use 3 elements per vector.
        /// </summary>
        public static float[] Multiply_CrossWise(float[] arr, float[] multiplier)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                if (i < a - 2)
                    arr[i] = arr[i + 1] * multiplier[i + 2] - arr[i + 2] * multiplier[i + 1];
                else if (i == a - 2)
                    arr[i] = arr[i + 1] * multiplier[i] - arr[i] * multiplier[i + 1];
                else
                    arr[i] = arr[i] * multiplier[i + 1] - arr[i + 1] * multiplier[i];
            }

            return arr;
        }
        /// <summary>
        /// Matrix Product
        /// </summary>
        public static float[,] Multiply_CrossWise(float[,] arr, float[,] multiplier)
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
        public static float[,,] Multiply_CrossWise(this float[,,] arr, float[,,] multiplier)
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
        public static float[,,,] Multiply_CrossWise(this float[,,,] arr, float[,,,] multiplier)
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

        public static float[] Divide(float[] arr, float[] divisor)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                throw new NotImplementedException();
            }

            return arr;
        }
        public static float[,] Divide(float[,] arr, float[,] divisor)
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
    }
}
