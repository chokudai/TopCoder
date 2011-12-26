using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PuyoPuyo {

    const long mod = 1000000007;
    const int MAX = 1024;
    long[,,] dp = new long[MAX, MAX, 2]; //Ç®Ç¢ÇΩêîÅAè¡Ç≥Ç»Ç¢Ç∆Ç¢ÇØÇ»Ç¢ÇÃÇÃêî
    public int theCount(int L, int N)
    {
        int i, j, k, l;
        for (i = 0; i < MAX; i++)
        {
            for (j = 0; j < MAX; j++)
            {
                for (l = 0; l < 2; l++)
                {
                    dp[i, j, l] = 0;
                }
            }
        }
        dp[0, 0, 1] = 1;
        for (i = 0; i <= N; i++)
        {
            for (j = 0; j <= N; j++)
            {
                for (l = 0; l < 2; l++)
                {
                    if (dp[i, j, l] == 0) continue;
                    //Console.WriteLine(i + " " + j + " " + dp[i, j]);
                    int kakeru = 3;
                    if (j == 0) kakeru = 4;

                    dp[i + L, j, 1] += dp[i, j, l] * kakeru;

                    for (k = 1; k < L; k++)
                    {
                        dp[i + k, j + L - k, 0] += dp[i, j, l] * kakeru;
                        dp[i + k, j + L - k, 0] %= mod;
                    }
                    if (j != 0 && l == 1)
                    {
                        dp[i + 1, j - 1, l] += dp[i, j, l];
                        dp[i + 1, j - 1, l] %= mod;
                    }
                }
            }
        }

        return (int)((dp[N, 0, 0] + dp[N, 0, 1]) % mod);
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
	private void test_case_0() { int Arg0 = 2; int Arg1 = 2; int Arg2 = 4; verify_case(0, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 2; int Arg1 = 4; int Arg2 = 28; verify_case(1, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 2; int Arg1 = 58; int Arg2 = 868294620; verify_case(2, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 4; int Arg1 = 84; int Arg2 = 621871151; verify_case(3, Arg2, theCount(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 5; int Arg1 = 8; int Arg2 = 0; verify_case(4, Arg2, theCount(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
    PuyoPuyo ___test = new PuyoPuyo();
    ___test.run_test(-1);
    try {

} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
