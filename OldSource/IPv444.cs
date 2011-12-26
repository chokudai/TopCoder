using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class IPv444 {
    public long getMaximumMoney(string[] request, int[] price)
    {
        int i, j, k;
        int len = request.Length;
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len - 1; j++)
            {
                if (price[j] < price[j + 1])
                {
                    int temp = price[j];
                    price[j] = price[j + 1];
                    price[j + 1] = temp;
                    string temps = request[j];
                    request[j] = request[j + 1];
                    request[j + 1] = temps;
                }
            }
        }
        Dictionary<long, long> dic = new Dictionary<long, long>();
        long res = 0;
        long[] ar = new long[4] { 1, 1002, 1002 * 1002, (long)1002 * 1002 * 1002 };
        for (i = 0; i < len; i++)
        {
            long mine = 1;
            long mynumber = 0;
            string[] s = request[i].Split('.');
            long[] num = new long[4];
            for (j = 0; j < 4; j++)
            {
                if (s[j] == "*")
                {
                    num[j] = 1000;
                    mine *= 1000;
                }
                else
                {
                    num[j] = int.Parse(s[j]);
                }
                mynumber += num[j] * ar[j];
            }
            long add = mine;
            long[] memo = new long[16];
            if (dic.ContainsKey(mynumber))
            {
                for (k = 0; k < (1 << 4); k++)
                {
                    long need = 1;
                    long now = 0;
                    int count = 0;
                    for (j = 0; j < 4; j++)
                    {
                        if ((k >> j) % 2 == 1)
                        {
                            now += ar[j] * 1000;
                            need *= 1000;
                            count++;
                        }
                        else
                        {
                            if (num[j] != 1000) now += ar[j] * 1001;
                            //else continue;
                            now += ar[j] * num[j];
                        }
                    }
                    long d = 0;
                    if (dic.ContainsKey(now)) d = dic[now];
                    d = Math.Max(d - memo[k], 0);
                    add -= d;
                    Console.WriteLine(k + " " + d);
                    for (j = 15; j > k; j = ((j - 1) & k))
                    {
                        int nextcount = 0;
                        for (j = 0; j < 4; j++)
                        {
                            if ((k >> j) % 2 == 1)
                            {
                                nextcount++;
                            }
                        }
                        memo[j] += d;
                        //if (j == 0) break;
                    }
                    //if (j != 4) continue;
                }
                //add -= dic[mynumber];
                //Console.WriteLine("dic:" + dic[mynumber]);
            }
            /*
            for (k = 0; k < (1 << 4); k++)
            {
                long need = 1;
                long now = 0;
                for (j = 0; j < 4; j++)
                {
                    if ((k >> j) % 2 == 1)
                    {
                        now += ar[j] * 1000;
                        need *= 1000;
                    }
                    else
                    {
                        if (num[j] == 1000) continue;
                        now += ar[j] * num[j];
                    }
                }
                if (j != 4) continue;
                if (dic.ContainsKey(now) && dic[now] == need)
                {
                    add = 0; break;
                }
            }
             */
            Console.WriteLine(request[i] + " " + add);
            if (add != 0)
            {
                res += add * price[i];
                for (k = 0; k < (1 << 4); k++)
                {
                    long need = 1;
                    long now = 0;
                    for (j = 0; j < 4; j++)
                    {
                        if ((k >> j) % 2 == 1)
                        {
                            now += ar[j] * 1000;
                            need *= 1000;
                        }
                        else
                        {
                            if (num[j] == 1000) now += ar[j] *= 1001;
                            now += ar[j] * num[j];
                        }
                    }
                    if (j != 4) continue;
                    if (dic.ContainsKey(now))
                    {
                        dic[now] += add;
                    }
                    else dic[now] = add;
                    //Console.Write(now + " ");
                }
            }
            //Console.WriteLine();
        }
        return res;
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
	private void test_case_0() { string[] Arg0 = new string[]{"66.37.210.86"}; int[] Arg1 = new int[]{47}; long Arg2 = 47l; verify_case(0, Arg2, getMaximumMoney(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"0.0.0.*", "0.0.0.3", "0.0.0.5"}; int[] Arg1 = new int[]{1, 3, 9}; long Arg2 = 1010l; verify_case(1, Arg2, getMaximumMoney(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"*.*.*.*", "123.456.789.0", "434.434.434.434", "999.*.999.*"}; int[] Arg1 = new int[]{1, 5, 3, 6}; long Arg2 = 1000005000006l; verify_case(2, Arg2, getMaximumMoney(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"*.*.999.999", "888.888.999.*", "888.888.*.999", "777.777.777.777", "777.*.*.777"}; int[] Arg1 = new int[]{19, 33, 42, 777, 7}; long Arg2 = 26075718l; verify_case(3, Arg2, getMaximumMoney(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"127.0.0.1", "*.0.0.*", "*.*.255.255", "192.68.*.*"}; int[] Arg1 = new int[]{999999, 629851, 294016, 438090}; long Arg2 = 1361957076132l; verify_case(4, Arg2, getMaximumMoney(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
IPv444 ___test = new IPv444();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
