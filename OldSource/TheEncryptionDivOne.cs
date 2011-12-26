using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheEncryptionDivOne {
    long mod = 1234567891;

    public int count(string msg, string encmsg)
    {
        Dictionary<char, char> dic = new Dictionary<char, char>();
        Dictionary<char, char> edic = new Dictionary<char, char>();
        int i, j;
        int len = msg.Length;
        int nokori = 52;
        for (i = 0; i < len; i++)
        {
            if (dic.ContainsKey(msg[i]))
            {
                if (!edic.ContainsKey(encmsg[i])) return 0;
                if (dic[msg[i]] != encmsg[i]) return 0;
                if (edic[encmsg[i]] != sg[i]) return 0;
                continue;
            }
            else if (edic.ContainsKey(encmsg[i])) return 0;
            nokori--;
            if (msg[i] == encmsg[i]) return 0;
            if (Math.Abs((int)msg[i] - (int)encmsg[i]) == (int)('A' - 'a')) return 0;
            dic[msg[i]] = encmsg[i];
            edic[encmsg[i]] = msg[i];
        }
        int[] have = new int[5];
        for (i = 0; i < 26; i++)
        {
            int a = 0, b = 0;
            if (dic.ContainsKey[i + 'a']) a++;
            if (dic.ContainsKey[i + 'A']) a++;
            if (edic.ContainsKey[i + 'a']) b++;
            if (edic.ContainsKey[i + 'A']) b++;
            have[a * b]++;
        }
        long res = 0;
        for (i = 0; i <= nokori; i++)
        {
            if (i % 2 == 0) res += saiki(have,1,nokori);
            else res -= saiki(have, 1, nokori);
            res = setmod(res);
        }
        return setmod(res);
    }

    long saiki(int[] have, int now, int nokori)
    {
        long res = 0;
        if (nokori == 3)
        {
            
        }
    }


    long setmod(long a)
    {
        return ((a % mod) + mod) % mod;
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
	private void test_case_0() { string Arg0 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWX"; string Arg1 = "cdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"; int Arg2 = 2; verify_case(0, Arg2, count(Arg0, Arg1)); }
	private void test_case_1() { string Arg0 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWX"; string Arg1 = "bcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXY"; int Arg2 = 1; verify_case(1, Arg2, count(Arg0, Arg1)); }
	private void test_case_2() { string Arg0 = "topcoder"; string Arg1 = "TOPCODER"; int Arg2 = 0; verify_case(2, Arg2, count(Arg0, Arg1)); }
	private void test_case_3() { string Arg0 = "thisisaveryhardproblem"; string Arg1 = "nobodywillsolveittoday"; int Arg2 = 0; verify_case(3, Arg2, count(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheEncryptionDivOne ___test = new TheEncryptionDivOne();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
