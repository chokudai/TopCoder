using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FibonacciKnapsack {

    class P : IComparable
    {
        public long w;
        public long p;
        public P(long _w, long _p)
        {
            w = _w;
            p = _p;
        }

        public int CompareTo(object obj)
        {
            if (w != ((P)obj).w) return (int)((w - ((P)obj).w) / Math.Abs(w - ((P)obj).w));
            else
            {
                if ((p - ((P)obj).p) == 0) return 0;
                return -(int)((p - ((P)obj).p) / Math.Abs(p - ((P)obj).p));
            }
        }

        public string show()
        {
            return w + " " + p;
        }
    }


    class E:IComparable
    {
        public long w;
        public long p;
        public E(long _w, long _p)
        {
            w = _w;
            p = _p;
        }

        public int CompareTo(object obj)
        {
            if (w != ((E)obj).w) return -(int)((w - ((E)obj).w) / Math.Abs(w - ((E)obj).w));
            else
            {
                if ((p - ((E)obj).p) == 0) return 0;
                return -(int)((p - ((E)obj).p) / Math.Abs(p - ((E)obj).p));
            }
        }

        public string show()
        {
            return w + " " + p;
        }
    }


    public long maximalCost(string[] items, string C)
    {
        long c = long.Parse(C);
        int i, j;
        int len = items.Length;
        E[] es = new E[len]; 
        for (i = 0; i < len; i++)
        {
            string[] s = items[i].Split(' ');
            es[i] = new E(long.Parse(s[0]), long.Parse(s[1]));
        }
        Array.Sort(es);
        long res = 0;

        P[] ps = new P[1];
        ps[0] = new P(0, 0);

        long nokoriw = 0;
        long nokorip = 0;
        for (i = 0; i < len; i++) nokoriw += es[i].w;
        for (i = 0; i < len; i++) nokorip += es[i].p;

        for (i = 0; i < len; i++)
        {
            //Console.WriteLine(ps.Length);
            List<P> pl = new List<P>();
            nokoriw -= es[i].w;
            nokorip -= es[i].p;

            for (j = 0; j < ps.Length; j++)
            {
                pl.Add(ps[j]);
                if (ps[j].w + es[i].w <= c)
                {
                    pl.Add(new P(ps[j].w + es[i].w, ps[j].p + es[i].p));
                }
            }
            pl.Sort();
            long max = -1;
            List<P> pl2 = new List<P>();
            foreach (P p in pl)
            {
                if (max < p.p)
                {
                    max = p.p;
                    if (p.w + nokoriw <= c)
                    {
                        res = Math.Max(res, p.p + nokorip);
                    }
                    else
                    {
                        res = Math.Max(res, p.p);
                        pl2.Add(p);
                    }
                }
            }
            ps = pl2.ToArray();
        }


        return res;
    }

    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"5 555", "8 195", "13 651"}; string Arg1 = "15"; long Arg2 = 750l; verify_case(0, Arg2, maximalCost(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"5 555", "8 195", "13 751"}; string Arg1 = "15"; long Arg2 = 751l; verify_case(1, Arg2, maximalCost(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"55 1562", "5 814", "55 1962", "8 996", "2 716", "34 1792"}; string Arg1 = "94"; long Arg2 = 4568l; verify_case(2, Arg2, maximalCost(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"13 89"}; string Arg1 = "1"; long Arg2 = 0l; verify_case(3, Arg2, maximalCost(Arg0, Arg1)); }
    private void test_case_4()
    {
        string[] Arg0 = new string[] { "1 1", "2 2", "3 3", "5 5", "8 8", "13 13", "21 20", "34 37", "55 56", "89 84", "144 133", "233 228", "377 393", "610 587", "987 1031", "1597 1579", "2584 2812", "4181 4321", "6765 6480", "10946 10053", "17711 19231", "28657 30976", "46368 43296", "75025 74145", "121393 117082", "196418 202129", "317811 349478", "514229 550698", "832040 800191", "1346269 1290891", "2178309 2107281", "3524578 3667874", "5702887 5241212", "9227465 9694388", "14930352 15448878", "24157817 23173825", "39088169 40271360", "63245986 60486470", "102334155 105820454", "165580141 166547785", "267914296 241952193", "433494437 472718930", "701408733 718384717", "1134903170 1044216097", "1836311903 1689914494", "2971215073 2863714071", "4807526976 4778873392", "7778742049 7186307248", "12586269025 12397382373", "20365011074 18466752436" }; string Arg1 = "26658145585"; long Arg2 = 15160907110354694l; verify_case(4, Arg2, maximalCost(Arg0, Arg1));
    }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        FibonacciKnapsack ___test = new FibonacciKnapsack();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
