using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheMoviesLevelTwoDivOne {

    double eps = 1e-7;

    public int[] find(int[] length, int[] scary)
    {
        int start = 74;
        int inc = 47;
        int res = 0;
        Queue<int> q = new Queue<int>();
        int resnum = 0;
        int[] pre = new int[1 << 20];
        bool[] b = new bool[1 << 20];
        b[0] = true;
        q.Enqueue(0);
        int i;
        int len = length.Length;
        while (q.Count != 0)
        {
            int now = q.Dequeue();
            bool fin = false;
            int point = 74;
            int count = 0;
            for (i = 0; i < len; i++)
            {
                if (((now >> i) & 1) == 0) continue;
                count++;
                point += 47;
                point -= length[i];
            }
            if (count > res)
            {
                res = count;
                resnum = now;
            }
            for (i = 0; i < len; i++)
            {
                if (((now >> i) & 1) == 1) continue;
                int next = now + (1 << i);
                if (b[next]) continue;
                if (point < scary[i]) continue;
                if (point + 47 < length[i]) continue;
                b[next] = true;
                q.Enqueue(next);
                pre[next] = now;
            }
        }
        int[] result = new int[len];
        int nowa = resnum;
        for (i = res - 1; i >= 0; i--)
        {
            int next = pre[nowa];
            int j;
            for (j = 0; j < len; j++)
            {
                if (next + (1 << j) == nowa) break;
            }
            result[i] = j;
            nowa = next;
        }
        i = res;
        for (int k = 0; k < len; k++)
        {
            if (((resnum >> k) & 1) == 0)
            {
                result[i++] = k;
            }
        }
        return result;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
