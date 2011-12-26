using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class GreenWarfare {
    public int minimumEnergyCost(int[] canonX, int[] canonY, int[] baseX, int[] baseY, int[] plantX, int[] plantY, int energySupplyRadius)
    {

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
	private void test_case_0() { int[] Arg0 = new int[]{ 0 }; int[] Arg1 = new int[]{ 0 }; int[] Arg2 = new int[]{1,2,3}; int[] Arg3 = new int[]{0,0,0}; int[] Arg4 = new int[]{3}; int[] Arg5 = new int[]{3}; int Arg6 = 4; int Arg7 = 14; verify_case(0, Arg7, minimumEnergyCost(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6)); }
	private void test_case_1() { int[] Arg0 = new int[]{ 0 }; int[] Arg1 = new int[]{ 0 }; int[] Arg2 = new int[]{1,2,3}; int[] Arg3 = new int[]{0,0,0}; int[] Arg4 = new int[]{2}; int[] Arg5 = new int[]{2}; int Arg6 = 4; int Arg7 = 8; verify_case(1, Arg7, minimumEnergyCost(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6)); }
	private void test_case_2() { int[] Arg0 = new int[]{3,6}; int[] Arg1 = new int[]{3,6}; int[] Arg2 = new int[]{1,2,3,4,5}; int[] Arg3 = new int[]{5,4,2,3,1}; int[] Arg4 = new int[]{1,2,5}; int[] Arg5 = new int[]{1,2,5}; int Arg6 = 5; int Arg7 = 12; verify_case(2, Arg7, minimumEnergyCost(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6)); }
	private void test_case_3() { int[] Arg0 = new int[]{0}; int[] Arg1 = new int[]{0}; int[] Arg2 = new int[]{-10,-10,10}; int[] Arg3 = new int[]{10,-10,0}; int[] Arg4 = new int[]{10,10,-10}; int[] Arg5 = new int[]{10,-10,0}; int Arg6 = 10; int Arg7 = 200; verify_case(3, Arg7, minimumEnergyCost(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6)); }
	private void test_case_4() { int[] Arg0 = new int[]{0}; int[] Arg1 = new int[]{0}; int[] Arg2 = new int[]{3}; int[] Arg3 = new int[]{3}; int[] Arg4 = new int[]{1,2,3}; int[] Arg5 = new int[]{0,0,0}; int Arg6 = 4; int Arg7 = 14; verify_case(4, Arg7, minimumEnergyCost(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
GreenWarfare ___test = new GreenWarfare();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
