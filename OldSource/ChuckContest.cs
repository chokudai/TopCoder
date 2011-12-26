using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ChuckContest {
public string chuckRules(int numProblems, string[] lowerBounds, string[] upperBounds, int[] partTimes) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); if ((Case == -1) || (Case == 6)) test_case_6(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 10; string[] Arg1 = new string[]{"1 31"}; string[] Arg2 = new string[]{"1 10"}; int[] Arg3 = new int[]{1}; string Arg4 = "1 21"; verify_case(0, Arg4, chuckRules(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int Arg0 = 10; string[] Arg1 = new string[]{"10 31"}; string[] Arg2 = new string[]{"10 10"}; int[] Arg3 = new int[]{1}; string Arg4 = "10 30"; verify_case(1, Arg4, chuckRules(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int Arg0 = 10; string[] Arg1 = new string[]{"10 30"}; string[] Arg2 = new string[]{"10 10"}; int[] Arg3 = new int[]{1}; string Arg4 = ""; verify_case(2, Arg4, chuckRules(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int Arg0 = 60; string[] Arg1 = new string[]{"60 60"}; string[] Arg2 = new string[]{"1 100000"}; int[] Arg3 = new int[]{1500}; string Arg4 = ""; verify_case(3, Arg4, chuckRules(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_4() { int Arg0 = 10; string[] Arg1 = new string[]{"1 21", "1 23"}; string[] Arg2 = new string[]{"1 19", "1 21"}; int[] Arg3 = new int[]{20, 60}; string Arg4 = ""; verify_case(4, Arg4, chuckRules(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_5() { int Arg0 = 10; string[] Arg1 = new string[]{"1 3", "1 100000"}; string[] Arg2 = new string[]{"1 1", "10 10"}; int[] Arg3 = new int[]{30, 31}; string Arg4 = "10 281"; verify_case(5, Arg4, chuckRules(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_6() { int Arg0 = 17; string[] Arg1 = new string[]{"4 982", "5 182", "14 103"}; string[] Arg2 = new string[]{"14 14", "9 703", "17 440"}; int[] Arg3 = new int[]{6, 10, 16}; string Arg4 = "17 441"; verify_case(6, Arg4, chuckRules(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ChuckContest ___test = new ChuckContest();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
