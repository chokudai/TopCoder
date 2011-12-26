using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class LightedPanels {

    int w, h;
    int len;
    int[,] board;

    bool ok(int y, int x)
    {
        return y >= 0 && y < h && x >= 0 && x < w;
    }

    void turn(int y, int x)
    {
        for (int i = y - 1; i <= y + 1; i++)
        {
            for (int j = x - 1; j <= x + 1; j++)
            {
                if (ok(i, j)) board[i, j] ^= 1;
            }
        }
    }

    public int minTouch(string[] b)
    {
        h = b.Length;
        w = b[0].Length;
        board = new int[h, w];
        len = h + w - 1;
        int i, j, k, l;
        int MAX = 100000;
        int res = MAX;
        for (i = 0; i < (1 << len); i++)
        {
            for (j = 0; j < h; j++)
            {
                for (k = 0; k < w; k++)
                {
                    if (b[j][k] == '*') board[j, k] = 1;
                    else board[j, k] = 0;
                }
            }
            int count = 0;
            for (j = 0; j < h; j++)
            {
                if (((i >> j) & 1) != 0)
                {
                    count++;
                    turn(j, 0);
                }
            }
            for (j = h; j < len; j++)
            {
                k = j - h + 1;
                if (((i >> j) & 1) != 0)
                {
                    count++;
                    turn(0, k);
                }
            }

            for (j = 0; j < h; j++)
            {
                for (k = 0; k < w; k++)
                {
                    if (board[j, k] == 0)
                    {
                        if (j != h - 1 && k != w - 1)
                        {
                            turn(j + 1, k + 1);
                            count++;
                        }
                        else count = MAX;
                    }
                }
            }
            res = Math.Min(res, count);
        }


        if (res == MAX) return -1;
        else return res;
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
	private void test_case_0() { string[] Arg0 = new string[]{"*****",
 "*...*",
 "*...*",
 "*...*",
 "*****"}; int Arg1 = 1; verify_case(0, Arg1, minTouch(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{".*"}; int Arg1 = -1; verify_case(1, Arg1, minTouch(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"**.",
 "**.",
 "..."}; int Arg1 = 2; verify_case(2, Arg1, minTouch(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"*...",
 "**..",
 "..**",
 "...*"}; int Arg1 = 10; verify_case(3, Arg1, minTouch(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
    LightedPanels ___test = new LightedPanels();
    ___test.run_test(-1);
try {

} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
