using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ReverseDistance {
    public string find(int difference)
    {
        int len;
        long ret = long.MaxValue;
        for (len = 2; len <= 18; len++)
        {
            int i, j;
            if (Math.Pow(10, len) - 1e-9 < difference) continue;
            int[] res = new int[len];
            for (i = 0; i < (1 << ((len + 1) / 2)); i++)
            {
                int now = difference;
                bool prev = true;
                for (j = 0; j < (len + 1) / 2; j++)
                {
                    int next = now % 10;
                    if (!prev) next++;
                    bool flag = true;
                    if ((i >> j) % 2 == 0) flag = false;
                    int first, second;
                    if (flag)
                    {
                        first = 0;
                        second = next;
                    }
                    else
                    {
                        first = 10 - next;
                        second = 0;
                    }
                    while (first < 0 || second < 0)
                    {
                        first++; second++;
                    }
                    while (j == 0 && first == 0)
                    {
                        first++; second++;
                    }
                    if (first >= 10 || second >= 10) continue;
                    res[j] = second;
                    res[len - j - 1] = first;
                    prev = flag;
                    now /= 10;
                }
                if (j == (len + 1) / 2)
                {
                    int[] cal = new int[len];
                    for (j = 0; j < len; j++)
                    {
                        cal[j] = res[j] - res[len - j - 1];
                    }
                    for (j = 0; j < len - 1; j++)
                    {
                        while (cal[j] < 0)
                        {
                            cal[j] += 10;
                            cal[j + 1]--;
                        }
                    }
                    now = difference;
                    for (j = 0; j < len; j++, now /= 10)
                    {
                        if (now % 10 != cal[j]) break;
                    }
                    string r = "";
                    if (j == len)
                    {
                        for (j = 0; j < len; j++)
                        {
                            r = res[j] + r;
                        }
                        //Console.WriteLine(r);
                        ret = Math.Min(ret, long.Parse(r));
                    }
                }
            }
        }
        if (ret == long.MaxValue) return "NONE";
        else return ret.ToString();
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
	private void test_case_0() { int Arg0 = 18; string Arg1 = "20"; verify_case(0, Arg1, find(Arg0)); }
	private void test_case_1() { int Arg0 = 15; string Arg1 = "NONE"; verify_case(1, Arg1, find(Arg0)); }
	private void test_case_2() { int Arg0 = 4275; string Arg1 = "5080"; verify_case(2, Arg1, find(Arg0)); }
	private void test_case_3() { int Arg0 = 900; string Arg1 = "101001"; verify_case(3, Arg1, find(Arg0)); }
	private void test_case_4() { int Arg0 = 1989; string Arg1 = "100990"; verify_case(4, Arg1, find(Arg0)); }
	private void test_case_5() { int Arg0 = 857232; string Arg1 = "860300"; verify_case(5, Arg1, find(Arg0)); }
	private void test_case_6() { int Arg0 = 45; string Arg1 = "50"; verify_case(6, Arg1, find(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        ReverseDistance ___test = new ReverseDistance();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
