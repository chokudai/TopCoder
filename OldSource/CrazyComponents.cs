using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CrazyComponents {
    public double expectedProfit(int K, string[] components, int[] income, int[] expense)
    {
        int len = expense.Length;
        int i, j,k;
        double[] dp = new double[1 << len];
        int[] need = new int[len];
        for (i = 0; i < len; i++)
        {
            string[] s = components[i].Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
            foreach (string ss in s)
            {
                need[i] |= (1 << int.Parse(ss));
            }
        }
        for (k = 0; k < K; k++)
        {
            double[] nextdp = new double[1 << len];
            for (i = 0; i < (1 << len); i++)
            {
                for (j = 0; j < len; j++)
                {
                    if ((need[j] & i) != need[j]) nextdp[i] += dp[i] * 1.0 / len;
                    else nextdp[i] += Math.Max(dp[i] * 1.0 / len, (dp[i | (1 << j)] + income[j] - expense[j]) * 1.0 / len);
                }
            }
            dp = (double[])nextdp.Clone();
        }
        return dp[0];
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
	private void test_case_0() { int Arg0 = 1; string[] Arg1 = new string[]{ "", "" }; int[] Arg2 = new int[]{ 1, 2 }; int[] Arg3 = new int[]{ 0, 0 }; double Arg4 = 1.5; verify_case(0, Arg4, expectedProfit(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int Arg0 = 2; string[] Arg1 = new string[]{ "1", "" }; int[] Arg2 = new int[]{ 10, 0 }; int[] Arg3 = new int[]{ 0, 2 }; double Arg4 = 1.5; verify_case(1, Arg4, expectedProfit(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int Arg0 = 3; string[] Arg1 = new string[]{ "1 2", "", "" }; int[] Arg2 = new int[]{ 100, 0, 0 }; int[] Arg3 = new int[]{ 0, 0, 0 }; double Arg4 = 7.407407407407408; verify_case(2, Arg4, expectedProfit(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int Arg0 = 5; string[] Arg1 = new string[]{ "1", "2", "0", "" }; int[] Arg2 = new int[]{ 4, 5, 6, 7 }; int[] Arg3 = new int[]{ 0, 0, 0, 8 }; double Arg4 = 0.0; verify_case(3, Arg4, expectedProfit(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_4() { int Arg0 = 10; string[] Arg1 = new string[]{ "", "", "", "", "", "", "", "", "", "" }; int[] Arg2 = new int[]{ 142352, 2342, 34534, 2344, 12346, 7589, 79872, 973453, 96233, 34567 }; int[] Arg3 = new int[]{ 12432, 2345, 3678, 456, 345, 457, 56758, 4564, 774, 34567 }; double Arg4 = 1269258.9999999998; verify_case(4, Arg4, expectedProfit(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CrazyComponents ___test = new CrazyComponents();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
