using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class GuessTheNumberGame {
    public int possibleClues(int n)
    {
        long mod = 1000000007;
        int i, j;
        int MAX = 2000000;
        bool[] prime = new bool[MAX];
        prime[0] = prime[1] = true;
        long res = 1;
        for (i = 2; i <= n; i++)
        {
            if (!prime[i])
            {
                int count = 1;
                long now = i;
                while (now <= n)
                {
                    now *= i;
                    count++;
                }
                res *= count;
                res %= mod;
                for (j = i + i; j <= n; j += i) prime[j] = true;
            }
        }
        return (int)res;
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
	private void test_case_0() { int Arg0 = 5; int Arg1 = 12; verify_case(0, Arg1, possibleClues(Arg0)); }
	private void test_case_1() { int Arg0 = 16; int Arg1 = 240; verify_case(1, Arg1, possibleClues(Arg0)); }
	private void test_case_2() { int Arg0 = 1; int Arg1 = 1; verify_case(2, Arg1, possibleClues(Arg0)); }
	private void test_case_3() { int Arg0 = 1000000; int Arg1 = 677298706; verify_case(3, Arg1, possibleClues(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
GuessTheNumberGame ___test = new GuessTheNumberGame();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
