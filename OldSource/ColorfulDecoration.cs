using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ColorfulDecoration {


    public int getMaximum(int[] xa, int[] ya, int[] xb, int[] yb)
    {
        int i, j;
        int len = xa.Length;
        int minres = int.MaxValue;

        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                if (i == j) continue;
                int aa = Math.Max(Math.Abs(xa[i] - xa[j]), Math.Abs(ya[i] - ya[j]));
                int ab = Math.Max(Math.Abs(xa[i] - xb[j]), Math.Abs(ya[i] - yb[j]));
                int ba = Math.Max(Math.Abs(xb[i] - xa[j]), Math.Abs(yb[i] - ya[j]));
                int bb = Math.Max(Math.Abs(xb[i] - xb[j]), Math.Abs(yb[i] - yb[j]));
                minres = Math.Max(Math.Min(aa, ab), Math.Min(ba, bb));
            }
        }
        return minres;
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
	private void test_case_0() { int[] Arg0 = new int[]{ 10,  0,  7 }; int[] Arg1 = new int[]{  0, 19,  6 }; int[] Arg2 = new int[]{ 20, 10, 25 }; int[] Arg3 = new int[]{ 20, 35, 25 }; int Arg4 = 19; verify_case(0, Arg4, getMaximum(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int[] Arg0 = new int[]{ 464, 20 }; int[] Arg1 = new int[]{ 464, 10 }; int[] Arg2 = new int[]{ 464,  3 }; int[] Arg3 = new int[]{ 464, 16 }; int Arg4 = 461; verify_case(1, Arg4, getMaximum(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int[] Arg0 = new int[]{ 0, 0, 1, 1 }; int[] Arg1 = new int[]{ 0, 0, 1, 1 }; int[] Arg2 = new int[]{ 1, 1, 0, 0 }; int[] Arg3 = new int[]{ 1, 1, 0, 0 }; int Arg4 = 0; verify_case(2, Arg4, getMaximum(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int[] Arg0 = new int[]{ 0, 3, 0, 5, 6 }; int[] Arg1 = new int[]{ 1, 6, 0, 8, 5 }; int[] Arg2 = new int[]{ 6, 1, 7, 4, 7 }; int[] Arg3 = new int[]{ 5, 9, 2, 8, 9 }; int Arg4 = 3; verify_case(3, Arg4, getMaximum(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_4() { int[] Arg0 = new int[]{ 1000000000, 0 }; int[] Arg1 = new int[]{ 0, 1000000000 }; int[] Arg2 = new int[]{ 0, 1000000000 }; int[] Arg3 = new int[]{ 0, 1000000000 }; int Arg4 = 1000000000; verify_case(4, Arg4, getMaximum(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ColorfulDecoration ___test = new ColorfulDecoration();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
