using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MirrorNumber {

    long A, B;
    static int memoMAX = 18;
    long[] memo = new long[memoMAX];
    public int count(string _A, string _B)
    {
        int i;
        memo[0] = 1;
        for (i = 1; i < memoMAX; i++) memo[i] = memo[i - 1] * 10;
        A = long.Parse(_A);
        B = long.Parse(_B);
        return calc(0, 0, 0);
    }

    int[] numa = new int[] { 0, 1, 2, 5, 8 };
    int[] numb = new int[] { 0, 1, 5, 2, 8 };

    int[] numc = new int[] { 0, 1, 8 };
    int calc(long a, long b, int num)
    {
        //Console.WriteLine("now:" + a + " " + b);
        int res = 0;
        long now = a * memo[num] + b;
        if (num != 0)
        {
            if ((a * 1.0 * memo[num] + b) * 0.99 > B) return 0;
            if (now > B) return 0;
            if (now <= B && now >= A)
            {
                //Console.WriteLine(now);
                res++;
            }
        }
        int i;
        for (i = 0; i < numa.Length; i++)
        {
            if (num == 0 && i == 0) continue;
            res += calc(a * 10 + numa[i], numb[i] * memo[num] + b, num + 1);
        }
        for (i = 0; i < numc.Length; i++)
        {
            now = a * memo[num] * 10 + numc[i] * memo[num] + b;
            if ((a * 1.0 * memo[num] * 10 + numc[i] * memo[num] + b) * 0.99 > B) continue;
            if (now <= B && now >= A)
            {
                res++;
            }
        }
        return res;
    }



    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string Arg0 = "0"; string Arg1 = "10"; int Arg2 = 3; verify_case(0, Arg2, count(Arg0, Arg1)); }
	private void test_case_1() { string Arg0 = "0"; string Arg1 = "100"; int Arg2 = 7; verify_case(1, Arg2, count(Arg0, Arg1)); }
	private void test_case_2() { string Arg0 = "143"; string Arg1 = "23543"; int Arg2 = 54; verify_case(2, Arg2, count(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        MirrorNumber ___test = new MirrorNumber();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
