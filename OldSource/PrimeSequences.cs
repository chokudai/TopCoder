using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PrimeSequences {
    int[] test = new int[10000001];
    public int getLargestGenerator(int N, int D)
    {
        int i,j;
        for (i = 0; i <= N; i++) test[i] = 1;
        test[0] = test[1] = 0;
        for (i = 0; i * i <= N; i++)
        {
            if (test[i] == 0) continue;
            for (j = i + i; j <= N; j += i)
            {
                test[j] = 0;
            }
        }

        int res = -1;
        test[0] = test[1] = 0;
        for (i = 2; i <= N; i++)
        {
            if (test[i] != 0)
            {
                test[i] = test[i / 2] + 1;
                if (test[i] >= D) res = i;
            }
        }
        return res;

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
	private void test_case_0() { int Arg0 = 10; int Arg1 = 2; int Arg2 = 7; verify_case(0, Arg2, getLargestGenerator(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 42; int Arg1 = 3; int Arg2 = 23; verify_case(1, Arg2, getLargestGenerator(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 666; int Arg1 = 7; int Arg2 = -1; verify_case(2, Arg2, getLargestGenerator(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 1337; int Arg1 = 5; int Arg2 = 47; verify_case(3, Arg2, getLargestGenerator(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 100000; int Arg1 = 5; int Arg2 = 2879; verify_case(4, Arg2, getLargestGenerator(Arg0, Arg1)); }
	private void test_case_5() { int Arg0 = 40000; int Arg1 = 1; int Arg2 = 39989; verify_case(5, Arg2, getLargestGenerator(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
PrimeSequences ___test = new PrimeSequences();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
