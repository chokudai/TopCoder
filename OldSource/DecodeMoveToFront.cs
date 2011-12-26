using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class DecodeMoveToFront {
    public string findKey(string[] plaintexts, string[] ciphertexts)
    {
        int i, j, k;
        Dictionary<char, char> dic = new Dictionary<char, char>();
        int len = plaintexts.Length;
        int MAX = 27;
        int[] num = new int[MAX];
        char[] cs = new char[MAX];
        for (i = 0; i < MAX; i++) cs[i] = '-';
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < MAX; j++) num[j] = j;
            for (j = 0; j < plaintexts[i].Length; j++)
            {
                char c = plaintexts[i][j];
                int next = ciphertexts[i][j] - 'A';
                if (next < 0) next = 26;
                int pos = num[next];
                if (cs[pos] != '-' && cs[pos] != c) return "ERROR";
                cs[pos] = c;
                int temp = num[next];
                for (k = next; k > 0; k--)
                {
                    num[k] = num[k - 1];
                }
                num[0] = temp;
            }
        }
        string res = "";
        bool[] b = new bool[27];
        int count = 0;
        int empty = -1;
        for (i = 0; i < MAX; i++)
        {
            if (cs[i] == ' ') b[26] = true;
            else if (cs[i] != '-')
            {
                b[(char)(cs[i] - 'A')] = true;
            }
            else
            {
                count++;
                empty = i;
            }
        }
        if (count == 1)
        {
            for (i = 0; i < 27; i++)
            {
                if (!b[i])
                {
                    if (i != 26) cs[empty] = (char)('A' + i);
                    else cs[empty] = ' ';
                }
            }
        }
        for (i = 0; i < MAX; i++) res += cs[i];
        Array.Sort(cs);
        for (i = 0; i < MAX - 1; i++) if (cs[i] == cs[i + 1] && cs[i] != '-') return "ERROR";
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"TPCDR"}; string[] Arg1 = new string[]{"GKYYL"}; string Arg2 = "------T-R-P------------DC--"; verify_case(0, Arg2, findKey(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"A","B"}; string[] Arg1 = new string[]{"X","X"}; string Arg2 = "ERROR"; verify_case(1, Arg2, findKey(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"HELLO"}; string[] Arg1 = new string[]{"HOWDY"}; string Arg2 = "ERROR"; verify_case(2, Arg2, findKey(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"FOUR SCORE AND","SEVEN YEARS AGO","OUR FOREFATHERS"}; string[] Arg1 = new string[]{"ABCDEFGFEHFIJK","FHLBKIMDLKHFDNK","BCDEEEDHDIOPEFJ"}; string Arg2 = "FOUR SCEANDVYGTH-----------"; verify_case(3, Arg2, findKey(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"LIZARD","JACKAL","HOWLER MONKEY","BLOWFISH","LYNX","GIRAFFE","VULTURE","QUAIL"}; string[] Arg1 = new string[]{"LG GLM","ZEQWCO","GFNMFLGRGLVGS","UMGOTJML","LQJY","OGKGSAG","WNNFCMG","XNFHN"}; string Arg2 = " ETAOIHNSRDLUWGCYMFPBKVQXJZ"; verify_case(4, Arg2, findKey(Arg0, Arg1)); }
	private void test_case_5() { string[] Arg0 = new string[]{"HI"}; string[] Arg1 = new string[]{"AA"}; string Arg2 = "ERROR"; verify_case(5, Arg2, findKey(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        DecodeMoveToFront ___test = new DecodeMoveToFront();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
