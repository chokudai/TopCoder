using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ConvexSequence
{
    public long getMinimum(int[] a)
    {
        bool flag = true;
        int[] first = (int[])a.Clone();
        int i;
        while (flag)
        {
            flag = false;
            for (i = 1; i < a.Length - 1; i++)
            {
                if (a[i] * 2 > a[i - 1] + a[i + 1])
                {
                    flag = true;
                    a[i] = (a[i - 1] + a[i + 1]) / 2;
                }
            }

        }
        long res = 0;
        for (i = 0; i < a.Length; i++) res += first[i] - a[i];
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
    private void verify_case(int Case, long Expected, long Received)
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
    private void test_case_0() { int[] Arg0 = new int[] { 6, 5, 1, 5, 3, 3 }; long Arg1 = 7l; verify_case(0, Arg1, getMinimum(Arg0)); }
    private void test_case_1() { int[] Arg0 = new int[] { 3, 0, 1, 4 }; long Arg1 = 0l; verify_case(1, Arg1, getMinimum(Arg0)); }
    private void test_case_2() { int[] Arg0 = new int[] { 1, 1, 1, 0, 2, 2, 2 }; long Arg1 = 5l; verify_case(2, Arg1, getMinimum(Arg0)); }
    private void test_case_3()
    {
        int[] Arg0 = new int[]{854159326, 317144183, 781399725, 287076509, 894967145, 882577367, 174517516, 134415519,
 274494874, 709819883, 59717133, 732212854, 40551288, 232526958, 811785438, 930853743,
 946882902, 321325300, 397702677, 376192501, 599310562, 889156198, 135776890, 882710939,
 823196361, 681959076, 318666702, 94469186, 536320456, 116468376, 530320850, 436708006,
 903344748, 659080120, 774722507, 967315412, 566063635, 43970906, 497687103, 781266213,
 876086123, 366960001, 587364849, 191948103, 172568553, 539762057, 83507466, 71569625,
 686305822, 663789601}; long Arg1 = 20178337330l; verify_case(3, Arg1, getMinimum(Arg0));
    }
    private void test_case_4() { int[] Arg0 = new int[] { 5 }; long Arg1 = 0l; verify_case(4, Arg1, getMinimum(Arg0)); }

    // END CUT HERE
    // BEGIN CUT HERE
    public static void Main()
    {
        try
        {
            ConvexSequence ___test = new ConvexSequence();
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
