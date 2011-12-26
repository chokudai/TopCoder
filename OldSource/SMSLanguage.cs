using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SMSLanguage {
    public string translate(string text)
    {
        text = text.Replace(".", "");
        text = text.Replace(",", "");
        text = text.Replace("!", "");
        text = text.Replace("?", "");
        text = text.ToLower();
        text = text.Replace("and", "&");
        text = text.Replace("ate", "8");
        text = text.Replace("at", "@");
        text = text.Replace("you", "U");
        return text;
    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string Arg0 = "I HATE rats, and you?"; string Arg1 = "i h8 r@s & U"; verify_case(0, Arg1, translate(Arg0)); }
	private void test_case_1() { string Arg0 = "What is the weather like today?"; string Arg1 = "wh@ is the we@her like today"; verify_case(1, Arg1, translate(Arg0)); }
	private void test_case_2() { string Arg0 = "It is not too late to.."; string Arg1 = "it is not too l8 to"; verify_case(2, Arg1, translate(Arg0)); }
	private void test_case_3() { string Arg0 = "this text is already in sms language"; string Arg1 = "this text is already in sms language"; verify_case(3, Arg1, translate(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SMSLanguage ___test = new SMSLanguage();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
