using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamMove : MonoBehaviour
{
    public GameObject Cam;
    public float MoveSpeed;
    public float SeeSpeed;

    public GameObject LeftObject;
    public GameObject CenterObject;
    public GameObject RightObject;

    Vector3 LeftLoc = new Vector3(0, 0, 0);
    Vector3 CenterLoc = new Vector3(0, 0, 0);
    Vector3 RightLoc = new Vector3(0, 0, 0);

    Vector3 TargetPos = new Vector3(0, 0, 0);

    private void Start()
    {
        LeftLoc = LeftObject.transform.position;
        CenterLoc = CenterObject.transform.position;
        RightLoc = RightObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MousePos = Input.mousePosition;
        var TargetRot = LeftObject.transform.rotation;

        if (MousePos.x < Screen.width / 3)
        {
            TargetPos = LeftLoc;
            TargetRot = LeftObject.transform.rotation;
        }
        else if (MousePos.x < Screen.width / 3 * 2)
        {
            TargetPos = CenterLoc;
            TargetRot = CenterObject.transform.rotation;
        }
        else
        {
            TargetPos = RightLoc;
            TargetRot = RightObject.transform.rotation;
        }
        Vector3 dir = TargetPos - Cam.transform.position;
        Cam.transform.rotation = Quaternion.Lerp(Cam.transform.rotation, TargetRot, Time.deltaTime * SeeSpeed);

        Cam.transform.position = Vector3.Lerp(Cam.transform.position, TargetPos, Time.deltaTime * MoveSpeed);
    }
}
