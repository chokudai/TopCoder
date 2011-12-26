using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RightTriangle {
    public long triangleCount(int places, int points, int a, int b, int c)
    {
        if (places % 2 == 1) return 0;
        uni = new int[places];
        List<int> pl = new List<int>();
        int i;
        for (i = 0; i < places; i++) uni[i] = -1;
        for (i = 0; i < points; i++)
        {
            int next = (int)(((long)a * i * i + (long)b * i + c) % places);
            next = getuni(next);
            pl.Add(next);
            if(i != points - 1) connect(next, (next + 1) % places);
        }
        int len = pl.Count;
        int[] p = pl.ToArray();
        Array.Sort(p);
        int j = 0;
        long ret = 0;
        for (i = 0; i < len; i++)
        {
            for (; j < len && p[j] < p[i] + places / 2; j++) ;
            if (j >= len) break;
            if (p[i] + places / 2 == p[j]) ret += (len - 2);
        }
        return ret;
    }

    int[] uni;
    int getuni(int a)
    {
        if (uni[a] == -1) return a;
        return uni[a] = getuni(uni[a]);
    }

    void connect(int a, int b)
    {
        a = getuni(a);
        b = getuni(b);
        uni[a] = b;
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
	private void test_case_0() { int Arg0 = 9; int Arg1 = 3; int Arg2 = 0; int Arg3 = 3; int Arg4 = 0; long Arg5 = 0l; verify_case(0, Arg5, triangleCount(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_1() { int Arg0 = 40; int Arg1 = 3; int Arg2 = 5; int Arg3 = 0; int Arg4 = 0; long Arg5 = 1l; verify_case(1, Arg5, triangleCount(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_2() { int Arg0 = 4; int Arg1 = 4; int Arg2 = 16; int Arg3 = 24; int Arg4 = 17; long Arg5 = 4l; verify_case(2, Arg5, triangleCount(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_3() { int Arg0 = 1000000; int Arg1 = 47000; int Arg2 = 0; int Arg3 = 2; int Arg4 = 5; long Arg5 = 0l; verify_case(3, Arg5, triangleCount(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_4() { int Arg0 = 200000; int Arg1 = 700; int Arg2 = 123456; int Arg3 = 789012; int Arg4 = 345678; long Arg5 = 6980l; verify_case(4, Arg5, triangleCount(Arg0, Arg1, Arg2, Arg3, Arg4)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        RightTriangle ___test = new RightTriangle();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
