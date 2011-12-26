using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PrimeCompositeGame {

    bool[] prime;
    const int MAX = 1 << 19;
    List<int> pl;
    int[] l;
    int[] dp;
    int[] seg;
    int[] segnum;
    int _K;

    int checkingnum = 0;

    public int theOutcome(int N, int K)
    {
        _K = K;
        prime = new bool[MAX];
        pl = new List<int>();
        era();
        l = pl.ToArray();
        dp = new int[MAX];
        int i;
        for (i = 0; i < MAX; i++)
        {
            dp[i] = MAX * 10;
        }
        dp[0] = 0;
        dp[1] = 0;

        seg = new int[MAX * 2];
        segnum = new int[MAX * 2];
        for (i = 0; i < MAX * 2; i++)
        {
            seg[i] = MAX * 10;
            segnum[i] = 0;
        }
        for (i = 2; i <= N; i++)
        {
            checkingnum = i;
            dp[i] = queue(1, 0, MAX, Math.Max(0, i - K), i);
            if (dp[i] == MAX) dp[i] = 0;
            else{
                if (dp[i] > 0) dp[i] = MAX - dp[i];
                else if (dp[i] < 0) dp[i] = -MAX + dp[i];

                if (dp[i] < 0) dp[i]--;
                else dp[i]++;
                dp[i] = -dp[i];
                if (dp[i] > 0)
                {
                    dp[i] = MAX - dp[i];
                }
                else dp[i] = -MAX + dp[i];
            }
            //Console.WriteLine(i + " " + dp[i]);
            if (!prime[i])
            {
                add(1, 0, MAX, i, i + 1, i, dp[i]);
            }
        }
        Console.ReadLine();
        int ret = dp[N];
        if (ret > 0) ret = MAX - ret;
        else if (ret < 0) ret = -MAX + ret;
        return ret;
    }

    int queue(int a, int l, int r, int nl, int nr)
    {
        //Console.WriteLine(a + " " + l + " " + r + " " + nl + " " + nr);
        int ret = MAX;
        if (l >= nr || r <= nl) return ret;
        //Console.WriteLine(checkingnum - segnum[a]);
        if (prime[checkingnum] != prime[segnum[a]] && checkingnum - segnum[a] >= 1 && checkingnum - segnum[a] <= _K)
        {
            Console.WriteLine("ok! {0} {1}",nl,nr);
            return seg[a];
        }
        if (r - l == 1) return ret;
        int mid = (l + r) / 2;
        if (nl < mid && nr > l) ret = Math.Min(ret, queue(a * 2, l, mid, nl, nr));
        if (nl < r && nr > mid) ret = Math.Min(ret, queue(a * 2, mid, r, nl, nr));
        return ret;
    }

    void add(int a, int l, int r, int nl, int nr, int add2, int num)
    {
        if (l >= nr || r <= nl) return;
        //Console.WriteLine(seg[a] + " " + num);
        if (seg[a] > num)
        {
            Console.WriteLine("add! " + l + " " + r + " " + add2 + " " + num);
            seg[a] = num;
            segnum[a] = add2;
        }
        int mid = (l + r) / 2;
        if (r - l == 1) return;
        if (nl < mid && nr > l) add(a * 2, l, mid, nl, nr, add2, num);
        if (nl < r && nr > mid) add(a * 2, mid, r, nl, nr, add2, num);
    }
    


    void era()
    {
        int i, j;
        prime[0] = prime[1] = false;
        for (i = 2; i < MAX; i++)
        {
            if (prime[i]) continue;
            pl.Add(i);
            for (j = i + i; j < MAX; j += i) prime[j] = true;
        }
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
	private void test_case_0() { int Arg0 = 3; int Arg1 = 2; int Arg2 = 1; verify_case(0, Arg2, theOutcome(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 58; int Arg1 = 1; int Arg2 = 0; verify_case(1, Arg2, theOutcome(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 30; int Arg1 = 3; int Arg2 = -2; verify_case(2, Arg2, theOutcome(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 6; int Arg1 = 3; int Arg2 = 1; verify_case(3, Arg2, theOutcome(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 526; int Arg1 = 58; int Arg2 = 19; verify_case(4, Arg2, theOutcome(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        PrimeCompositeGame ___test = new PrimeCompositeGame();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
