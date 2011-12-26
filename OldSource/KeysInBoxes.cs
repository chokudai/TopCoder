using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


public class KeysInBoxes {
    public string getAllKeys(int N, int M)
    {
        fraction[,] dp = new fraction[N + 2, M + 2];
        int i, j;
        for (i = 0; i <= N + 1; i++)
        {
            for (j = 0; j <= M + 1; j++)
            {
                dp[i, j] = new fraction(1, 0);
            }
        }
        dp[0, 0] = new fraction(1, 1);
        for (i = 0; i < N; i++)
        {
            for (j = 0; j <= M; j++)
            {
                fraction ng = new fraction(N - i, 1);
                fraction ok = new fraction(N - i, N - i - 1);
                dp[i + 1, j] = dp[i + 1, j].add(dp[i, j].mul(ok));
                dp[i + 1, j + 1] = dp[i + 1, j + 1].add(dp[i, j].mul(ng));
                //Console.WriteLine(i + " " + j + " " + dp[i, j].bunsi + "/" + dp[i, j].bunbo);
            }
        }
        fraction ret = new fraction(1, 0);
        for (j = 0; j <= M; j++) ret = ret.add(dp[N, j]);
        string res = ret.bunsi + "/" + ret.bunbo;
        return res;
    }

    class fraction
    {
        public long bunsi;
        public long bunbo;
        
        long gcd(long a, long b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }

        public fraction(long a, long b)
        {
            long firstgcd = gcd(a, b);
            bunbo = a / firstgcd;
            bunsi = b / firstgcd;
        }

        public fraction add(fraction a)
        {
            long waru = gcd(this.bunbo, a.bunbo);
            a.bunbo /= waru;
            this.bunbo /= waru;
            long nextbunbo = a.bunbo * this.bunbo * waru;
            long nextbunsi = a.bunbo * this.bunsi + this.bunbo * a.bunsi;
            return new fraction(nextbunbo, nextbunsi);
        }

        public fraction mul(fraction a)
        {
            long nextbunbo = a.bunbo / gcd(a.bunbo, this.bunsi) * this.bunbo / gcd(this.bunbo, a.bunsi);
            long nextbunsi = this.bunsi / gcd(a.bunbo, this.bunsi) * a.bunsi / gcd(this.bunbo, a.bunsi);
            return new fraction(nextbunbo, nextbunsi);
        }

        public string tost()
        {
            return bunsi + "/" + bunbo;
        }

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
	private void test_case_0() { int Arg0 = 2; int Arg1 = 1; string Arg2 = "1/2"; verify_case(0, Arg2, getAllKeys(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 2; int Arg1 = 2; string Arg2 = "1/1"; verify_case(1, Arg2, getAllKeys(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 3; int Arg1 = 1; string Arg2 = "1/3"; verify_case(2, Arg2, getAllKeys(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 3; int Arg1 = 2; string Arg2 = "5/6"; verify_case(3, Arg2, getAllKeys(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 4; int Arg1 = 2; string Arg2 = "17/24"; verify_case(4, Arg2, getAllKeys(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
KeysInBoxes ___test = new KeysInBoxes();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
