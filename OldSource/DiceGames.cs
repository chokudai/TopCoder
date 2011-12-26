using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class DiceGames {
    public long countFormations(int[] sides)
    {
        Array.Sort(sides);
        int len = sides.Length;
        long[,] dp = new long[len + 1, 34];
        int i, j, k;
        dp[0, 33] = 1;
        for (i = 33; i > 0; i--)
        {
            int count = 0;
            for (j = 0; j < len; j++) if (sides[j] >= i) count++;
            for (j = 0; j <= len; j++)
            {
                int max = count - j;
                for (k = 0; k <= max; k++)
                {
                    dp[j + k, i - 1] += dp[j, i];
                }
            }
        }
        return dp[len, 0];
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
	private void test_case_0() { int[] Arg0 = new int[]{4}; long Arg1 = 4l; verify_case(0, Arg1, countFormations(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{2, 2}; long Arg1 = 3l; verify_case(1, Arg1, countFormations(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{4, 4}; long Arg1 = 10l; verify_case(2, Arg1, countFormations(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{3, 4}; long Arg1 = 9l; verify_case(3, Arg1, countFormations(Arg0)); }
	private void test_case_4() { int[] Arg0 = new int[]{4, 5, 6}; long Arg1 = 48l; verify_case(4, Arg1, countFormations(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
DiceGames ___test = new DiceGames();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
