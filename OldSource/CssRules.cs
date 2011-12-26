using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CssRules
{

    class css
    {
        public int color;
        public int tag;
        public List<css> li;
        public int[, ,] dp;
        public css mother;

        public css(int _color, int _tag)
        {
            color = _color;
            tag = _tag;
            li = new List<css>();
            dp = new int[8, 8, 8];
        }

        public void add(css child)
        {
            child.mother = this;
            li.Add(child);
        }

        public int getnum()
        {
            foreach (css next in li) next.fill();
            int res = 0;
            foreach (css next in li) res += next.dp[7, 7, 7];
            return res;
        }

        public void fill()
        {
            foreach (css next in li) next.fill();
            int i, j, k;
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    for (k = 0; k < 8; k++)
                    {
                        dp[i, j, k] = 0;
                        foreach (css next in li) dp[i, j, k] += next.dp[i, j, k];
                        if (tag == 0 && color != i) dp[i, j, k]++;
                        if (tag == 1 && color != j) dp[i, j, k]++;
                        if (tag == 2 && color != k) dp[i, j, k]++;

                        int other = 1;
                        //if (mother.color == 7) other++;
                        if (tag == 0 && color != i) other++;
                        if (tag == 1 && color != j) other++;
                        if (tag == 2 && color != k) other++;
                        int nexti = i;
                        int nextj = j;
                        int nextk = k;
                        if (tag == 0) nexti = color;
                        if (tag == 1) nextj = color;
                        if (tag == 2) nextk = color;
                        foreach (css next in li) other += next.dp[nexti, nextj, nextk];
                        dp[i, j, k] = Math.Min(dp[i, j, k], other);
                    }
                }
            }
        }
    }

    string[] color = new string[] { "black", "blue", "gray", "green", "red", "white", "yellow" };
    string[] tag = new string[] { "b", "u", "i" }; 
    Dictionary<string, int> dic;
    Dictionary<string, int> tagdic;


    public int getMinimalCssRuleCount(string[] xthml)
    {
        string s = "";
        foreach (string sss in xthml) s += sss;
        char[] c = new char[] { '<', '>' };
        string[] ss = s.Split(c, StringSplitOptions.RemoveEmptyEntries);
        //foreach(string sss in ss) Console.WriteLine(sss);
        dic = new Dictionary<string, int>();
        tagdic = new Dictionary<string, int>();
        int i;
        for (i = 0; i < color.Length; i++) dic[color[i]] = i;
        for (i = 0; i < tag.Length; i++) tagdic[tag[i]] = i;
        css first = new css(7, 7);
        css now = first;
        for (i = 0; i < ss.Length; i++)
        {
            string next = ss[i];
            if (next[0] == '/')
            {
                now = now.mother;
            }
            else
            {
                int color, tag;
                //<b id='x' style='color:red'
                char[] newset = new char[] { ' ', ':', '\'' };
                string[] s1 = ss[i].Split(newset, StringSplitOptions.RemoveEmptyEntries);
                tag = tagdic[s1[0]];
                color = dic[s1[s1.Length - 1]];
                css child = new css(color, tag);
                now.add(child);
                now = child;
            }
        }
        return first.getnum();
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
