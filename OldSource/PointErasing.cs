using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PointErasing {

    Random r;
    long[,] memo;
    public int[] getOutcomes(int[] y)
    {
        r = new Random();
        DateTime dt = DateTime.Now;
        List<int> retl = new List<int>();
        int len = y.Length;
        bool[] resmemo = new bool[len + 1];
        memo = new long[len, len];
        List<int> lnumbox = new List<int>();

        int i, j, k;
        for (i = 0; i < len; i++)
        {
            for (j = i + 1; j < len; j++)
            {
                long now = 0;
                for (k = i + 1; k < j; k++)
                {
                    if ((long)(y[i] - y[k]) * (long)(y[j] - y[k]) < 0)
                    {
                        now |= (long)1 << k;
                    }
                }
                memo[i, j] = now;
                if (now != 0)
                {
                    lnumbox.Add((i << 8) + j);
                }
            }
        }
        int[] numbox = lnumbox.ToArray();

        int[] ary = new int[len];
        for (i = 0; i < len; i++) ary[i] = i;
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len - 1; j++)
            {
                if (y[ary[j]] > y[ary[j + 1]])
                {
                    int temp = ary[j];
                    ary[j] = ary[j + 1];
                    ary[j + 1] = temp;
                }
            }
        }

        //sorted
        do
        {
            int count = 0;
            long now = ((long)1 << len) - 1;
            for (i = 0; i < len; i++)
            {
                for (j = i + 1; j < len; j++)
                {
                    int A = i;
                    int B = j;
                    if (((now >> A) & (now >> B) & 1) == 1)
                    {
                        now &= ~memo[A, B];
                    }
                }
            }
            for (i = 0; i < len; i++)
            {
                if ((now >> i) % 2 == 1) count++;
            }
            if (!resmemo[count])
            {
                resmemo[count] = true;
                retl.Add(count);
            }
        } while (false);

        do
        {
            int count = 0;
            long now = ((long)1 << len) - 1;
            for (j = 1; j < len; j++)
            {
                for (i = 0; i < j; i++)
                {
                    int A = i;
                    int B = j;
                    if (((now >> A) & (now >> B) & 1) == 1)
                    {
                        now &= ~memo[A, B];
                    }
                }
            }
            for (i = 0; i < len; i++)
            {
                if ((now >> i) % 2 == 1) count++;
            }
            if (!resmemo[count])
            {
                resmemo[count] = true;
                retl.Add(count);
            }
        } while (false);

        do
        {
            int count = 0;
            long now = ((long)1 << len) - 1;
            for (i = 0; i < len; i++)
            {
                for (j = i + 1; j < len; j++)
                {
                    int A = Math.Min(ary[i], ary[j]);
                    int B = Math.Max(ary[i], ary[j]);
                    if (((now >> A) & (now >> B) & 1) == 1)
                    {
                        now &= ~memo[A, B];
                    }
                }
            }
            for (i = 0; i < len; i++)
            {
                if ((now >> i) % 2 == 1) count++;
            }
            if (!resmemo[count])
            {
                resmemo[count] = true;
                retl.Add(count);
            }
        } while (false);

        do
        {
            int count = 0;
            long now = ((long)1 << len) - 1;
            for (j = 1; j < len; j++)
            {
                for (i = 0; i < j; i++)
                {
                    int A = Math.Min(ary[i], ary[j]);
                    int B = Math.Max(ary[i], ary[j]);
                    if (((now >> A) & (now >> B) & 1) == 1)
                    {
                        now &= ~memo[A, B];
                    }
                }
            }
            for (i = 0; i < len; i++)
            {
                if ((now >> i) % 2 == 1) count++;
            }
            if (!resmemo[count])
            {
                resmemo[count] = true;
                retl.Add(count);
            }
        } while (false);


        //rev
        do
        {
            int count = 0;
            long now = ((long)1 << len) - 1;
            for (i = len - 1; i >= 0; i--)
            {
                for (j = len - 1; j > i; j--)
                {
                    int A = i;
                    int B = j;
                    if (((now >> A) & (now >> B) & 1) == 1)
                    {
                        now &= ~memo[A, B];
                    }
                }
            }
            for (i = 0; i < len; i++)
            {
                if ((now >> i) % 2 == 1) count++;
            }
            if (!resmemo[count])
            {
                resmemo[count] = true;
                retl.Add(count);
            }
        } while (false);

        do
        {
            int count = 0;
            long now = ((long)1 << len) - 1;
            for (j = len; j >= 1; j--)
            {
                for (i = j-1; i >= 0; i--)
                {
                    int A = i;
                    int B = j;
                    if (((now >> A) & (now >> B) & 1) == 1)
                    {
                        now &= ~memo[A, B];
                    }
                }
            }
            for (i = 0; i < len; i++)
            {
                if ((now >> i) % 2 == 1) count++;
            }
            if (!resmemo[count])
            {
                resmemo[count] = true;
                retl.Add(count);
            }
        } while (false);

        do
        {
            int count = 0;
            long now = ((long)1 << len) - 1;
            for (i = len- 1; i >= 0; i--)
            {
                for (j = len - 1; j >= i+1; j--)
                {
                    int A = Math.Min(ary[i], ary[j]);
                    int B = Math.Max(ary[i], ary[j]);
                    if (((now >> A) & (now >> B) & 1) == 1)
                    {
                        now &= ~memo[A, B];
                    }
                }
            }
            for (i = 0; i < len; i++)
            {
                if ((now >> i) % 2 == 1) count++;
            }
            if (!resmemo[count])
            {
                resmemo[count] = true;
                retl.Add(count);
            }
        } while (false);

        do
        {
            int count = 0;
            long now = ((long)1 << len) - 1;
            for (j = len - 1; j >= 1; j--)
            {
                for (i = j-1; i >= 0; i--)
                {
                    int A = Math.Min(ary[i], ary[j]);
                    int B = Math.Max(ary[i], ary[j]);
                    if (((now >> A) & (now >> B) & 1) == 1)
                    {
                        now &= ~memo[A, B];
                    }
                }
            }
            for (i = 0; i < len; i++)
            {
                if ((now >> i) % 2 == 1) count++;
            }
            if (!resmemo[count])
            {
                resmemo[count] = true;
                retl.Add(count);
            }
        } while (false);


        


        //Main
        Console.WriteLine("num:{0}", numbox.Length);

        while ((DateTime.Now - dt).TotalMilliseconds < 1800)
        {
            int count = 0;
            long now = ((long)1 << len) - 1;
            for (i = 0; i < numbox.Length; i++)
            {
                int A = numbox[i] >> 8;
                int B = numbox[i] & 0xFF;
                if (((now >> A) & (now >> B) & 1) == 1)
                {
                    now &= ~memo[A, B];
                }
            }
            for (i = 0; i < len; i++)
            {
                if ((now >> i) % 2 == 1) count++;
            }
            if (!resmemo[count])
            {
                resmemo[count] = true;
                retl.Add(count);
                Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
            }
            shuffle(numbox);
        }

        int[] ret = retl.ToArray();
        Array.Sort(ret);
        return ret;
    }

    void shuffle(int[] a)
    {
        int i;
        for (i = 0; i < a.Length - 1; i++)
        {
            int next = i + r.Next(a.Length - i);
            if (next != i)
            {
                int temp = a[i];
                a[i] = a[next];
                a[next] = temp;
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
