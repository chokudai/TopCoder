using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class AmoebaDivTwo {


    int h, w;

    public int count(string[] table, int K)
    {
        int i, j, k;
        h = table.Length;
        w = table[0].Length;

        int res = 0;

        for (i = 0; i < h; i++)
        {
            for (j = 0; j < w; j++)
            {
                for (k = 0; k < K; k++)
                {
                    if (!ok(i + k, j) || table[i + k][j] != 'A') break;
                }
                if (k == K) res++;
                for (k = 0; k < K; k++)
                {
                    if (!ok(i, j + k) || table[i][j + k] != 'A') break;
                }
                if (k == K) res++;
            }
        }

        if (K == 1) res /= 2;
        return res;
    }

    bool ok(int y, int x)
    {
        return y >= 0 && x >= 0 && y < h && x < w;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"MA"}; int Arg1 = 2; int Arg2 = 0; verify_case(0, Arg2, count(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"AAA",
 "AMA",
 "AAA"}; int Arg1 = 3; int Arg2 = 4; verify_case(1, Arg2, count(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"AA",
 "AA",
 "AA"}; int Arg1 = 2; int Arg2 = 7; verify_case(2, Arg2, count(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"MMM",
 "MMM",
 "MMM"}; int Arg1 = 1; int Arg2 = 0; verify_case(3, Arg2, count(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"AAM",
 "MAM",
 "AAA"}; int Arg1 = 1; int Arg2 = 6; verify_case(4, Arg2, count(Arg0, Arg1)); }
	private void test_case_5() { string[] Arg0 = new string[]{"AAA",
 "AAM",
 "AAA"}; int Arg1 = 2; int Arg2 = 9; verify_case(5, Arg2, count(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
AmoebaDivTwo ___test = new AmoebaDivTwo();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
