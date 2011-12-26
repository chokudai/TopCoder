using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RectangularGrid {
    public long countRectangles(int width, int height)
    {
        long count = 0;
        int i, j;
        for (i = 1; i <= width; i++)
        {
            for (j = 1; j <= height; j++)
            {
                if (i == j) continue;
                count += ((long)width + 1 - i) * ((long)height + 1 - j);
            }
        }
        return count;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 3; int Arg1 = 3; long Arg2 = 22l; verify_case(0, Arg2, countRectangles(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 5; int Arg1 = 2; long Arg2 = 31l; verify_case(1, Arg2, countRectangles(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 10; int Arg1 = 10; long Arg2 = 2640l; verify_case(2, Arg2, countRectangles(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 1; int Arg1 = 1; long Arg2 = 0l; verify_case(3, Arg2, countRectangles(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 592; int Arg1 = 964; long Arg2 = 81508708664l; verify_case(4, Arg2, countRectangles(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
RectangularGrid ___test = new RectangularGrid();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
