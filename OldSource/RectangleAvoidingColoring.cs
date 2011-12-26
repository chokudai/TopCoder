using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RectangleAvoidingColoring
{
    public long count(string[] board)
    {
        //Ç±Ç±Ç…âÒìöì¸óÕ
        return 0;
    }

    // BEGIN CUT HERE
    public void run_test(int Case)
    {
        if ((Case == -1) || (Case == 0)) test_case_0();
        if ((Case == -1) || (Case == 1)) test_case_1();
        if ((Case == -1) || (Case == 2)) test_case_2();
        if ((Case == -1) || (Case == 3)) test_case_3();
        if ((Case == -1) || (Case == 4)) test_case_4();
        if ((Case == -1) || (Case == 5)) test_case_5();
        if ((Case == -1)) Console.WriteLine("Å™Div2 Hard / Å´Div1 Medium");
        if ((Case == -1) || (Case == 6)) test_case_6();
        if ((Case == -1) || (Case == 7)) test_case_7();
        if ((Case == -1) || (Case == 8)) test_case_8();
    }
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
    private void test_case_0()
    {
        string[] Arg0 = new string[]{"??",
 "??"}; long Arg1 = 14l; verify_case(0, Arg1, count(Arg0));
    }
    private void test_case_1()
    {
        string[] Arg0 = new string[]{"B?",
 "?B"}; long Arg1 = 3l; verify_case(1, Arg1, count(Arg0));
    }
    private void test_case_2()
    {
        string[] Arg0 = new string[]{"WW",
 "WW"}; long Arg1 = 0l; verify_case(2, Arg1, count(Arg0));
    }
    private void test_case_3()
    {
        string[] Arg0 = new string[]{"??B??",
 "W???W",
 "??B??"}; long Arg1 = 12l; verify_case(3, Arg1, count(Arg0));
    }
    private void test_case_4()
    {
        string[] Arg0 = new string[]{"??",
 "W?",
 "W?",
 "?W",
 "W?"}; long Arg1 = 16l; verify_case(4, Arg1, count(Arg0));
    }

    private void test_case_5()
    {
        string[] Arg0 = new string[]{"??????????",
"??????????"}; long Arg1 = 34304l; verify_case(5, Arg1, count(Arg0));
    }

    private void test_case_6()
    {
        string[] Arg0 = new string[] { "??????????????????????????????????????????????????", "?W????????????????????B???????????????????????????" };
        long Arg1 = 186899384535875584l; verify_case(6, Arg1, count(Arg0));
    }

    private void test_case_7()
    {
        string[] Arg0 = new string[] { "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "B?", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??", "??" };
        long Arg1 = 373517294095040512l; verify_case(7, Arg1, count(Arg0));
    }

    private void test_case_8()
    {
        string[] Arg0 = new string[] { "??????????????????????????????????????????????????" };
        long Arg1 = 1125899906842624l; verify_case(8, Arg1, count(Arg0));
    }


    // END CUT HERE
    // BEGIN CUT HERE
    public static void Main()
    {
        try
        {
            RectangleAvoidingColoring ___test = new RectangleAvoidingColoring();
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
