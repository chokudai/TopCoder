using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ChatTranscript {
    public int howMany(string[] transcript, string name)
    {
        int i, res = 0;
        name = name + ":";
        for (i = 0; i < transcript.Length; i++)
        {
            if (transcript[i].IndexOf(name) == 0) res++;
        }
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
	private void test_case_0() { string[] Arg0 = new string[]{
"Bob: Hello Tim.",
"Tim: Hello Bob.",
"Bob: How are ya Tim?",
"Frank: Stop chatting!"
}; string Arg1 = "Bob"; int Arg2 = 2; verify_case(0, Arg2, howMany(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{
"Bob: This is a long",
"sentence that takes 2 lines.",
"Tim: Yes it is.",
"Bob : I am not Bob.",
"Frank: No you aren't!",
" Bob: Neither am I."
}; string Arg1 = "Bob"; int Arg2 = 1; verify_case(1, Arg2, howMany(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{
"Crazy1010: !@LK%#L%K @#L%K @#L%K@#L%K2kl53k2",
"Bob: You are crazy.",
"Crazy1010 Yup #@LK%$L!K%LK%!K% !K afmas,"
}; string Arg1 = "Crazy1010"; int Arg2 = 1; verify_case(2, Arg2, howMany(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{
"A:A:A:A:A:A:A:A:A",
"b:b:b:b:b:b:b:b:b"
}; string Arg1 = "B"; int Arg2 = 0; verify_case(3, Arg2, howMany(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"A:A:A:A:A:A:A:A:A"}; string Arg1 = "A"; int Arg2 = 1; verify_case(4, Arg2, howMany(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ChatTranscript ___test = new ChatTranscript();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
