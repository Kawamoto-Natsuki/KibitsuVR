using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ClampSide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;

        // x�������̈ړ��͈͐���
        pos.x = Mathf.Clamp(pos.x, 555, 580);

        transform.position = pos;

        // y�������̈ړ��͈͐���
        pos.y = Mathf.Clamp(pos.y, 22, 25);

        transform.position = pos;

        // z�������̈ړ��͈͐���
        pos.z = Mathf.Clamp(pos.z, 138, 275);

        transform.position = pos;


    }
}
