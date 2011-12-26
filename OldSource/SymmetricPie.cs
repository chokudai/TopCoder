using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SymmetricPie {
    public int getLines(int[] dogs)
    {
        int now = 0;
        int[] ar = new int[dogs.Length];
        int i;
        int res2 = 0;
        for (i = 0; i < ar.Length; i++) ar[i] = i;
        do
        {
            int[] dp = new int[50];
            dp[0] = 0;
            for (i = 0; i < dogs.Length; i++)
            {
                now += dogs[ar[i]];
                dp[now % 50] += 1;
            }
            int res = 0;
            for (i = 0; i < 50; i++) if (dp[i] >= 2) res++;
            res2 = Math.Max(res, res2);
        } while (Algorithm.next_permutation(ar));
        return res2;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{10,40,10,40}; int Arg1 = 2; verify_case(0, Arg1, getLines(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{10,50,40}; int Arg1 = 1; verify_case(1, Arg1, getLines(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{50,50}; int Arg1 = 1; verify_case(2, Arg1, getLines(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{1,48,1,1,48,1}; int Arg1 = 3; verify_case(3, Arg1, getLines(Arg0)); }
	private void test_case_4() { int[] Arg0 = new int[]{2,2,96}; int Arg1 = 0; verify_case(4, Arg1, getLines(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SymmetricPie ___test = new SymmetricPie();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}

public static partial class Algorithm
{
    public static bool next_permutation<T>(T[] array) where T : IComparable
    {
        return next_permutation(array, 0, array.Length);
    }

    public static bool next_permutation<T>(T[] array, int start, int length) where T : IComparable
    {
        int end = start + length - 1;
        if (end <= start) return false;
        int last = end;
        while (true)
        {
            int pos = last--;
            if (array[last].CompareTo(array[pos]) < 0)
            {
                int i;
                for (i = end + 1; array[last].CompareTo(array[--i]) >= 0; ) { }
                T tmp = array[last]; array[last] = array[i]; array[i] = tmp;
                Array.Reverse(array, pos, end - pos + 1);
                return true;
            }
            if (last == start)
            {
                //Array.Reverse(array, start, end - start);
                return false;
            }
        }
    }
}
