using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using calculation;

public class CalcCliUnity : MonoBehaviour
{
    public InputField inputA, inputB;
    public Text result;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Add()
    {
        var calc = new calculate();
        var a = Int32.Parse(inputA.text);
        var b = Int32.Parse(inputB.text);
        var text = $"{calc.Sum(a, b)}";
        Debug.Log(text);
        result.text = text;
    }
}
