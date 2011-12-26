using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class EscapeTheJail {
    DateTime dt;
    double MAX = 16000;
    public double findExit(string[] jail)
    {
        dt = DateTime.Now;
        int i, j, k;
        int len = jail.Length;
        int len2 = jail[0].Length;
        double[,] dp = new double[len, len2];
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len2; j++)
            {
                dp[i, j] = MAX;
            }
        }
        int[] vx = new int[] { 1, 0, -1, 0 };
        int[] vy = new int[] { 0, 1, 0, -1 };
        double res = 0;
        while ((DateTime.Now - dt).TotalMilliseconds <= 1800)
        {
            for (i = 0; i < len; i++)
            {
                for (j = 0; j < len2; j++)
                {
                    if (jail[i][j] == '$') dp[i, j] = 0;
                    else
                    {
                        int count = 0;
                        double sum = 0;
                        for (k = 0; k < 4; k++)
                        {
                            int ni = i + vx[k];
                            int nj = j + vy[k];
                            if (ni < 0 || nj < 0 || ni >= len || nj >= len2) continue;
                            if (jail[ni][nj] == '#') continue;
                            count++;
                            sum += dp[ni, nj];
                        }
                        if (count != 0)
                        {
                            dp[i, j] = sum / count + 1;
                        }
                    }
                    if (jail[i][j] == '@') res = dp[i, j];
                }
            }
        }
        if (res >= MAX - 1) return -1.0;
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
	private void test_case_0() { string[] Arg0 = new string[]{"@$"}; double Arg1 = 1.0; verify_case(0, Arg1, findExit(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"$.",
 ".@"}; double Arg1 = 4.0; verify_case(1, Arg1, findExit(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"@..$"}; double Arg1 = 9.0; verify_case(2, Arg1, findExit(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"@#",
 "#$"}; double Arg1 = -1.0; verify_case(3, Arg1, findExit(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
EscapeTheJail ___test = new EscapeTheJail();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
