using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PopupDetect : MonoBehaviour
{
    public GameObject popup;
    string angle, msg, pmsg, angle_from_device="75";
    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        angle = GameObject.Find("Angle").GetComponent<Text>().text;
        GameObject.Find("Popangle").GetComponent<Text>().text = angle + " Angle:";
       // msg = GameObject.Find("DetectMsg").GetComponent<Text>().text;
        if (angle_from_device!=angle)
        {
            GameObject.Find("anglednd").GetComponent<Text>().text = "Not Detected";
            GameObject.Find("anglednd").GetComponent<Text>().color = new Color32(248, 88, 88, 255);
            GameObject.Find("Dpic").GetComponent<RawImage>().texture = Resources.Load("Imagess/NotDetected") as Texture2D;
            Debug.DrawLine(Vector3.zero, Quaternion.Euler(0, 30, 0) * transform.forward, Color.white, 2.5f);
        }
        else 
        {
            GameObject.Find("anglednd").GetComponent<Text>().text = "Detected";
            GameObject.Find("anglednd").GetComponent<Text>().color = new Color32(42, 255, 120, 255);
            GameObject.Find("Dpic").GetComponent<RawImage>().texture = Resources.Load("Imagess/Detected") as Texture2D;
        }

       pmsg = GameObject.Find("Pfalse").GetComponent<Text>().text;
        if (pmsg == "False")
        {
            GameObject.Find("Pfalse").GetComponent<Text>().color = new Color32(248, 88, 88, 255);
            GameObject.Find("Msg").GetComponent<Text>().text = "AcuPoint Not Punched";
        }
        else
        {
            GameObject.Find("Pfalse").GetComponent<Text>().color = new Color32(42, 255, 120, 255);
            GameObject.Find("Msg").GetComponent<Text>().text = "AcuPoint Punched";
        }
    }
   
}
