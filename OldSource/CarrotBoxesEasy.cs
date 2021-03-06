using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CarrotBoxesEasy {
    public int theIndex(int[] carrots, int K)
    {
        int pre = -1;
        int i ,j;
        int len = carrots.Length;
        for (i = 0; i < K; i++)
        {
            int next = 0;
            for (j = 1; j < len; j++)
            {
                if (carrots[next] < carrots[j])
                {
                    next = j;
                }
            }
            carrots[next]--;
            pre = next;
        }
        return pre;
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
	private void test_case_0() { int[] Arg0 = new int[]{5, 8}; int Arg1 = 3; int Arg2 = 1; verify_case(0, Arg2, theIndex(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{5, 8}; int Arg1 = 4; int Arg2 = 0; verify_case(1, Arg2, theIndex(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{4, 9, 5}; int Arg1 = 18; int Arg2 = 2; verify_case(2, Arg2, theIndex(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{13, 75, 24, 55}; int Arg1 = 140; int Arg2 = 0; verify_case(3, Arg2, theIndex(Arg0, Arg1)); }
	private void test_case_4() { int[] Arg0 = new int[]{14, 36, 52, 86, 27, 97, 3, 67}; int Arg1 = 300; int Arg2 = 4; verify_case(4, Arg2, theIndex(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CarrotBoxesEasy ___test = new CarrotBoxesEasy();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
