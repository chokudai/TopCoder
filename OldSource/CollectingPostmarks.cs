using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CollectingPostmarks {
public int amountOfMoney(int[] prices, int[] have, int[] values, int K) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{2,15}; int[] Arg1 = new int[]{}; int[] Arg2 = new int[]{2,21}; int Arg3 = 13; int Arg4 = 15; verify_case(0, Arg4, amountOfMoney(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int[] Arg0 = new int[]{9,18,7,6,18}; int[] Arg1 = new int[]{4,0}; int[] Arg2 = new int[]{12,27,10,10,25}; int Arg3 = 67; int Arg4 = 22; verify_case(1, Arg4, amountOfMoney(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int[] Arg0 = new int[]{14,14,12,6}; int[] Arg1 = new int[]{3,2,1}; int[] Arg2 = new int[]{19,23,20,7}; int Arg3 = 10; int Arg4 = 0; verify_case(2, Arg4, amountOfMoney(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int[] Arg0 = new int[]{43,33,14,31,42,37,17,42,40,20}; int[] Arg1 = new int[]{6}; int[] Arg2 = new int[]{116,71,38,77,87,106,48,107,91,41}; int Arg3 = 811; int Arg4 = -1; verify_case(3, Arg4, amountOfMoney(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CollectingPostmarks ___test = new CollectingPostmarks();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
