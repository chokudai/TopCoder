using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheJackpotDivOne {
    public long[] find(long[] money, long jackpot)
    {
        int i;
        long sum = 0;
        int len = money.Length;
        Array.Sort(money);
        foreach (long a in money) sum += a;
        while (jackpot != 0)
        {
            long nextmoney = 0;
            long nextamari = 0;
            for (i = 0; i < len; i++)
            {
                nextamari += money[i];
                nextmoney += nextamari / len;
                nextamari %= len;
            }
            nextmoney++;
            long ad = Math.Min(nextmoney - money[0], jackpot);
            money[0] += ad;
            jackpot -= ad;
            sum += ad;
            Array.Sort(money);
            if (money[len - 1] - money[0] <= 1) break;
        }
        Array.Sort(money);
        long add = jackpot / len;
        for (i = 0; i < len; i++) money[i] += add;
        jackpot -= add * len;
        for (i = 0; i < jackpot; i++) money[i]++;
        Array.Sort(money);
        return money;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
