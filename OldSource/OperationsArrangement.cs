using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class OperationsArrangement {
    public string arrange(string sequence)
    {
        int i;
        int now = 0;
        bool flag = false;
        for (i = 0; i < sequence.Length; i++) if (sequence[i] == '0') flag = true;
        string res = "";
        if (flag)
        {
            for (i = 0; i < sequence.Length; i++)
            {
                res += sequence[i];
                if (i == sequence.Length - 1) break;
                res += "*";
            }
            return res;
        }
        res += sequence[0];
        now = sequence[0] - '0';
        for (i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] == '1')
            {
                res += "*";
                res += sequence[i];
                continue;
            }
            else if (now == 1)
            {
                res += "*";
                res += sequence[i];
                now *= sequence[i] - '0';
                continue;
            }
            else if (now == 2 && sequence[i]=='2')
            {
                res += "*";
                res += sequence[i];
                now *= sequence[i] - '0';
                continue;
            }
            else
            {
                res += "+";
                res += sequence[i];
                now = sequence[i] - '0';
                continue;
            }
        }
        return res;
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
	private void test_case_0() { string Arg0 = "222"; string Arg1 = "2*2+2"; verify_case(0, Arg1, arrange(Arg0)); }
	private void test_case_1() { string Arg0 = "322"; string Arg1 = "3+2*2"; verify_case(1, Arg1, arrange(Arg0)); }
	private void test_case_2() { string Arg0 = "307"; string Arg1 = "3*0*7"; verify_case(2, Arg1, arrange(Arg0)); }
	private void test_case_3() { string Arg0 = "391118571"; string Arg1 = "3+9*1*1*1+8+5+7*1"; verify_case(3, Arg1, arrange(Arg0)); }
	private void test_case_4() { string Arg0 = "111221911212"; string Arg1 = "1*1*1*2*2*1+9*1*1+2*1*2"; verify_case(4, Arg1, arrange(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
OperationsArrangement ___test = new OperationsArrangement();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
