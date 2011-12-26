using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class HanoiGoodAndBad {

    int res, nokori;
    int[] nowd;
    int[] nowe;
    int[] count;
    int n;

    public int moves(int N, int Dave)
    {
        nowd = new int[N];
        nowe = new int[N];
        count = new int[N];
        n = N;
        nokori = Dave; res = 0;
        int i;
        int num = 1;
        for (i = 0; i < N; i++)
        {
            num *= 3;
            count[i] = num - 1;
        }
        solveDave(0, 1, 2, N - 1);
        solveEarl(0, 1, 2, N - 1);
        return res;
    }

    void solveDave(int s, int t, int sp, int N)
    {
        if (N >= 0)
        {
            solveDave(s, sp, t, N - 1);
            if (nokori > 0)
            {
                nowd[N] = t;
                nokori--;
            }
            solveDave(sp, t, s, N - 1);
        }
    }

    void solveEarl(int s, int t, int sp, int N)
    {
        int i;
        if (N >= 0)
        {
            if (nowd[N] == nowe[N])
            {
                solveEarl(s, t, sp, N - 1);
                return;
            }
            else
            {
                for (i = N - 1; i >= 0; i--) nowe[i] = t;
                if (N != 0) res += count[N - 1];
            }
            nowe[N] = sp; res++;
            if (nowd[N] == nowe[N])
            {
                solveEarl(t, s, sp, N - 1);
                return;
            }
            else
            {
                for (i = N - 1; i >= 0; i--) nowe[i] = s;
                if (N != 0) res += count[N - 1];
            }
            nowe[N] = t; res++;
            solveEarl(s, t, sp, N - 1);
        }
        return;
    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 3; int Arg1 = 1; int Arg2 = 2; verify_case(0, Arg2, moves(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 4; int Arg1 = 15; int Arg2 = 80; verify_case(1, Arg2, moves(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 9; int Arg1 = 265; int Arg2 = 16418; verify_case(2, Arg2, moves(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
    HanoiGoodAndBad ___test = new HanoiGoodAndBad();
    ___test.run_test(-1);
try {

} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
