using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SaveTheTrees {
    public int minimumCut(int[] x, int[] y, int[] h)
    {
        int i, j,k,l,m;
        int len = x.Length;
        int mintree = len;
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                if (x[i] > x[j]) continue;
                for (k = 0; k < len; k++)
                {
                    for (l = 0; l < len; l++)
                    {
                        if (y[k] > y[l]) continue;
                        int mx = x[i];
                        int my = y[k];
                        int lx = x[j];
                        int ly = y[l];
                        int nowtree = 0;
                        int nowh = 0;
                        List<int> hlist = new List<int>();
                        for (m = 0; m < len; m++)
                        {
                            if (!ok(x[m], y[m], mx, my, lx, ly))
                            {
                                nowh += h[m];
                                nowtree++;
                            }
                            else
                            {
                                hlist.Add(h[m]);
                            }
                        }
                        if (mx == 1 && my == 1 && lx == 9 && ly == 9) Console.Write(nowtree);
                        if (mintree <= nowtree) continue;
                        int[] a = new int[hlist.Count];
                        m = 0;
                        foreach (int ii in hlist) { a[m] = ii; m++; }
                        Array.Sort(a);
                        Array.Reverse(a);
                        m = 0;
                        while (nowh < ((lx - mx) + (ly - my)) * 2)
                        {
                            nowtree++;
                            if (mintree <= nowtree) break;
                            nowh += a[m];
                            m++;
                        }
                        if (mintree <= nowtree) continue;
                        mintree = nowtree;
                        //Console.Write(nowh);
                    }
                }
            }
        }

        return mintree;
    }

    bool ok(int x, int y, int mx, int my, int lx, int ly)
    {
        if (x < mx || y < my || x > lx || y > ly) return false;
        return true;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
