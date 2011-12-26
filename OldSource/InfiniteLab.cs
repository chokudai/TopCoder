using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class InfiniteLab {
    public long getDistance(string[] map, long r1, int c1, long r2, int c2)
    {

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
	private void test_case_0() { string[] Arg0 = new string[]{"#...##",
 ".##...",
 "..#.##",
 "#.#.##"}; long Arg1 = 1l; int Arg2 = 0; long Arg3 = 5l; int Arg4 = 3; long Arg5 = 7l; verify_case(0, Arg5, getDistance(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_1() { string[] Arg0 = new string[]{"##.#.",
 ".#T#T",
 "...#.",
 "##.#."}; long Arg1 = 7l; int Arg2 = 4; long Arg3 = 1l; int Arg4 = 0; long Arg5 = 9l; verify_case(1, Arg5, getDistance(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_2() { string[] Arg0 = new string[]{"..######.#",
 ".###T###.T",
 "..T#.##T##",
 ".######..#"}; long Arg1 = 1l; int Arg2 = 0; long Arg3 = 6l; int Arg4 = 4; long Arg5 = 11l; verify_case(2, Arg5, getDistance(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_3() { string[] Arg0 = new string[]{"..#..",
 ".#.#.",
 "....."}; long Arg1 = -29l; int Arg2 = 2; long Arg3 = 19l; int Arg4 = 2; long Arg5 = 54l; verify_case(3, Arg5, getDistance(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_4() { string[] Arg0 = new string[]{".#.#.",
 "..#..",
 ".....",
 ".....",
 "..#.."}; long Arg1 = -999l; int Arg2 = 3; long Arg3 = 100l; int Arg4 = 2; long Arg5 = -1l; verify_case(4, Arg5, getDistance(Arg0, Arg1, Arg2, Arg3, Arg4)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
InfiniteLab ___test = new InfiniteLab();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
