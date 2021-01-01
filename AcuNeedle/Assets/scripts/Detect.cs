using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Detect : MonoBehaviour
{
    
    public GameObject ang;
    string text;
    string angle = "85";
    public GameObject detect;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("DetectImg").GetComponent<RawImage>().enabled = true; ;
        GameObject.Find("DetectMsg").GetComponent<Text>().enabled = true;
        GameObject.Find("DetectMsg").GetComponent<Text>().text = "NOT DETECTED";
        GameObject.Find("DetectImg").GetComponent<RawImage>().texture = Resources.Load("Imagess/NotDetected") as Texture2D;

    }

    public void change()
    {
        if (ang.GetComponent<Text>().text.Equals(angle))
        {
            GameObject.Find("DetectImg").GetComponent<RawImage>().enabled = true; ;
            GameObject.Find("DetectMsg").GetComponent<Text>().enabled = true;
            GameObject.Find("DetectMsg").GetComponent<Text>().text = "DETECTED";
            GameObject.Find("DetectImg").GetComponent<RawImage>().texture = Resources.Load("Imagess/Detected") as Texture2D;
           // Debug.Log(GameObject.Find("DetectMsg").GetComponent<Text>().text);
        }
        else
        {
            GameObject.Find("DetectImg").GetComponent<RawImage>().enabled = true; ;
            GameObject.Find("DetectMsg").GetComponent<Text>().enabled = true;
            GameObject.Find("DetectMsg").GetComponent<Text>().text = "NOT DETECTED";
            GameObject.Find("DetectImg").GetComponent<RawImage>().texture = Resources.Load("Imagess/NotDetected") as Texture2D;
          //  Debug.Log(GameObject.Find("DetectMsg").GetComponent<Text>().text);
        }
    }
    // Update is called once per frame
    void Update()
    {
       // change();
    }
}
