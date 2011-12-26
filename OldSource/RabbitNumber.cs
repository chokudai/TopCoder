using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RabbitNumber {
    public int theCount(int low, int high)
    {
        int res = 0;
        long i;
        for (i = 1;; i++)
        {
            long a = getnum(i);
            //Console.WriteLine(a);
            if (a < low) continue;
            if (a > high) break;
            if (s(a * a) == s(a) * s(a)) res++;
        }
        return res;
    }

    long getnum(long a)
    {
        long res = 0;
        long now = 1;
        while (a != 0)
        {
            res += (a & 3) * now;
            a >>= 2; now *= 10;
        }
        return res;
    }

    long s(long a)
    {
        long res = 0;
        while (a != 0)
        {
            res += a % 10;
            a /= 10;
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
	private void test_case_0() { int Arg0 = 22; int Arg1 = 22; int Arg2 = 1; verify_case(0, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 484; int Arg1 = 484; int Arg2 = 0; verify_case(1, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 1; int Arg1 = 58; int Arg2 = 12; verify_case(2, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 58; int Arg1 = 484; int Arg2 = 24; verify_case(3, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 1000000000; int Arg1 = 1000000000; int Arg2 = 1; verify_case(4, Arg2, theCount(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
RabbitNumber ___test = new RabbitNumber();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
