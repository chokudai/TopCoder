using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheAirTripDivOne {
    V[] vs;
    public int find(int n, string[] flights, int time)
    {
        string s = "";
        foreach (string ss in flights) s += ss;
        string[] st = s.Split(' ');
        int len = st.Length;
        vs = new V[n];
        int i;
        for (i = 0; i < n; i++) vs[i] = new V();
        for (i = 0; i < len; i++)
        {
            string[] ss = st[i].Split(',');
            long A = long.Parse(ss[0]) - 1;
            long B = long.Parse(ss[1]) - 1;
            long F = long.Parse(ss[2]);
            long T = long.Parse(ss[3]);
            long P = long.Parse(ss[4]);
            vs[A].Blist.Add(B);
            vs[A].Flist.Add(F);
            vs[A].Tlist.Add(T);
            vs[A].Plist.Add(P);
        }

        for (i = 0; i < n; i++) vs[i].init();

        if (!check(1, time)) return -1;

        long min = 1;
        long max = time + 1;
        while (min + 1 != max)
        {
            long mid = (min + max) / 2;
            if (check(mid, time))
            {
                min = mid;
            }
            else
            {
                max = mid;
            }
        }
        return (int)min;
    }

    bool check(long limit, long time){
        int n = vs.Length;
        long[] t = new long[n];
        int i;
        for (i = 0; i < n; i++) t[i] = time + 1;
        Queue<int> q = new Queue<int>();
        t[0] = -limit;
        bool[] checking = new bool[n];
        q.Enqueue(0);
        while (q.Count != 0)
        {
            int a = q.Dequeue();
            checking[a] = false;
            for (i = 0; i < vs[a].T.Length; i++)
            {
                int next = (int)vs[a].B[i];
                long nexttime = gettime(t[a], limit, vs[a].F[i], vs[a].T[i], vs[a].P[i]);
                if (nexttime < t[next])
                {
                    t[next] = nexttime;
                    if (next == n - 1) return true;
                    if (!checking[next])
                    {
                        checking[next] = true;
                        q.Enqueue(next);
                    }
                }
            }
        }
        return false;
    }

    class V
    {
        public V() {
            Blist = new List<long>();
            Flist = new List<long>();
            Tlist = new List<long>();
            Plist = new List<long>();
        }

        public List<long> Blist;
        public List<long> Flist;
        public List<long> Tlist;
        public List<long> Plist;

        public long[] B;
        public long[] F;
        public long[] T;
        public long[] P;

        public void init()
        {
            B = Blist.ToArray();
            F = Flist.ToArray();
            T = Tlist.ToArray();
            P = Plist.ToArray();
        }
    }

    long gettime(long now, long limit, long F, long T, long P)
    {
        long start = now + limit;
        if (start <= F) start = F;
        else
        {
            long nokori = start - F;
            if (nokori % P != 0)
            {
                start += P - nokori % P;
            }
        }
        return start + T;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
