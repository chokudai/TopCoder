using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SlimeXSlimeRancher2 {
    public int train(int[] attributes)
    {
        int sum = 0;
        int max = 0;
        int i;
        for (i = 0; i < attributes.Length; i++)
        {
            sum += attributes[i];
            max = Math.Max(max, attributes[i]);
        }
        return max * attributes.Length - sum;
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
	private void test_case_0() { int[] Arg0 = new int[]{1,2,3}; int Arg1 = 3; verify_case(0, Arg1, train(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{5,5}; int Arg1 = 0; verify_case(1, Arg1, train(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{900,500,100}; int Arg1 = 1200; verify_case(2, Arg1, train(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SlimeXSlimeRancher2 ___test = new SlimeXSlimeRancher2();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
