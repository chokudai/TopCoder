using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class OptimalQueues {
    public int minWaitingTime(int[] clientArrivals, int tellerCount, int serviceTime)
    {
        Array.Sort(clientArrivals);
        Array.Reverse(clientArrivals);
        int res = 0;
        for (int i = 0; i < clientArrivals.Length; i++)
            res = Math.Max(res, i / tellerCount * serviceTime + clientArrivals[i]);
        return res + serviceTime; 
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
	private void test_case_0() { int[] Arg0 = new int[]{1,2}; int Arg1 = 1; int Arg2 = 10; int Arg3 = 21; verify_case(0, Arg3, minWaitingTime(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int[] Arg0 = new int[]{10}; int Arg1 = 50; int Arg2 = 50; int Arg3 = 60; verify_case(1, Arg3, minWaitingTime(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int[] Arg0 = new int[]{10,10,10}; int Arg1 = 2; int Arg2 = 20; int Arg3 = 50; verify_case(2, Arg3, minWaitingTime(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int[] Arg0 = new int[]{2,4,6,3,5}; int Arg1 = 3; int Arg2 = 10; int Arg3 = 23; verify_case(3, Arg3, minWaitingTime(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
OptimalQueues ___test = new OptimalQueues();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
