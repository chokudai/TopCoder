using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class UnluckyIntervals {
    public int[] getLuckiest(int[] luckySet, int n)
    {
        Array.Sort(luckySet);
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int[] result = new int[n + 1];
        int[] low = new int[n + 1];
        int[] mid = new int[n + 1];
        int[] hi = new int[n + 1];
        int i, j;
        int himax = luckySet[luckySet.Length - 1] + 1;
        for (i = 0; i < Math.Min(luckySet.Length, n); i++) result[i+1] = luckySet[i];
        for (i = 2; i < Math.Min(luckySet.Length+1, n+1); i++) low[i] = luckySet[i - 2];
        for (i = 1; i < Math.Min(luckySet.Length+1, n+1); i++) mid[i] = luckySet[i - 1];
        for (i = 0; i < Math.Min(luckySet.Length, n); i++) hi[i] = luckySet[i];
        result[0] = 0;
        for (i = 0; i < Math.Min(luckySet.Length+1, n+1); i++) dic[result[i]] = 0;
        dic[0] = 0;
        dic[-1] = 0;
        for (; i < n + 1; i++)
        {
            int bestnum = -1;
            long bestlucky = long.MaxValue;
            long bestlow=0;
            long besthi=0;
            for (j = 0; j < i; j++)
            {
                int check = result[j] - 1;
                if (!dic.ContainsKey(check) && check > 0)
                {
                    long nowlow = low[j];
                    long nowhi = hi[j];
                    if (mid[j] != -1) nowhi = mid[j];
                    long nowlucky = (nowhi - check) * (check - nowlow) - 1;
                    if (nowlucky < bestlucky || (nowlucky == bestlucky && bestnum > check))
                    {
                        bestnum = check;
                        bestlucky = nowlucky;
                        bestlow = nowlow;
                        besthi = nowhi;
                    }
                }
                check = result[j] + 1;
                if (!dic.ContainsKey(check) && check < luckySet[luckySet.Length - 1])
                {
                    long nowlow = low[j];
                    long nowhi = hi[j];
                    if (mid[j] != -1) nowlow = mid[j];
                    long nowlucky = (nowhi - check) * (check - nowlow) - 1;
                    if (nowlucky < bestlucky || (nowlucky == bestlucky && bestnum > check))
                    {
                        bestnum = check;
                        bestlucky = nowlucky;
                        bestlow = nowlow;
                        besthi = nowhi;
                    }
                }
            }
            if (bestnum == -1) { bestnum = himax; himax++; }
            dic[bestnum] = 1;
            result[i] = bestnum;
            low[i] = (int)bestlow;
            hi[i] = (int)besthi;
            mid[i] = -1;
            //Console.WriteLine("num:{0} lucky:{1} low:{2} hi:{3}", bestnum, bestlucky, bestlow, besthi);
        }
        int[] res = new int[n];
        for (i = 0; i < n; i++) res[i] = result[i + 1];
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
