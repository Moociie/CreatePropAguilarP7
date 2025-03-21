using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public class Delegate : MonoBehaviour
{
    delegate void MyDelegate(int num);
    MyDelegate myDelegate;

    // Start is called before the first frame update
    void Start()
    {
        myDelegate = PrintNum;
        myDelegate(50);

        myDelegate = DoubleNum;
        myDelegate(50);

    }
    void PrintNum(int num)
    {
        print("Print Num: " + num);
    }

    // Update is called once per frame
    void DoubleNum(int num)
    {
        print("Print Num: " + num);
    }
}
