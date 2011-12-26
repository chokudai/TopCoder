using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MovieSeating {
    public long getSeatings(int numFriends, string[] hall)
    {
        long[] memo = new long[51];
        int i,j;
        int[] tate = new int[hall.Length];
        int[] yoko = new int[hall[0].Length];

        for (i = 0; i < 51; i++) memo[i] = 0;
        memo[numFriends] = 1;
        for (i = 1; i <= numFriends; i++) memo[numFriends] *= i;

        for (i = numFriends + 1; i < 51; i++)
        {
            memo[i] = memo[i - 1];
            memo[i] *= i;
            memo[i] /= i - numFriends;
        }

        for (i = 0; i < hall.Length; i++)
        {
            for (j = 0; j < hall[0].Length; j++)
            {
                if (hall[i][j] == '.')
                {
                    tate[i]++;
                    yoko[j]++;
                }
            }
        }

        long res = 0;
        for (i = 0; i < hall.Length; i++) res += memo[tate[i]];
        if (numFriends != 1) for (i = 0; i < hall[0].Length; i++) res += memo[yoko[i]];
        return res;
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
	private void test_case_0() { int Arg0 = 2; string[] Arg1 = new string[]{ ".#..",
  ".##.",
  "...." }; long Arg2 = 34l; verify_case(0, Arg2, getSeatings(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 2; string[] Arg1 = new string[]{ "..#",
  ".##",
  "..." }; long Arg2 = 16l; verify_case(1, Arg2, getSeatings(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 5; string[] Arg1 = new string[]{ "..####..", 
  ".###.##.",
  ".######.",
  "#.#.#.#." }; long Arg2 = 0l; verify_case(2, Arg2, getSeatings(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 8; string[] Arg1 = new string[]{ "........" }; long Arg2 = 40320l; verify_case(3, Arg2, getSeatings(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MovieSeating ___test = new MovieSeating();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
