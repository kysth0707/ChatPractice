using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    float MoveTime = 0;
    bool StartedToRealMove = false;
    GameObject SystemManager;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 140f);

        SystemManager = GameObject.Find("SystemManager");
        SystemManager.GetComponent<DataScript>().Create(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveTime < 2f && transform.position.z > 0f)
        {
            MoveTime += Time.deltaTime;

            transform.position = Vector3.Lerp(transform.position, new Vector3(0, 0, 10f), Time.deltaTime * 2.7f);
        }
        else
        {

            if(transform.position.z <= 0f)
            {
                if(StartedToRealMove == true)
                {
                    StartedToRealMove = false;
                    MoveTime = 0;
                }
                else
                {
                    if(MoveTime < 1f)
                    {
                        MoveTime += Time.deltaTime;
                        transform.localScale = new Vector3(2, 2, 1) * Mathf.Lerp(transform.localScale.z, 0f, MoveTime);
                    }
                    else
                    {
                        SystemManager.GetComponent<DataScript>().Remove();
                        Destroy(transform.gameObject);
                    }
                }
            }
            else
            {
                if (StartedToRealMove == false)
                {
                    StartedToRealMove = true;
                    transform.position = new Vector3(0, 0, 10f);
                }
                else
                {
                    transform.position += new Vector3(0, 0, -1f) * Time.deltaTime * 2f;
                }
            }
        }
    }
}
