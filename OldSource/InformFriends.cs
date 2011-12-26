using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class InformFriends {
    public int maximumGroups(string[] friends)
    {
        int len = friends.Length;
        int i, j;
        int[] fdata = new int[len];
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                if (friends[i][j] == 'Y') fdata[i] += 1 << j;
            }
        }
        List<int> l = new List<int>();
        bool[] flag = new bool[1 << len];
        for (i = 0; i < (1 << len); i++)
        {
            for (j = 0; j < len; j++)
            {
                if ((i >> j) % 2 == 1)
                {
                    if (flag[i - (1 << j)]) break;
                }
            }
            if (j != len)
            {
                flag[i] = true;
                continue;
            }

            int now = 0;
            for (j = 0; j < len; j++)
            {
                if ((i >> j) % 2 == 1)
                {
                    now |= 1 << j;
                    now |= fdata[j];
                }
            }
            if (now == (1 << len) - 1)
            {
                flag[i] = true;
                l.Add(i);
            }
        }
        //Console.WriteLine(l.Count);
        int[] dp = new int[1 << len];
        int res = 0;
        for (i = 0; i < (1 << len); i++)
        {
            foreach (int a in l)
            {
                if ((i & a) == 0)
                {
                    dp[i + a] = Math.Max(dp[i + a], dp[i] + 1);
                }
            }
            res = Math.Max(res, dp[i]);
        }
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"NYYN",
 "YNYY",
 "YYNY",
 "NYYN"}; int Arg1 = 3; verify_case(0, Arg1, maximumGroups(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"NYYN",
 "YNYN",
 "YYNN",
 "NNNN"}; int Arg1 = 1; verify_case(1, Arg1, maximumGroups(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"NYNNNY",
 "YNYNNN",
 "NYNYNN",
 "NNYNYN",
 "NNNYNY",
 "YNNNYN"}; int Arg1 = 3; verify_case(2, Arg1, maximumGroups(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"NYNY",
 "YNYN",
 "NYNY",
 "YNYN"}; int Arg1 = 2; verify_case(3, Arg1, maximumGroups(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
InformFriends ___test = new InformFriends();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
