using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class LotteryCheating {

    bool[] isprime = new bool[100006];
    void sieve_of_atkin()
    {
        int n;
        long N = 100005;
        long sqrtN = (long)(Math.Sqrt(N) + 1);
        for (int z = 1; z <= 5; z += 4)
        {
            for (int y = z; y <= sqrtN; y += 6)
            {
                for (int x = 1; x <= sqrtN && (n = 4 * x * x + y * y) <= N; ++x)
                    isprime[n] = !isprime[n];
                for (int x = y + 1; x <= sqrtN && (n = 3 * x * x - y * y) <= N; x += 2)
                    isprime[n] = !isprime[n];
            }
        }
        for (int z = 2; z <= 4; z += 2)
        {
            for (int y = z; y <= sqrtN; y += 6)
            {
                for (int x = 1; x <= sqrtN && (n = 3 * x * x + y * y) <= N; x += 2)
                    isprime[n] = !isprime[n];
                for (int x = y + 1; x <= sqrtN && (n = 3 * x * x - y * y) <= N; x += 2)
                    isprime[n] = !isprime[n];
            }
        }
        for (int y = 3; y <= sqrtN; y += 6)
        {
            for (int z = 1; z <= 2; ++z)
            {
                for (int x = z; x <= sqrtN && (n = 4 * x * x + y * y) <= N; x += 3)
                    isprime[n] = !isprime[n];
            }
        }
        for (n = 5; n <= sqrtN; ++n)
            if (isprime[n])
                for (int k = n * n; k <= N; k += n * n)
                    isprime[k] = false;
        isprime[2] = isprime[3] = true;
    }

    List<long> primelist;
    int len;
    public int minimalChange(string ID)
    {
        long i;
        len = ID.Length;
        primelist = new List<long>();
        sieve_of_atkin();
        for (i = 2; i * i < 10000000000; i++)
        {
            if (isprime[i]) primelist.Add(i * i);
        }
        for (i = 0; i < len; i++)
        {
            if (checksaiki(long.Parse(ID), (int)i, len)) return (int)i;
        }
        return len;
    }

    bool checksaiki(long now, int nokori, int prev)
    {
        if (nokori > prev) return false;
        if (nokori == 0) return check(now);
        int i,j;
        long pos = 1;
        for (i = 0; i < prev; i++)
        {
            long pre = now - ((now / pos) % 10) * pos;
            for (j = 0; j < 10; j++) if (checksaiki(pre + j * pos, nokori - 1, i)) return true;
            pos *= 10;
        }
        return false;
    }

    bool check(long a)
    {
        if (a == 0) return true;
        foreach (long b in primelist)
        {
            while (a % b == 0) a /= b;
            if (a < b) break;
        }
        if (a == 1) return true;
        else return false;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
