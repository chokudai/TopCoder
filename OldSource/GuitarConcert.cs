using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class GuitarConcert {
    public string[] buyGuitars(string[] guitarNames, string[] guitarSongs)
    {
        int len = guitarNames.Length;
        int songs = guitarSongs[0].Length;
        int i, j, k;
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len - 1; j++)
            {
                if (String.CompareOrdinal(guitarNames[j], guitarNames[j + 1]) < 0)
                {
                    string temp = guitarNames[j];
                    guitarNames[j] = guitarNames[j + 1];
                    guitarNames[j + 1] = temp;
                    temp = guitarSongs[j];
                    guitarSongs[j] = guitarSongs[j + 1];
                    guitarSongs[j + 1] = temp;
                }
            }
        }
        int bestsong = 0;
        int bestuse = 0;
        int best = 0;
        for (i = 1; i < (1 << len); i++)
        {
            bool[] s = new bool[songs];
            int song = 0;
            int use = 0;
            for (j = 0; j < len; j++)
            {
                if ((i >> j) % 2 == 1)
                {
                    use++;
                    for (k = 0; k < songs; k++)
                    {
                        if (guitarSongs[j][k] == 'Y') s[k] = true;
                    }
                }
            }
            for (k = 0; k < songs; k++)
            {
                if (s[k]) song++;
            }
            if (song > bestsong || (song == bestsong && bestuse >= use))
            {
                bestsong = song;
                bestuse = use;
                best = i;
            }
        }
        List<string> l = new List<string>();
        for (j = 0; j < len; j++)
        {
            if ((best >> j) % 2 == 1)
            {
                l.Add(guitarNames[j]);
            }
        }
        string[] res = l.ToArray();
        Array.Reverse(res);
        return res;
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
	private void test_case_0() { string[] Arg0 = new string[]{"GIBSON","FENDER", "TAYLOR"}; string[] Arg1 = new string[]{"YNYYN", "NNNYY", "YYYYY"}; string[] Arg2 = new string[]{"TAYLOR" }; verify_case(0, Arg2, buyGuitars(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"GIBSON", "CRAFTER", "FENDER", "TAYLOR"}; string[] Arg1 = new string[]{"YYYNN", "NNNYY", "YYNNY", "YNNNN"}; string[] Arg2 = new string[]{"CRAFTER", "GIBSON" }; verify_case(1, Arg2, buyGuitars(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"AB", "AA", "BA"}; string[] Arg1 = new string[]{"YN", "YN", "NN"}; string[] Arg2 = new string[]{"AA" }; verify_case(2, Arg2, buyGuitars(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"FENDER", "GIBSON", "CRAFTER", "EPIPHONE", "BCRICH"}; string[] Arg1 = new string[]{"YYNNYNN", "YYYNYNN", "NNNNNYY", "NNYNNNN", "NNNYNNN"}; string[] Arg2 = new string[]{"BCRICH", "CRAFTER", "GIBSON" }; verify_case(3, Arg2, buyGuitars(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"GIBSON","FENDER"}; string[] Arg1 = new string[]{"NNNNNNNNNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNNNNNNNNNN"}; string[] Arg2 = new string[]{ }; verify_case(4, Arg2, buyGuitars(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        GuitarConcert ___test = new GuitarConcert();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
