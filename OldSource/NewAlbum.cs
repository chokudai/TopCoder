using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class NewAlbum {
    public int leastAmountOfCDs(int nSongs, int length, int cdCapacity)
    {
        int num = (cdCapacity+1) / (length + 1);
        if (num % 13 == 0) num--;
        int temp = (nSongs + num - 1) / num;
        int nokori = nSongs - num * (temp - 1);
        if (nokori % 13 == 0)
        {
            if (temp == 1 || nokori == num - 1) temp++;
        }
        return temp;
    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 7; int Arg1 = 2; int Arg2 = 6; int Arg3 = 4; verify_case(0, Arg3, leastAmountOfCDs(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int Arg0 = 20; int Arg1 = 1; int Arg2 = 100; int Arg3 = 1; verify_case(1, Arg3, leastAmountOfCDs(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int Arg0 = 26; int Arg1 = 1; int Arg2 = 100; int Arg3 = 2; verify_case(2, Arg3, leastAmountOfCDs(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int Arg0 = 26; int Arg1 = 3; int Arg2 = 51; int Arg3 = 3; verify_case(3, Arg3, leastAmountOfCDs(Arg0, Arg1, Arg2)); }
	private void test_case_4() { int Arg0 = 67; int Arg1 = 271; int Arg2 = 1000; int Arg3 = 23; verify_case(4, Arg3, leastAmountOfCDs(Arg0, Arg1, Arg2)); }
	private void test_case_5() { int Arg0 = 27; int Arg1 = 1; int Arg2 = 27; int Arg3 = 3; verify_case(5, Arg3, leastAmountOfCDs(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
NewAlbum ___test = new NewAlbum();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
