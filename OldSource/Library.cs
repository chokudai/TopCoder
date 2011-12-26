using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Library {
    public int documentAccess(string[] records, string[] userGroups, string[] roomRights)
    {
        Dictionary<string, int> userdic = new Dictionary<string, int>();
        Dictionary<string, int> roomdic = new Dictionary<string, int>();
        Dictionary<string, int> recdic = new Dictionary<string, int>();
        int i;
        for (i = 0; i < userGroups.Length; i++) userdic[userGroups[i]] = 1;
        for (i = 0; i < roomRights.Length; i++) roomdic[roomRights[i]] = 1;
        for (i = 0; i < records.Length; i++)
        {
            string[] st = records[i].Split(' ');
            if (userdic.ContainsKey(st[2]) && roomdic.ContainsKey(st[1])) recdic[st[0]] = 1;
        }
        return recdic.Count;
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
	private void test_case_0() { string[] Arg0 = new string[]{"diary computers editor","fairytale gardening editor","comix cars author","comix cars librarian"}; string[] Arg1 = new string[]{"employee","editor","author"}; string[] Arg2 = new string[]{"history","cars","computers"}; int Arg3 = 2; verify_case(0, Arg3, documentAccess(Arg0, Arg1, Arg2)); }
	private void test_case_1() { string[] Arg0 = new string[]{"diary computers editor","fairytale gardening editor","comix cars author","comix cars librarian"}; string[] Arg1 = new string[]{"employee","editor","author","librarian"}; string[] Arg2 = new string[]{"history","cars","computers"}; int Arg3 = 2; verify_case(1, Arg3, documentAccess(Arg0, Arg1, Arg2)); }
	private void test_case_2() { string[] Arg0 = new string[]{"diary computers editor","fairytale gardening editor","comix cars author","comix cars librarian"}; string[] Arg1 = new string[]{"employee","editor","author","librarian"}; string[] Arg2 = new string[]{}; int Arg3 = 0; verify_case(2, Arg3, documentAccess(Arg0, Arg1, Arg2)); }
	private void test_case_3() { string[] Arg0 = new string[]{"a b c","a b d","b b c","b b d","e c d","e c b","e c c","t d e"}; string[] Arg1 = new string[]{"c","d","x"}; string[] Arg2 = new string[]{"a","b","c"}; int Arg3 = 3; verify_case(3, Arg3, documentAccess(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Library ___test = new Library();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
