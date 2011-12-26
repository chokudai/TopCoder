using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ColoredStrokes {
    public int getLeast(string[] picture)
    {
        int i, j;
        int ret = 0;
        for (i = 0; i < picture.Length; i++)
        {
            bool pre = false;
            for (j = 0; j < picture[0].Length; j++)
            {
                if (picture[i][j] == 'R' || picture[i][j] == 'G')
                {
                    if (!pre)
                    {
                        pre = true;
                        ret++;
                    }
                }
                else
                {
                    pre = false;
                }
            }
        }
        for (j = 0; j < picture[0].Length; j++) 
        {
            bool pre = false;
            for (i = 0; i < picture.Length; i++)
            {
                if (picture[i][j] == 'B' || picture[i][j] == 'G')
                {
                    if (!pre)
                    {
                        pre = true;
                        ret++;
                    }
                }
                else
                {
                    pre = false;
                }
            }
        }

        return ret;
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
	private void test_case_0() { string[] Arg0 = new string[]{"...",
 "..."}; int Arg1 = 0; verify_case(0, Arg1, getLeast(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"..B.",
 "..B."}; int Arg1 = 1; verify_case(1, Arg1, getLeast(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{".BB."}; int Arg1 = 2; verify_case(2, Arg1, getLeast(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"...B..",
 ".BRGRR",
 ".B.B.."}; int Arg1 = 3; verify_case(3, Arg1, getLeast(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"...B..",
 ".BRBRR",
 ".B.B.."}; int Arg1 = 4; verify_case(4, Arg1, getLeast(Arg0)); }
	private void test_case_5() { string[] Arg0 = new string[]{"GR",
 "BG"}; int Arg1 = 4; verify_case(5, Arg1, getLeast(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ColoredStrokes ___test = new ColoredStrokes();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
