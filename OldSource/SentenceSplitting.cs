using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SentenceSplitting {
    //used max -> now
    public int split(string sentence, int K)
    {
        int i, j,k;
        int[,] res = new int[105, 105];
        for (i = 0; i < 100; i++) for (j = 0; j < 100; j++) res[i, j] = 9999999;
        string[] st = sentence.Split(' ');
        res[0, 0] = 0;
        for (k = 0; k < st.Length; k++)
        {
            //Console.WriteLine(st[k].Length);
            int[,] next = new int[105, 105];
            for (i = 0; i < 100; i++) for (j = 0; j < 100; j++) next[i, j] = 9999999;
            for (i = 0; i <= K; i++)
            {
                for (j = 0; j < 100; j++)
                {
                    if (res[i, j] == 9999999) continue;
                    next[i + 1, Math.Max(j, st[k].Length)] = Math.Min(next[i + 1, Math.Max(j, st[k].Length)], st[k].Length);
                    if (res[i, j] == 0)
                    {
                        next[i, Math.Max(j, st[k].Length)] = Math.Min(next[i, Math.Max(j, st[k].Length)], st[k].Length);
                        //Console.WriteLine(Math.Max(j, st[k].Length));
                    }
                    else
                    {
                        next[i, Math.Max(j, res[i, j] + 1 + st[k].Length)] = Math.Min(next[i, Math.Max(j, res[i, j] + 1 + st[k].Length)], res[i, j] + 1 + st[k].Length);
                    }
                }
            }
            res = (int[,])next.Clone();
        }
        int result = 99999;
        for (i = 0; i <= K; i++)
        {
            for (j = 0; j < 100; j++)
            {
                if (res[i, j] != 9999999)
                {
                    //Console.WriteLine("res = " + j);
                    result = Math.Min(result, j);
                }
            }
        }
        return result;
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
	private void test_case_0() { string Arg0 = "This is a test sentence"; int Arg1 = 1; int Arg2 = 13; verify_case(0, Arg2, split(Arg0, Arg1)); }
	private void test_case_1() { string Arg0 = "TheOnlyWord"; int Arg1 = 37; int Arg2 = 11; verify_case(1, Arg2, split(Arg0, Arg1)); }
	private void test_case_2() { string Arg0 = "One veeeeeeeeeeeeeeeeeeery long word"; int Arg1 = 2; int Arg2 = 22; verify_case(2, Arg2, split(Arg0, Arg1)); }
	private void test_case_3() { string Arg0 = "Each tournament round is an elimination round"; int Arg1 = 3; int Arg2 = 15; verify_case(3, Arg2, split(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SentenceSplitting ___test = new SentenceSplitting();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
