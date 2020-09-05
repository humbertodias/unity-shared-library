using System;
using UnityEngine;
using UnityEngine.UI;
using calculation;

public class CalcCSharpLib : MonoBehaviour
{
    public InputField inputA, inputB;
    public Text result;

    public void Sum()
    {
        var calc = new Calculate();
        var a = Int32.Parse(inputA.text);
        var b = Int32.Parse(inputB.text);
        result.text = $"{calc.Sum(a, b)}";
    }
}
