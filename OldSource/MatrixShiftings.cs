using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MatrixShiftings {
    public int minimumShifts(string[] matrix, int value)
    {
        int i, j;
        int res = 1000;
        for (i = 0; i < matrix.Length; i++)
        {
            for (j = 0; j < matrix[0].Length; j++)
            {
                if (int.Parse(matrix[i][j] + "") == value)
                {
                    res = Math.Min(res, Math.Min(i, matrix.Length - i) + Math.Min(j, matrix[0].Length - j));
                }
            }
        }
        if (res == 1000) return -1;
        return res;
        
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
	private void test_case_0() { string[] Arg0 = new string[]{"136",
 "427",
 "568",
 "309"}; int Arg1 = 2; int Arg2 = 2; verify_case(0, Arg2, minimumShifts(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"0000",
 "0000",
 "0099"}; int Arg1 = 9; int Arg2 = 2; verify_case(1, Arg2, minimumShifts(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"0123456789"}; int Arg1 = 7; int Arg2 = 3; verify_case(2, Arg2, minimumShifts(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"555",
 "555"}; int Arg1 = 1; int Arg2 = -1; verify_case(3, Arg2, minimumShifts(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"12417727123",
 "65125691886",
 "55524912622",
 "12261288888"}; int Arg1 = 9; int Arg2 = 6; verify_case(4, Arg2, minimumShifts(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MatrixShiftings ___test = new MatrixShiftings();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
