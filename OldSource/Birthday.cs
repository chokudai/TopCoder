using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Birthday {
    public string getNext(string date, string[] birthdays)
    {
        Array.Sort(birthdays);
        foreach (string s in birthdays) if (date.CompareTo(s) <= 0) return s.Split(' ')[0];
        return birthdays[0].Split(' ')[0];
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
	private void test_case_0() { string Arg0 = "06/17"; string[] Arg1 = new string[]{"02/17 Wernie", "10/12 Stefan"}; string Arg2 = "10/12"; verify_case(0, Arg2, getNext(Arg0, Arg1)); }
	private void test_case_1() { string Arg0 = "06/17"; string[] Arg1 = new string[]{"10/12 Stefan"}; string Arg2 = "10/12"; verify_case(1, Arg2, getNext(Arg0, Arg1)); }
	private void test_case_2() { string Arg0 = "02/17"; string[] Arg1 = new string[]{"02/17 Wernie", "10/12 Stefan"}; string Arg2 = "02/17"; verify_case(2, Arg2, getNext(Arg0, Arg1)); }
	private void test_case_3() { string Arg0 = "12/24"; string[] Arg1 = new string[]{"10/12 Stefan"}; string Arg2 = "10/12"; verify_case(3, Arg2, getNext(Arg0, Arg1)); }
	private void test_case_4() { string Arg0 = "01/02"; string[] Arg1 = new string[]{"02/17 Wernie",
 "10/12 Stefan",
 "02/17 MichaelJordan",
 "10/12 LucianoPavarotti",
 "05/18 WilhelmSteinitz"}; string Arg2 = "02/17"; verify_case(4, Arg2, getNext(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Birthday ___test = new Birthday();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
