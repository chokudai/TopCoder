using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MinimalDifference {

    int getnum(int a)
    {
        int sum = 0;
        while (a != 0)
        {
            sum += a % 10;
            a /= 10;
        }
        return sum;
    }

    public int findNumber(int A, int B, int C)
    {
        int i;
        int min = int.MaxValue;
        int res = -1;
        int target = getnum(C);
        for (i = A; i <= B; i++)
        {
            int dist = Math.Abs(getnum(i) - target);
            if (dist < min)
            {
                min = dist;
                res = i;
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
	private void test_case_0() { int Arg0 = 1; int Arg1 = 9; int Arg2 = 10; int Arg3 = 1; verify_case(0, Arg3, findNumber(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int Arg0 = 11; int Arg1 = 20; int Arg2 = 20; int Arg3 = 11; verify_case(1, Arg3, findNumber(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int Arg0 = 1; int Arg1 = 1; int Arg2 = 999; int Arg3 = 1; verify_case(2, Arg3, findNumber(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int Arg0 = 100; int Arg1 = 1000; int Arg2 = 99; int Arg3 = 189; verify_case(3, Arg3, findNumber(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int Arg0 = 1987; int Arg1 = 9123; int Arg2 = 1; int Arg3 = 2000; verify_case(4, Arg3, findNumber(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MinimalDifference ___test = new MinimalDifference();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
