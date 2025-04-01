using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColorScript : MonoBehaviour
{
    private Renderer rendererD;

    private void Start()
    {
        rendererD = GetComponent<Renderer>();
    }

    void OnEnable()
    {
        EventManager.OnClicked += TurnColor;
    }
    void OnDisable()
    {
        EventManager.OnClicked -= TurnColor;
    }

   
    void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
       rendererD.material.color = col;
    }
}
