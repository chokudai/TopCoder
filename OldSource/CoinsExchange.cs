using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CoinsExchange {
    public int countExchanges(int G1, int S1, int B1, int G2, int S2, int B2)
    {
        G1 -= G2; S1 -= S2; B1 -= B2;
        int res = 0;
        Console.WriteLine(G1 + " " + S1 + " " + B1 + " " + res);
        if (G1 < 0)
        {
            res -= G1;
            S1 += G1 * 11;
            G1 = 0;
        }
        if (S1 < 0)
        {
            int need = (-S1 + 8) / 9;
            int change = Math.Min(need, G1);
            res += change;
            G1 -= change;
            S1 += change * 9;
        }
        if (S1 < 0)
        {
            res -= S1;
            B1 += S1 * 11;
            S1 = 0;
        }
        if (B1 < 0)
        {
            int need = (-B1 + 8) / 9;
            int change = need;
            res += change;
            S1 -= change;
            B1 += change * 9;
        }
        if (S1 < 0)
        {
            int need = (-S1 + 8) / 9;
            int change = Math.Min(need, G1);
            res += change;
            G1 -= change;
            S1 += change * 9;
        }
        Console.WriteLine(G1 + " " + S1 + " " + B1 + " " + res);
        if (G1 < 0) return -1;
        if (S1 < 0) return -1;
        if (B1 < 0) return -1;
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
	private void test_case_0() { int Arg0 = 1; int Arg1 = 0; int Arg2 = 0; int Arg3 = 0; int Arg4 = 0; int Arg5 = 81; int Arg6 = 10; verify_case(0, Arg6, countExchanges(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_1() { int Arg0 = 1; int Arg1 = 100; int Arg2 = 12; int Arg3 = 5; int Arg4 = 53; int Arg5 = 33; int Arg6 = 7; verify_case(1, Arg6, countExchanges(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_2() { int Arg0 = 1; int Arg1 = 100; int Arg2 = 12; int Arg3 = 5; int Arg4 = 63; int Arg5 = 33; int Arg6 = -1; verify_case(2, Arg6, countExchanges(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_3() { int Arg0 = 5; int Arg1 = 10; int Arg2 = 12; int Arg3 = 3; int Arg4 = 7; int Arg5 = 9; int Arg6 = 0; verify_case(3, Arg6, countExchanges(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CoinsExchange ___test = new CoinsExchange();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
