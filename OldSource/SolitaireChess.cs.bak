using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SolitaireChess {
public int transform(string[] board1, string[] board2) {

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
	private void test_case_0() { string[] Arg0 = new string[]{"...N....",
 "........",
 "........",
 "........",
 "........",
 "........",
 "...P....",
 "........"}; string[] Arg1 = new string[]{"...N....",
 ".....N..",
 "........",
 "........",
 "........",
 "........",
 "........",
 "........"}; int Arg2 = 7; verify_case(0, Arg2, transform(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"........",
 "........",
 "...P....",
 "........",
 "........",
 "........",
 "........",
 "........"}; string[] Arg1 = new string[]{"........",
 "........",
 "........",
 "........",
 "........",
 "........",
 "........",
 "...P...."}; int Arg2 = -1; verify_case(1, Arg2, transform(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"........",
 "........",
 "........",
 "........",
 "........",
 "........",
 "........",
 ".N...P.."}; string[] Arg1 = new string[]{"........",
 "........",
 "........",
 "........",
 "........",
 "........",
 ".....P..",
 ".......N"}; int Arg2 = 5; verify_case(2, Arg2, transform(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"N.......",
 "........",
 "N.......",
 "........",
 "........",
 "........",
 "........",
 "........"}; string[] Arg1 = new string[]{"........",
 "..N.....",
 "........",
 "........",
 "........",
 "........",
 "........",
 "........"}; int Arg2 = -1; verify_case(3, Arg2, transform(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"..N.N...",
 "PPP....N",
 "..N..N..",
 "N...N...",
 "...NNNNN",
 "N.......",
 "...NN...",
 "..N...N."}; string[] Arg1 = new string[]{"..N....N",
 "P....N..",
 "..N..N..",
 "N..NNN.N",
 "N.....N.",
 "N.N.....",
 "...NNN..",
 ".....N.N"}; int Arg2 = 23; verify_case(4, Arg2, transform(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SolitaireChess ___test = new SolitaireChess();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
