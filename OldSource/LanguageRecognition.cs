using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class LanguageRecognition {
    public int whichLanguage(string[] languages, string text)
    {
        double eps = 1e-9;
        double[] c1, c2;
        c1 = new double[256];
        double best = 10000;
        int res = 0;
        int i, j;
        for (i = 0; i < 256; i++) c1[i] = 0;
        for (j = 0; j < text.Length; j++)
        {
            if (text[j] <= 'Z' && text[j] >= 'A') c1[text[j] - 'A' + 'a'] += 1;
            else c1[text[j]] += 1;
        }
        for (i = 0; i < languages.Length; i++)
        {
            c2 = new double[256];
            for (j = 0; j < 256; j++) c2[j] = 0;
            for (j = 0; j < languages[i].Length; j++)
            {
                if (languages[i][j] <= 'Z' && languages[i][j] >= 'A') c2[languages[i][j] - 'A' + 'a'] += 1;
                c2[languages[i][j]] += 1;
            }
            double memo = 0;
            for (j = 0; j < 256; j++)
            {
                memo += Math.Pow((c1[j] / text.Length) - (c2[j] / languages[i].Length), 2);
            }
            Console.WriteLine(memo);
            if (memo < best -eps)
            {
                best = memo;
                res = i;
            }
        }
        return res;
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
	private void test_case_0() { string[] Arg0 = new string[]{"This is an English sentence.",
 "Dieser ist ein Deutscher Satz.",
 "C'est une phrase Francaise.",
 "Dit is een Nederlandse zin."
}; string Arg1 = "In welke taal is deze zin geschreven?"; int Arg2 = 3; verify_case(0, Arg2, whichLanguage(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"aaaaa","bbbb","ccc","dd","e"}; string Arg1 = "xxx"; int Arg2 = 0; verify_case(1, Arg2, whichLanguage(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"AABB","AaBb","A? B!","ab!@#$%"}; string Arg1 = "ab"; int Arg2 = 0; verify_case(2, Arg2, whichLanguage(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
LanguageRecognition ___test = new LanguageRecognition();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
