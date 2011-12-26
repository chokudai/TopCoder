using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class WebsiteRank {
    public long countVotes(string[] votes, string website)
    {
        int len = votes.Length;
        int i, j, k;
        long[] point = new long[len];
        for (i = 0; i < point.Length; i++) point[i] = 1;
        Dictionary<string, int> name = new Dictionary<string, int>();
        for (i = 0; i < point.Length; i++)
        {
            string[] st = votes[i].Split(' ');
            name[st[0]] = i;
        }
        bool[,] loop = new bool[len, len];
        bool[,] connect = new bool[len, len];
        for (i = 0; i < point.Length; i++)
        {
            point[i] = 1;
            string[] st = votes[i].Split(' ');
            for (j = 1; j < st.Length; j++)
            {
                if (name.ContainsKey(st[j]))
                {
                    loop[i, name[st[j]]] = true;
                    connect[i, name[st[j]]] = true;
                }
                else point[i]++;
            }
        }
        for (k = 0; k < len; k++)
        {
            for (i = 0; i < len; i++)
            {
                for (j = 0; j < len; j++)
                {
                    loop[i, j] |= loop[i, k] & loop[k, j];
                }
            }
        }
        long[] newpoint = new long[len];
        for (i = 0; i < len; i++) newpoint[i] = point[i];

        for (k = 0; k <= len; k++)
        {
            for (i = 0; i < len; i++)
            {
                newpoint[i] = point[i];
                for (j = 0; j < len; j++)
                {
                    if (loop[i, j] && !loop[j, i] && connect[i, j])
                    {
                        newpoint[i] += newpoint[j];
                    }
                }
            }
        }
        if (name.ContainsKey(website)) return newpoint[name[website]];
        else return 1;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"C A B"}; string Arg1 = "C"; long Arg2 = 3l; verify_case(0, Arg2, countVotes(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"A B C D", "B C D", "C D"}; string Arg1 = "A"; long Arg2 = 8l; verify_case(1, Arg2, countVotes(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"A"}; string Arg1 = "A"; long Arg2 = 1l; verify_case(2, Arg2, countVotes(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"A B", "B A"}; string Arg1 = "A"; long Arg2 = 1l; verify_case(3, Arg2, countVotes(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"A B C D E F", "B A", "C B", "D B"}; string Arg1 = "A"; long Arg2 = 3l; verify_case(4, Arg2, countVotes(Arg0, Arg1)); }
	private void test_case_5() { string[] Arg0 = new string[]{"MYSITE OTHERSITE ANOTHERSITE THIRDSITE"}; string Arg1 = "MYSITE"; long Arg2 = 4l; verify_case(5, Arg2, countVotes(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
WebsiteRank ___test = new WebsiteRank();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
