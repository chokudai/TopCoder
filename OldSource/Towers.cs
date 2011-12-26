using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Towers {
    public int attack(int myUnits, int hpT, int attackT, int numT)
    {
        int life = hpT * numT;
        int turn = 0;
        while (life > 0 && myUnits > 0)
        {
            turn++;
            life -= myUnits;
            int k = (life + hpT - 1) / hpT;
            myUnits -= k * attackT;
        }
        if (myUnits <= 0) return -1;
        return turn;
    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 13; int Arg1 = 2; int Arg2 = 3; int Arg3 = 8; int Arg4 = 2; verify_case(0, Arg4, attack(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int Arg0 = 10; int Arg1 = 6; int Arg2 = 8; int Arg3 = 2; int Arg4 = 2; verify_case(1, Arg4, attack(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int Arg0 = 10; int Arg1 = 6; int Arg2 = 9; int Arg3 = 2; int Arg4 = -1; verify_case(2, Arg4, attack(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int Arg0 = 1; int Arg1 = 1; int Arg2 = 1; int Arg3 = 1; int Arg4 = 1; verify_case(3, Arg4, attack(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_4() { int Arg0 = 10000; int Arg1 = 10; int Arg2 = 2; int Arg3 = 2789; int Arg4 = 10; verify_case(4, Arg4, attack(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_5() { int Arg0 = 2; int Arg1 = 1; int Arg2 = 1; int Arg3 = 3; int Arg4 = 2; verify_case(5, Arg4, attack(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Towers ___test = new Towers();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
