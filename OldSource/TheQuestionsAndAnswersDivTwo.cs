using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheQuestionsAndAnswersDivTwo {
    public int find(string[] questions)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        foreach (string s in questions) dic[s] = 1;
        return 1 << dic.Count;
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
	private void test_case_0() { string[] Arg0 = new string[]{"How_are_you_doing?", "How_do_you_like_our_country?", "How_are_you_doing?"}; int Arg1 = 4; verify_case(0, Arg1, find(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"Whazzup?"}; int Arg1 = 2; verify_case(1, Arg1, find(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"Are_you_ready?", "Are_you_ready?", "Are_you_ready?", "Are_you_ready?"}; int Arg1 = 2; verify_case(2, Arg1, find(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"Do_you_like_my_story?", "Do_you_like_my_story", "DO_YOU_LIKE_MY_STORY?", "Do__you__like__my__story?"}; int Arg1 = 16; verify_case(3, Arg1, find(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheQuestionsAndAnswersDivTwo ___test = new TheQuestionsAndAnswersDivTwo();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
