﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space))
		{
			SceneManager.LoadScene("cabin");
		}
		
	}
}
