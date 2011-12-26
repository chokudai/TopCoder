using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class grafixGlobs {

    int[,] num;
    public int[] execute(string[] commands, int sel)
    {
        num = new int[2000, 3];
        int i, j, k;
        Dictionary<string, int> dic = new Dictionary<string, int>();
        dic["polygon"] = 2;
        dic["circle"] = 1;
        dic["arc"] = 0;
        for (i = 0; i < commands.Length; i++)
        {
            string[] st = commands[i].Split(' ');
            if (st[0] == "make")
            {
                int next = dic[st[1]];
                for (j = 0; ; j++)
                {
                    if (num[j, 0] != 0) continue;
                    else if (num[j, 1] != 0) continue;
                    else if (num[j, 2] != 0) continue;
                    else
                    {
                        num[j, next] = 1;
                        break;
                    }
                }
            }
            else if (st[0] == "merge")
            {
                int first = int.Parse(st[1]);
                int secound = int.Parse(st[2]);
                for (j = 0; j < 3; j++)
                {
                    num[first, j] += num[secound, j];
                    num[secound, j] = 0;
                }
            }
            else if (st[0] == "delete")
            {
                int first = int.Parse(st[1]);
                for (j = 0; j < 3; j++)
                {
                    num[first, j] = 0;
                }
            }
            else
            {
                int first = int.Parse(st[1]);
                int[] nokori = new int[3];
                for (j = 0; j < 3; j++)
                {
                    nokori[j] = num[first, j];
                    num[first, j] = 0;
                }
                for (j = 0;; j++)
                {
                    if (num[j, 0] != 0) continue;
                    else if (num[j, 1] != 0) continue;
                    else if (num[j, 2] != 0) continue;
                    else if (nokori[0] != 0)
                    {
                        num[j, 0]++;
                        nokori[0]--;
                    }
                    else if (nokori[1] != 0)
                    {
                        num[j, 1]++;
                        nokori[1]--;
                    }
                    else if (nokori[2] != 0)
                    {
                        num[j, 2]++;
                        nokori[2]--;
                    }
                    else break;
                }
            }
            /*
            for (j = 0; j < 10; j++)
            {
                for (k = 0; k < 3; k++) Console.Write(num[j, k] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
             */
        }



        int[] res = new int[3];
        int sum = 0;
        for (i = 0; i < 3; i++) sum += res[i] = num[sel, i];
        if (sum == 0) return new int[0];
        return res;
    }


    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, int[] Expected, int[] Received) {
		Console.Write("Test Case #" + Case + "...");
		if (equal_arrays(Expected, Received)) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: " + print_array(Expected)); 
			Console.WriteLine("\tReceived: " + print_array(Received)); } }
	string print_array(int[] V) {
		System.Text.StringBuilder builder = new System.Text.StringBuilder();
		builder.Append("{ ");
		foreach (int o in V) {
			builder.Append('\"');
			builder.Append(o.ToString());
			builder.Append("\",");
		}
		builder.Append(" }");
		return builder.ToString();
	}
	bool equal_arrays(int[] a, int[]b) {
		if (a.Length != b.Length) return false;
		for (int i = 0; i < a.Length; ++i) if (a[i] != b[i]) return false;
		return true;
	}
	private void test_case_0() { string[] Arg0 = new string[]{"make polygon", "make circle", "make polygon", "merge 0 1", "merge 2 0", "split 2"}; int Arg1 = 0; int[] Arg2 = new int[]{ 0,  1,  0 }; verify_case(0, Arg2, execute(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"make circle", "make circle", "make arc", "merge 2 1", "delete 0",
 "split 2", "delete 0", "make polygon"}; int Arg1 = 0; int[] Arg2 = new int[]{ 0,  0,  1 }; verify_case(1, Arg2, execute(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"make circle", "make circle", "make arc", "merge 2 1", "delete 0",
 "split 2", "delete 0", "make polygon"}; int Arg1 = 2; int[] Arg2 = new int[]{ }; verify_case(2, Arg2, execute(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"make arc"}; int Arg1 = 999; int[] Arg2 = new int[]{ }; verify_case(3, Arg2, execute(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"make polygon", "make polygon", "make arc", "make circle",
 "make circle", "delete 3", "make polygon", "make arc",
 "make arc", "merge 1 3", "merge 1 4", "merge 2 1", "make arc",
 "make arc", "make circle", "make circle", "merge 6 5",
 "split 6", "merge 2 1"}; int Arg1 = 2; int[] Arg2 = new int[]{ 2,  1,  2 }; verify_case(4, Arg2, execute(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {

    grafixGlobs ___test = new grafixGlobs();
    ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
