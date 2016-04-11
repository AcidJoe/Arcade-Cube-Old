﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ArkMap : MonoBehaviour
{
    public int[,] map(int i)
    {
        switch (i)
        {
            case 0:
                int[,] q = new int[10, 11] {
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                };
                return q;
            case 1:
                int[,] q1 = new int[10, 11] {
                    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                    { 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0},
                    { 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0},
                    { 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0},
                    { 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0},
                    { 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0},
                    { 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0},
                    { 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0},
                    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                };
                return q1;
            case 2:
                int[,] q2 = new int[10, 11] {
                    { 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1 },
                    { 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0},
                    { 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0},
                    { 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0},
                    { 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0},
                    { 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0},
                    { 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0},
                    { 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                };
                return q2;
            case 3:
                int[,] q3 = new int[10, 11] {
                    { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1},
                    { 0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0},
                    { 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0},
                    { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                    { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
                    { 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0},
                    { 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0},
                    { 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                };
                return q3;
            case 4:
                int[,] q4 = new int[10, 11] {
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                };
                return q4;
        }

        return null;
    }
}