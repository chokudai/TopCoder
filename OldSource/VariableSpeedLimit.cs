using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class VariableSpeedLimit {
    public double journeyTime(int journeyLength, int[] speedLimit)
    {
        int i;
        double res = 0;
        while (true)
        {
            for (i = 0; i < speedLimit.Length; i++)
            {
                if (journeyLength < speedLimit[i]) return res + journeyLength / (double)speedLimit[i];
                res++; journeyLength -= speedLimit[i];
            }
        }
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 100; int[] Arg1 = new int[]{50}; double Arg2 = 2.0; verify_case(0, Arg2, journeyTime(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 100; int[] Arg1 = new int[]{50,25}; double Arg2 = 2.5; verify_case(1, Arg2, journeyTime(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 1000; int[] Arg1 = new int[]{50,40,30,40,50}; double Arg2 = 24.0; verify_case(2, Arg2, journeyTime(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 2058; int[] Arg1 = new int[]{80,43,57,23,28,45,60,75,73,80}; double Arg2 = 37.4; verify_case(3, Arg2, journeyTime(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 17216; int[] Arg1 = new int[]{26,30,62,55,51,56,58,4,60,23,31}; double Arg2 = 415.03333333333336; verify_case(4, Arg2, journeyTime(Arg0, Arg1)); }
	private void test_case_5() { int Arg0 = 9839; int[] Arg1 = new int[]{45,90,13,4,81,50,81,10,64,86,69}; double Arg2 = 182.8395061728395; verify_case(5, Arg2, journeyTime(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
VariableSpeedLimit ___test = new VariableSpeedLimit();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
