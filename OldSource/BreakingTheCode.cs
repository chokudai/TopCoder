using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BreakingTheCode {
    public string decodingEncoding(string code, string message)
    {
        Dictionary<char, string> dic = new Dictionary<char, string>();
        Dictionary<string, string> dic2 = new Dictionary<string, string>();
        int i;
        for (i = 0; i < code.Length; i++)
        {
            if (i >= 9)
            {
                dic[code[i]] = (i + 1).ToString();
                dic2[(i + 1).ToString()] = "" + code[i];
            }
            else
            {
                dic[code[i]] = "0" + (i + 1).ToString();
                dic2["0" + (i + 1).ToString()] = "" + code[i];
            }
        }
        string res = "";
        for (i = 0; i < message.Length; i++)
        {
            if (message[i] < '0' || message[i] > '9') res += dic[message[i]];
            else
            {
                res += dic2[(message[i] + "" + message[i + 1])];
                i++;
            }
        }
        return res;
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
	private void test_case_0() { string Arg0 = "abcdefghijklmnopqrstuvwxyz"; string Arg1 = "test"; string Arg2 = "20051920"; verify_case(0, Arg2, decodingEncoding(Arg0, Arg1)); }
	private void test_case_1() { string Arg0 = "abcdefghijklmnopqrstuvwxyz"; string Arg1 = "20051920"; string Arg2 = "test"; verify_case(1, Arg2, decodingEncoding(Arg0, Arg1)); }
	private void test_case_2() { string Arg0 = "qesdfvujrockgpthzymbnxawli"; string Arg1 = "mwiizkelza"; string Arg2 = "19242626171202251723"; verify_case(2, Arg2, decodingEncoding(Arg0, Arg1)); }
	private void test_case_3() { string Arg0 = "faxmswrpnqdbygcthuvkojizle"; string Arg1 = "02170308060416192402"; string Arg2 = "ahxpwmtvza"; verify_case(3, Arg2, decodingEncoding(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BreakingTheCode ___test = new BreakingTheCode();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
