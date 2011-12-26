using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MicrowaveSelling {
    public int mostAttractivePrice(int minPrice, int maxPrice)
    {
        int i;
        int res = -1;
        int max = -1;
        for (i = maxPrice; i >= minPrice; i--)
        {
            int a = get(i);
            //Console.WriteLine(a + " " + i);
            if (a > max)
            {
                max = a;
                res = i;
            }
        }
        return res;
    }

    int get(int a)
    {
        int res = 0;
        while (a != 0)
        {
            if (a % 10 == 9) res++;
            else return res;
            a /= 10;
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
	private void test_case_0() { int Arg0 = 460; int Arg1 = 680; int Arg2 = 599; verify_case(0, Arg2, mostAttractivePrice(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 10; int Arg1 = 1000; int Arg2 = 999; verify_case(1, Arg2, mostAttractivePrice(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 1255; int Arg1 = 2999; int Arg2 = 2999; verify_case(2, Arg2, mostAttractivePrice(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 20; int Arg1 = 25; int Arg2 = 25; verify_case(3, Arg2, mostAttractivePrice(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MicrowaveSelling ___test = new MicrowaveSelling();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
