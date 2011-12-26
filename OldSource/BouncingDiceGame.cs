using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BouncingDiceGame {


    double[] p1, p2;
    double[] memo;

    public double winProbability(int n, int d, int x, int y)
    {
        int i, j;
        p1 = new double[5001];
        p2 = new double[5001];
        memo = new double[5001];
        for (i = 0; i <= 5000; i++) memo[i] = 1 - Math.Pow((d - 1.0) / d, i);
        for (i = 1; i <= 5000; i++) p1[i] = p2[i] = 0;


        double res = 0;
        for (i = 0; i <= 5000; i++)
        {
            for (j = 0; j <= 5000; j++)
            {
                double now = p1[i] * p2[j];
                if (i == j) res += now / 2;
                if (i < j)
                {
                    res += now * (1 + memo[j - i]) / 2;
                }
                else
                {
                    double nokori = 1 - Math.Pow((d - 1.0) / d, i - j);
                    res += now * (1 - memo[i - j]) / 2;
                }
            }
        }
        return res;
    }

    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 10; int Arg1 = 6; int Arg2 = 1; int Arg3 = 1; double Arg4 = 0.5417251215862328; verify_case(0, Arg4, winProbability(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int Arg0 = 10; int Arg1 = 2; int Arg2 = 1; int Arg3 = 1; double Arg4 = 0.6090494791666666; verify_case(1, Arg4, winProbability(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int Arg0 = 100; int Arg1 = 20; int Arg2 = 1; int Arg3 = 10; double Arg4 = 0.49158887163174947; verify_case(2, Arg4, winProbability(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int Arg0 = 10; int Arg1 = 5; int Arg2 = 9; int Arg3 = 1; double Arg4 = 0.6943018666666667; verify_case(3, Arg4, winProbability(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BouncingDiceGame ___test = new BouncingDiceGame();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
