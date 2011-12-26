using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Glossary {
    public string[] buildGlossary(string[] items)
    {
        //Array.Sort(items, String.CompareOrdinal);
        Array.Sort(items);
        int i;
        bool[] flag = new bool[26];
        int len = items.Length;

        List<string> s1l = new List<string>();
        List<string> s2l = new List<string>();


        string blank = "                   ";
        string blank2 = "                  ";
        string bar = "-------------------";

        for (i = 0; i < len; i++)
        {

            string adds = "  " + items[i];
            while (adds.Length < 19) adds += " ";

            int num = getnum(items[i][0]);
            if (num < 13)
            {
                if (!flag[num])
                {
                    s1l.Add((char)('A' + num) + blank2);
                    s1l.Add(bar);
                }
                s1l.Add(adds);
            }
            else
            {
                if (!flag[num])
                {
                    s2l.Add((char)('A' + num) + blank2);
                    s2l.Add(bar);
                }
                s2l.Add(adds);
            }
            flag[num] = true;
        }
        string[] s1 = s1l.ToArray();
        string[] s2 = s2l.ToArray();

        List<string> res = new List<string>();

        for (i = 0; i < Math.Max(s1.Length, s2.Length); i++)
        {
            string st = "";
            if (s1.Length <= i) st += blank;
            else st += s1[i];
            st += "  ";
            if (s2.Length <= i) st += blank;
            else st += s2[i];
            res.Add(st);
        }
        return res.ToArray();
    }


    int getnum(char c)
    {
        if (c >= 'a' && c <= 'z') return c - 'a';
        return c - 'A';
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, string[] Expected, string[] Received) {
		Console.Write("Test Case #" + Case + "...");
		if (equal_arrays(Expected, Received)) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: " + print_array(Expected)); 
			Console.WriteLine("\tReceived: " + print_array(Received)); } }
	string print_array(string[] V) {
		System.Text.StringBuilder builder = new System.Text.StringBuilder();
		builder.Append("{ ");
		foreach (string o in V) {
			builder.Append('\"');
			builder.Append(o.ToString());
			builder.Append("\",");
		}
		builder.Append(" }");
		return builder.ToString();
	}
	bool equal_arrays(string[] a, string[]b) {
		if (a.Length != b.Length) return false;
		for (int i = 0; i < a.Length; ++i) if (a[i] != b[i]) return false;
		return true;
	}
	private void test_case_0() { string[] Arg0 = new string[]{"Canada", "France", "Germany", "Italy", "Japan", "Russia", 
 "United Kingdom", "United States"}; string[] Arg1 = new string[]{"C                    R                  ", "-------------------  -------------------", "  Canada               Russia           ", "F                    U                  ", "-------------------  -------------------", "  France               United Kingdom   ", "G                      United States    ", "-------------------                     ", "  Germany                               ", "I                                       ", "-------------------                     ", "  Italy                                 ", "J                                       ", "-------------------                     ", "  Japan                                 " }; verify_case(0, Arg1, buildGlossary(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"alpha", "beta", "gamma", "delta", "omega"}; string[] Arg1 = new string[]{"A                    O                  ", "-------------------  -------------------", "  alpha                omega            ", "B                                       ", "-------------------                     ", "  beta                                  ", "D                                       ", "-------------------                     ", "  delta                                 ", "G                                       ", "-------------------                     ", "  gamma                                 " }; verify_case(1, Arg1, buildGlossary(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"AVL tree", "backtracking", "array", "balanced tree", "binary search"}; string[] Arg1 = new string[]{"A                                       ", "-------------------                     ", "  array                                 ", "  AVL tree                              ", "B                                       ", "-------------------                     ", "  backtracking                          ", "  balanced tree                         ", "  binary search                         " }; verify_case(2, Arg1, buildGlossary(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"XXXXXXXXXXXXXXXXX", 
 "YYYYYYYYYYYYYYYYY",
 "ZZZZZZZZZZZZZZZZZ"}; string[] Arg1 = new string[]{"                     X                  ", "                     -------------------", "                       XXXXXXXXXXXXXXXXX", "                     Y                  ", "                     -------------------", "                       YYYYYYYYYYYYYYYYY", "                     Z                  ", "                     -------------------", "                       ZZZZZZZZZZZZZZZZZ" }; verify_case(3, Arg1, buildGlossary(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"Asteria", "Astraeus", "Atlas", "Clymene", "Coeus", "Crius", 
 "Cronus", "Dione", "Epimetheus", "Helios", "Hyperion", "Iapetus", 
 "Leto", "Mnemosyne", "Oceanus", "Ophion", "Phoebe", "Prometheus", 
 "Rhea", "Tethys", "Theia", "Themis"}; string[] Arg1 = new string[]{"A                    O                  ", "-------------------  -------------------", "  Asteria              Oceanus          ", "  Astraeus             Ophion           ", "  Atlas              P                  ", "C                    -------------------", "-------------------    Phoebe           ", "  Clymene              Prometheus       ", "  Coeus              R                  ", "  Crius              -------------------", "  Cronus               Rhea             ", "D                    T                  ", "-------------------  -------------------", "  Dione                Tethys           ", "E                      Theia            ", "-------------------    Themis           ", "  Epimetheus                            ", "H                                       ", "-------------------                     ", "  Helios                                ", "  Hyperion                              ", "I                                       ", "-------------------                     ", "  Iapetus                               ", "L                                       ", "-------------------                     ", "  Leto                                  ", "M                                       ", "-------------------                     ", "  Mnemosyne                             " }; verify_case(4, Arg1, buildGlossary(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        Glossary ___test = new Glossary();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
