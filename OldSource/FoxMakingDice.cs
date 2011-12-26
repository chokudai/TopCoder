using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FoxMakingDice {
    public long theCount(int N, int K)
    {
        long res = 0;
        int i, j, k;
        for (int sum = K; sum <= 2000; sum++)
        {
            for (i = 1; i < Math.Min(N, (sum - 1) / 2); i++)
            {
                int a = sum - i;
                if (a < 1 || a > N) continue;
                if (i == a) continue;
                for (j = i + 1; j < Math.Min(N, (sum - 1) / 2); j++)
                {
                    if (j == a) continue;
                    int b = sum - j;
                    if (b < 1 || b > N) continue;
                    if (b == j) continue;

                    int min = j + 1;
                    int max = Math.Min(N, (sum - 1) / 2);

                    //Console.WriteLine(i + " " + j + " " + min + " " + max);
                    res += Math.Max(0, (max - min + 1) * 2);
                }
            }
        }
        //Console.ReadLine();
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 6; int Arg1 = 7; long Arg2 = 2l; verify_case(0, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 5; int Arg1 = 7; long Arg2 = 0l; verify_case(1, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 1000; int Arg1 = 1; long Arg2 = 20625666000l; verify_case(2, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 456; int Arg1 = 123; long Arg2 = 879075732l; verify_case(3, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 913; int Arg1 = 1014; long Arg2 = 4506149340l; verify_case(4, Arg2, theCount(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
FoxMakingDice ___test = new FoxMakingDice();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
