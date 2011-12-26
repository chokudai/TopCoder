using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RandomSort {
    Dictionary<long, double> dic;
    public double getExpected(int[] permutation)
    {
        dic = new Dictionary<long, double>();
        dic[87654321] = 0;
        return saiki(permutation);
    }

    double saiki(int[] permutation)
    {
        long sum = 0;
        int now = 1;
        int i,j;
        for (i = 0; i < permutation.Length; i++)
        {
            sum += now * permutation[i];
            now *= 10;
        }
        if (dic.ContainsKey(sum)) return dic[sum];
        int count = 0;
        double res = 0;
        for (i = 0; i < permutation.Length; i++)
        {
            for (j = i+1; j < permutation.Length; j++)
            {
                if (permutation[i] > permutation[j])
                {
                    count++;
                    int[] next = (int[])permutation.Clone();
                    next[i] = permutation[j];
                    next[j] = permutation[i];
                    res += saiki(next) + 1;
                }
            }
        }
        if (count == 0) return 0;
        return dic[sum] = (res / count);

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
	private void test_case_0() { int[] Arg0 = new int[]{1,3,2}; double Arg1 = 1.0; verify_case(0, Arg1, getExpected(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{4,3,2,1}; double Arg1 = 4.066666666666666; verify_case(1, Arg1, getExpected(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{1}; double Arg1 = 0.0; verify_case(2, Arg1, getExpected(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{2,5,1,6,3,4}; double Arg1 = 5.666666666666666; verify_case(3, Arg1, getExpected(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
RandomSort ___test = new RandomSort();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
