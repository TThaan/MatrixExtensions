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
    public static class PerformantScalarOperations
    {
        // I define the first dimension of an array as the vertical dimension (column) of a matrix (or tensor).
        // If the array is one-dimensional it depicts a column vector.
        public static void Transpose(this float[] arr, float[,] result)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                result[0, i] = arr[i];
            }
        }
        public static void Transpose(this float[,] arr, float[,] result)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    result[j, i] = arr[i, j];
                }
            }
        }

        public static void Add(this float[] arr, float summand, float[] result)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                result[i] = arr[i] + summand;
            }
        }
        public static void Add(this float[,] arr, float summand, float[,] result)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    result[i, j] = arr[i, j] + summand;
                }
            }
        }

        public static void Subtract(this float[] arr, float subtrahend, float[] result)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                result[i] = arr[i] - subtrahend;
            }
        }
        public static void Subtract(this float[,] arr, float subtrahend, float[,] result)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    result[i, j] = arr[i, j] - subtrahend;
                }
            }
        }

        public static void Multiply(this float[] arr, float multiplier, float[] result)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                result[i] = arr[i] * multiplier;
            }
        }
        public static void Multiply(this float[,] arr, float multiplier, float[,] result)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    result[i, j] = arr[i, j] * multiplier;
                }
            }
        }

        public static void Divide(this float[] arr, float divisor, float[] result)
        {
            int a = arr.Length;

            for (int i = 0; i < a; i++)
            {
                result[i] = arr[i] / divisor;
            }
        }
        public static void Divide(this float[,] arr, float divisor, float[,] result)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    result[i, j] = arr[i, j] / divisor;
                }
            }
        }
    }
}
