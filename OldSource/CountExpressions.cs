using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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

public class CountExpressions {
    public int calcExpressions(int x, int y, int val)
    {
        if (x > y) return calcExpressions(y, x, val);
        int[] perm = new int[] { x, x, y, y };
        int res = 0;
        do
        {
            int i, j;
            for (i = 0; i < 27; i++)
            {
                int temp = i;
                int now = perm[0];
                for (j = 1; j <= 3; j++)
                {
                    int next = temp % 3; temp /= 3;
                    if (next == 0) now += perm[j];
                    else if (next == 1) now -= perm[j];
                    else if (next == 2) now *= perm[j];
                }
                if (now == val) res++;
            }
        } while (Algorithm.next_permutation<int>(perm));
        return res;
    }


// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 7; int Arg1 = 8; int Arg2 = 16; int Arg3 = 9; verify_case(0, Arg3, calcExpressions(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int Arg0 = 3; int Arg1 = 5; int Arg2 = 7; int Arg3 = 5; verify_case(1, Arg3, calcExpressions(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int Arg0 = 99; int Arg1 = 100; int Arg2 = 98010000; int Arg3 = 6; verify_case(2, Arg3, calcExpressions(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int Arg0 = -99; int Arg1 = 42; int Arg2 = -1764; int Arg3 = 2; verify_case(3, Arg3, calcExpressions(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int Arg0 = 100; int Arg1 = -100; int Arg2 = -100000000; int Arg3 = 0; verify_case(4, Arg3, calcExpressions(Arg0, Arg1, Arg2)); }
	private void test_case_5() { int Arg0 = 1; int Arg1 = 2; int Arg2 = 5; int Arg3 = 17; verify_case(5, Arg3, calcExpressions(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CountExpressions ___test = new CountExpressions();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
