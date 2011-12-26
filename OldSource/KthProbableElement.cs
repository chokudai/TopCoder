using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class KthProbableElement {
    
    public double probability(int M, int lowerBound, int upperBound, int N, int K)
    {
        double[,] dpnow = new double[M+1, M+1];
        double[,] dpnext = new double[M+1, M+1];
        int i, j, k;
        double equ = 1.0 / (upperBound - lowerBound + 1);
        double down = equ * (N - lowerBound);
        double still = equ * (upperBound - N);
        dpnow[0, 0] = 1;
        for (k = 0; k < M; k++)
        {
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < M; j++)
                {
                    dpnext[i, j] += still * dpnow[i, j];
                    dpnext[i + 1, j + 1] += down * dpnow[i, j];
                    dpnext[i, j + 1] += equ * dpnow[i, j];
                }
            }
            for (i = 0; i <= M; i++)
            {
                for (j = 0; j <= M; j++)
                {
                    dpnow[i, j] = dpnext[i, j];
                    dpnext[i, j] = 0;
                }
            }
        }
        double res = 0;
        for (i = 0; i <= M; i++)
        {
            for (j = 0; j <= M; j++)
            {
                if (i < K && j >= K) res += dpnow[i, j];
            }
        }
        return res;
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
	private void test_case_0() { int Arg0 = 1; int Arg1 = 1; int Arg2 = 10; int Arg3 = 3; int Arg4 = 1; double Arg5 = 0.1; verify_case(0, Arg5, probability(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_1() { int Arg0 = 3; int Arg1 = 1; int Arg2 = 2; int Arg3 = 2; int Arg4 = 2; double Arg5 = 0.5; verify_case(1, Arg5, probability(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_2() { int Arg0 = 3; int Arg1 = 1; int Arg2 = 3; int Arg3 = 2; int Arg4 = 2; double Arg5 = 0.48148148148148145; verify_case(2, Arg5, probability(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_3() { int Arg0 = 10; int Arg1 = 1; int Arg2 = 10; int Arg3 = 1; int Arg4 = 10; double Arg5 = 1.0000000000000003E-10; verify_case(3, Arg5, probability(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_4() { int Arg0 = 4; int Arg1 = 61; int Arg2 = 65; int Arg3 = 62; int Arg4 = 3; double Arg5 = 0.15200000000000002; verify_case(4, Arg5, probability(Arg0, Arg1, Arg2, Arg3, Arg4)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
KthProbableElement ___test = new KthProbableElement();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
