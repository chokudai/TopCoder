using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RemissiveSwaps {
    bool[] b;
    int[] num = new int[8];
    public int findMaximum(int N)
    {
        int MAX = 2000000;
        b = new bool[MAX];
        int i;
        num[0] = 1;
        for (i = 1; i < 8; i++) num[i] = num[i - 1] * 10;
        calc(N);
        for (i = MAX - 1; i >= 0; i--) if (b[i]) return i;
        return 0;
    }

    void calc(int n)
    {
        if (b[n]) return;
        b[n] = true;
        int i, j;
        for (i = 0; i < 8; i++)
        {
            int a = n / num[i] % 10;
            if (a == 0) continue;
            for (j = i + 1; j < 8; j++)
            {
                int c = n / num[j] % 10;
                if (a == 1 && n / num[j] < 10) continue;
                if (c == 0) continue;
                int next = n - a * num[i] - c * num[j] + (a - 1) * num[j] + (c - 1) * num[i];
                //Console.WriteLine(n + " " + next);
                calc(next);
            }
        }
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
	private void test_case_0() { int Arg0 = 166; int Arg1 = 560; verify_case(0, Arg1, findMaximum(Arg0)); }
	private void test_case_1() { int Arg0 = 3499; int Arg1 = 8832; verify_case(1, Arg1, findMaximum(Arg0)); }
	private void test_case_2() { int Arg0 = 34199; int Arg1 = 88220; verify_case(2, Arg1, findMaximum(Arg0)); }
	private void test_case_3() { int Arg0 = 809070; int Arg1 = 809070; verify_case(3, Arg1, findMaximum(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        RemissiveSwaps ___test = new RemissiveSwaps();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
