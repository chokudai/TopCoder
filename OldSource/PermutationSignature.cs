using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PermutationSignature {
    public int[] reconstruct(string signature)
    {
        int[] res = new int[signature.Length + 1];
        int i,j;
        for (i = 1; i <= signature.Length+1; i++)
        {
            for (j = 0; j < signature.Length; j++)
            {
                if (res[j] == 0 && (signature[j] == 'I' || res[j + 1] != 0)) break;
            }
            res[j] = i;
        }
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
