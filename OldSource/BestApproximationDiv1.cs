using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BestApproximationDiv1 {
    int[] num;

    int check(int a, int b)
    {
        int res = 1;
        for (int i = 0; i < 6;i++)
        {
            a *= 10;
            if (a / b != num[i]) break;
            a %= b;
            res++;
        }
        return res;
    }

    public string findFraction(int maxDen, string number)
    {
        num = new int[6];
        int i, j;
        int max = 0;
        string res = "";
        for (i = 0; i < 6; i++) num[i] = number[i + 2] - '0';
        for (i = 1; i <= maxDen; i++)
        {
            for (j = 0; j < i; j++)
            {
                int now = check(j, i);
                if (now > max)
                {
                    max = now;
                    res = j + "/" + i + " has " + max + " exact digits";
                }
            }
        }
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 42; string Arg1 = "0.141592"; string Arg2 = "1/7 has 3 exact digits"; verify_case(0, Arg2, findFraction(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 3; string Arg1 = "0.133700"; string Arg2 = "0/1 has 1 exact digits"; verify_case(1, Arg2, findFraction(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 1000; string Arg1 = "0.123456"; string Arg2 = "10/81 has 7 exact digits"; verify_case(2, Arg2, findFraction(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 1000; string Arg1 = "0.420000"; string Arg2 = "21/50 has 7 exact digits"; verify_case(3, Arg2, findFraction(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 100; string Arg1 = "0.909999"; string Arg2 = "10/11 has 4 exact digits"; verify_case(4, Arg2, findFraction(Arg0, Arg1)); }
	private void test_case_5() { int Arg0 = 115; string Arg1 = "0.141592"; string Arg2 = "16/113 has 7 exact digits"; verify_case(5, Arg2, findFraction(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BestApproximationDiv1 ___test = new BestApproximationDiv1();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
