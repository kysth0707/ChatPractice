using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCreater : MonoBehaviour
{
    public GameObject Prefab;
    public GameObject ParentObject;
    public bool Create;

    public Material[] Materials;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Create)
        {
            Create = false;
            GameObject tmp = Instantiate(Prefab, Prefab.transform.position, Prefab.transform.rotation, ParentObject.transform);
            Material mat = Materials[Random.Range(0, Materials.Length)];
            tmp.GetComponent<Renderer>().material = mat;
            tmp.transform.Find("ChatBox").GetComponent<Renderer>().material = mat;
        }
    }
}
