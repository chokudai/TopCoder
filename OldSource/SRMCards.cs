using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SRMCards {
    public int maxTurns(int[] cards)
    {
        int i;
        Array.Sort(cards);
        int len = cards.Length;
        int count1 = 0; // 前に取った　時の最大値
        int count2 = 0; // 前に取ってない　時の最大値
        for (i = 0; i < len; i++)
        {
            int nextc1 = 0;
            int nextc2 = 0;
            if (i == 0 || cards[i - 1] + 1 == cards[i])
            {
                nextc1 = count2 + 1;
                nextc2 = Math.Max(count1, count2);
            }
            else
            {
                nextc1 = Math.Max(count1, count2) + 1;
                nextc2 = Math.Max(count1, count2);
            }

            count1 = nextc1;
            count2 = nextc2;
        }
        return Math.Max(count1, count2);
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
	private void test_case_0() { int[] Arg0 = new int[]{498, 499}; int Arg1 = 1; verify_case(0, Arg1, maxTurns(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{491, 492, 495, 497, 498, 499}; int Arg1 = 4; verify_case(1, Arg1, maxTurns(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{100, 200, 300, 400}; int Arg1 = 4; verify_case(2, Arg1, maxTurns(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{11, 12, 102, 13, 100, 101, 99, 9, 8, 1}; int Arg1 = 6; verify_case(3, Arg1, maxTurns(Arg0)); }
	private void test_case_4() { int[] Arg0 = new int[]{118, 321, 322, 119, 120, 320}; int Arg1 = 4; verify_case(4, Arg1, maxTurns(Arg0)); }
	private void test_case_5() { int[] Arg0 = new int[]{10, 11, 12, 13, 14, 1, 2, 3, 4, 5, 6, 7, 8, 9}; int Arg1 = 7; verify_case(5, Arg1, maxTurns(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SRMCards ___test = new SRMCards();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
