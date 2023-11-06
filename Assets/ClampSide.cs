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

        // x²•ûŒü‚ÌˆÚ“®”ÍˆÍ§ŒÀ
        pos.x = Mathf.Clamp(pos.x, 555, 580);

        transform.position = pos;

        // y²•ûŒü‚ÌˆÚ“®”ÍˆÍ§ŒÀ
        pos.y = Mathf.Clamp(pos.y, 22, 25);

        transform.position = pos;

        // z²•ûŒü‚ÌˆÚ“®”ÍˆÍ§ŒÀ
        pos.z = Mathf.Clamp(pos.z, 138, 275);

        transform.position = pos;


    }
}
