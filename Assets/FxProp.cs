﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FxProp : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetString("fx") == "on")
        {
            this.GetComponent<Image>().color = Color.blue;

        }
        else
        {
            this.GetComponent<Image>().color = Color.red;

        }
    }
}
