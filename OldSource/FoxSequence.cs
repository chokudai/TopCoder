using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FoxSequence {
    public string isValid(int[] seq)
    {
        int now = 0;
        int i;
        int pre = seq[0];
        int count = 0;
        int plus = 0;
        for (i = 1; i < seq.Length; i++)
        {
            if (now == 0)
            {
                if (seq[i] > pre)
                {
                    if (count == 0) plus = seq[i] - pre;
                    else if (plus != seq[i] - pre) return "NO";
                    count++;
                }
                else if (seq[i] == pre) return "NO";
                else
                {
                    if (count == 0) return "NO";
                    plus = seq[i] - pre;
                    count = 1;
                    now++;
                }
                
            }
            else if (now == 1)
            {
                if (seq[i] < pre)
                {
                    if (count == 0) plus = seq[i] - pre;
                    else if (plus != seq[i] - pre) return "NO";
                    count++;
                }
                else if (seq[i] == pre)
                {
                    if (count == 0) return "NO";
                    count = 1;
                    now = 2;
                }
                else
                {
                    if (count == 0) return "NO";
                    count = 1;
                    plus = seq[i] - pre;
                    now = 3;
                }
            }
            else if (now == 2)
            {
                if (seq[i] == pre)
                {
                    count++;
                }
                else if (seq[i] < pre) return "NO";
                else
                {
                    plus = seq[i] - pre;
                    count = 1;
                    now = 3;
                }
            }
            else if (now == 3)
            {
                if (seq[i] > pre)
                {
                    if (count == 0) plus = seq[i] - pre;
                    else if (plus != seq[i] - pre) return "NO";
                    count++;
                }
                else if (seq[i] == pre) return "NO";
                else
                {
                    if (count == 0) return "NO";
                    count = 1;
                    plus = seq[i] - pre;
                    now = 4;
                }
            }
            else if (now == 4)
            {
                if (seq[i] < pre)
                {
                    if (count == 0) plus = seq[i] - pre;
                    else if (plus != seq[i] - pre) return "NO";
                    count++;
                }
                else if (seq[i] == pre)
                {
                    return "NO";
                }
                else
                {
                    return "NO";
                }
            }
            pre = seq[i];
        }
        if (now == 4 && count != 0) return "YES";
        else return "NO";
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{1,3,5,7,5,3,1,1,1,3,5,7,5,3,1}
; string Arg1 = "YES"; verify_case(0, Arg1, isValid(Arg0)); }
	private void test_case_1() { int[] Arg0 = new int[]{1,2,3,4,5,4,3,2,2,2,3,4,5,6,4}
; string Arg1 = "YES"; verify_case(1, Arg1, isValid(Arg0)); }
	private void test_case_2() { int[] Arg0 = new int[]{3,6,9,1,9,5,1}
; string Arg1 = "YES"; verify_case(2, Arg1, isValid(Arg0)); }
	private void test_case_3() { int[] Arg0 = new int[]{1,2,3,2,1,2,3,2,1,2,3,2,1}
; string Arg1 = "NO"; verify_case(3, Arg1, isValid(Arg0)); }
	private void test_case_4() { int[] Arg0 = new int[]{1,3,4,3,1,1,1,1,3,4,3,1}
; string Arg1 = "NO"; verify_case(4, Arg1, isValid(Arg0)); }
	private void test_case_5() { int[] Arg0 = new int[]{6,1,6}
; string Arg1 = "NO"; verify_case(5, Arg1, isValid(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
FoxSequence ___test = new FoxSequence();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
