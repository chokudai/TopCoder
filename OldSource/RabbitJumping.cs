using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RabbitJumping {
    
    long bigvalue = (long)1 << 50;

    public int getMinimum(int[] holes, int largeJump)
    {
        
        List<long> odd = new List<long>();
        List<long> even = new List<long>();
        int i, j, k;
        Array.Sort(holes);
        odd.Add(-bigvalue - 1);
        even.Add(-bigvalue);
        for (i = 0; i < holes.Length / 2; i++)
        {
            long mi = holes[2 * i];
            long ma = holes[2 * i + 1];
            long oddmi, oddma, evenmi, evenma;
            oddmi = evenmi = mi;
            oddma = evenma = ma + 1;
            if (oddmi % 2 == 0) oddmi++;
            if (oddma % 2 == 0) oddma++;
            if (evenmi % 2 == 1) evenmi++;
            if (evenma % 2 == 1) evenma++;
            odd.Add(oddmi);
            odd.Add(oddma);
            even.Add(evenmi);
            even.Add(evenma);
        }
        odd.Add(bigvalue - 1);
        even.Add(bigvalue);

        int vlen = (odd.Count + even.Count) / 2;

        long[] minpos = new long[vlen];
        long[] maxpos = new long[vlen];

        int count = 0;
        bool flag = true;
        foreach (long a in even)
        {
            if (flag) minpos[count++] = a;
            flag = !flag;
        }
        foreach (long a in odd)
        {
            if (flag) minpos[count++] = a;
            flag = !flag;
        }

        count = 0;
        flag = false;
        foreach (long a in even)
        {
            if (flag) maxpos[count++] = a;
            flag = !flag;
        }
        foreach (long a in odd)
        {
            if (flag) maxpos[count++] = a;
            flag = !flag;
        }

        long[,] dp = new long[vlen, vlen];
        for (i = 0; i < vlen; i++)
        {
            for (j = 0; j < vlen; j++)
            {
                dp[i, j] = bigvalue;
                if (i == j) dp[i, j] = Math.Min(dp[i, j], 0);
                long a;

                if (minpos[i] <= maxpos[i] - 2)
                {
                    a = minpos[i] + 2;
                    if (a >= minpos[j] && a < maxpos[j] && (a - minpos[j]) % 2 == 0) dp[i, j] = Math.Min(dp[i, j], 0);
                    a = minpos[i] - 2;
                    if (a >= minpos[j] && a < maxpos[j] && (a - minpos[j]) % 2 == 0) dp[i, j] = Math.Min(dp[i, j], 0);
                    a = minpos[i] + largeJump;
                    if (a >= minpos[j] && a < maxpos[j] && (a - minpos[j]) % 2 == 0) dp[i, j] = Math.Min(dp[i, j], 1);
                    a = minpos[i] - largeJump;
                    if (a >= minpos[j] && a < maxpos[j] && (a - minpos[j]) % 2 == 0) dp[i, j] = Math.Min(dp[i, j], 1);

                    a = maxpos[i] + 2 - 2;
                    if (a >= minpos[j] && a < maxpos[j] && (a - minpos[j]) % 2 == 0) dp[i, j] = Math.Min(dp[i, j], 0);
                    a = maxpos[i] - 2 - 2;
                    if (a >= minpos[j] && a < maxpos[j] && (a - minpos[j]) % 2 == 0) dp[i, j] = Math.Min(dp[i, j], 0);
                    a = maxpos[i] + largeJump - 2;
                    if (a >= minpos[j] && a < maxpos[j] && (a - minpos[j]) % 2 == 0) dp[i, j] = Math.Min(dp[i, j], 1);
                    a = maxpos[i] - largeJump - 2;
                    if (a >= minpos[j] && a < maxpos[j] && (a - minpos[j]) % 2 == 0) dp[i, j] = Math.Min(dp[i, j], 1);
                }
                
            }
        }

        for (i = 0; i < vlen; i++)
        {
            for (j = 0; j < vlen; j++)
            {
                dp[i, j] = Math.Min(dp[i, j], dp[j, i]);
            }
        }

        for (i = 0; i < vlen; i++)
        {
            Console.WriteLine(minpos[i] + " " + maxpos[i]);
        }

        for (i = 0; i < vlen; i++)
        {
            for (j = 0; j < vlen; j++)
            {
                if (dp[i, j] == bigvalue) Console.Write("x ");
                else Console.Write("{0} ", dp[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (k = 0; k < vlen; k++)
        {
            for (i = 0; i < vlen; i++)
            {
                for (j = 0; j < vlen; j++)
                {
                    dp[i, j] = Math.Min(dp[i, j], dp[i, k] + dp[k, j]);
                }
            }
        }

        for (i = 0; i < vlen; i++)
        {
            for (j = 0; j < vlen; j++)
            {
                if (dp[i, j] == bigvalue) Console.Write("x ");
                else Console.Write("{0} ", dp[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        if (dp[0, vlen - 1] == bigvalue) return -1;
        else return (int)dp[0, vlen - 1];

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
	private void test_case_0() { int[] Arg0 = new int[]{ 1, 2 }; int Arg1 = 3; int Arg2 = 1; verify_case(0, Arg2, getMinimum(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{ 1, 2 }; int Arg1 = 4; int Arg2 = -1; verify_case(1, Arg2, getMinimum(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{ 2, 3 }; int Arg1 = 3; int Arg2 = 3; verify_case(2, Arg2, getMinimum(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{ 2, 17, 21, 36, 40, 55, 59, 74 }; int Arg1 = 19; int Arg2 = 5; verify_case(3, Arg2, getMinimum(Arg0, Arg1)); }
	private void test_case_4() { int[] Arg0 = new int[]{ 187640193, 187640493, 187640738, 187640845, 564588641, 564588679, 
  564588696, 564588907, 605671187, 605671278, 605671288, 605671386, 
  755723729, 755723774, 755723880, 755723920, 795077469, 795077625, 
  795077851, 795078039, 945654724, 945654815, 945655107, 945655323 }
; int Arg1 = 475; int Arg2 = 9; verify_case(4, Arg2, getMinimum(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
RabbitJumping ___test = new RabbitJumping();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
