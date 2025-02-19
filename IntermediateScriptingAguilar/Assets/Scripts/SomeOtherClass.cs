using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{

    void Start()
    {
        SomeClass myClass = new SomeClass();

        myClass.Add(3, 4);
        myClass.Add("Hello ", "World");
    }

}
