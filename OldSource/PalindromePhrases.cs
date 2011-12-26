using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PalindromePhrases {
    long[] dp;

    public long getAmount(string[] words)
    {
        int i,j;
        long res = 0;
        dp = new long[1 << words.Length];
        int[] ar = new int[words.Length];
        for (i = 0; i < words.Length; i++)
        {
            Array.Sort(ar);
            ar[i] = 1;
            do
            {
                int memo = 0;
                for (j = 0; j < words.Length; j++) memo += used[j] << j;
                dp[memo] = getParts(words, ar);
                res += dp[memo];
            } while (Algorithm.next_permutation<int>(ar));
        }
        return res;
    }

    public long getParts(string[] words,int[] used)
    {
        int kisu = -1;
        int syurui = 0;
        int[] num = new int[26];
        int sum = 0;
        long res = 0;
        foreach (string s in words)
        {
            if (used[i]==0) continue;
            sum += s.Length;
            foreach (char c in s) num[c - 'a']++;
        }
        int i, j;
        for (i = 0; i < 26; i++)
        {
            if (num[i] % 2 != 0)
            {
                if (kisu == -1)
                {
                    kisu = i;
                    if (sum % 2 == 0) return 0;
                }
                else return 0;
            }
            if (num[i] != 0) syurui++;
        }
        if (syurui == 1) return kaijou(words.Length);
        return search(words,(int[])used.Clone(),false,"",false);
    }

    public long search(string[] words, int[] used, bool flag,string amari,bool muki)
    {
        int i, j;
        if (flag && amari == "")
        {
            long memo=0;
            for (j = 0; j < words.Length; j++) memo += used[j] << j;
            return dp[memo];
        }
        long res = 0;
        bool flag2 = true;
        for (i = 0; i < words.Length; i++)
        {
            if (used[i] == 0) continue;
            flag2 = false;
            used[i] = 0;
            if (muki)
            {
                for (j = 0; j < Math.Min(amari.Length, words[i].Length); j++)
                {
                    if (amari[j] != words[i][j]) break;
                }
                if (j != Math.Min(amari.Length, words[i].Length)) continue;
                for (j = 0; j < Math.Min(amari.Length, words[i].Length); j++)
                {
                    if (amari[j] != words[i][j]) break;
                }
            }
            else
            {

            }
            used[i] = 1;
        }
        if (flag2)
        {
            for (i = 0; i < amari.Length; i++)
            {
                if (amari[i] != amari[amari.Length - i - 1]) return 0;
            }
            return 1;
        }
        return res;
    }

    public long kaijou(int N)
    {
        int i;
        long res = 1;
        for (i = 1; i <= N; i++) res *= N;
        return res;
    }


    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"a","ba"}; long Arg1 = 2l; verify_case(0, Arg1, getAmount(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"ab","bcd","efg"}; long Arg1 = 0l; verify_case(1, Arg1, getAmount(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"a", "bba", "abb"}; long Arg1 = 7l; verify_case(2, Arg1, getAmount(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"aabccc", "ccbbca", "a", "acaabb", "aaa", "aab", "c", "babb", "aacaa", "b"}; long Arg1 = 47l; verify_case(3, Arg1, getAmount(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
PalindromePhrases ___test = new PalindromePhrases();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}

public static partial class Algorithm
{
    public static bool next_permutation<T>(T[] array) where T : IComparable
    {
        return next_permutation(array, 0, array.Length);
    }

    public static bool next_permutation<T>(T[] array, int start, int length) where T : IComparable
    {
        int end = start + length - 1;
        if (end <= start) return false;
        int last = end;
        while (true)
        {
            int pos = last--;
            if (array[last].CompareTo(array[pos]) < 0)
            {
                int i;
                for (i = end + 1; array[last].CompareTo(array[--i]) >= 0; ) { }
                T tmp = array[last]; array[last] = array[i]; array[i] = tmp;
                Array.Reverse(array, pos, end - pos + 1);
                return true;
            }
            if (last == start)
            {
                //Array.Reverse(array, start, end - start);
                return false;
            }
        }
    }
}