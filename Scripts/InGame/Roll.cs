using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
    float i = 0;
    void Update()
    {
        transform.Rotate(new Vector3(0, i * 360f, 0));

        if (i > 1f)
            i = 0;
        i += Time.deltaTime;
    }
}
