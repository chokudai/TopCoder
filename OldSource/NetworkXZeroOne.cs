using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class NetworkXZeroOne {
    public string reconstruct(string message)
    {
        int len = message.Length;
        int i = 0;
        string st1 = ""; // こっちはoxoxoみたいなの
        string st2 = ""; // こっちがxoxoxみたいなの
        bool flag = true; //st1が条件を満たすかのフラグ
        char[] c = new char[] { 'o', 'x' }; //交互にやるならchar型の２つ作ればいいんだけど、楽になるように配列で
        for (i = 0; i < len; i++)
        {
            //１文字ずつ足す
            st1 += c[i % 2];
            st2 += c[(i + 1) % 2];
            //条件を満たしているかの判定
            if (message[i] != '?' && message[i] != c[i % 2]) flag = false;
        }
        if (flag) return st1;
        return st2;
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
	private void test_case_0() { string Arg0 = "x?x?"; string Arg1 = "xoxo"; verify_case(0, Arg1, reconstruct(Arg0)); }
	private void test_case_1() { string Arg0 = "?xo?"; string Arg1 = "oxox"; verify_case(1, Arg1, reconstruct(Arg0)); }
	private void test_case_2() { string Arg0 = "xo"; string Arg1 = "xo"; verify_case(2, Arg1, reconstruct(Arg0)); }
	private void test_case_3() { string Arg0 = "o??x??o"; string Arg1 = "oxoxoxo"; verify_case(3, Arg1, reconstruct(Arg0)); }
	private void test_case_4() { string Arg0 = "???????x"; string Arg1 = "oxoxoxox"; verify_case(4, Arg1, reconstruct(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
NetworkXZeroOne ___test = new NetworkXZeroOne();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
