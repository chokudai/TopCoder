using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BoxesArrangement {
    public int maxUntouched(string boxes)
    {
        int countA = 0;
        int countB = 0;
        int countC = 0;
        int i, j, k, l, m, p, q;
        for (i = 0; i < boxes.Length; i++)
        {
            if (boxes[i] == 'A') countA++;
            if (boxes[i] == 'B') countB++;
            if (boxes[i] == 'C') countC++;
        }
        int maxA, maxB, maxC;
        maxA = countA * 2 + 5;
        maxB = countB * 2 + 5;
        maxC = countC * 2 + 5;
        int[, , , ,] dp = new int[maxA, maxB, maxC, 3, 3];
        int[, , , ,] nextdp = new int[maxA, maxB, maxC, 3, 3];
        for (j = 0; j < maxA; j++)
        {
            for (k = 0; k < maxB; k++)
            {
                for (l = 0; l < maxC; l++)
                {
                    for (p = 0; p < 3; p++)
                    {
                        for (q = 0; q < 3; q++)
                        {
                            dp[j, k, l, p, q] = 100;
                        }
                    }
                }
            }
        }
        for (p = 0; p < 3; p++)
        {
            for (q = 0; q < 3; q++)
            {
                dp[countA + 2, countB + 2, countC + 2, p, q] = 0;
            }
        }
        for (i = 0; i < boxes.Length; i++)
        {
            for (j = 0; j < maxA; j++)
            {
                for (k = 0; k < maxB; k++)
                {
                    for (l = 0; l < maxC; l++)
                    {
                        for (p = 0; p < 3; p++)
                        {
                            for (q = 0; q < 3; q++)
                            {
                                nextdp[j, k, l, p, q] = 100;
                            }
                        }
                    }
                }
            }
            for (j = 1; j < maxA-1; j++)
            {
                for (k = 1; k < maxB-1; k++)
                {
                    for (l = 1; l < maxC-1; l++)
                    {
                        for (p = 0; p < 3; p++)
                        {
                            for (q = 0; q < 3; q++)
                            {
                                for (m = 0; m < 3; m++)
                                {
                                    if (dp[j, k, l, p, q] >= 100) continue;
                                    int plusA = 0;
                                    int plusB = 0;
                                    int plusC = 0;
                                    int add = 0;
                                    if (boxes[i] == 'A') plusA++;
                                    if (boxes[i] == 'B') plusB++;
                                    if (boxes[i] == 'C') plusC++;
                                    if ((char)(m + 'A') == 'A') plusA--;
                                    if ((char)(m + 'A') == 'B') plusB--;
                                    if ((char)(m + 'A') == 'C') plusC--;
                                    if ((char)(m + 'A') != boxes[i]) add++;
                                    //Console.WriteLine(add);
                                    int nextp = m;
                                    int nextq = 1;
                                    if (p == nextp) nextq = q + 1;
                                    if (nextq < 3)
                                    {
                                        nextdp[j + plusA, k + plusB, l + plusC, nextp, nextq] =
                                            Math.Min(nextdp[j + plusA, k + plusB, l + plusC, nextp, nextq],
                                            dp[j, k, l, p, q] + add);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            dp = (int[, , , ,])nextdp.Clone();
        }
        int res = 100;
        for (p = 0; p < 3; p++)
        {
            for (q = 0; q < 3; q++)
            {
                //Console.WriteLine(dp[countA + 2, countB + 2, countC + 2, p, q]);
                res = Math.Min(res, dp[countA + 2, countB + 2, countC + 2, p, q]);
            }
        }
        if (res >= 100) return -1;
        else return boxes.Length - res;
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
	private void test_case_0() { string Arg0 = "AAABBBCCC"; int Arg1 = 6; verify_case(0, Arg1, maxUntouched(Arg0)); }
	private void test_case_1() { string Arg0 = "AAAAAAAACBB"; int Arg1 = 7; verify_case(1, Arg1, maxUntouched(Arg0)); }
	private void test_case_2() { string Arg0 = "CCCCCB"; int Arg1 = -1; verify_case(2, Arg1, maxUntouched(Arg0)); }
	private void test_case_3() { string Arg0 = "BAACAABAACAAA"; int Arg1 = 5; verify_case(3, Arg1, maxUntouched(Arg0)); }
	private void test_case_4() { string Arg0 = "CBBABA"; int Arg1 = 6; verify_case(4, Arg1, maxUntouched(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BoxesArrangement ___test = new BoxesArrangement();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
