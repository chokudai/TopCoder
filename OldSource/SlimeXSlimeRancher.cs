using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SlimeXSlimeRancher {
public long train(string[] first_slime, string[] second_slime, string[] third_slime) {

}




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"1 6 2"}; string[] Arg1 = new string[]{"1 3 5"}; string[] Arg2 = new string[]{"5 4 3"}; long Arg3 = 5l; verify_case(0, Arg3, train(Arg0, Arg1, Arg2)); }
	private void test_case_1() { string[] Arg0 = new string[]{"3 2 1"}; string[] Arg1 = new string[]{"6 5 4"}; string[] Arg2 = new string[]{"9 8 7"}; long Arg3 = 0l; verify_case(1, Arg3, train(Arg0, Arg1, Arg2)); }
	private void test_case_2() { string[] Arg0 = new string[]{"1 2", "3 4"}; string[] Arg1 = new string[]{"12 3 ", "4"}; string[] Arg2 = new string[]{"1 2 ", "34"}; long Arg3 = 36l; verify_case(2, Arg3, train(Arg0, Arg1, Arg2)); }
	private void test_case_3() { string[] Arg0 = new string[]{"1 1 1 1000000000 1000000000 1000000000"}; string[] Arg1 = new string[]{"1000000000 1000000000 1000000000 1 1 1"}; string[] Arg2 = new string[]{"1 1 1 2 2 2"}; long Arg3 = 2999999997l; verify_case(3, Arg3, train(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SlimeXSlimeRancher ___test = new SlimeXSlimeRancher();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
