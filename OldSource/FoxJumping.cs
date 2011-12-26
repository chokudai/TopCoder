using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FoxJumping {
    public int getCount(int Tx, int Ty, int Mx, int My, int R, int[] bad)
    {
        long mod = 10007;
        int i, j;
        long[,] memox = new long[R + 1, Tx + 1];
        long[,] memoy = new long[R + 1, Ty + 1];
        Array.Sort(bad);
        memox[0, 0] = memoy[0, 0] = 1;
        for (i = 1; i <= R; i++)
        {
            long temp = 0;
            for (j = 0; j <= Tx; j++)
            {
                temp += memox[i - 1, j];
                if (j - Mx - 1 >= 0) temp -= memox[i - 1, j - Mx - 1];
                temp = ((temp % mod) + mod) % mod;
                memox[i, j] = temp;
            }

            temp = 0;
            for (j = 0; j <= Ty; j++)
            {
                temp += memoy[i - 1, j];
                if (j - My - 1 >= 0) temp -= memoy[i - 1, j - Mx - 1];
                temp = ((temp % mod) + mod) % mod;
                memoy[i, j] = temp;
            }
        }
        for (j = 0; j <= Tx; j++) Console.WriteLine(memox[R, j]);
        Console.WriteLine();
        for (j = 0; j <= Ty; j++) Console.WriteLine(memoy[R, j]);
        long[,] tmemox = new long[R + 1, Tx + 1];
        long[,] tmemoy = new long[R + 1, Ty + 1];
        Console.ReadLine();
        return 0;
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
	private void test_case_0() { int Arg0 = 2; int Arg1 = 2; int Arg2 = 1; int Arg3 = 1; int Arg4 = 2; int[] Arg5 = new int[]{}; int Arg6 = 1; verify_case(0, Arg6, getCount(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_1() { int Arg0 = 2; int Arg1 = 2; int Arg2 = 1; int Arg3 = 1; int Arg4 = 3; int[] Arg5 = new int[]{}; int Arg6 = 6; verify_case(1, Arg6, getCount(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_2() { int Arg0 = 10; int Arg1 = 10; int Arg2 = 10; int Arg3 = 10; int Arg4 = 1; int[] Arg5 = new int[]{}; int Arg6 = 1; verify_case(2, Arg6, getCount(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_3() { int Arg0 = 10; int Arg1 = 10; int Arg2 = 10; int Arg3 = 10; int Arg4 = 1; int[] Arg5 = new int[]{10}; int Arg6 = 0; verify_case(3, Arg6, getCount(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_4() { int Arg0 = 11; int Arg1 = 11; int Arg2 = 11; int Arg3 = 11; int Arg4 = 2; int[] Arg5 = new int[]{10}; int Arg6 = 140; verify_case(4, Arg6, getCount(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_5() { int Arg0 = 123; int Arg1 = 456; int Arg2 = 70; int Arg3 = 80; int Arg4 = 90; int[] Arg5 = new int[]{30, 40, 20, 10, 50}; int Arg6 = 6723; verify_case(5, Arg6, getCount(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
FoxJumping ___test = new FoxJumping();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
