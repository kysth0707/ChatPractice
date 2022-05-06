using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWing : MonoBehaviour
{
    Vector3 TargetScale = new Vector3(3.0418f, 0.6314127f, 0.2788f);

    float MoveTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < 8)
        {
            if(MoveTime < 1f)
            {
                MoveTime += Time.deltaTime;
                transform.localScale = new Vector3(Mathf.Lerp(transform.localScale.x, TargetScale.x, MoveTime), TargetScale.y, TargetScale.z);
            }
        }
    }
}
