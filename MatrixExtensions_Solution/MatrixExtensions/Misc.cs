using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixExtensions
{
    public static class Misc
    {
        public static string ToLog(this float[] arr, string arrName = default)
        {
            string log = "";

            if (!string.IsNullOrEmpty(arrName))
                log += arrName + "\n";

            if (arr == null)
                return "null\n";

            int m = arr.Length;   // n or m ?

            log += "-";
            for (int i = 0; i < 1; i++)
            {
                log += "----------------";
            }
            log += "\n";

            for (int j = 0; j < m; j++)
            {
                log += string.Format("|{0, 15}|\n", arr[j]);
            }

            log += "-";
            for (int i = 0; i < 1; i++)
            {
                log += "----------------";
            }

            return $"{log}\n";
        }
        public static string ToLog(this float[,] arr, string arrName = default)
        {
            string log = "";

            if (!string.IsNullOrEmpty(arrName))
                log += arrName + "\n";

            if (arr == null)
                return "null\n";

            int m = arr.GetLength(0);   // n or m ?
            int n = arr.GetLength(1);   // n or m ?

            log += "-";
            for (int i = 0; i < m; i++)
            {
                log += "----------------";
            }
            log += "\n";

            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < m; k++)
                {
                    log += string.Format("|{0, 15}", arr[k, j]);
                }
                log += "|\n";
            }

            log += "-";
            for (int i = 0; i < m; i++)
            {
                log += "----------------";
            }

            return $"{log}\n";
        }
        public static float[] GetCopy(this float[] arr)
        {
            float[] result = new float[arr.Length];
            arr.CopyTo(result, 0);
            return result;
        }
        public static float[,] GetCopy(this float[,] arr)
        {
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);
            var result = new float[a, b];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    result[i, j] = arr[i, j];
                }
            }
            return result;
        }
    }
}
