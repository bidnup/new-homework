using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{




    private void Start()
    {
        int array;
        {
            int[] points = new int[6];
            points[0] = 47;
            points[1] = 86;
            points[2] = 43;
            points[3] = 19;
            points[4] = 67;
            points[5] = 57;
            for (int num = 0; num <= 5; num++) { Debug.Log(points[num]); };
            for (int i = 5; i >= 0; i--) { Debug.Log(points[i]); }
        }
    }

    private void Update()
    {

    }
}



