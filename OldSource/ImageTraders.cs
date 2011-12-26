using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ImageTraders {
    public int maxOwners(string[] price)
    {
        int i, j, k, l;
        int len = price.Length;
        int[,] num = new int[len, len];
        for (i = 0; i < len; i++)
            for (j = 0; j < len; j++)
                num[i, j] = price[i][j] - '0';
        int[] dp = new int[1 << len];
        int[] nextdp = new int[1 << len];
        dp[1] = nextdp[1] = 1;
        for (k = 0; k <= 9; k++)
        {
            Queue<int> q = new Queue<int>();
            for (i = 1; i < (1 << len); i++)
            {
                if (dp[i] == 0) continue;
                for (j = 0; j < len; j++)
                {
                    if (((dp[i] >> j) & 1) == 0) continue;
                    for (l = 0; l < len; l++)
                    {
                        if (((i >> l) & 1) == 1) continue;
                        if (num[j, l] == k)
                        {
                            if ((nextdp[i | (1 << l)] | (1 << l)) != (nextdp[i | (1 << l)]))
                            {
                                nextdp[i | (1 << l)] |= (1 << l);
                                q.Enqueue(((i | (1 << l)) << 8) + l);
                            }
                        }
                    }
                }
            }
            while (q.Count != 0)
            {
                int next = q.Dequeue();
                i = next >> 8;
                j = next & 0xFF;
                for (l = 0; l < len; l++)
                {
                    if (((i >> l) & 1) == 1) continue;
                    if (num[j, l] == k)
                    {
                        if ((nextdp[i | (1 << l)] | (1 << l)) != (nextdp[i | (1 << l)]))
                        {
                            nextdp[i | (1 << l)] |= (1 << l);
                            q.Enqueue(((i | (1 << l)) << 8) + l);
                        }
                    }
                }
            }
            dp = (int[])nextdp.Clone();
        }
        int res = 0;
        for (i = 0; i < (1 << len); i++)
        {
            if (dp[i] == 0) continue;
            int count = 0;
            for (j = 0; j < len; j++) if ((i >> j) % 2 == 1) count++;
            res = Math.Max(count, res);
        }
        return res;
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
	private void test_case_0() { string[] Arg0 = new string[]{
"01",
"10"
}; int Arg1 = 2; verify_case(0, Arg1, maxOwners(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{
"022",
"101",
"110"
}
; int Arg1 = 2; verify_case(1, Arg1, maxOwners(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{
"01231",
"00231",
"00031",
"00002",
"00000"
}; int Arg1 = 4; verify_case(2, Arg1, maxOwners(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{
"15555",
"11111",
"15111",
"11111",
"11111"
}; int Arg1 = 3; verify_case(3, Arg1, maxOwners(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{
"0100000000",
"0020000000",
"0003000000",
"0000400000",
"0000050000",
"0000006000",
"0000000700",
"0000000080",
"0000000009",
"1111111111"
}; int Arg1 = 10; verify_case(4, Arg1, maxOwners(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ImageTraders ___test = new ImageTraders();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
