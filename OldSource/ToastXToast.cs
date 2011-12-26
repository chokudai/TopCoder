using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ToastXToast {
    public int bake(int[] undertoasted, int[] overtoasted)
    {
        int umax = -1;
        int umin = 9999999;
        int omax = -1;
        int omin = 9999999;
        int i;
        for (i = 0; i < undertoasted.Length; i++)
        {
            umax = Math.Max(undertoasted[i], umax);
            umin = Math.Min(undertoasted[i], umin);
        }
        for (i = 0; i < overtoasted.Length; i++)
        {
            omax = Math.Max(overtoasted[i], omax);
            omin = Math.Min(overtoasted[i], omin);
        }
        if (umax >= omax) return -1;
        if (umin >= omin) return -1;
        if (omin > umax) return 1;
        return 2;
    }



}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
