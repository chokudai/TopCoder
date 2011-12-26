using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PrimePairs {
    int len;
    bool[,] check;
    int[] co;
    public int[] matches(int[] numbers)
    {
        len = numbers.Length;
        check = new bool[len, len];
        co = new int[len];
        int i, j;
        for (i = 0; i < len; i++)
        {
            check[i, i] = false;
            for (j = i + 1; j < len; j++)
            {
                if (isPrime(numbers[i] + numbers[j]))
                {
                    check[i, j] = true;
                    check[j, i] = true;
                    co[j]++;
                    co[i]++;
                }
                else
                {
                    check[i, j] = false;
                    check[j, i] = false;
                }
            }
        }
        List<int> res = new List<int>();
        for (i = 1; i < len; i++)
        {
            if (check[0, i])
            {
                long start = 1 + ((long)1 << i);
                if (saiki(start)) res.Add(numbers[i]);
            }
        }
        int[] result = new int[res.Count];
        for (i = 0; i < res.Count; i++) result[i] = res[i];
        Array.Sort(result);
        return result;
    }

    bool saiki(long a)
    {
        int i, j;
        if (a == ((long)1 << len) - 1) return true;
        for (i = 1; i < len; i++)
        {
            if ((((long)1 << i) & a) != 0) continue;
            for (j = i + 1; j < len; j++)
            {
                if ((((long)1 << j) & a) != 0) continue;
                if (check[i, j])
                {
                    a += (long)1 << i;
                    a += (long)1 << j;
                    bool ch = saiki(a);
                    a -= (long)1 << i;
                    a -= (long)1 << j;
                    if (ch)
                    {
                        return true;
                    }
                }
            }
            break;
        }
        return false;
    }


    bool isPrime(int a)
    {
        int i;
        if (a <= 1) return false;
        //Console.WriteLine(a);
        for (i = 2; i*i <= a; i++)
        {
            if (a % i == 0) return false;
            
        }
        return true;
    }





}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
