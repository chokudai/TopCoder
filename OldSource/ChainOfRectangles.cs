using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ChainOfRectangles {
    public int getMaximalArea(int[] width, int[] height, string color)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        dic['R'] = 0;
        dic['G'] = 1;
        dic['B'] = 2;
        int i;
        int pre = 0;
        int[] res = new int[3];
        for (i = width.Length - 1; i >= 0; i--)
        {
            res[dic[color[i]]] += width[i] * height[i] - pre;
            pre = width[i] * height[i];
        }
        int max = 0;
        for (i = 0; i < 3; i++) max = Math.Max(max, res[i]);
        return max;
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
	private void test_case_0() { int[] Arg0 = new int[]{10000}; int[] Arg1 = new int[]{10000}; string Arg2 = "R"; int Arg3 = 100000000; verify_case(0, Arg3, getMaximalArea(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int[] Arg0 = new int[]{10, 5}; int[] Arg1 = new int[]{10, 5}; string Arg2 = "GB"; int Arg3 = 75; verify_case(1, Arg3, getMaximalArea(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int[] Arg0 = new int[]{10, 9}; int[] Arg1 = new int[]{8, 7}; string Arg2 = "GB"; int Arg3 = 63; verify_case(2, Arg3, getMaximalArea(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int[] Arg0 = new int[]{10, 8, 6, 4, 2}; int[] Arg1 = new int[]{9, 7, 5, 3, 1}; string Arg2 = "GBRRG"; int Arg3 = 36; verify_case(3, Arg3, getMaximalArea(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ChainOfRectangles ___test = new ChainOfRectangles();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
