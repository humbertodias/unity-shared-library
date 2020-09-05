using System;
using UnityEngine;
using UnityEngine.UI;
using calculation;

public class CalcCLIUnity : MonoBehaviour
{
    public InputField inputA, inputB;
    public Text result;

    public void Sum()
    {
        var calc = new calculate();
        var a = Int32.Parse(inputA.text);
        var b = Int32.Parse(inputB.text);
        result.text = $"{calc.Sum(a, b)}";
    }
}
