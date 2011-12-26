using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BalanceScale {
    public int takeWeights(int[] weight)
    {
        int i, j, k;
        int now = weight[0];
        int len = weight.Length;
        for (i = 1; i < len; i++) now = gcd(now, weight[i]);
        for (i = 0; i < len; i++) weight[i] /= now;
        Dictionary<int, bool>[] dic = new Dictionary<int, bool>[len + 1];
        for (k = 0; k < len; k++) dic[k] = new Dictionary<int, bool>();
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                if (j == 0)
                {
                    dic[j][weight[i]] = true;
                }
                else
                {
                    foreach (int a in dic[j-1].Keys)
                    {
                        dic[j][gcd(a, weight[i])] = true;
                    }
                }
            }
        }
        for (k = 0; k < len; k++) if (dic[k].ContainsKey(1)) return k + 1;
        return -1;
    }

    int gcd(int a, int b)
    {
        if (b == 0) return a;
        return gcd(b, a % b);
    }


// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{ 5, 4, 1, 8 }; int Arg1 = 1; verify_case(0, Arg1, takeWeights(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{ 2, 3, 8, 9 }; int Arg1 = 2; verify_case(1, Arg1, takeWeights(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{ 60, 105, 490, 42 }; int Arg1 = 4; verify_case(2, Arg1, takeWeights(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{ 15, 25, 9 }; int Arg1 = 2; verify_case(3, Arg1, takeWeights(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BalanceScale ___test = new BalanceScale();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
