using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerCreater : MonoBehaviour
{
    public GameObject Prefab;
    public GameObject ParentObject;
    void Start()
    {
        for(int i = 0; i < 30; i++)
        {
            Vector3 Loc = new Vector3(0, -1.22f, -1f + i * 0.4f);
            Instantiate(Prefab, Loc, Prefab.transform.rotation, ParentObject.transform);
        }
    }
}
