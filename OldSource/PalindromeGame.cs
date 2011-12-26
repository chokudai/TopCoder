using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PalindromeGame {
    public int getMaximum(string[] front, int[] back)
    {
        int i, j;
        for (i = 0; i < front.Length; i++)
        {
            for (j = 0; j < back.Length - 1; j++)
            {
                if (back[j] < back[j + 1])
                {
                    string temp = front[j];
                    front[j] = front[j + 1];
                    front[j + 1] = temp;
                    int t = back[j];
                    back[j] = back[j + 1];
                    back[j + 1] = t;
                }
            }
        }
        string[] rfront = new string[front.Length];
        for (i = 0; i < front.Length; i++)
        {
            rfront[i] = "";
            for (j = front[i].Length - 1; j >= 0; j--)
            {
                rfront[i] += front[i][j];
            }
        }
        bool[] used = new bool[front.Length];
        int res = 0;
        for (i = 0; i < front.Length; i++)
        {
            if (used[i]) continue;
            for (j = i + 1; j < front.Length; j++)
            {
                if (used[j]) continue;
                if (front[i] == rfront[j])
                {
                    res += back[i] + back[j];
                    used[i] = used[j] = true;
                    break;
                }
            }
        }
        for (i = 0; i < front.Length; i++)
            if (!used[i] && front[i] == rfront[i])
            {
                res += back[i]; break;
            }
        return res;
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
	private void test_case_0() { string[] Arg0 = new string[]{ "topcoder", "redcoder", "redocpot" }; int[] Arg1 = new int[]{ 7, 5, 3 }; int Arg2 = 10; verify_case(0, Arg2, getMaximum(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{ "rabbit" }; int[] Arg1 = new int[]{ 1000000 }; int Arg2 = 0; verify_case(1, Arg2, getMaximum(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{ "abc", "abc", "def", "cba", "fed" }; int[] Arg1 = new int[]{ 24, 7, 63, 222, 190 }; int Arg2 = 499; verify_case(2, Arg2, getMaximum(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
PalindromeGame ___test = new PalindromeGame();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}