﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {
    public Text mDiamond;

    // Update is called once per frame
    void Update () {
        mDiamond.text = ""+PlayerPrefs.GetInt("dia");

    }
}
