using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheBoredomDivTwo {
    public int find(int _n, int _m, int j, int b)
    {
        int nNum = _n, mNum = _m, cnt = 0, i;
        int[] n = new int[47];
        int[] m = new int[47];

        for (i = 0; i < 47; i++) n[i] = 1;
        for (i = 0; i < 47; i++) m[i] = 0;

        if (j > nNum) m[j] = 1;
        if (b > nNum) m[b] = 1;

        cnt = nNum;
        for (i = 0; i < 47; i++)
        {
            if (m[i] == 1)
            {
                cnt += 1;
            }
        }
        return cnt;
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
	private void test_case_0() { int Arg0 = 1; int Arg1 = 1; int Arg2 = 1; int Arg3 = 2; int Arg4 = 2; verify_case(0, Arg4, find(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int Arg0 = 2; int Arg1 = 1; int Arg2 = 1; int Arg3 = 2; int Arg4 = 2; verify_case(1, Arg4, find(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int Arg0 = 1; int Arg1 = 2; int Arg2 = 3; int Arg3 = 2; int Arg4 = 3; verify_case(2, Arg4, find(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int Arg0 = 4; int Arg1 = 7; int Arg2 = 7; int Arg3 = 4; int Arg4 = 5; verify_case(3, Arg4, find(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheBoredomDivTwo ___test = new TheBoredomDivTwo();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
