﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficConeController : MonoBehaviour {

    private GameObject unitychan;

    // Use this for initialization
    void Start () {
        this.unitychan = GameObject.Find("unitychan");
    }
	
	// Update is called once per frame
	void Update () {

        if ((this.unitychan.transform.position.z - 15) >= this.transform.position.z)
        {
            Destroy(this.gameObject);
        }

    }


}
