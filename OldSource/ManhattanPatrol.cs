using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ManhattanPatrol {
    public long countIntersections(int N, int AX, int BX, int MX, int AY, int BY, int MY)
    {
        // X0 = BX Xi = (AX * Xi-1 + BX) mod MX for 0 < i < N
        int[] x = new int[N];
        int[] y = new int[N];
        int i, j, k;
        x[0] = BX;
        y[0] = BY;
        for (i = 1; i < N; i++)
        {
            x[i] = (AX * x[i - 1] + BX) % MX;
            y[i] = (AY * y[i - 1] + BY) % MY;
        }

        long res = 0;
        for (i = 0; i < N; i++)
        {
            for (j = i + 1; j < N; j++)
            {
                long c1 = 0;
                long c2 = 0;
                long hx = Math.Max(x[i], x[j]);
                long hy = Math.Max(y[i], y[j]);
                long lx = Math.Min(x[i], x[j]);
                long ly = Math.Min(y[i], y[j]);

                for (k = 0; k < N; k++)
                {
                    if (i == k || j == k) continue;
                    if (hx > x[k] && lx < x[k])
                    {
                        if (hy < y[k]) c1++;
                        if (ly > y[k]) c2++;
                    }
                }
                res += c1 * c2;
            }
        }

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
	private void test_case_0() { int Arg0 = 4; int Arg1 = 1; int Arg2 = 2; int Arg3 = 11; int Arg4 = 2; int Arg5 = 2; int Arg6 = 13; long Arg7 = 1l; verify_case(0, Arg7, countIntersections(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6)); }
	private void test_case_1() { int Arg0 = 7; int Arg1 = 1; int Arg2 = 2; int Arg3 = 11; int Arg4 = 2; int Arg5 = 2; int Arg6 = 13; long Arg7 = 2l; verify_case(1, Arg7, countIntersections(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6)); }
	private void test_case_2() { int Arg0 = 6; int Arg1 = 1; int Arg2 = 2; int Arg3 = 7; int Arg4 = 1; int Arg5 = 1; int Arg6 = 6; long Arg7 = 5l; verify_case(2, Arg7, countIntersections(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6)); }
	private void test_case_3() { int Arg0 = 7; int Arg1 = 1; int Arg2 = 1; int Arg3 = 11; int Arg4 = 13; int Arg5 = 1; int Arg6 = 16; long Arg7 = 0l; verify_case(3, Arg7, countIntersections(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6)); }
	private void test_case_4() { int Arg0 = 20; int Arg1 = 6; int Arg2 = 1; int Arg3 = 211; int Arg4 = 13; int Arg5 = 11; int Arg6 = 186; long Arg7 = 862l; verify_case(4, Arg7, countIntersections(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ManhattanPatrol ___test = new ManhattanPatrol();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
