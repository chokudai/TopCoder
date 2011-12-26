using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CandyBox {
    int len;
    double[,] first;


    public double[] expectedScore(int C, int[] score, int S)
    {
        int i, j;
        len = score.Length;
        //if (score.Length == 1) return score;
        double[,] dp = new double[len, len];
        first = new double[len, len];
        int sum = C * len;
        double choose = 2.0 / sum;
        double[,] dp2 = new double[len, len];
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                if (i == j)
                {
                    dp[i, j] = C;
                    dp2[i, j] = (1 - choose) + choose * ((C - 1.0) / (sum - 1));
                    first[i,j] = 1;
                }
                else
                {
                    dp[i, j] = 0;
                    dp2[i, j] = choose * ((double)C / (sum - 1));
                    first[i,j] = 0;
                }
            }
        }
        double[,] memo2 = pow(first, dp2, S);
        double[,] memo = mul(dp, memo2);
        double[] res = new double[len];
        for (i = 0; i < len; i++)
        {
            res[i] = 0;
            for (j = 0; j < len; j++)
            {
                res[i] += memo[i, j] * score[j];
            }
            res[i] /= C;
        }
        return res;
    }


    double[,] pow(double[,] a, double[,] b, int p)
    {
        if (p == 0) return a;
        else if (p == 1) return mul(a, b);
        if (p % 2 == 0)
        {
            double[,] next = mul(b, b);
            return pow(a, next, p / 2);
        }
        else
        {
            double[,] next = mul(a, b);
            return pow(next, b, p - 1);
        }
    }

    double[,] mul(double[,] a, double[,] b)
    {
        int i, j, k;
        double[,] res = new double[len, len];
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                res[i, j] = 0;
                for (k = 0; k < len; k++)
                {
                    res[i, j] += a[i, k] * b[k, j];
                }
            }
        }
        return res;
    }

    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, double[] Expected, double[] Received) {
		Console.Write("Test Case #" + Case + "...");
		if (equal_arrays(Expected, Received)) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: " + print_array(Expected)); 
			Console.WriteLine("\tReceived: " + print_array(Received)); } }
	string print_array(double[] V) {
		System.Text.StringBuilder builder = new System.Text.StringBuilder();
		builder.Append("{ ");
		foreach (double o in V) {
			builder.Append('\"');
			builder.Append(o.ToString());
			builder.Append("\",");
		}
		builder.Append(" }");
		return builder.ToString();
	}
	bool equal_arrays(double[] a, double[]b) {
		if (a.Length != b.Length) return false;
		for (int i = 0; i < a.Length; ++i) if (a[i] != b[i]) return false;
		return true;
	}
	private void test_case_0() { int Arg0 = 10; int[] Arg1 = new int[]{1, 10}; int Arg2 = 0; double[] Arg3 = new double[]{1.0, 10.0 }; verify_case(0, Arg3, expectedScore(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int Arg0 = 2; int[] Arg1 = new int[]{1, 10}; int Arg2 = 1; double[] Arg3 = new double[]{4.0, 7.000000000000001 }; verify_case(1, Arg3, expectedScore(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int Arg0 = 1; int[] Arg1 = new int[]{1, 4, 10}; int Arg2 = 1; double[] Arg3 = new double[]{5.0, 5.0, 5.0 }; verify_case(2, Arg3, expectedScore(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int Arg0 = 98; int[] Arg1 = new int[]{13, 82, 74, 78, 12, 71, 81, 80, 30}; int Arg2 = 154; double[] Arg3 = new double[]{26.25622829378155, 74.87969915903301, 69.24219529059805, 72.06094722481552, 25.551540310227182, 67.12813133993495, 74.17501117547864, 73.47032319192427, 38.23592401420582 }; verify_case(3, Arg3, expectedScore(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CandyBox ___test = new CandyBox();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
