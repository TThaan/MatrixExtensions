using System;
using System.Collections;

namespace MatrixExtensionsTest
{
    internal class ArrayComparer
    {
        public static bool AreEqual(object x, object y)
        {
            Array xArr = x as Array;
            Array yArr = y as Array;

            if (xArr.Rank != yArr.Rank)
                return false;

            for (int r = 0; r < xArr.Rank; r++)
            {
                if (xArr.GetLength(r) != yArr.GetLength(r))
                    return false;

                int rankSize = xArr.GetUpperBound(r);
                //for (int i = 0; i < rankSize; i++)
                //{
                //    if (xArr.GetValue(i) != yArr.GetValue(i))
                //        return false;
                //}
            }

            var xFlat = new ArrayList();
            var yFlat = new ArrayList();
            
            foreach (var item in xArr)
                xFlat.Add(item);
            foreach (var item in yArr)
                yFlat.Add(item);

            return true;
        }
    }
}
