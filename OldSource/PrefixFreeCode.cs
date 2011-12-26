using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PrefixFreeCode {
    public int minCost(int N, int[] characterCosts)
    {
        Array.Sort(characterCosts);
        int[] memo = new int[1000];
        int i;
        for (i = 2; i < characterCosts.Length; i++)
        {
            if (characterCosts[0] + characterCosts[1] > characterCosts[i])
            {
                memo[i - 1] = characterCosts[i]; continue;
            }
            else
            {
                break;
            }
        }
        memo[0] = characterCosts[0] + characterCosts[1];
        int M = i - 1;
        int res=0;
        for (i = 0; i < N; i++)
        {
            res += memo[i % M];
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
	private void test_case_0() { int Arg0 = 3; int[] Arg1 = new int[]{1,4}; int Arg2 = 11; verify_case(0, Arg2, minCost(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 3; int[] Arg1 = new int[]{1,3,5}; int Arg2 = 9; verify_case(1, Arg2, minCost(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 500; int[] Arg1 = new int[]{ 2, 4, 6, 8,10,12,14,16,18,20,
 22,24,26,28,30,32,34,36,38,40,
 42,44,46,48,50,52,54,56,58,60,
 62,64,66,68,70,72,74,76,78,80,
 82,84,86,88,90,92,94,96,98,100}; int Arg2 = 9464; verify_case(2, Arg2, minCost(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 500; int[] Arg1 = new int[]{1,2,3,4,5,6,7,8,9,10}; int Arg2 = 4732; verify_case(3, Arg2, minCost(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
PrefixFreeCode ___test = new PrefixFreeCode();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
