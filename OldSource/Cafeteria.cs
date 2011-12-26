using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Cafeteria {
public string latestTime(int[] offset, int[] walkingTime, int[] drivingTime) {
    int best = 0;
    int nokori;
    int i;
    for (i = offset.Length - 1; i >= 0; i--)
    {
        nokori = 150;
        nokori += 60 * 12 * 100;
        nokori -= drivingTime[i];
        nokori -= (nokori - offset[i]) % 10;
        nokori -= walkingTime[i];
        best = Math.Max(nokori, best);
    }
    nokori = best;
    nokori %= 720;
    if (nokori < 60) nokori += 720;
    string s = string.Concat(nokori / 60);
    while (s.Length != 2) s = "0" + s;
    string ss = string.Concat(nokori % 60);
    while (ss.Length != 2) ss = "0" + ss;
    return string.Concat(s, ":", ss);
}




// BEGIN CUT HERE
public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{9}; int[] Arg1 = new int[]{1}; int[] Arg2 = new int[]{1}; string Arg3 = "02:28"; verify_case(0, Arg3, latestTime(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int[] Arg0 = new int[]{6}; int[] Arg1 = new int[]{9}; int[] Arg2 = new int[]{120}; string Arg3 = "12:17"; verify_case(1, Arg3, latestTime(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int[] Arg0 = new int[]{6,9}; int[] Arg1 = new int[]{9,10}; int[] Arg2 = new int[]{120,121}; string Arg3 = "12:19"; verify_case(2, Arg3, latestTime(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int[] Arg0 = new int[]{0,1,2,3,4,5,6,7,8,9}; int[] Arg1 = new int[]{11,11,11,11,11,11,11,11,11,11}; int[] Arg2 = new int[]{190,190,190,190,190,190,190,190,190,190}; string Arg3 = "11:09"; verify_case(3, Arg3, latestTime(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int[] Arg0 = new int[]{7,4,0,0,2,1,6,7,7,0,8,6,0,5,0,6,7,9,0,2,4,8,4,7,
9,2,4,4,3,1,4,5,8,8,2,5,7,8,7,5,6,8,8,0,1,3,5,0,8}; int[] Arg1 = new int[]{26,14,1,4,16,28,16,6,4,5,21,18,5,2,21,21,28,22,5,22,26,16,14,
19,19,19,4,12,24,4,30,16,28,20,25,2,30,18,4,6,9,22,8,3,7,29,8,30,6}; int[] Arg2 = new int[]{151,264,280,89,63,57,15,120,28,296,76,269,90,106,31,222,
291,52,102,73,140,248,44,187,76,49,296,106,54,119,54,283,263,
285,275,127,108,82,84,241,169,203,244,256,109,288,9,262,103}; string Arg3 = "02:07"; verify_case(4, Arg3, latestTime(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Cafeteria ___test = new Cafeteria();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
