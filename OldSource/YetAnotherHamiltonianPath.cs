using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class YetAnotherHamiltonianPath
{

    public int leastCost(string[] label)
    {
        int len = label.Length;
        bool[] used = new bool[len];
        used[0] = used[1] = true;
        int pre = 0;
        int i, j;
        int res = 0;
        for (i = 0; i < len - 2; i++)
        {
            int max = -9999999;
            int num = -1;
            for (j = 0; j < len; j++)
            {
                if (used[j]) continue;
                int now = getlcm(label[pre], label[j]) * 100 - getlcm(label[1], label[j]);
                if (max < now)
                {
                    max = now;
                    num = j;
                }
            }

            if (num == -1) break;
            res += getdist(label[pre], label[num]);
            pre = num;
            used[pre] = true;
        }
        res += getdist(label[pre], label[1]);
        return res;
    }

    int getdist(string a, string b)
    {
        int lcm = getlcm(a, b);
        return a.Length * a.Length + b.Length * b.Length - lcm * lcm;
    }

    int getlcm(string a, string b)
    {
        int i;
        int lcm = 0;
        for (i = 0; i < a.Length && i < b.Length; i++)
        {
            if (a[i] == b[i]) lcm++;
            else break;
        }
        return lcm;
    }


    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
    private void verify_case(int Case, int Expected, int Received)
    {
        Console.Write("Test Case #" + Case + "...");
        if (Expected == Received)
            Console.WriteLine("PASSED");
        else
        {
            Console.WriteLine("FAILED");
            Console.WriteLine("\tExpected: \"" + Expected + '\"');
            Console.WriteLine("\tReceived: \"" + Received + '\"');
        }
    }
    private void test_case_0() { string[] Arg0 = new string[] { "home", "school", "pub" }; int Arg1 = 70; verify_case(0, Arg1, leastCost(Arg0)); }
    private void test_case_1() { string[] Arg0 = new string[] { "school", "home", "pub", "stadium" }; int Arg1 = 167; verify_case(1, Arg1, leastCost(Arg0)); }
    private void test_case_2() { string[] Arg0 = new string[] { "abcd", "aecgh", "abef", "aecd" }; int Arg1 = 91; verify_case(2, Arg1, leastCost(Arg0)); }
    private void test_case_3() { string[] Arg0 = new string[] { "canada", "cyprus", "croatia", "colombia", "chile", "china", "cameroon" }; int Arg1 = 509; verify_case(3, Arg1, leastCost(Arg0)); }

    // END CUT HERE
    // BEGIN CUT HERE
    public static void Main()
    {
        try
        {
            YetAnotherHamiltonianPath ___test = new YetAnotherHamiltonianPath();
            ___test.run_test(-1);
        }
        catch (Exception e)
        {
            //Console.WriteLine(e.StackTrace);
            Console.WriteLine(e.ToString());
        }
    }
    // END CUT HERE
}
