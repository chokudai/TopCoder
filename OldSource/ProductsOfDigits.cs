using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ProductsOfDigits {
    public long firstOccurrence(int[] prod)
    {
        int i,j;
        long res = long.MaxValue;
        int len = prod.Length;
        for (i = 1; i < 20000; i++)
        {
            for (j = 0; j < len; j++)
            {
                if (prod[j] != P(i + j)) break;
            }
            if (j == len) return i;
        }
        for (i = 1; i < 10000; i++)
        {
            long kakeru = -1;
            for (j = 0; j < len; j++)
            {
                long now = P(i + j);
                if (i + j < 1000) now = 0;
                if (i + j > 10000) now = 0;

                if (prod[j] == 0)
                {
                    if (now == 0) continue;
                    else break;
                }
                else
                {
                    if (now == 0) break;
                    if (kakeru != -1)
                    {
                        if (prod[j] != now * kakeru) break;
                    }
                    else
                    {
                        if (prod[j] % now != 0) break;
                        kakeru = prod[j] / now;
                    }
                }
            }
            if (j == len)
            {
                res = Math.Min(res, getnum(i, kakeru));
            }
        }
        //Console.WriteLine(long.MaxValue);
        return res;
    }

    long P(int a)
    {
        long res = 1;
        while (a != 0)
        {
            res *= a % 10;
            a /= 10;
        }
        return res;
    }

    long getnum(int a, long kake)
    {
        if (kake == -1) kake = 1;
        long kakeru = 10000;
        long res = a;
        int i;
        for (i = 9; i >= 2; i--)
        {
            while (kake % i == 0)
            {
                if (kakeru > long.MaxValue / i) return long.MaxValue;
                res += kakeru * i;
                kake /= i;
                if (kake == 1) break;
                if (kakeru > long.MaxValue / 10) return long.MaxValue;
                kakeru *= 10;
            }
        }
        if (kake != 1) return long.MaxValue; 
        return res;
    }



// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); if ((Case == -1) || (Case == 6)) test_case_6(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{1, 2, 3, 4, 5}; long Arg1 = 1l; verify_case(0, Arg1, firstOccurrence(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{9, 0, 1}; long Arg1 = 9l; verify_case(1, Arg1, firstOccurrence(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{0, 0, 0, 0}; long Arg1 = 100l; verify_case(2, Arg1, firstOccurrence(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{288}; long Arg1 = 489l; verify_case(3, Arg1, firstOccurrence(Arg0)); }
	private void test_case_4() { int[] Arg0 = new int[]{108864, 127008, 145152, 163296, 0, 22680, 45360, 68040, 90720}; long Arg1 = 789946l; verify_case(4, Arg1, firstOccurrence(Arg0)); }
	private void test_case_5() { int[] Arg0 = new int[]{1}; long Arg1 = 1l; verify_case(5, Arg1, firstOccurrence(Arg0)); }
	private void test_case_6() { int[] Arg0 = new int[]{0, 1, 2, 3, 4, 5}; long Arg1 = 10l; verify_case(6, Arg1, firstOccurrence(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ProductsOfDigits ___test = new ProductsOfDigits();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
