using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CircleMarket {
    public int makePurchases(int[] openTime, int[] closeTime, int travelTime)
    {
        bool[] b = new bool[openTime.Length];
        int i, res = 0, time = 0;
        while (time <= 1000000)
        {
            for (i = 0; i < openTime.Length && time <= 1000000; i++)
            {
                if (time >= openTime[i] && time <= closeTime[i] && !b[i]) { b[i] = true; res++; }
                time += travelTime;
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
	private void test_case_0() { int[] Arg0 = new int[]{0, 0, 0}; int[] Arg1 = new int[]{100, 100, 100}; int Arg2 = 3; int Arg3 = 3; verify_case(0, Arg3, makePurchases(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int[] Arg0 = new int[]{45, 45, 0}; int[] Arg1 = new int[]{50, 50, 20}; int Arg2 = 15; int Arg3 = 1; verify_case(1, Arg3, makePurchases(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int[] Arg0 = new int[]{1000, 1000}; int[] Arg1 = new int[]{1010, 1010}; int Arg2 = 1; int Arg3 = 2; verify_case(2, Arg3, makePurchases(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int[] Arg0 = new int[]{999999, 2, 4}; int[] Arg1 = new int[]{1000000, 22, 44}; int Arg2 = 2; int Arg3 = 2; verify_case(3, Arg3, makePurchases(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int[] Arg0 = new int[]{363, 237, 382, 232, 392, 3829, 99999, 12}; int[] Arg1 = new int[]{365, 1239, 2384, 234, 394, 3831, 100001, 15}; int Arg2 = 3; int Arg3 = 3; verify_case(4, Arg3, makePurchases(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CircleMarket ___test = new CircleMarket();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
