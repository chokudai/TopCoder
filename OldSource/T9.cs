using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class T9 {
    public string message(string[] part, string[] dict, string[] keystr)
    {
        string res = "";
        Dictionary<char, int> dic = new Dictionary<char, int>();
        int i,j;
        Array.Sort(dict);
        for (i = 0; i < 9; i++)
        {
            for (j = 0; j < part[i].Length; j++)
            {
                dic[part[i][j]] = i + 1;
            }
        }
        Dictionary<string, string> worddic = new Dictionary<string, string>();
        //for (i = 0; i < 9; i++) if (part[i].Length == 0) worddic[i.ToString()] = " ";
        worddic["0"] = " ";
        for (i = 0; i < dict.Length; i++)
        {
            string makeword = "";
            for (j = 0; j < dict[i].Length; j++) { makeword += dic[dict[i][j]].ToString(); }
            while(worddic.ContainsKey(makeword)) makeword += "#";
            worddic[makeword] = dict[i];
        }
        string st = "";
        for (i = 0; i < keystr.Length; i++) st += keystr[i];
        st = st.Replace("*", "#####");
        while (st.Length>0)
        {
            int maxlen = 0;
            //Console.WriteLine(st + " " + res);
            string add = "";
            foreach (string key in worddic.Keys)
            {
                if (key.Length > st.Length || key != st.Substring(0, key.Length)) continue;
                if (key.Length <= maxlen) continue;
                add = worddic[key];
                maxlen = key.Length;
            }
            st = st.Substring(maxlen);
            res += add;
        }
        return res;
    }



}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
