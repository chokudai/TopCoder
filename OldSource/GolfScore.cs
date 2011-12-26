using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class GolfScore {
    public int tally(int[] parValues, string[] scoreSheet)
    {
    //"triple bogey"  three strokes over par
    //"double bogey"  two strokes over par
    //"bogey"         one stroke over par
    //"par"           exactly par 
    //"birdie"        one stroke under par
    //"eagle"         two strokes under par
    //"albatross"     three strokes under par
    //"hole in one"   exactly one stroke
        int res = 0;
        int i;
        int len = scoreSheet.Length;
        Dictionary<string, int> dic = new Dictionary<string, int>();
        dic["triple bogey"] = 3;
        dic["double bogey"] = 2;
        dic["bogey"] = 1;
        dic["par"] = 0;
        dic["birdie"] = -1;
        dic["eagle"] = -2;
        dic["albatross"] = -3;

        for (i = 0; i < len; i++)
        {
            if (scoreSheet[i] == "hole in one") res += 1;
            else
            {
                res += dic[scoreSheet[i]] + parValues[i];
            }
        }
        return res;
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
	private void test_case_0() { int[] Arg0 = new int[]{1, 1, 1, 1, 1, 1,
 1, 1, 1, 5, 5, 5,
 5, 5, 5, 5, 5, 5}; string[] Arg1 = new string[]{"bogey", "bogey", "bogey", "bogey", "bogey", "bogey",
 "bogey", "bogey", "bogey", "eagle", "eagle", "eagle",
 "eagle", "eagle", "eagle", "eagle", "eagle", "eagle"}; int Arg2 = 45; verify_case(0, Arg2, tally(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{3, 2, 4, 2, 2, 1,
 1, 1, 3, 2, 4, 4,
 4, 2, 3, 1, 3, 2}; string[] Arg1 = new string[]{"bogey", "double bogey", "par", "double bogey", "double bogey", "triple bogey",
 "triple bogey", "triple bogey", "bogey", "double bogey", "par", "par",
 "par", "double bogey", "bogey", "triple bogey", "bogey", "double bogey"}; int Arg2 = 72; verify_case(1, Arg2, tally(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{3, 2, 4, 2, 2, 1,
 1, 1, 3, 2, 4, 4,
 4, 2, 3, 1, 3, 2}; string[] Arg1 = new string[]{"eagle", "birdie", "albatross", "birdie", "birdie", "par",
 "hole in one", "par", "eagle", "birdie", "albatross", "albatross",
 "albatross", "birdie", "eagle", "hole in one", "eagle", "birdie"}; int Arg2 = 18; verify_case(2, Arg2, tally(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{4, 1, 3, 3, 4, 4,
 1, 4, 2, 3, 3, 5,
 4, 1, 4, 4, 2, 1}; string[] Arg1 = new string[]{"triple bogey", "triple bogey", "bogey", "par", "triple bogey", "double bogey",
 "triple bogey", "triple bogey", "par", "eagle", "bogey", "bogey",
 "birdie", "par", "triple bogey", "eagle", "triple bogey", "triple bogey"}; int Arg2 = 77; verify_case(3, Arg2, tally(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
GolfScore ___test = new GolfScore();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
