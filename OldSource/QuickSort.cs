using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class QuickSort {
    public double getEval(int[] L)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int i, j;
        int[] ar = (int[])L.Clone();
        Array.Sort(ar);
        for (i = 0; i < ar.Length; i++) dic[ar[i]] = i;
        double res = 0;
        for (i = 0; i < L.Length; i++)
        {
            for (j = i + 1; j < L.Length; j++)
            {
                if (L[i] > L[j])
                {
                    int diff = dic[L[i]] - dic[L[j]];
                    res += 1-(diff - 1) / (2.0 + diff - 1);
                    //Console.WriteLine((diff - 1) / (2.0 + diff - 1));
                }
            }
        }
        return res;
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
	private void test_case_0() { int[] Arg0 = new int[]{1,2,3,4,5}; double Arg1 = 0.0; verify_case(0, Arg1, getEval(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{1,2,4,3,5,6}; double Arg1 = 1.0; verify_case(1, Arg1, getEval(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{3,2,1}; double Arg1 = 2.6666666666666665; verify_case(2, Arg1, getEval(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{50,40,30,20,10,15,25,35,45}; double Arg1 = 11.07698412698413; verify_case(3, Arg1, getEval(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
QuickSort ___test = new QuickSort();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
