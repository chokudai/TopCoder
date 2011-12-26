using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SRMChallengePhase {

    long mod = 1000000007;
    Dictionary<long, long> dic;
    int ng;
    int len;
    int target;

    public int countWays(string[] codersAttempted, string[] codersChallenged)
    {
        dic = new Dictionary<long, long>();
        string ca = "";
        string cc = "";
        foreach (string ss in codersAttempted) ca += ss;
        foreach (string ss in codersChallenged) cc += ss;
        int i;
        len = ca.Length;
        int yy = 0;
        int yn = 0;
        int ny = 0;
        for (i = 0; i < len; i++)
        {
            if (ca[i] == 'Y' && cc[i] == 'Y') yy++;
            if (ca[i] == 'N' && cc[i] == 'Y') ny++;
            if (ca[i] == 'Y' && cc[i] == 'N') yn++;
        }
        target = len - yy - ny;
        return (int)saiki(yy, yn, ny, false);
    }

    public long saiki(int yy, int yn, int ny, bool flag)
    {
        //Console.WriteLine(yy + " " + yn + " " + ny + " " + flag);
        if (!flag && yn < ny) return 0;
        if (yn < ny - 1) return 0;
        long enc = encode(yy, yn, ny, flag);
        if (dic.ContainsKey(enc)) return dic[enc];
        long ret = 0;
        if (flag)
        {
            if (yy > 0) ret += yy * saiki(yy - 1, yn, ny + 1, true);
            ret %= mod;
            if (ny > 0) ret += ny * saiki(yy, yn, ny - 1, false);
            ret %= mod;
            if ((len - 1) > 0) ret += (len - 1) * saiki(yy, yn, ny, false);
            ret %= mod;
        }
        else
        {
            if (yy != 0)
            {
                if (ny > 0) ret += yy * ny * saiki(yy - 1, yn, ny - 1, false);
                ret %= mod;
                if (yy != 1) ret += yy * (yy - 1) * saiki(yy - 2, yn, ny + 1, true);
                ret %= mod;
                if ((len-1) > 0) ret += yy * (len - 1) * saiki(yy - 1, yn, ny + 1, false);
                ret %= mod;
            }
            if (yn != 0)
            {
                if (ny > 0) ret += yn * ny * saiki(yy, yn - 1, ny - 1, false);
                ret %= mod;
                if ((len - 1) > 0) ret += yn * (len - 1) * saiki(yy, yn - 1, ny, false);
                ret %= mod;
            }
            if (yy == 0 && yn == 0)
            {
                if (ny == 0)
                {
                    ret = 1;
                }
                else ret = 0;
            }
        }
        return dic[enc] = ret % mod;
    }

    long encode(int yy, int yn, int ny, bool flag)
    {
        long now = 0;
        if (flag) now = 1;
        now |= (long)yy << 1;
        now |= (long)yn << 13;
        now |= (long)ny << 25;
        return now;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"YY"}; string[] Arg1 = new string[]{"NY"}; int Arg2 = 1; verify_case(0, Arg2, countWays(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"YY", "NN"}; string[] Arg1 = new string[]{"N", "NYY"}; int Arg2 = 4; verify_case(1, Arg2, countWays(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"YNNN"}; string[] Arg1 = new string[]{"NYY", "Y"}; int Arg2 = 0; verify_case(2, Arg2, countWays(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"N"}; string[] Arg1 = new string[]{"N"}; int Arg2 = 1; verify_case(3, Arg2, countWays(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"YYY"}; string[] Arg1 = new string[]{"NNY"}; int Arg2 = 24; verify_case(4, Arg2, countWays(Arg0, Arg1)); }
	private void test_case_5() { string[] Arg0 = new string[]{"YY", "N", "YYYY", "NN", "YYYYY"}; string[] Arg1 = new string[]{"N", "YYYYY", "N", "Y", "N", "YYYY", "N"}; int Arg2 = 807026001; verify_case(5, Arg2, countWays(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SRMChallengePhase ___test = new SRMChallengePhase();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
