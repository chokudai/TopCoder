using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class KingdomTour {

    int[] uni;
    bool[] used;
    int[] check;

    public int minTime(int N, string[] roads, int K, int L)
    {
        string s1 = "";
        foreach (string s in roads) s1 += s;
        string[] s2 = s1.Split(',');
        int len = s2.Length;
        int[] A = new int[len];
        int[] B = new int[len];
        int[] C = new int[len];
        uni = new int[N];
        check = new int[N];
        used = new bool[len];
        int i, j;
        for (i = 0; i < N; i++) uni[i] = -1;
        for (i = 0; i < len; i++)
        {
            string[] s3 = s2[i].Split(' ');
            A[i] = int.Parse(s3[0]);
            B[i] = int.Parse(s3[1]);
            C[i] = int.Parse(s3[2]);
        }
        int res = 0;

        for (i = 0; i < N; i++)
        {
            int low = int.MaxValue;
            //if (i >= N - K) low = L;
            int best = -1;

            for (j = 0; j < len; j++)
            {
                if (used[j]) continue;
                if (check[A[j]] >= 2) continue;
                if (check[B[j]] >= 2) continue;
                if (i != N - 1 && same(A[j], B[j])) continue;
                if (C[j] < low)
                {
                    low = C[j];
                    best = j;
                }
            }

            Console.WriteLine(best + " " + low);
            if (best == -1) return res + (N - i) * L;
            res += low;

            connect(A[best], B[best]);
            used[best] = true;
        }
        return res;
    }


    int root(int a)
    {
        if (uni[a] == -1) return a;
        else return uni[a] = root(uni[a]);
    }

    bool same(int a, int b)
    {
        return root(a) == root(b);
    }

    void connect(int a, int b)
    {
        check[a]++;
        check[b]++;
        uni[root(a)] = root(b);
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
	private void test_case_0() { int Arg0 = 3; string[] Arg1 = new string[]{"2 1 9,0 1 3"}; int Arg2 = 8; int Arg3 = 4; int Arg4 = 16; verify_case(0, Arg4, minTime(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int Arg0 = 2; string[] Arg1 = new string[]{"0 1 4"}; int Arg2 = 2; int Arg3 = 3; int Arg4 = 7; verify_case(1, Arg4, minTime(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int Arg0 = 6; string[] Arg1 = new string[]{"4 0 4,2 0 4,2 5 4,4 3 1",
 "0,1 2 10"}; int Arg2 = 2; int Arg3 = 5; int Arg4 = 41; verify_case(2, Arg4, minTime(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int Arg0 = 10; string[] Arg1 = new string[]{"1 2 2,4 1 9,2 5 5,6 5 4,", "1 7 7,7 3 1,2 0 2", ",5 8 5,9 5 6"}; int Arg2 = 2; int Arg3 = 4; int Arg4 = 59; verify_case(3, Arg4, minTime(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
KingdomTour ___test = new KingdomTour();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
