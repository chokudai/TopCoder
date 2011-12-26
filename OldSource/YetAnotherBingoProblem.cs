using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class YetAnotherBingoProblem {

    class P : IComparable
    {
        public long x, y;
        public P(long _x, long _y)
        {
            x = _x;
            y = _y;
        }

        public int CompareTo(object obj)
        {
            P temp = (P)obj;
            if (x < temp.x) return -1;
            if (x > temp.x) return 1;
            if (y < temp.y) return -1;
            if (y > temp.y) return 1;
            return 0;
        }
    }

    public int longestWinningSequence(string[] cards1, string[] cards2)
    {
        int[][] c1;
        int[][] c2;
        string s;
        string[] st;
        int i, j;
        s = "";
        foreach (string ss in cards1) s += ss;
        st = s.Split(',');
        c1 = new int[st.Length][];
        for (i = 0; i < st.Length; i++)
        {
            string[] sst = st[i].Split(' ');
            c1[i] = new int[25];
            for (j = 0; j < 25; j++)
            {
                c1[i][j] = int.Parse(sst[j]);
            }
        }

        s = "";
        foreach (string ss in cards2) s += ss;
        st = s.Split(',');
        c2 = new int[st.Length][];
        for (i = 0; i < st.Length; i++)
        {
            string[] sst = st[i].Split(' ');
            c2[i] = new int[25];
            for (j = 0; j < 25; j++)
            {
                c2[i][j] = int.Parse(sst[j]);
            }
        }


        int len1 = c1.Length;
        int len2 = c2.Length;

        long[] in1 = new long[75];
        long[] in2 = new long[75];

        for (i = 0; i < len1; i++)
        {
            for (j = 0; j < 25; j++)
            {
                in1[c1[i][j] - 1] |= ((long)1 << i);
            }
        }


        for (i = 0; i < len2; i++)
        {
            for (j = 0; j < 25; j++)
            {
                in2[c2[i][j] - 1] |= ((long)1 << i);
            }
        }

        long win = (1 << len1) - 1;
        long lose = (1 << len2) - 1;

        int res = -1;
        Dictionary<Decimal, int> dic = new Dictionary<Decimal, int>();
        List<Decimal> l = new List<Decimal>();
        l.Add(0);
        dic[0] = 0;
        Decimal mul = ((long)1 << len1);
        for (i = 0; i < 75; i++)
        {
            List<Decimal> nl = new List<Decimal>();
            foreach (Decimal p in l)
            {
                long a = (long)(p % mul);
                long b = (long)(p / mul);
                long pa = a;
                long pb = b;
                a |= in1[i];
                b |= in2[i];
                Decimal np = a;
                np += (decimal)b * mul;
                if (dic.ContainsKey(np))
                {
                    dic[np] = Math.Min(dic[np], dic[p] + 1);
                }
                else
                {
                    nl.Add(np);
                    dic[np] = dic[p] + 1;
                }
            }
            foreach (Decimal p in nl) l.Add(p);
        }
        for (i = 0; i < 75; i++)
        {
            List<Decimal> nl = new List<Decimal>();
            foreach (Decimal p in l)
            {
                long a = (long)(p % mul);
                long b = (long)(p / mul);
                long pa = a;
                long pb = b;
                a |= in1[i];
                b |= in2[i];
                Decimal np = a;
                np += (decimal)b * mul;
                if (a == win && pa != win && pb == lose)
                {
                    res = Math.Max(res, 75 - dic[p]);
                }
            }
            foreach (Decimal p in nl) l.Add(p);
        }
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
