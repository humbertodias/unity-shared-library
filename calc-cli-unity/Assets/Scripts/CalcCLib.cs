﻿using System;
using UnityEngine;
using UnityEngine.UI;
// DllImport
using System.Runtime.InteropServices;

public class CalcCLib : MonoBehaviour
{
    public InputField inputA, inputB;
    public Text result;

    [DllImport("libcalc.so")] // 32-bit arm7 dll
    public static extern int sum(int a, int b);

    public void Sum()
    {
        var a = Int32.Parse(inputA.text);
        var b = Int32.Parse(inputB.text);
        result.text = $"{sum(a, b)}";
    }
}
