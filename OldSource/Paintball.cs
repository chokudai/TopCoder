using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Paintball {
    public string[] getLeaderboard(string[] players, string[] messages)
    {
        int i, j;
        Dictionary<string, int> teampoint = new Dictionary<string, int>();
        Dictionary<string, int> playerpoint = new Dictionary<string, int>();
        Dictionary<string, string> playerteam = new Dictionary<string, string>();
        List<string> lteamname = new List<string>();
        List<string> lplayername = new List<string>();
        for (i = 0; i < players.Length; i++)
        {
            string[] s = players[i].Split(' ');
            if (!teampoint.ContainsKey(s[1]))
            {
                teampoint[s[1]] = 0;
                lteamname.Add(s[1]);
            }
            playerpoint[s[0]] = 0;
            lplayername.Add(s[0]);
            playerteam[s[0]] = s[1];
        }
        string[] teamname = lteamname.ToArray();
        string[] playername = lplayername.ToArray();
        Array.Sort(teamname, String.CompareOrdinal);
        Array.Sort(playername, String.CompareOrdinal);
       
        for (i = 0; i < messages.Length; i++)
        {
            string[] s = messages[i].Split(' ');
            string from = s[0];
            string to = s[2];
            if (playerteam[from] == playerteam[to])
            {
                playerpoint[from] -= 1;
                //playerpoint[to] -= 1;
            }
            else
            {
                playerpoint[from] += 1;
                playerpoint[to] -= 1;
            }
        }
        StringBuilder sss = new StringBuilder("abc");
        sss[2] = 'D';
        Console.WriteLine(sss);
        for (i = 0; i < playername.Length; i++) teampoint[playerteam[playername[i]]] += playerpoint[playername[i]];
        //for (i = 0; i < playername.Length; i++) Console.WriteLine(playername[i]);

        for (i = 0; i < teamname.Length; i++)
        {
            for (j = 0; j < teamname.Length - 1; j++)
            {
                if (teampoint[teamname[j]] < teampoint[teamname[j+1]])
                {
                    string temp = teamname[j];
                    teamname[j] = teamname[j+1];
                    teamname[j+1] = temp;
                }
            }
        }

        for (i = 0; i < playername.Length; i++)
        {
            for (j = 0; j < playername.Length - 1; j++)
            {
                if (playerpoint[playername[j]] < playerpoint[playername[j+1]])
                {
                    string temp = playername[j];
                    playername[j] = playername[j+1];
                    playername[j+1] = temp;
                }
            }
        }

        //for (i = 0; i < playername.Length; i++) Console.WriteLine(playername[i] + " " + playerpoint[playername[i]]);

        List<string> res = new List<string>();
        for (i = 0; i < teamname.Length; i++)
        {
            res.Add(teamname[i] + " " + teampoint[teamname[i]]);
            for (j = 0; j < playername.Length; j++)
            {
                if (playerteam[playername[j]] == teamname[i])
                {
                    res.Add("  " + playername[j] + " " + playerpoint[playername[j]]);
                }
            }
        }

        return res.ToArray();
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
	private void test_case_0() { string[] Arg0 = new string[]{"A RED", "B BLUE"}; string[] Arg1 = new string[]{"A SPLATTERED B"}; string[] Arg2 = new string[]{"RED 1", "  A 1", "BLUE -1", "  B -1" }; verify_case(0, Arg2, getLeaderboard(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"LISA RED", "BART RED", "HOMER BLUE", "MARGE BLUE", "MAGGIE GREEN"}; string[] Arg1 = new string[]{"MAGGIE SPLATTERED HOMER", "MAGGIE SPLATTERED MARGE"}; string[] Arg2 = new string[]{"GREEN 2", "  MAGGIE 2", "RED 0", "  BART 0", "  LISA 0", "BLUE -2", "  HOMER -1", "  MARGE -1" }; verify_case(1, Arg2, getLeaderboard(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"TODD STRIKEFORCE",
 "BART OMEGA",
 "DATA STRIKEFORCE",
 "MILHOUSE OMEGA",
 "NELSON DISCOVERYCHANNEL",
 "MARTIN DISCOVERYCHANNEL"}; string[] Arg1 = new string[]{"BART SPLATTERED MARTIN","TODD SPLATTERED MARTIN"}; string[] Arg2 = new string[]{"OMEGA 1", "  BART 1", "  MILHOUSE 0", "STRIKEFORCE 1", "  TODD 1", "  DATA 0", "DISCOVERYCHANNEL -2", "  NELSON 0", "  MARTIN -2" }; verify_case(2, Arg2, getLeaderboard(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"DR COHO", "ST COHO", "PE COHO"}; string[] Arg1 = new string[]{"DR SPLATTERED ST",
 "ST SPLATTERED PE"}; string[] Arg2 = new string[]{"COHO -2", "  PE 0", "  DR -1", "  ST -1" }; verify_case(3, Arg2, getLeaderboard(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"A B", "AA AA", "AAA AAA"}; string[] Arg1 = new string[]{"A SPLATTERED AAA", "A SPLATTERED AAA", "A SPLATTERED AAA", 
"AA SPLATTERED AAA", "AA SPLATTERED AAA"}; string[] Arg2 = new string[]{"B 3", "  A 3", "AA 2", "  AA 2", "AAA -5", "  AAA -5" }; verify_case(4, Arg2, getLeaderboard(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {

    Paintball ___test = new Paintball();
    ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
