using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MarriageProblemRevised {
    byte[,] dp;
    int man;
    int woman;
    int[] num;
    int[] num2;

    class p
    {
        public p(int a, int b)
        {
            m = (short)a;
            n = (short)b;
        }

        public short m;
        public short n;
    }

    public int neededMarriages(string[] preferences)
    {
        man = preferences.Length;
        woman = preferences[0].Length;
        num = new int[man];
        num2 = new int[woman];
        dp = new byte[1 << man, 1 << woman];
        int i, j, k;
        for (i = 0; i < man; i++)
        {
            for (j = 0; j < woman; j++)
            {
                if (preferences[i][j] == '1') num[i] += 1 << j;
            }
            if (num[i] == 0) return -1;
        }
        for (j = 0; j < woman; j++) 
        {
            for (i = 0; i < man; i++)
            {
                if (preferences[i][j] == '1') num2[j] += 1 << i;
            }
            if (num2[j] == 0) return -1;
        }
        
        Queue<p> q = new Queue<p>();
        q.Enqueue(new p(0, 0));
        dp[0, 0] = 1;
        while (q.Count != 0)
        {
            p now = q.Dequeue();
            int m = now.m;
            int w = now.n;
            if (m == (1 << man) - 1 && w == (1 << woman) - 1)
                return dp[(1 << man) - 1, (1 << woman) - 1] - 1;
            int minman = 0;
            for (i = 0; i < man; i++)
            {
                //minman = i;
                int nextm = m | (1 << i);
                int nextw = w | num[i];
                if (dp[nextm, nextw] == 0)
                {
                    dp[nextm, nextw] = dp[m, w];
                    dp[nextm, nextw]++;
                    q.Enqueue(new p(nextm, nextw));
                }
                //break;
            }
            for (i = 0; i < woman; i++)
            {
                //if ((num2[i] >> minman) % 2 == 0) continue;
                int nextm = m | num2[i];
                int nextw = w | (1 << i);
                if (dp[nextm, nextw] == 0)
                {
                    dp[nextm, nextw] = dp[m, w];
                    dp[nextm, nextw]++;
                    q.Enqueue(new p(nextm, nextw));
                }
            }
        }
        return -1;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"111"}; int Arg1 = 1; verify_case(0, Arg1, neededMarriages(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"100", "010", "001"}; int Arg1 = 3; verify_case(1, Arg1, neededMarriages(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"00", "00"}; int Arg1 = -1; verify_case(2, Arg1, neededMarriages(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"0001", "0001", "0001", "1111"}; int Arg1 = 2; verify_case(3, Arg1, neededMarriages(Arg0)); }
    private void test_case_4() { string[] Arg0 = new string[] { "111111111111", "111111111111", "111111111111", "111111111111", "111111111111", "111111111111", "111111111111", "111111111111", "111111111111", "111111111111", "111111111111", "111111111111" }; int Arg1 = 2; verify_case(4, Arg1, neededMarriages(Arg0)); }

    //private void test_case_4() { string[] Arg0 = new string[]{"11101011","00011110","11100100","01010000","01000010","10100011","01110110","10111111"}; int Arg1 = 3; verify_case(4, Arg1, neededMarriages(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        MarriageProblemRevised ___test = new MarriageProblemRevised();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
