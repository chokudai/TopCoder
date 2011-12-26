using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Prerequisites
{
    public string[] orderClasses(string[] param0)
    {
        int i;
        SortedDictionary<string, Dictionary<string, int>> dic = new SortedDictionary<string, Dictionary<string, int>>();
        for (i = 0; i < param0.Length; i++)
        {
            string[] st = param0[i].Split(new char[] { ':', ' ' });
            string next = "";
            foreach (string s in st)
            {
                if (s.Length >= 3)
                {
                    next += s.Substring(s.Length - 3, 3) + s.Substring(0, s.Length - 3);
                }
                else next += s;
                next += " ";
            }
            param0[i] = next;
            Console.WriteLine(param0[i]);
        }
        foreach (string s in param0)
        {
            string[] st = s.Split(new char[] {' ' });
            if (!dic.ContainsKey(st[0])) dic[st[0]] = new Dictionary<string, int>();
        }
        foreach (string s in param0)
        {
            string[] st = s.Split(new char[] { ' ' });
            for (i = 2; i < st.Length; i++)
            {
                if (st[i].Length >= 1)
                {
                    if (!dic.ContainsKey(st[i])) return new string[0];
                    dic[st[0]][st[i]] = 1;
                }
            }
        }
        string[] res = new string[dic.Count];
        Dictionary<string, int> check = new Dictionary<string, int>();
        int now = 0;
        while (true)
        {
            bool flag2 = true;
            foreach (KeyValuePair<string, Dictionary<string, int>> d in dic)
            {
                if (check.ContainsKey(d.Key)) continue;
                bool flag = true;
                foreach (string s in d.Value.Keys)
                {
                    if (!check.ContainsKey(s))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    flag2 = false;
                    Console.WriteLine(d.Key);
                    check[d.Key] = 1;
                    res[now++] = d.Key.Substring(3, d.Key.Length - 3) + d.Key.Substring(0, 3);
                    break;
                }
            }
            if(flag2) break;
        }

        if (now == dic.Count) return res;
        else return new string[0];
    }
}
