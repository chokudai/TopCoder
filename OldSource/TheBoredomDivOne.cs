using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheBoredomDivOne {
    double[] dp;
    int sum;
    public double find(int n, int m)
    {
        int i;
        dp = new double[m + 1];
        sum = n + m;
        for (i = 0; i < dp.Length; i++) dp[i] = -1;
        return saiki(m);
    }

    double saiki(int m)
    {
        if (dp[m] >= 0) return dp[m];
        if (m == 0) return 0;
        int i;
        int n = sum - m;
        double a = 0, b = 0; //aÇ™ÇPêlå∏ÇÈÅ@bÇ™ÇQêlå∏ÇÈ
        double res = 0;
        if (true)
        {
            //ÇPêlå∏ÇÈÇœÇΩÅ[ÇÒ
            a = ((double)n / sum) * ((double)m / (sum - 1));
            a += ((double)n / (sum - 1)) * ((double)m / (sum));
            res += saiki(m - 1) * a;
        }
        if (m != 1)
        {
            //ÇQêlå∏ÇÈÇœÇΩÅ[ÇÒ
            b = ((double)m / sum) * ((double)(m - 1) / (sum - 1));
            res += saiki(m - 2) * b;
        }
        res /= a + b;
        res += 1 / (a + b);
        return dp[m] = res;
    }



// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 1; int Arg1 = 1; double Arg2 = 1.0; verify_case(0, Arg2, find(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 2; int Arg1 = 1; double Arg2 = 1.5; verify_case(1, Arg2, find(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 1; int Arg1 = 2; double Arg2 = 2.0; verify_case(2, Arg2, find(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 4; int Arg1 = 7; double Arg2 = 13.831068977298521; verify_case(3, Arg2, find(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheBoredomDivOne ___test = new TheBoredomDivOne();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
