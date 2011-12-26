using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class VoteRigging {
public int minimumVotes(int[] votes) {
    int res = 0;
    while (true)
    {
        int i;
        int max = 0;
        for (i = 1; i < votes.Length; i++)
        {
            if (votes[max] <= votes[i])
            {
                max = i;
            }
        }
        if (max == 0) return res;
        res++;
        votes[0]++;
        votes[max]--;
    }
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
	private void test_case_0() { int[] Arg0 = new int[]{5, 7, 7}; int Arg1 = 2; verify_case(0, Arg1, minimumVotes(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{10, 10, 10, 10}; int Arg1 = 1; verify_case(1, Arg1, minimumVotes(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{1}; int Arg1 = 0; verify_case(2, Arg1, minimumVotes(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{5, 10, 7, 3, 8}; int Arg1 = 4; verify_case(3, Arg1, minimumVotes(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
VoteRigging ___test = new VoteRigging();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
