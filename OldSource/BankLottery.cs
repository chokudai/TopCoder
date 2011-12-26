using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BankLottery {
    public double expectedAmount(int[] accountBalance, int weeklyJackpot, int weekCount)
    {
        int i, j;
        double sum = 0;
        for (i = 0; i < accountBalance.Length; i++) sum += accountBalance[i];
        double now = accountBalance[0];
        for (i = 0; i < weekCount; i++)
        {
            double plus = now / sum;
            now += plus * weeklyJackpot;
            sum += weeklyJackpot;
        }
        return now;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{100,100}; int Arg1 = 100; int Arg2 = 2; double Arg3 = 200.0; verify_case(0, Arg3, expectedAmount(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int[] Arg0 = new int[]{2,2,2}; int Arg1 = 1; int Arg2 = 2; double Arg3 = 2.6666666666666665; verify_case(1, Arg3, expectedAmount(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int[] Arg0 = new int[]{1,2,3,4,5,6,7,8,9,10}; int Arg1 = 100; int Arg2 = 20; double Arg3 = 37.36363636363636; verify_case(2, Arg3, expectedAmount(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int[] Arg0 = new int[]{0,200,200,0,300,300,600}; int Arg1 = 3; int Arg2 = 776; double Arg3 = 0.0; verify_case(3, Arg3, expectedAmount(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BankLottery ___test = new BankLottery();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
