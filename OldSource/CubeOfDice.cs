using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CubeOfDice {
    public long minimumSum(int _N, int[] values)
    {
        long N = _N;
        int i;
        long res = long.MaxValue;
        long[] a;
        if (N == 1)
        {
            a = new long[] { 0, 1, 1, 1, 1, 1 };
            do
            {
                long sum = 0;
                for (i = 0; i < 6; i++)
                {
                    sum += a[i] * values[i];
                }
                res = Math.Min(res, sum);
            } while (Algorithm.next_permutation<long>(a));
            return res;
        }
        long result = 0;
        res = long.MaxValue;
        a = new long[] { 0, 0, 0, 0, 0, 1 };
        do
        {
            long sum = 0;
            for (i = 0; i < 3; i++)
            {
                if (a[i] * a[5 - i] == 1) break;
            }
            if (i != 3) continue;
            for (i = 0; i < 6; i++)
            {
                sum += a[i] * values[i];
            }
            res = Math.Min(res, sum);
        } while (Algorithm.next_permutation<long>(a));
        result += res * (N - 2) * (N - 1) * 4 + res * (N - 2) * (N - 2);
        a = new long[] { 0, 0, 0, 0, 1, 1 };
        res = long.MaxValue;
        do
        {
            long sum = 0;
            for (i = 0; i < 3; i++)
            {
                if (a[i] * a[5 - i] == 1) break;
            }
            if (i != 3) continue;
            for (i = 0; i < 6; i++)
            {
                sum += a[i] * values[i];
            }
            res = Math.Min(res, sum);
        } while (Algorithm.next_permutation<long>(a));
        result += res * (N - 1) * 4 + res * (N - 2) * 4;
        res = long.MaxValue;
        a = new long[] { 0, 0, 0, 1, 1, 1 };
        do
        {
            long sum = 0;
            for (i = 0; i < 3; i++)
            {
                if (a[i] * a[5 - i] == 1) break;
            }
            if (i != 3) continue;
            for (i = 0; i < 6; i++)
            {
                sum += a[i] * values[i];
            }
            res = Math.Min(res, sum);
        } while (Algorithm.next_permutation<long>(a));
        result += res * 4;
        return result;
    }




}

public static partial class Algorithm
{
    public static bool next_permutation<T>(T[] array) where T : IComparable
    {
        return next_permutation(array, 0, array.Length);
    }

    public static bool next_permutation<T>(T[] array, int start, int length) where T : IComparable
    {
        int end = start + length - 1;
        if (end <= start) return false;
        int last = end;
        while (true)
        {
            int pos = last--;
            if (array[last].CompareTo(array[pos]) < 0)
            {
                int i;
                for (i = end + 1; array[last].CompareTo(array[--i]) >= 0; ) { }
                T tmp = array[last]; array[last] = array[i]; array[i] = tmp;
                Array.Reverse(array, pos, end - pos + 1);
                return true;
            }
            if (last == start)
            {
                //Array.Reverse(array, start, end - start);
                return false;
            }
        }
    }
}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
