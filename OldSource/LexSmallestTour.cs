using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class LexSmallestTour {

    public int[] determineTour(string[] roads, int[] queries)
    {
        int i, j, k, l;
        int r = 0;
        int len = roads.Length;
        int[,] rs = new int[len,len];
        int CMAX = 52;
        int MAX = 10000;

        for (i = 0; i < len; i++)
        {
            for (j = i; j < len; j++)
            {
                if (roads[i][j] != '.')
                {
                    r++;
                    rs[i, j] = rs[j, i] = getch(roads[i][j]);
                }
                else
                {
                    rs[i, j] = rs[j, i] = -1;
                }
            }
        }

        bool[] need = new bool[r + 1];
        foreach (int aa in queries) need[aa] = true;

        int[,] dp = new int[len, CMAX];
        for (j = 0; j < len; j++)
        {
            for (k = 0; k < CMAX; k++)
            {
                dp[j, k] = MAX;
            }
        }
        for (k = 0; k < CMAX; k++) dp[0, k] = 0;

        int[][] dpar = new int[1][];
        dpar[0] = new int[queries.Length];

        for (i = 0; i <= r; i++)
        {
            if (need[i])
            {
                List<int> needlist = new List<int>();
                for (j = 0; j < queries.Length; j++)
                {
                    if (queries[j] == i) needlist.Add(j);
                }
                List<int[]> arlist = new List<int[]>();
                Dictionary<int, int> dic = new Dictionary<int, int>();
                for (j = 0; j < len; j++)
                {
                    for (k = 0; k < CMAX; k++)
                    {
                        if (dp[j, k] == MAX) continue;
                        int[] tempar = (int[])dpar[dp[j, k]].Clone();
                        foreach (int aa in needlist) tempar[aa] = j + 1;
                        int t = dp[j, k] * 100 + j;
                        if (!dic.ContainsKey(t))
                        {
                            dic[t] = 1;
                            arlist.Add((int[])tempar.Clone());
                        }
                    }
                }

                int[][] arar = arlist.ToArray();
                Array.Sort(arar, compare);
                
                for (j = 0; j < len; j++)
                {
                    for (k = 0; k < CMAX; k++)
                    {
                        if (dp[j, k] == MAX) continue;
                        int[] tempar = (int[])dpar[dp[j, k]].Clone();
                        foreach (int aa in needlist) tempar[aa] = j + 1;
                        for (l = 0; l < arar.Length; l++)
                        {
                            if (compare(arar[l], tempar) == 0)
                            {
                                dp[j, k] = l;
                                break;
                            }
                        }

                        if (l == arar.Length) Console.WriteLine("??");
                    }
                }
                dpar = (int[][])arar.Clone();
            }

            if (i == r) break;
            int[,] nextdp = new int[len, CMAX];
            for (j = 0; j < len; j++)
            {
                for (k = 0; k < CMAX; k++)
                {
                    nextdp[j, k] = MAX;
                }
            }

            for (j = 0; j < len; j++)
            {
                for (k = 0; k < CMAX; k++)
                {
                    if (dp[j, k] == MAX) continue;
                    for (l = 0; l < len; l++)
                    {
                        if (j == l) continue;
                        if (k == rs[j, l]) continue;
                        if (rs[j, l] == -1) continue;
                        nextdp[l, rs[j, l]] = Math.Min(nextdp[l, rs[j, l]], dp[j, k]);
                    }
                }
            }
            dp = (int[,])nextdp.Clone();
        }
        int res = MAX;
        for (k = 0; k < CMAX; k++)
        {
            res = Math.Min(res, dp[0, k]);
        }
        if (res == MAX) return new int[0];
        int[] ret = (int[])dpar[res].Clone();
        for (i = 0; i < ret.Length; i++) ret[i]--;
        return ret;
        
    }

    int compare(int[] a, int[] b)
    {
        int i;
        for (i = 0; i < a.Length; i++)
        {
            if (a[i] > b[i]) return -1;
            else if (a[i] < b[i]) return 1;
        }
        return 0;
    }

    int getch(char a)
    {
        if (a >= 'a' && a <= 'z') return a - 'a';
        else return a - 'A' + 26;
    }



    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
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
	private void test_case_0() { string[] Arg0 = new string[]{".AB"
,"A.C"
,"BC."}; int[] Arg1 = new int[]{0, 1, 2, 3}; int[] Arg2 = new int[]{0, 1, 2, 0 }; verify_case(0, Arg2, determineTour(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{".A..C"
,"A.ABB"
,".A.C."
,".BC.."
,"CB..."}; int[] Arg1 = new int[]{0, 1, 2, 3, 4, 5, 6}; int[] Arg2 = new int[]{0, 1, 3, 2, 1, 4, 0 }; verify_case(1, Arg2, determineTour(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{".aa"
,"a.A"
,"aA."}; int[] Arg1 = new int[]{3, 2, 1}; int[] Arg2 = new int[]{0, 2, 1 }; verify_case(2, Arg2, determineTour(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"..A.A"
,"...A."
,"A...A"
,".A..."
,"A.A.."}; int[] Arg1 = new int[]{1, 2}; int[] Arg2 = new int[]{ }; verify_case(3, Arg2, determineTour(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        LexSmallestTour ___test = new LexSmallestTour();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
