using System;

namespace MatrixExtensions
{
    /// <summary>
    /// The same array that is 'extended' is returned, 
    /// i.e. no new array gets defined here, except it's necessary like in 'Transpose()'
    /// or there is no array returned at all. 
    /// 
    /// No null check or checks if the arrays fulfill the requirements for a certain
    /// algorithm are executed.
    /// </summary>
    public static partial class Performance
    {
        public static float Magnitude(this float[] arr)
        {
            float result = default;
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                result += arr[i];
            }

            return result;
        }
        public static float Magnitude(this float[,] arr)
        {
            float result = default;
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    result += arr[i, j];
                }
            }

            return result;
        }
        public static float Magnitude(this float[,,] arr)
        {
            float result = default;
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            int c = arr.GetLength(2);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        result += arr[i, j, k];
                    }
                }
            }

            return result;
        }
        public static float Magnitude(this float[,,,] arr)
        {
            float result = default;
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
                            result += arr[i, j, k, l];
                        }
                    }
                }
            }

            return result;
        }

        // I define the first dimension of an array as the vertical dimension (column) of a matrix (or tensor).
        // If the array is one-dimensional it depicts a column vector.
        public static float[,] Transpose(this float[] arr)
        {
            int a = arr.Length;
            float[,] result = new float[1, a];

            for (int i = 0; i < a; i++)
            {
                result[0, i] = arr[i];
            }

            return result;
        }
        public static float[,] Transpose(this float[,] arr)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            float[,] result = new float[b, a];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    result[j, i] = arr[i, j];
                }
            }

            return result;
        }
        public static float[,,] Transpose(this float[,,] arr)
        {
            float[,,] result = default;
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

            return result;
        }
        public static float[,,,] Transpose(this float[,,,] arr)
        {
            float[,,,] result = default;
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

            return result;
        }

        public static float[] Add(this float[] arr, float summand)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                arr[i] += summand;
            }

            return arr;
        }
        public static float[,] Add(this float[,] arr, float summand)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] += summand;
                }
            }

            return arr;
        }
        public static float[,,] Add(this float[,,] arr, float summand)
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
                        arr[i, j, k] += summand;
                    }
                }
            }

            return arr;
        }
        public static float[,,,] Add(this float[,,,] arr, float summand)
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
                            arr[i, j, k, l] += summand;
                        }
                    }
                }
            }

            return arr;
        }

        public static float[] Subtract(this float[] arr, float subtrahend)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                arr[i] -= subtrahend;
            }

            return arr;
        }
        public static float[,] Subtract(this float[,] arr, float subtrahend)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] -= subtrahend;
                }
            }

            return arr;
        }
        public static float[,,] Subtract(this float[,,] arr, float subtrahend)
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
                        arr[i, j, k] -= subtrahend;
                    }
                }
            }

            return arr;
        }
        public static float[,,,] Subtract(this float[,,,] arr, float subtrahend)
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
                            arr[i, j, k, l] -= subtrahend;
                        }
                    }
                }
            }

            return arr;
        }

        public static float[] Multiply(this float[] arr, float multiplier)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                arr[i] *= multiplier;
            }

            return arr;
        }
        public static float[,] Multiply(this float[,] arr, float multiplier)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] *= multiplier;
                }
            }

            return arr;
        }
        public static float[,,] Multiply(this float[,,] arr, float multiplier)
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
                        arr[i, j, k] *= multiplier;
                    }
                }
            }

            return arr;
        }
        public static float[,,,] Multiply(this float[,,,] arr, float multiplier)
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
                            arr[i, j, k, l ] *= multiplier;
                        }
                    }
                }
            }

            return arr;
        }

        public static float[] Divide(this float[] arr, float divisor)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                arr[i] /= divisor;
            }

            return arr;
        }
        public static float[,] Divide(this float[,] arr, float divisor)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] /= divisor;
                }
            }

            return arr;
        }
        public static float[,,] Divide(this float[,,] arr, float divisor)
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
                        arr[i, j, k] /= divisor;
                    }
                }
            }

            return arr;
        }
        public static float[,,,] Divide(this float[,,,] arr, float divisor)
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
                            arr[i, j, k, l] /= divisor;
                        }
                    }
                }
            }

            return arr;
        }
    }
}
