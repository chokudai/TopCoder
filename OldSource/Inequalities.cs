using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Inequalities {
    public int maximumSubset(string[] inequalities)
    {
        int i,j,k;
        int res = 0;
        int len = inequalities.Length;
        string[] st = new string[len];
        long[] num = new long[len];
        for (i = 0; i < len; i++)
        {
            string[] temp = inequalities[i].Split(' ');
            st[i] = temp[1];
            num[i] = int.Parse(temp[2]);
            num[i] *= 2;
        }

        for (i = 0; i < len; i++)
        {
            for (j = -1; j <= 1; j++)
            {
                long X = num[i] + j;
                int now = 0;
                for (k = 0; k < len; k++)
                {
                    if (st[k] == "=")
                    {
                        if (num[k] == X) now++;
                    }
                    else if (st[k] == ">=")
                    {
                        if (X >= num[k]) now++;
                    }
                    else if (st[k] == "<=")
                    {
                        if (X <= num[k]) now++;
                    }
                    else if (st[k] == "<")
                    {
                        if (X < num[k]) now++;
                    }
                    else if (st[k] == ">")
                    {
                        if (X > num[k]) now++;
                    }
                }
                res = Math.Max(res, now);
            }
        }
        return res;
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
	private void test_case_0() { string[] Arg0 = new string[]{"X <= 12","X = 13","X > 9","X < 10","X >= 14"}; int Arg1 = 3; verify_case(0, Arg1, maximumSubset(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"X < 0","X <= 0"}; int Arg1 = 2; verify_case(1, Arg1, maximumSubset(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"X = 1","X = 2","X = 3","X > 0"}; int Arg1 = 2; verify_case(2, Arg1, maximumSubset(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"X <= 521","X >= 521","X = 521","X > 902","X > 12","X <= 1000"}; int Arg1 = 5; verify_case(3, Arg1, maximumSubset(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Inequalities ___test = new Inequalities();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
