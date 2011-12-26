using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ColorfulStrings {
    public string getKth(int n, int K)
    {
        long i;
        if (n == 1)
        {
            if (K > 10) return "";
            else return (K - 1).ToString();
        }
        if (n >= 9) return "";
        long start = 1;
        for (i = 1; i < n; i++) start *= 10;
        long goal = start * 10;
        long j,k;
        int count = 0;
        for (i = start; i < goal;)
        {
            Dictionary<long, bool> dic = new Dictionary<long, bool>();
            dic[0] = dic[1] = true;
            for (j = start; j > 0; j /= 10)
            {
                long now = 1;
                for (k = j; k < goal; k *= 10)
                {
                    long next = (i / k) % 10;
                    now *= next;
                    if (dic.ContainsKey(now)) break;
                    dic[now] = true;
                }
                if (k != goal) break;
            }
            if (j != 0)
            {
                i -= i % j;
                i += j;
            }
            else
            {
                count++;
                if (count == K) return i.ToString();
                i++;
            }
        }
        return "";
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
