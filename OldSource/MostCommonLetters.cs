using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MostCommonLetters {
    public string listMostCommon(string[] text)
    {
        int[] num = new int[26];
        int i;

        foreach (string s in text)
        {
            foreach (char c in s)
            {
                if (c != ' ')
                {
                    num[(int)(c - 'a')]++;
                }
            }
        }
        string res = "";
        int best = 1;
        for (i = 0; i < 26; i++)
        {
            if (num[i] > best)
            {
                best = num[i];
                res = "";
            }
            if (num[i] >= best)
            {
                res += (char)('a' + i);
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
	private void test_case_0() { string[] Arg0 = new string[]{"abc a"}; string Arg1 = "a"; verify_case(0, Arg1, listMostCommon(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"abc", "ab"}; string Arg1 = "ab"; verify_case(1, Arg1, listMostCommon(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"qwerty", "abc", "qwe", "a"}; string Arg1 = "aeqw"; verify_case(2, Arg1, listMostCommon(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"english is a west germanic language originating",
 "in england and is the first language for most",
 "people in the united kingdom the united",
 "states canada australia new zealand ireland",
 "and the anglophone caribbean it is used",
 "extensively as a second language and as an",
 "official language throughout the world",
 "especially in commonwealth countries and in",
 "many international organizations"}; string Arg1 = "a"; verify_case(3, Arg1, listMostCommon(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"amanda forsaken bloomer meditated gauging knolls",
 "betas neurons integrative expender commonalities",
 "latins antidotes crutched bandwidths begetting",
 "prompting dog association athenians christian ires",
 "pompousness percolating figured bagatelles bursted",
 "ninth boyfriends longingly muddlers prudence puns",
 "groove deliberators charter collectively yorks",
 "daringly antithesis inaptness aerosol carolinas",
 "payoffs chumps chirps gentler inexpressive morales"}; string Arg1 = "e"; verify_case(4, Arg1, listMostCommon(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MostCommonLetters ___test = new MostCommonLetters();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
