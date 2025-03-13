using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtScript : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 relativepos = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativepos);
    }
}
