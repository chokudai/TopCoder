using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class LongestSequence {
    public int maxLength(int[] C)
    {
        DateTime dt = DateTime.Now;
        TimeSpan ts;
        List<int> lneg = new List<int>();
        List<int> lpos = new List<int>();
        int i;
        foreach (int a in C)
        {
            if (a < 0)
            {
                lneg.Add(-a);
            }
            else lpos.Add(a);
        }
        int[] neg = lneg.ToArray();
        int[] pos = lpos.ToArray();
        Array.Sort(neg);
        Array.Sort(pos);

        if (neg.Length == 0) return -1;
        if (pos.Length == 0) return -1;


        int ret = 1;
        data = new double[datasize * 3];
        datb = new double[datasize * 3];

        while ((ts = DateTime.Now - dt).TotalMilliseconds < 1900)
        {
            bool flag = true;
            foreach (int a in neg)
            {
                for (i = 0; i <= ret - a; i++)
                {
                    double s = sum(i, i + a, 0, 0, datasize);
                    if (s > -1e-9)
                    {
                        double need = (s + 5) / a;
                        add(i, i + a, -need, 0, 0, datasize);
                        flag = false;
                        break;
                    }
                }
                if (!flag) break;
            }
            bool flag2 = true;
            foreach (int a in pos)
            {
                for (i = 0; i <= ret - a; i++)
                {
                    double s = sum(i, i + a, 0, 0, datasize);
                    if (s < 1e-9)
                    {
                        double need = (-s + 5) / a;
                        add(i, i + a, need, 0, 0, datasize);
                        flag = false;
                        flag2 = false;
                        break;
                    }
                }
                if (!flag2) break;
            }
            if (flag)
            {
                Console.WriteLine("ok:{0} {1}", ret, ts.TotalMilliseconds);
                ret++;
            }
        }
        return ret - 1;
    }

    const int datasize = 1 << 11;
    double[] data;
    double[] datb;
    
    double sum(int a, int b, int k, int l, int r)
    {
        if (b <= l || r <= a) return 0;
        else if (a <= l && r <= b) return data[k] * (r - l) + datb[k];
        else
        {
            double res = (Math.Min(b, r) - Math.Max(a, l)) * data[k];
            res += sum(a, b, k * 2 + 1, l, (l + r) / 2);
            res += sum(a, b, k * 2 + 2, (l + r) / 2, r);
            return res;
        }
    }

    void add(int a, int b, double x, int k, int l, int r)
    {
        if (a <= l && r <= b) data[k] += x;
        else if (l < b && a < r)
        {
            datb[k] += (Math.Min(b, r) - Math.Max(a, l)) * x;
            add(a, b, x, k * 2 + 1, l, (l + r) / 2);
            add(a, b, x, k * 2 + 2, (l + r) / 2, r);
        }
    }





// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{-2,3}; int Arg1 = 3; verify_case(0, Arg1, maxLength(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{524}; int Arg1 = -1; verify_case(1, Arg1, maxLength(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{1, -1}; int Arg1 = 0; verify_case(2, Arg1, maxLength(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{11,-7}; int Arg1 = 16; verify_case(3, Arg1, maxLength(Arg0)); }
	private void test_case_4() { int[] Arg0 = new int[]{-227,690,590,-524}; int Arg1 = 713; verify_case(4, Arg1, maxLength(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        LongestSequence ___test = new LongestSequence();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
