using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BottlesOnShelf {
    public int getNumBroken(int N, int[] left, int[] right, int[] damage)
    {
        int len = left.Length;
        int i, j;
        long res = 0;
        for (i = 1; i < (1 << len); i++)
        {
            int count = 0;
            int min = 0;
            int max = int.MaxValue;
            long g = 1;
            for (j = 0; j < len; j++)
            {
                if ((i >> j) % 2 == 1)
                {
                    count++;
                    min = Math.Max(left[j], min);
                    max = Math.Min(right[j], max);
                    long gg = gcd(damage[j], g);
                    g = g * damage[j] / gg;
                }
            }
            long plus = max / g - (min - 1) / g;
            if (plus > 0)
            {
                if (count % 2 == 1) res += plus;
                else res -= plus;
            }
        }
        return (int)res;

    }

    long gcd(long a, long b)
    {
        if (b == 0) return a;
        return gcd(b, a % b);
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 7; int[] Arg1 = new int[]{1}; int[] Arg2 = new int[]{7}; int[] Arg3 = new int[]{2}; int Arg4 = 3; verify_case(0, Arg4, getNumBroken(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int Arg0 = 7; int[] Arg1 = new int[]{1,1}; int[] Arg2 = new int[]{7,7}; int[] Arg3 = new int[]{2,3}; int Arg4 = 4; verify_case(1, Arg4, getNumBroken(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int Arg0 = 7; int[] Arg1 = new int[]{1,1,1}; int[] Arg2 = new int[]{7,7,7}; int[] Arg3 = new int[]{2,3,6}; int Arg4 = 4; verify_case(2, Arg4, getNumBroken(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int Arg0 = 10; int[] Arg1 = new int[]{1,6}; int[] Arg2 = new int[]{5,10}; int[] Arg3 = new int[]{1,7}; int Arg4 = 6; verify_case(3, Arg4, getNumBroken(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_4() { int Arg0 = 5; int[] Arg1 = new int[]{4}; int[] Arg2 = new int[]{4}; int[] Arg3 = new int[]{7}; int Arg4 = 0; verify_case(4, Arg4, getNumBroken(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_5() { int Arg0 = 1000000000; int[] Arg1 = new int[]{1}; int[] Arg2 = new int[]{1000000000}; int[] Arg3 = new int[]{1}; int Arg4 = 1000000000; verify_case(5, Arg4, getNumBroken(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BottlesOnShelf ___test = new BottlesOnShelf();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
