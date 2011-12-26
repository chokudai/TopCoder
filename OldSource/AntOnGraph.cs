using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


public class Graph
{
    int n;
    List<int>[] edge;
    int[,] value;

    public Graph(int _n)
    {
        n = _n;
        edge = new List<int>[n];
        value = new int[n, n];
        int i;
        for (i = 0; i < n; i++) edge[i] = new List<int>();
    }

    public void addedge(int start, int goal, int val)
    {
        edge[start].Add(goal);
        value[start, goal] = val;
    }

    public bool[] cflag;
    public bool[] cnflag;
    public long[] cvalue;
    public long[] cnvalue;
    public bool[,] cflag2;
    public long[,] cvalue2;


    public void checkedge(int start,int move,bool first)
    {
        cflag = new bool[n];
        cnflag = new bool[n];
        cvalue = new long[n];
        cnvalue = new long[n];
        cflag2 = new bool[n, 51];
        cvalue2 = new long[n, 51];
        int i,j=0;
        for (i = 0; i < n; i++)
        {
            cflag[i] = false;
            cnflag[i] = false;
            cvalue[i] = 0;
            cnvalue[i] = 0;
        }
        cflag[start] = true;
        for (i = 0; i < n; i++)
        {
            cflag2[i,j] = cflag[i];
            cvalue2[i, j] = cvalue[i];
        }
        for (j = 0; j < move; j++)
        {
            for (i = 0; i < n; i++)
            {
                if (!cflag[i]) continue;
                foreach (int k in edge[i])
                {
                    if (!cnflag[k])
                    {
                        cnvalue[k] = cvalue[i] + value[i, k];
                        cnflag[k] = true;
                    }
                    else
                    {
                        cnvalue[k] = Math.Max(cvalue[i] + value[i, k], cnvalue[k]);
                    }
                }
            }
            if (j < 51)
            {
                for (i = 0; i < n; i++)
                {
                    cflag2[i, j] = cflag[i];
                    cvalue2[i, j] = cvalue[i];
                }
            }
            for (i = 0; i < n; i++)
            {
                cflag[i] = cnflag[i];
                cvalue[i] = cnvalue[i];
                if (first)
                {
                    cnflag[i] = false;
                    cnvalue[i] = 0;
                }
            }
        }
        return;
    }

}


public class AntOnGraph {
    public string maximumBonus(string[] p0, string[] p1, string[] p2, int stepsPerSecond, int timeLimit)
    {
        int len = p0.Length;
        int i, j;
        Graph g1 = new Graph(p0.Length);
        Graph g2 = new Graph(p0.Length);
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                int a = (p0[i][j] - '0') * 100;
                a += (p1[i][j] - '0') * 10;
                a += (p2[i][j] - '0') * 1;
                if (a == 0) continue;
                else g1.addedge(i, j, a - 500);
            }
        }
        for (i = 0; i < len; i++)
        {
            g1.checkedge(i, stepsPerSecond,true);
            for (j = 0; j < len; j++)
            {
                if (g1.cflag[j])
                {
                    g2.addedge(i, j, (int)g1.cvalue[j]);
                }
            }
        }
        {

            long best = long.MinValue;
            bool pos = false;
            long[, ,] memo = new long[len, len, 51];
            bool[, ,] memoflag = new bool[len, len, 51];
            int k;
            for (i = 0; i < len; i++)
            {
                g2.checkedge(i, 51, true);
                for (k = 0; k <= 50; k++)
                {
                    for (j = 0; j < len; j++)
                    {
                        if (g2.cflag2[j,k])
                        {
                            memoflag[i, j, k] = true;
                            memo[i, j, k] = g2.cvalue2[j, k];
                        }
                        else memoflag[i, j, k] = false;
                    }
                }
            }
            for (i = 0; i < len; i++)
            {
                for (j = 0; j <= 50; j++)
                {
                    if (!memoflag[0, i, j]) continue;
                    for (k = 0; k <= 50; k++)
                    {
                        if (!memoflag[i, 1, k]) continue;
                        long nokori2 = timeLimit - j - k;
                        if (nokori2 < 0) continue;
                        for (int l = 1; l <= 50; l++)
                        {
                            if (!memoflag[i, i, l]) continue;
                            long nokori = nokori2 / l;
                            pos = true;
                            best = Math.Max(best, memo[0, i, j] + memo[i, 1, k] + memo[i, i, l] * nokori);
                        }
                        pos = true;
                        best = Math.Max(best, memo[0, i, j] + memo[i, 1, k]);
                    }
                }
            }
            if (pos) return best.ToString();
            else return "IMPOSSIBLE";

        }
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
	private void test_case_0() { string[] Arg0 = new string[]{"05","50"}; string[] Arg1 = new string[]{"00","00"}; string[] Arg2 = new string[]{"01","10"}; int Arg3 = 3; int Arg4 = 2; string Arg5 = "3"; verify_case(0, Arg5, maximumBonus(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_1() { string[] Arg0 = new string[]{"05","50"}; string[] Arg1 = new string[]{"00","00"}; string[] Arg2 = new string[]{"01","10"}; int Arg3 = 2; int Arg4 = 3; string Arg5 = "IMPOSSIBLE"; verify_case(1, Arg5, maximumBonus(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_2() { string[] Arg0 = new string[]{"0550","0000","0005","5000"}; string[] Arg1 = new string[]{"0000","0000","0000","0000"}; string[] Arg2 = new string[]{"0110","0000","0001","1000"}; int Arg3 = 7; int Arg4 = 9; string Arg5 = "49"; verify_case(2, Arg5, maximumBonus(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_3() { string[] Arg0 = new string[]{"0540","0000","0004","4000"}; string[] Arg1 = new string[]{"0090","0000","0009","9000"}; string[] Arg2 = new string[]{"0190","0000","0009","9000"}; int Arg3 = 7; int Arg4 = 9; string Arg5 = "-5"; verify_case(3, Arg5, maximumBonus(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_4() { string[] Arg0 = new string[]{"079269665406","506042219642","720809987956",
 "315099331918","952306192584","406390344278",
 "999241035142","370785209189","728363760165",
 "019367419000","279718007804","610188263490"}; string[] Arg1 = new string[]{"038604914953","804585763146","350629473403",
 "028096403898","575205051686","427800322647",
 "655168017864","582553303278","980402170192",
 "620737714031","686142310509","092421645460"}; string[] Arg2 = new string[]{"063231394554","109852259379","740182746422",
 "853015982521","476805512496","898530717993",
 "430534005863","440162807186","132879980431",
 "685312177072","780267345400","959947501200"}; int Arg3 = 37; int Arg4 = 1221; string Arg5 = "20992235"; verify_case(4, Arg5, maximumBonus(Arg0, Arg1, Arg2, Arg3, Arg4)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
AntOnGraph ___test = new AntOnGraph();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
