﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidenSkript : MonoBehaviour {

	public float speed = -0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(1,0,0)*speed*Time.deltaTime);
		
	}
}
