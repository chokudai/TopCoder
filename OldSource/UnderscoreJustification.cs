using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class UnderscoreJustification {
    public string justifyLine(string[] words, int width)
    {
        int i, len = words.Length - 1;
        for (i = 0; i < words.Length; i++) width -= words[i].Length;
        int[] ar = new int[len];
        for (i = 0; i < len; i++) ar[i] = width / len;
        width -= width / len * len;
        for (i = 0; i < len && width != 0; i++)
        {
            if (words[i + 1][0].CompareTo('_') >= 0)
            {
                width--;
                ar[i]++;
            }
        }
        for (i = len-1; i >= 0 && width != 0; i--)
        {
            if (words[i + 1][0].CompareTo('_') < 0)
            {
                width--;
                ar[i]++;
            }
        }
        string result = "";
        for (i = 0; i < len; i++)
        {
            result += words[i];
            for (int j = 0; j < ar[i]; j++) result += "_";
        }
        return result + words[len];
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"A", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog"}; int Arg1 = 50; string Arg2 = "A___quick__brown__fox__jumps__over__the__lazy__dog"; verify_case(0, Arg2, justifyLine(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"Alpha", "Beta", "Gamma", "Delta", "Epsilon"}; int Arg1 = 32; string Arg2 = "Alpha_Beta_Gamma__Delta__Epsilon"; verify_case(1, Arg2, justifyLine(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"Hello", "world", "John", "said"}; int Arg1 = 29; string Arg2 = "Hello____world___John____said"; verify_case(2, Arg2, justifyLine(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
UnderscoreJustification ___test = new UnderscoreJustification();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
