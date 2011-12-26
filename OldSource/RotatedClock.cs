using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RotatedClock {
    public string getEarliest(int hourHand, int minuteHand)
    {
        int i, j;
        for (i = 0; i < 60 * 12; i++)
        {
            for (j = 0; j < 12; j++)
            {
                int m = (minuteHand + j * 30) % 360;
                int h = (hourHand + j * 30) % 360;
                int t1 = h / 30;
                int t2 = (h % 30) * 2;
                if (t2 * 6 != m) continue;
                string s1 = t1.ToString();
                if (s1.Length == 1) s1 = "0" + s1;
                string s2 = t2.ToString();
                if (s2.Length == 1) s2 = "0" + s2;
                return s1 + ":" + s2;
            }
        }
        return "";
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 70; int Arg1 = 300; string Arg2 = "08:20"; verify_case(0, Arg2, getEarliest(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 90; int Arg1 = 120; string Arg2 = "11:00"; verify_case(1, Arg2, getEarliest(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 240; int Arg1 = 36; string Arg2 = ""; verify_case(2, Arg2, getEarliest(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 19; int Arg1 = 19; string Arg2 = ""; verify_case(3, Arg2, getEarliest(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 1; int Arg1 = 12; string Arg2 = "00:02"; verify_case(4, Arg2, getEarliest(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
RotatedClock ___test = new RotatedClock();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
