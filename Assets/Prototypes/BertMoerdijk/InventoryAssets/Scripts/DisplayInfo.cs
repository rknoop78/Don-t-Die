﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class will take care of displaying information about the object you are hovering over.

public class DisplayInfo : MonoBehaviour {

    // Get the text object
    private GameObject displaytext;
    private GameObject Canvas;

    void Start ()
    {
        Canvas = GameObject.Find("MainCanvas");
        displaytext = Canvas.transform.GetChild(3).GetChild(0).gameObject;
    }

    public void DisplayTextStart(Item item)
    {
        displaytext.SetActive(true);
        displaytext.transform.position = Input.mousePosition;
        displaytext.transform.GetChild(0).GetComponent <UnityEngine.UI.Text>().text = item.Title + "\n" + item.Description;
    }

    public void DisplayTextEnd(Item item)
    {
        displaytext.SetActive(false);
    }

}
