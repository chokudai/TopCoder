using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Mailbox {
    public int impossible(string collection, string[] address)
    {
        int[] numchar = new int[256];
        int count = 0;
        foreach (char c in collection) numchar[c]++;
        numchar[' '] = 1000;
        int i;
        foreach (string s in address)
        {
            int[] now = new int[256];
            foreach (char c in s) now[c]++;
            bool flag = true;
            for (i = 0; i < 256; i++) if (numchar[i] < now[i]) flag = false;
            if (!flag) count++;
        }
        return count;
    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string Arg0 = "AAAAAAABBCCCCCDDDEEE123456789"; string[] Arg1 = new string[]{"123C","123A","123 ADA"}; int Arg2 = 0; verify_case(0, Arg2, impossible(Arg0, Arg1)); }
	private void test_case_1() { string Arg0 = "ABCDEFGHIJKLMNOPRSTUVWXYZ1234567890"; string[] Arg1 = new string[]{"2 FIRST ST"," 31 QUINCE ST", "606 BAKER"}; int Arg2 = 3; verify_case(1, Arg2, impossible(Arg0, Arg1)); }
	private void test_case_2() { string Arg0 = "ABCDAAST"; string[] Arg1 = new string[]{"111 A ST", "A BAD ST", "B BAD ST"}; int Arg2 = 2; verify_case(2, Arg2, impossible(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Mailbox ___test = new Mailbox();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
