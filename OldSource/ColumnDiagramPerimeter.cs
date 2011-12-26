using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ColumnDiagramPerimeter {
    public int getPerimiter(int[] a)
    {
        int i;
        int len = a.Length;
        int ret = 0;
        for (i = 0; i < len - 1; i++)
        {
            ret += Math.Abs(a[i + 1] - a[i]);
        }
        ret += 2 * a.Length;
        ret += a[0];
        ret += a[len - 1];
        return ret;
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
	private void test_case_0() { int[] Arg0 = new int[]{2,3,5,6,1}; int Arg1 = 22; verify_case(0, Arg1, getPerimiter(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{3,2,1}; int Arg1 = 12; verify_case(1, Arg1, getPerimiter(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{2,2}; int Arg1 = 8; verify_case(2, Arg1, getPerimiter(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{1,2,1}; int Arg1 = 10; verify_case(3, Arg1, getPerimiter(Arg0)); }
	private void test_case_4() { int[] Arg0 = new int[]{1,2,3}; int Arg1 = 12; verify_case(4, Arg1, getPerimiter(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ColumnDiagramPerimeter ___test = new ColumnDiagramPerimeter();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
