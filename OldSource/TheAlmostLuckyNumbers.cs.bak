using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheAlmostLuckyNumbers {
    long[] data2 = new long[5000];
    long[] data;
    long A,B;

    int maxgetnow=0;
    public long count(long a, long b)
    {

        int i, j, k;
        A = b; B = a - 1;
        //memo = new List<long>();
        //data2 = new long[5000];
        int count = 0;
        for (i = 1; i <= 10; i++)
        {
            for (j = 0; j < (1 << i); j++)
            {
                long now = 0;
                long mul = 1;
                for (k = 0; k < i; k++)
                {
                    if (((j >> k) & 1) == 0) now += mul * 4;
                    else now += mul * 7;
                    mul *= 10;
                }
                if (now > A) continue;
                bool flag = true;
                for (k = 0; k < count;k++ )
                {
                    long c = data2[k];
                    if (now % c == 0)
                    {
                        flag = false; break;
                    }
                }
                if (flag)
                {
                    data2[count] = now;
                    count++;
                }
            }
        }
        data = new long[count];
        for (i = 0; i < count; i++) data[i] = data2[i];
        Array.Reverse(data);
        //data = memo.ToArray();
        //Console.WriteLine(data.Length);
        long res = 0;
        for (i = 0; i < data.Length; i++)
        {
            res += saiki(i, 1, 0);
        }
        Console.WriteLine(maxgetnow);
        return res;
    }

    long saiki(int now, long mulnow, int getnow)
    {
        if (now == data.Length)
        {
            maxgetnow = Math.Max(maxgetnow, getnow);
            //Console.WriteLine(mulnow + " " + getnow + " " + ((A / mulnow) - (B / mulnow)));
            if (getnow % 2 == 1) return (A / mulnow) - (B / mulnow);
            else return (B / mulnow) - (A / mulnow);
        }
        long res = 0;
        //res += saiki(now + 1, mulnow, getnow);
        long next = (long)data[now]/ gcd(data[now], mulnow);

        if ((A / next+1) / mulnow == 0) return 0;
        next *= mulnow;
        for (int i = 1; i + now <= data.Length; i++)
        {
            res += saiki(now + i, next, getnow + 1);
        }
        return res;
    }

    long gcd(long a, long b)
    {
        //return 1;
        if (b > a) return gcd(b, a);
        if (b == 0) return a;
        return gcd(b, a % b);
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { long Arg0 = 1l; long Arg1 = 10l; long Arg2 = 3l; verify_case(0, Arg2, count(Arg0, Arg1)); }
	private void test_case_1() { long Arg0 = 14l; long Arg1 = 14l; long Arg2 = 1l; verify_case(1, Arg2, count(Arg0, Arg1)); }
	private void test_case_2() { long Arg0 = 1l; long Arg1 = 100l; long Arg2 = 39l; verify_case(2, Arg2, count(Arg0, Arg1)); }
    private void test_case_3() { long Arg0 = 1234l; long Arg1 = 10000000000l; long Arg2 = 1178l; verify_case(3, Arg2, count(Arg0, Arg1)); }
    //private void test_case_3() { long Arg0 = 1234l; long Arg1 = 4321l; long Arg2 = 1178l; verify_case(3, Arg2, count(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheAlmostLuckyNumbers ___test = new TheAlmostLuckyNumbers();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
