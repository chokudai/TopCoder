using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ChickenOracle {
    public string theTruth(int n, int eggCount, int lieCount, int liarCount)
    {
        bool eggflag = check(eggCount,n-eggCount,lieCount,liarCount);
        bool chickenflag = check(n - eggCount, eggCount, lieCount, liarCount);
        if (eggflag && chickenflag) return "Ambiguous";
        else if (!eggflag && !chickenflag) return "The oracle is a lie";
        else if (eggflag) return "The egg";
        else return "The chicken";
        

    }

    bool check(int a, int b, int lie, int liar)
    {
        int anum = a + b - lie;
        int bnum = a + b - anum;

        int gettrue = Math.Min(bnum, liar);
        int amax = anum + gettrue - (liar - gettrue);

        gettrue = liar - Math.Min(anum, liar);
        int amin = anum + gettrue - (liar - gettrue);

        Console.WriteLine(amax + " " + a + " " + amin);

        if (amax >= a && amin <= a) return true;
        return false;
    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 10; int Arg1 = 10; int Arg2 = 0; int Arg3 = 0; string Arg4 = "The egg"; verify_case(0, Arg4, theTruth(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int Arg0 = 60; int Arg1 = 40; int Arg2 = 0; int Arg3 = 30; string Arg4 = "The oracle is a lie"; verify_case(1, Arg4, theTruth(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int Arg0 = 60; int Arg1 = 20; int Arg2 = 5; int Arg3 = 25; string Arg4 = "The chicken"; verify_case(2, Arg4, theTruth(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int Arg0 = 1000; int Arg1 = 500; int Arg2 = 250; int Arg3 = 250; string Arg4 = "Ambiguous"; verify_case(3, Arg4, theTruth(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ChickenOracle ___test = new ChickenOracle();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
