using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BestView {
    public int numberOfBuildings(int[] heights)
    {
        int i, j;
        int len = heights.Length;
        int result = 0;
        for (i = 0; i < len; i++)
        {
            int now = 0;
            double nowchange = -20000000000;
            for (j = i + 1; j < len; j++)
            {
                if (heights[i] + nowchange * (j - i) + 1e-9 < heights[j])
                {
                    now++;
                    nowchange = (heights[j] - heights[i]) * 1.0 / (j - i);
                }
            }
            nowchange = -20000000000;
            for (j = i - 1; j >= 0; j--)
            {
                if (heights[i] + nowchange * (i - j) + 1e-9 < heights[j])
                {
                    now++;
                    nowchange = (heights[j] - heights[i]) * 1.0 / (i - j);
                }
            }

            result = Math.Max(result, now);
        }
        return result;
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
	private void test_case_0() { int[] Arg0 = new int[]{10}; int Arg1 = 0; verify_case(0, Arg1, numberOfBuildings(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{5,5,5,5}; int Arg1 = 2; verify_case(1, Arg1, numberOfBuildings(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{1,2,7,3,2}; int Arg1 = 4; verify_case(2, Arg1, numberOfBuildings(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{1,5,3,2,6,3,2,6,4,2,5,7,3,1,5}; int Arg1 = 7; verify_case(3, Arg1, numberOfBuildings(Arg0)); }
	private void test_case_4() { int[] Arg0 = new int[]{1000000000,999999999,999999998,999999997,999999996,1,2,3,4,5}; int Arg1 = 6; verify_case(4, Arg1, numberOfBuildings(Arg0)); }
	private void test_case_5() { int[] Arg0 = new int[]{244645169,956664793,752259473,577152868,605440232,569378507,111664772,653430457,454612157,397154317}; int Arg1 = 7; verify_case(5, Arg1, numberOfBuildings(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BestView ___test = new BestView();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
