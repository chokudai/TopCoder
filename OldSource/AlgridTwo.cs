using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class AlgridTwo {
    public int makeProgram(string[] output)
    {
        long res = 1;
        long mod = 1000000007;
        int i, j;
        int h = output.Length;
        int w = output[0].Length;
        for (i = 0; i < h - 1; i++)
        {
            int last = 0;
            for (j = 0; j < w - 1; j++)
            {
                if (output[i][j] == 'W' && output[i][j + 1] == 'W')
                {
                    if (last == 1)
                    {
                        if (output[i + 1][j] == 'W') return 0;
                        res *= 2;
                        res %= mod;
                    }
                    else if (last == 2)
                    {
                        if (output[i + 1][j] == 'B') return 0;
                        res *= 2;
                        res %= mod;
                    }
                    last = 0;
                }
                else if (output[i][j] == 'B' && output[i][j + 1] == 'W')
                {
                    if (output[i + 1][j] == 'W') return 0;
                    res *= 2;
                    res %= mod;
                    last = 1;
                }
                else if (output[i][j] == 'W' && output[i][j + 1] == 'B')
                {
                    if (output[i + 1][j] == 'B') return 0;
                    res *= 2;
                    res %= mod;
                    last = 2;
                }
                else if (output[i][j] == 'B' && output[i][j + 1] == 'B')
                {
                    //last = 0;
                }
            }
            if (last == 1)
            {
                if (output[i + 1][j] == 'W') return 0;
                res *= 2;
                res %= mod;
            }
            else if (last == 2)
            {
                if (output[i + 1][j] == 'B') return 0;
                res *= 2;
                res %= mod;
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
	private void test_case_0() { string[] Arg0 = new string[]{"BB",
 "WB"}; int Arg1 = 1; verify_case(0, Arg1, makeProgram(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"BBWBBB",
 "WBWBBW"}; int Arg1 = 8; verify_case(1, Arg1, makeProgram(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"BWBWBW",
 "WWWWWW",
 "WBBWBW"}; int Arg1 = 0; verify_case(2, Arg1, makeProgram(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"WWBWBWBWBWBWBWBW",
 "BWBWBWBWBWBWBWBB",
 "BWBWBWBWBWBWBWBW"}; int Arg1 = 73741817; verify_case(3, Arg1, makeProgram(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        AlgridTwo ___test = new AlgridTwo();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
