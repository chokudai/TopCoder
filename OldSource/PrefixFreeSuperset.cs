using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PrefixFreeSuperset {
    public long minSumLength(string[] cur, long k)
    {
        int i, j;
        long sum = 0;
        int len = cur.Length;
        long d = 0;
        for (i = 0; i < len; i++)
        {
            d += cur[i].Length;
            sum += (long)1 << (51 - cur[i].Length);
        }
        if (len == k) return d;
        if (sum >= (long)1 << 51)
        {
            return -1;
        }
        long now = 1;
        long[] freepair = new long[100];
        long[] usenum = new long[100];
        for (i = 1; ; i++)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            now *= 2;
            for (j = 0; j < len; j++)
            {
                if (cur[j].Length == i)
                {
                    now -= 1;
                }
                else if (cur[j].Length > i)
                {
                    dic[cur[j].Substring(0, i)] = 1;
                }
            }
            long next = now - dic.Count;
            if (next >= k - len)
            {
                long dis = next - (k - len);
                long dissum = 0;
                usenum[i] = next;
                for (j = i - 1; j >= 0; j--)
                {
                    long nextdis = Math.Min(freepair[j], dis);
                    dissum += nextdis * (j + 2);
                    dis -= nextdis;
                    usenum[j + 1] -= nextdis * 2;
                    usenum[j] += nextdis;
                }
                for (j = i; j >= 0; j--)
                {
                    long nextdis = Math.Min(usenum[j], dis);
                    dissum += nextdis * j;
                    dis -= nextdis;
                    usenum[j] -= dissum;
                }
                return d + next * i - dissum;
            }
            else
            {
                freepair[i] = next;
            }
        }


    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"010"}; long Arg1 = 4l; long Arg2 = 9l; verify_case(0, Arg2, minSumLength(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"01","000"}; long Arg1 = 4l; long Arg2 = 9l; verify_case(1, Arg2, minSumLength(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"0011","011110101","11101010111","11101010100000000","11101010100000001111"}; long Arg1 = 1000000000000l; long Arg2 = 39971901640560l; verify_case(2, Arg2, minSumLength(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"010","00","011","1"}; long Arg1 = 4l; long Arg2 = 9l; verify_case(3, Arg2, minSumLength(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"010","00","011","1"}; long Arg1 = 5l; long Arg2 = -1l; verify_case(4, Arg2, minSumLength(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        PrefixFreeSuperset ___test = new PrefixFreeSuperset();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
