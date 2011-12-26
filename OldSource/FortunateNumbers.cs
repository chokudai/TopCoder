using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FortunateNumbers {
    public int getFortunate(int[] a, int[] b, int[] c)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        foreach (int d in a)
        {
            foreach (int e in b)
            {
                foreach (int f in c)
                {
                    if (ok(d + e + f)) dic[d + e + f] = 1;
                }
            }
        }
        return dic.Count;
    }

    bool ok(int a)
    {
        if (a == 0) return false;
        while (a != 0)
        {
            if (a % 10 != 8 && a % 10 != 5) return false;
            a /= 10;
        }
        return true;
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
	private void test_case_0() { int[] Arg0 = new int[]{ 1, 10, 100 }; int[] Arg1 = new int[]{ 3, 53 }; int[] Arg2 = new int[]{ 4, 54 }; int Arg3 = 2; verify_case(0, Arg3, getFortunate(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int[] Arg0 = new int[]{ 47 }; int[] Arg1 = new int[]{ 500 }; int[] Arg2 = new int[]{ 33 }; int Arg3 = 0; verify_case(1, Arg3, getFortunate(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int[] Arg0 = new int[]{ 100, 1, 10, 100, 1, 1 }; int[] Arg1 = new int[]{ 3, 53, 53, 53, 53, 53, 53 }; int[] Arg2 = new int[]{ 4, 54, 4, 54, 4, 54 }; int Arg3 = 2; verify_case(2, Arg3, getFortunate(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int[] Arg0 = new int[]{ 500, 800 }; int[] Arg1 = new int[]{ 50, 80 }; int[] Arg2 = new int[]{ 5, 8 }; int Arg3 = 8; verify_case(3, Arg3, getFortunate(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int[] Arg0 = new int[]{ 30000, 26264 }; int[] Arg1 = new int[]{ 30000, 29294 }; int[] Arg2 = new int[]{ 30000, 29594 }; int Arg3 = 3; verify_case(4, Arg3, getFortunate(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
FortunateNumbers ___test = new FortunateNumbers();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
