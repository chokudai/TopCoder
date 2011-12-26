using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Painting {
    public int largestBrush(string[] picture)
    {
        int h = picture.Length;
        int w = picture[0].Length;
        int[,] dp = new int[h, w];
        int i, j, k, l;
        for (i = 0; i < h; i++)
        {
            for (j = 0; j < w; j++)
            {
                if (picture[i][j] == 'B') dp[i, j] = 1;
            }
        }
        for (i = 1; i < h; i++)
        {
            for (j = 1; j < w; j++)
            {
                if (picture[i][j] == 'B')
                {
                    dp[i, j] = 100;
                    if (i != 0) dp[i, j] = Math.Min(dp[i - 1, j] + 1, dp[i, j]);
                    if (j != 0) dp[i, j] = Math.Min(dp[i, j - 1] + 1, dp[i, j]);
                    if (i != 0 && j != 0) dp[i, j] = Math.Min(dp[i - 1, j - 1] + 1, dp[i, j]);
                }
            }
        }
        int res = Math.Min(h, w);
        for (i = 0; i < h; i++)
        {
            for (j = 0; j < w; j++)
            {
                if (picture[i][j] == 'B')
                {
                    for (k = i; k < h; k++)
                    {
                        for (l = j; l < w; l++)
                        {
                            if (dp[k, l] == 0) break;
                            if (Math.Max(k - i, l - j) >= dp[k, l]) continue;
                            dp[i, j] = Math.Max(dp[i, j], dp[k, l]);
                        }
                    }
                    res = Math.Min(res, dp[i, j]);
                }
            }
        }
        return res;
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
	private void test_case_0() { string[] Arg0 = new string[]{"BBBB",
 "BBBB",
 "BBBB",
 "BBBB"}; int Arg1 = 4; verify_case(0, Arg1, largestBrush(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"BBBB",
 "BWWB",
 "BWWB",
 "BBBB"}; int Arg1 = 1; verify_case(1, Arg1, largestBrush(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"WBBBBB",
 "BBBBBB",
 "BBBBBB",
 "BBBBBB"}
; int Arg1 = 3; verify_case(2, Arg1, largestBrush(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"BBBB",
 "BBBB",
 "WBBB",
 "BBBB",
 "BBBB",
 "BBBB"}
; int Arg1 = 2; verify_case(3, Arg1, largestBrush(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"WBBBBBWWWWWWWWW",
 "WBBBBBBWWWWWWWW",
 "WBBBBBBBBBBBWWW",
 "WBBBBBBBBBBBWWW",
 "BBBBBBBBBBBBBBB",
 "BBBBBBBBBBBBBBB",
 "BBBBBBBBBBBBBBB",
 "BBBBBBBBWWBBBBB",
 "BBBBBBBBWBBBBBB",
 "WBBBBBBBWBBBBBW",
 "BBBBBBBWWBBBBBW",
 "BBBBBBBWWBBBBBW",
 "BBBBBBWWWBBBBBW",
 "BBBBBWWWWWWWWWW",
 "BBBBBWWWWWWWWWW"}
; int Arg1 = 5; verify_case(4, Arg1, largestBrush(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Painting ___test = new Painting();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
