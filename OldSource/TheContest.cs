using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheContest {
    public string[] getSchedule(int N, int M)
    {
        string[] res = new string[N];
        long[] nokori = new string[N, M];
        long[] tate = new long[M];
        int i, j, k, l;
        for (j = 0; j < M; j++) tate[j] = 0;
        for (i = 0; i < N; i++)
        {
            for (j = 0; j < M; j++)
            {
                nokori[i, j] = N + M - i - j - 1;
            }
        }
        for (i = 0; i < N; i++)
        {
            res[i] = "";
            long yoko = 0;
            for (j = 0; j < M; j++)
            {
                for (k = 0; k < N; k++)
                {
                    if ((tate[j] & ((long)1 << k)) == 0 && (yoko & ((long)1 << k)) == 0)
                    {
                        tate[j] += (long)1 << k;
                        yoko += (long)1 << k;
                        res[i] += cget(k);
                        break;
                    }
                }
                if (k == N) res[i] += " ";
            }
        }
        return res;
    }

    char cget(int a)
    {
        if (a <= 9) return (char)('1' + a);
        else if (a <= 35) return (char)('A' + a - 9);
        else return (char)('a' - 35);
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
	private void test_case_0() { int Arg0 = 3; int Arg1 = 3; string[] Arg2 = new string[]{"123", "231", "312" }; verify_case(0, Arg2, getSchedule(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 4; int Arg1 = 4; string[] Arg2 = new string[]{"1234", "2143", "3412", "4321" }; verify_case(1, Arg2, getSchedule(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 4; int Arg1 = 6; string[] Arg2 = new string[]{"123456", "214365", "345612", "436521" }; verify_case(2, Arg2, getSchedule(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 5; int Arg1 = 3; string[] Arg2 = new string[]{"123", "214", "345", "451", "532" }; verify_case(3, Arg2, getSchedule(Arg0, Arg1)); }
	private void test_case_4() { int Arg0 = 28; int Arg1 = 40; string[] Arg2 = new string[]{"123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcde", "21436587A9CBEDGFIHKJMLONQPSRUTWVYXaZcbed", "34127856BC9AFGDEJKHINOLMRSPQVWTUZaXYdebc", "43218765CBA9GFEDKJIHONMLSRQPWVUTaZYXedcb", "56781234DEFG9ABCLMNOHIJKTUVWPQRSbcdeXYZa", "65872143EDGFA9CBMLONIHKJUTWVQPSRcbedYXaZ", "78563412FGDEBC9ANOLMJKHIVWTURSPQdebcZaXY", "87654321GFEDCBA9ONMLKJIHWVUTSRQPedcbaZYX", "9ABCDEFG12345678PQRSTUVWXYZabcdeHIJKLMNO", "A9CBEDGF21436587QPSRUTWVYXaZcbedIHKJMLON", "BC9AFGDE34127856RSPQVWTUZaXYdebcJKHINOLM", "CBA9GFED43218765SRQPWVUTaZYXedcbKJIHONML", "DEFG9ABC56781234TUVWPQRSbcdeXYZaLMNOHIJK", "EDGFA9CB65872143UTWVQPSRcbedYXaZMLONIHKJ", "FGDEBC9A78563412VWTURSPQdebcZaXYNOLMJKHI", "GFEDCBA987654321WVUTSRQPedcbaZYXONMLKJIH", "HIJKLMNOPQRSTUVWXYZabcde123456789ABCDEFG", "IHKJMLONQPSRUTWVYXaZcbed21436587A9CBEDGF", "JKHINOLMRSPQVWTUZaXYdebc34127856BC9AFGDE", "KJIHONMLSRQPWVUTaZYXedcb43218765CBA9GFED", "LMNOHIJKTUVWPQRSbcdeXYZa56781234DEFG9ABC", "MLONIHKJUTWVQPSRcbedYXaZ65872143EDGFA9CB", "NOLMJKHIVWTURSPQdebcZaXY78563412FGDEBC9A", "ONMLKJIHWVUTSRQPedcbaZYX87654321GFEDCBA9", "PQRSTUVWXYZabcde9ABCDEFGHIJKLMNO12345678", "QPSRUTWVYXaZcbedA9CBEDGFIHKJMLON21436587", "RSPQVWTUZaXYdebcBC9AFGDEJKHINOLM34127856", "SRQPWVUTaZYXedcbCBA9GFEDKJIHONML43218765" }; verify_case(4, Arg2, getSchedule(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheContest ___test = new TheContest();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
