using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CollectingUsualPostmarks {
    public int numberOfPostmarks(int[] prices, int[] have)
    {
        int i;
        int ret = 0;
        int money = 0;
        for (i = 0; i < have.Length; i++)
        {
            money += prices[have[i]];
        }
        Array.Sort(prices);
        foreach (int a in prices)
        {
            if (money >= a)
            {
                ret++;
                money -= a;
            }
            else break;
        }
        return ret;
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
	private void test_case_0() { int[] Arg0 = new int[]{13,10,14,20}; int[] Arg1 = new int[]{3,0,2,1}; int Arg2 = 4; verify_case(0, Arg2, numberOfPostmarks(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{7,5,9,7}; int[] Arg1 = new int[]{}; int Arg2 = 0; verify_case(1, Arg2, numberOfPostmarks(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{4,13,9,1,5}; int[] Arg1 = new int[]{1,3,2}; int Arg2 = 4; verify_case(2, Arg2, numberOfPostmarks(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{16,32,13,2,17,10,8,8,20,17}; int[] Arg1 = new int[]{7,0,4,1,6,8}; int Arg2 = 8; verify_case(3, Arg2, numberOfPostmarks(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CollectingUsualPostmarks ___test = new CollectingUsualPostmarks();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
