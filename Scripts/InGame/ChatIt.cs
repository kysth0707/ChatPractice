using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatIt : MonoBehaviour
{
    GameObject SystemManager;
    public uint ThisThing = 0;
    uint LastThing = 0;

    string HaveToType = "";

    List<KeyCode> KeyCodes = new List<KeyCode>();
    List<char> Alphabets = new List<char>();

    void Start()
    {
        SystemManager = GameObject.Find("SystemManager");

        AddAlphabets();
    }

    // Update is called once per frame
    void Update()
    {
        if(SystemManager.GetComponent<DataScript>().Size() > 0)
        {
            if(ThisThing != LastThing)
            {
                LastThing = ThisThing;

                GameObject This = SystemManager.GetComponent<DataScript>().LatestThing();

                HaveToType = This.transform.Find("ChatBox").transform.Find("Text").GetComponent<TextMesh>().text.ToLower();
            }
            else
            {
                if (Input.anyKeyDown && HaveToType.Length > 0)
                {
                    for(int i = 0; i < KeyCodes.Count; i++)
                    {
                        if (Input.GetKeyDown(KeyCodes[i]) && Alphabets[i] == HaveToType[0])
                        {
                            HaveToType = HaveToType.Substring(1);
                            Debug.Log(HaveToType);

                            break;
                        }
                    }
                }
            }
        }
    }



    void AddAlphabets()
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        for (int i = 0; i < alphabet.Length; i++)
        {
            Alphabets.Add(alphabet[i]);
        }


        KeyCodes.Add(KeyCode.A);
        KeyCodes.Add(KeyCode.B);
        KeyCodes.Add(KeyCode.C);
        KeyCodes.Add(KeyCode.D);
        KeyCodes.Add(KeyCode.E);
        KeyCodes.Add(KeyCode.F);
        KeyCodes.Add(KeyCode.G);
        KeyCodes.Add(KeyCode.H);
        KeyCodes.Add(KeyCode.I);
        KeyCodes.Add(KeyCode.J);
        KeyCodes.Add(KeyCode.K);
        KeyCodes.Add(KeyCode.L);
        KeyCodes.Add(KeyCode.M);
        KeyCodes.Add(KeyCode.N);
        KeyCodes.Add(KeyCode.O);
        KeyCodes.Add(KeyCode.P);
        KeyCodes.Add(KeyCode.Q);
        KeyCodes.Add(KeyCode.R);
        KeyCodes.Add(KeyCode.S);
        KeyCodes.Add(KeyCode.T);
        KeyCodes.Add(KeyCode.U);
        KeyCodes.Add(KeyCode.V);
        KeyCodes.Add(KeyCode.W);
        KeyCodes.Add(KeyCode.X);
        KeyCodes.Add(KeyCode.Y);
        KeyCodes.Add(KeyCode.Z);
    }
}
