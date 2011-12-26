using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SRMCodingPhase {
    public int countScore(int[] points, int[] skills, int luck)
    {
        int i, j;
        int bestpoint = 0;
        Array.Reverse(skills);
        Array.Reverse(points);
        for (i = 0; i < 8; i++)
        {
            int nokori = luck;
            int spend = 0;
            int score = 0;
            for (j = 0; j < 3; j++)
            {
                if ((i >> j) % 2 == 1)
                {
                    int time = Math.Max(1, skills[j] - nokori);
                    spend += time;
                    nokori -= skills[j] - time;
                    score += points[j] - (1 << (3 - j)) * time;
                    //Console.Write(score);
                }
            }
            if (spend > 75) continue;
            bestpoint = Math.Max(score, bestpoint);
        }
        return bestpoint;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
