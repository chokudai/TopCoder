using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BouncingBalls {
    public double expectedBounces(int[] x, int T)
    {
        Array.Sort(x);
        int len = x.Length;
        int i, j;
        for (i = 0; i < len; i++) x[i] *= 2;
        T *= 2;
        long res = 0;
        for (i = 0; i < (1<<len); i++)
        {
            int now = i;
            int nokori = T;
            int[] xnow = (int[])x.Clone();
            while (true)
            {
                int best = nokori + 1;
                int pos = -1;
                for (j = 0; j < len - 1; j++)
                {
                    if ((now >> j) % 4 == 2)
                    {
                        if ((xnow[j + 1] - xnow[j]) / 2 < best)
                        {
                            best = (xnow[j + 1] - xnow[j]) / 2;
                            pos = j;
                        }
                    }
                }
                if (pos == -1) break;
                for (j = 0; j < len; j++)
                {
                    if (((now >> j) & 1) == 0)
                    {
                        xnow[j] += best;
                    }
                    else xnow[j] -= best;
                }
                res++;
                nokori -= best;
                now ^= (3 << pos);
            }
        }
        return res * 1.0 / (1 << len);
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{5, 8}; int Arg1 = 2; double Arg2 = 0.25; verify_case(0, Arg2, expectedBounces(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{5, 8}; int Arg1 = 1; double Arg2 = 0.0; verify_case(1, Arg2, expectedBounces(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{91, 857, 692, 54, 8679, 83, 792, 86, 9537, 913, 64, 592}; int Arg1 = 458; double Arg2 = 11.5; verify_case(2, Arg2, expectedBounces(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{75432}; int Arg1 = 386; double Arg2 = 0.0; verify_case(3, Arg2, expectedBounces(Arg0, Arg1)); }
	private void test_case_4() { int[] Arg0 = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}; int Arg1 = 3; double Arg2 = 12.75; verify_case(4, Arg2, expectedBounces(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BouncingBalls ___test = new BouncingBalls();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
