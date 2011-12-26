using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class DietPlan {
    public string chooseDinner(string diet, string breakfast, string lunch)
    {
        int[] c = new int[26]; //c[0]-> A‚ÌŒÂ” c[1]->B‚ÌŒÂ”
        int i,j;
        for (i = 0; i < diet.Length; i++) c[diet[i] - 'A']++;
        for (i = 0; i < breakfast.Length; i++) c[breakfast[i] - 'A']--;
        for (i = 0; i < lunch.Length; i++) c[lunch[i] - 'A']--;
        string ret = "";
        for (i = 0; i < 26; i++)
        {
            if (c[i] < 0) return "CHEATER";
            for (j = 0; j < c[i]; j++) ret += (char)('A' + i);
        }
        return ret;
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
	private void test_case_0() { string Arg0 = "ABCD"; string Arg1 = "AB"; string Arg2 = "C"; string Arg3 = "D"; verify_case(0, Arg3, chooseDinner(Arg0, Arg1, Arg2)); }
	private void test_case_1() { string Arg0 = "ABEDCS"; string Arg1 = ""; string Arg2 = ""; string Arg3 = "ABCDES"; verify_case(1, Arg3, chooseDinner(Arg0, Arg1, Arg2)); }
	private void test_case_2() { string Arg0 = "EDSMB"; string Arg1 = "MSD"; string Arg2 = "A"; string Arg3 = "CHEATER"; verify_case(2, Arg3, chooseDinner(Arg0, Arg1, Arg2)); }
	private void test_case_3() { string Arg0 = ""; string Arg1 = ""; string Arg2 = ""; string Arg3 = ""; verify_case(3, Arg3, chooseDinner(Arg0, Arg1, Arg2)); }
	private void test_case_4() { string Arg0 = "IWANTSODER"; string Arg1 = "SOW"; string Arg2 = "RAT"; string Arg3 = "DEIN"; verify_case(4, Arg3, chooseDinner(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
DietPlan ___test = new DietPlan();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
