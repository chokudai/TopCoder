using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SetMultiples {

    class P
    {
        public long a, b;

        public P(long _a, long _b)
        {
            a = _a;
            b = _b;
        }

        public List<P> sub(long suba, long subb)
        {
            List<P> res = new List<P>();
            if (suba <= a && subb >= b) return res;
            if (suba >= a)
            {
                if (suba > b)
                {
                    res.Add(new P(a, b));
                    return res;
                }
                else
                {
                    P temp1 = new P(a, suba - 1);
                    if (temp1.ok()) res.Add(temp1);
                    P temp2 = new P(subb + 1, b);
                    if (temp2.ok()) res.Add(temp2);
                    return res;
                }
            }
            else
            {
                if (a > subb)
                {
                    res.Add(new P(a, b));
                    return res;
                }
                else
                {
                    P temp1 = new P(subb + 1, b);
                    if (temp1.ok()) res.Add(temp1);
                    return res;
                }
            }
        }

        public bool ok()
        {
            return b >= a;
        }
    }
    
    public long smallestSubset(long A, long B, long C, long D)
    {
        int i;
        long count = 0;
        for (i = 2; i <= 10000000; i++)
        {
            if ((A <= i && i <= B) || (C <= i && i <= D))
            {
                if (A <= i) A = i + 1;
                if (C <= i) C = i + 1;
                if ((A / i >= B / i) && (A % i != 0) && (C / i >= D / i) && (C % i != 0)) count++;
            }
            if (A <= i) A = i + 1;
            if (C <= i) C = i + 1;
        }
        List<P> l = new List<P>();
        if (A <= B) l.Add(new P(A, B));
        if (C <= D) l.Add(new P(C, D));

        for (i = 2; i <= 1002; i++)
        {
            long minA = (A + i - 1) / i;
            long minB = B / i;
            long minC = (C + i - 1) / i;
            long minD = D / i;
            List<P> nl = new List<P>();
            foreach (P p in l)
            {
                List<P> nnl = p.sub(minA, minB);
                foreach (P pp in nnl) nl.Add(pp);
            }
            l.Clear();
            foreach (P p in nl) l.Add(p);
            nl.Clear();

            nl = new List<P>();

            foreach (P p in l)
            {
                List<P> nnl = p.sub(minC, minD);
                foreach (P pp in nnl) nl.Add(pp);
            }
            l.Clear();
            foreach (P p in nl) l.Add(p);
            nl.Clear();
        }

        foreach (P p in l)
        {
            //Console.WriteLine(p.a + " " + p.b);
            count += Math.Max(0, p.b - p.a + 1);
        }


        return count;
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
	private void test_case_0() { long Arg0 = 1l; long Arg1 = 1l; long Arg2 = 2l; long Arg3 = 2l; long Arg4 = 1l; verify_case(0, Arg4, smallestSubset(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { long Arg0 = 1l; long Arg1 = 2l; long Arg2 = 3l; long Arg3 = 4l; long Arg4 = 2l; verify_case(1, Arg4, smallestSubset(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { long Arg0 = 2l; long Arg1 = 3l; long Arg2 = 5l; long Arg3 = 7l; long Arg4 = 3l; verify_case(2, Arg4, smallestSubset(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { long Arg0 = 1l; long Arg1 = 10l; long Arg2 = 100l; long Arg3 = 1000l; long Arg4 = 500l; verify_case(3, Arg4, smallestSubset(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_4() { long Arg0 = 1000000000l; long Arg1 = 2000000000l; long Arg2 = 9000000000l; long Arg3 = 10000000000l; long Arg4 = 1254365078l; verify_case(4, Arg4, smallestSubset(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SetMultiples ___test = new SetMultiples();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
