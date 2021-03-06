using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MorselikeCode {
    public string decrypt(string[] library, string message)
    {
        int i;
        Dictionary<string, string> dic = new Dictionary<string, string>();
        for (i = 0; i < library.Length; i++)
        {
            string[] st = library[i].Split(' ');
            dic[st[1]] = st[0];
        }
        string res = "";
        string[] s = message.Split(' ');
        for (i = 0; i < s.Length; i++)
        {
            //Console.WriteLine(s[i]);
            if (dic.ContainsKey(s[i]))
            {
                res += dic[s[i]];
            }
            else res += "?";
        }
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); if ((Case == -1) || (Case == 6)) test_case_6(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"O ---",
 "S ..."}; string Arg1 = "... --- ..."; string Arg2 = "SOS"; verify_case(0, Arg2, decrypt(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"O ---"}; string Arg1 = "... --- ..."; string Arg2 = "?O?"; verify_case(1, Arg2, decrypt(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"H -",
 "E .",
 "L --",
 "L ..",
 "O -."}; string Arg1 = "- . -- .. -."; string Arg2 = "HELLO"; verify_case(2, Arg2, decrypt(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"H -.-.-.-.-.-.-.-.-.-.",
 "I .-.-.-.-.-.-.-.-.-.-",
 "K -.-.-.-.-.",
 "E .-.-.-.-.-"}; string Arg1 = "-.-.-.-.-.-.-.-.-.-. .-.-.-.-.-.-.-.-.-.-"; string Arg2 = "HI"; verify_case(3, Arg2, decrypt(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"O ---",
 "S ...",
 "B -...",
 "T -",
 "R .-.",
 "E .",
 "N -.",
 "X -..-",
 "D -.." }; string Arg1 = "-... --- ... - --- -. .-. . -.. ... --- -..-"; string Arg2 = "BOSTONREDSOX"; verify_case(4, Arg2, decrypt(Arg0, Arg1)); }
	private void test_case_5() { string[] Arg0 = new string[]{"B -...",
 "N -.",
 "H ....",
 "O --",
 "Z --..",
 "G ---",
 "I ..",
 "J .---" }; string Arg1 = "--- -- -... .- -. .- -. .-"; string Arg2 = "GOB?N?N?"; verify_case(5, Arg2, decrypt(Arg0, Arg1)); }
	private void test_case_6() { string[] Arg0 = new string[]{"A --",
 "B -.",
 "N ...-",
 "I --..",
 "F -.-.-."}; string Arg1 = "-. -- -.-.-. -.-.-. --- --.. ...- .-..--."; string Arg2 = "BAFF?IN?"; verify_case(6, Arg2, decrypt(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MorselikeCode ___test = new MorselikeCode();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
