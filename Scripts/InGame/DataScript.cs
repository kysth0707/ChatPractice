using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataScript : MonoBehaviour
{
    List<GameObject> Boxes = new List<GameObject>();

    public void Clear()
    {
        Boxes.Clear();
    }
    public void Create(GameObject obj)
    {
        Boxes.Add(obj);
        transform.gameObject.GetComponent<ChatIt>().ThisThing += 1;
    }

    public void Remove()
    {
        Boxes.RemoveAt(0);
    }

    public GameObject LatestThing()
    {
        return Boxes[0];
    }

    public int Size()
    {
        return Boxes.Count;
    }
}
