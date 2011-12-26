using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class LaserShooting {
    public double numberOfHits(int[] x, int[] y1, int[] y2)
    {
        double res = 0;
        int i;
        for (i = 0; i < x.Length; i++)
        {
            res += Math.Abs(Math.Atan((double)y1[i] / x[i])
                -Math.Atan((double)y2[i] / x[i]))/Math.PI;
        }
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{1}; int[] Arg1 = new int[]{-1}; int[] Arg2 = new int[]{1}; double Arg3 = 0.5; verify_case(0, Arg3, numberOfHits(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int[] Arg0 = new int[]{1,2}; int[] Arg1 = new int[]{-1,-2}; int[] Arg2 = new int[]{1,2}; double Arg3 = 1.0; verify_case(1, Arg3, numberOfHits(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int[] Arg0 = new int[]{3,4,7,1}; int[] Arg1 = new int[]{1,2,3,4}; int[] Arg2 = new int[]{4,3,2,1}; double Arg3 = 0.4623163952488826; verify_case(2, Arg3, numberOfHits(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int[] Arg0 = new int[]{134,298,151,942}; int[] Arg1 = new int[]{-753,-76,19,568}; int[] Arg2 = new int[]{440,689,-39,672}; double Arg3 = 1.444210260641501; verify_case(3, Arg3, numberOfHits(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
LaserShooting ___test = new LaserShooting();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
