using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class STable
{
    int slen;
    int tlen;

    bool[,] used;
    bool[,] rightflag;
    long[,] num;

    string _s, _t;

    public string getString(string s, string t, long pos)
    {
        int i, j;
        slen = s.Length;
        tlen = t.Length;
        _s = s; _t = t;
        num = new long[slen + 1,tlen + 1];
        for (i = 0; i <= slen; i++) num[i, 0] = 1;
        for (j = 0; j <= tlen; j++) num[0, j] = 1;
        for (i = 1; i <= slen; i++)
        {
            for (j = 1; j <= tlen; j++)
            {
                num[i, j] = num[i - 1, j] + num[i, j - 1];
            }
        }
        char[] cs = new char[slen + tlen];
        for (i = 0; i < slen; i++) cs[i] = s[i];
        for (j = 0; j < tlen; j++) cs[slen + j] = t[j];
        Array.Sort(cs);
        Dictionary<char, int> dic = new Dictionary<char, int>();
        int TMAX = 9999;
        for (i = 0; i < cs.Length; i++) dic[cs[i]] = i;
        int[] nums = new int[slen + 2];
        int[] numt = new int[tlen + 2];
        int[] poss = new int[cs.Length];
        int[] premins = new int[slen + 2];
        int[] premint = new int[tlen + 2];
        premins[0] = premint[0] = TMAX;
        nums[0] = numt[0] = nums[slen + 1] = numt[tlen + 1] = TMAX;
        for (i = 0; i < slen; i++)
        {
            nums[i + 1] = dic[s[i]];
            poss[dic[s[i]]] = i + 1;
            premins[i + 1] = Math.Min(premins[i], nums[i + 1]);
        }
        for (i = 0; i < tlen; i++)
        {
            numt[i + 1] = dic[t[i]];
            poss[dic[t[i]]] = -i - 1;
        }
        used = new bool[slen + 1, tlen + 1];
        rightflag = new bool[slen + 1, tlen + 1];
        for (i = 0; i < cs.Length; i++)
        {
            int now = poss[i];
            if (now < 0)
            {
                //t
                now = -poss[i];
                if (used[1, now]) continue;
                Console.Write(t[now - 1]);
                int minnum = TMAX;
                if (slen != 1) minnum = premins[2];
                if (now >= 2) minnum = Math.Min(minnum, premint[now - 1]);
                if (minnum < numt[now + 1]) dfs(1, now, false);
                else dfs(1, now, true);
                used[1, now] = true;
                rightflag[1, now] = false;
            }
            else
            {
                //s
                if (used[now, 1]) continue;
                Console.Write(s[now - 1]);
                int minnum = TMAX;
                if (tlen != 1) minnum = premint[2];
                if (now >= 2) minnum = Math.Min(minnum, premint[now - 1]);
                if (minnum < nums[now + 1]) dfs(now, 1, true);
                else dfs(now, 1, false);
                used[now, 1] = true;
                rightflag[now, 1] = true;
            }
        }
        //Console.WriteLine();
        //Console.WriteLine(num[slen, tlen]);
        return dfs2(slen, tlen, pos, Math.Min(pos + 50, num[slen, tlen]));

    }

    string dfs2(int y, int x, long start, long end)
    {
        
        if (y == 0) return _t[x - 1] + "";
        if (x == 0) return _s[y - 1] + "";
        long first;
        if (rightflag[y, x])
        {
            first = num[y, x - 1];
            if (end <= first)
            {
                return dfs2(y, x - 1, start, end);
            }
            else if (start >= first)
            {
                return dfs2(y - 1, x, start - first, end - first);
            }
            else
            {
                return dfs2(y, x - 1, start, first) + dfs2(y - 1, x, 0, end - first);
            }
        }
        else
        {
            first = num[y - 1, x];
            if (end <= first)
            {
                return dfs2(y - 1, x, start, end);
            }
            else if (start >= first)
            {
                return dfs2(y, x - 1, start - first, end - first);
            }
            else
            {
                return dfs2(y - 1, x, start, first) + dfs2(y, x - 1, 0, end - first);
            }
        }
    }

    void dfs(int y, int x, bool right)
    {
        if (!ok(y, x)) return;
        if (used[y, x]) return;
        if (right) dfs(y, x + 1, false);
        else dfs(y + 1, x, true);
        //used[y, x] = true;
        int i;
        for (i = y + 1; i <= slen; i++)
        {
            if (!used[i, x])
            {
                used[i, x] = true;
                rightflag[i, x] = false;
            }
            else break;
        }
        for (i = x + 1; i <= tlen; i++)
        {
            if (!used[y, i])
            {
                used[y, i] = true;
                rightflag[y, i] = true;
            }
            else break;
        }
    }

    bool ok(int y, int x)
    {
        return y >= 0 && x >= 0 && y <= slen && x <= tlen;
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
	private void test_case_0() { string Arg0 = "ad"; string Arg1 = "cb"; long Arg2 = 0l; string Arg3 = "acbacd"; verify_case(0, Arg3, getString(Arg0, Arg1, Arg2)); }
	private void test_case_1() { string Arg0 = "fox"; string Arg1 = "cat"; long Arg2 = 0l; string Arg3 = "acfcfoacftacfcfocfox"; verify_case(1, Arg3, getString(Arg0, Arg1, Arg2)); }
	private void test_case_2() { string Arg0 = "Ra6b1t"; string Arg1 = "W0lf"; long Arg2 = 66l; string Arg3 = "RWab0RWRWa0RWl0RWRWa6RWa0RWRWa6RWa6RWab0RWRWa6RWa6"; verify_case(2, Arg3, getString(Arg0, Arg1, Arg2)); }
	private void test_case_3() { string Arg0 = "M0HAXG"; string Arg1 = "COFU12"; long Arg2 = 919l; string Arg3 = "MOFU2"; verify_case(3, Arg3, getString(Arg0, Arg1, Arg2)); }
	private void test_case_4() { string Arg0 = "a0B1c2D3e4F5gHiJkLmN"; string Arg1 = "A9b8C7d6EfGhIjKlMn"; long Arg2 = 9876543210l; string Arg3 = "B10AaB1c0Aa9Aa0AaB0AaB10AaB1c0AaB1c20Aa9Aa0AaB0Aa9"; verify_case(4, Arg3, getString(Arg0, Arg1, Arg2)); }
	private void test_case_5() { string Arg0 = "TCOR2"; string Arg1 = "MEDiUm"; long Arg2 = 350l; string Arg3 = "MTDEMTiCMTEMTDEMTDEMTiDEMTiUCMTEMTCMTOCMTEMTDEMTCM"; verify_case(5, Arg3, getString(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        STable ___test = new STable();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
