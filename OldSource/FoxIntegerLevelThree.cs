using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FoxIntegerLevelThree {

    long MOD = 1;
    public long count(long min, long max)
    {
        int i;
        MOD = 1;
        for (i = 1; i <= 9; i++) MOD *= 9 *i /gcd(MOD, 9*i);
        return calc(max) - calc(min - 1);
    }

    long calc(long max)
    {
        int i, j;
        long res = 0;
        Console.WriteLine(MOD);
        bool[] b = new bool[MOD];
        b[0] = true;
        for (i = 1; i <= 9; i++)
        {
            int mul = 9 * i;
            int add = i * i;
            for (j = add; j <= MOD; j += mul)
            {
                b[j%MOD] = true;
            }
        }
        for (i = 0; i < MOD; i++)
        {
            if (b[i])
            {
                long minnum = i;
                long maxnum = max - max % MOD + i + MOD;
                while (maxnum > max) maxnum -= MOD;
                if (maxnum >= minnum)
                {
                    res += (maxnum - minnum) / MOD + 1;
                }

            }
        }
        Console.WriteLine(res);
        return res;
    }

    long gcd(long a, long b)
    {
        if (b == 0) return a;
        else return gcd(b, a % b);
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
	private void test_case_0() { long Arg0 = 10l; long Arg1 = 16l; long Arg2 = 2l; verify_case(0, Arg2, count(Arg0, Arg1)); }
	private void test_case_1() { long Arg0 = 123l; long Arg1 = 123l; long Arg2 = 0l; verify_case(1, Arg2, count(Arg0, Arg1)); }
	private void test_case_2() { long Arg0 = 160l; long Arg1 = 160l; long Arg2 = 1l; verify_case(2, Arg2, count(Arg0, Arg1)); }
	private void test_case_3() { long Arg0 = 47l; long Arg1 = 58l; long Arg2 = 4l; verify_case(3, Arg2, count(Arg0, Arg1)); }
	private void test_case_4() { long Arg0 = 123456789l; long Arg1 = 9876543210l; long Arg2 = 2618024258l; verify_case(4, Arg2, count(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        FoxIntegerLevelThree ___test = new FoxIntegerLevelThree();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
