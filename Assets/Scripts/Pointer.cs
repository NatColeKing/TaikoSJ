using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Pointer : MonoBehaviour {
	float entered_time = -1f;
	public String sceneName = "";
	public Material materialOn;
	public Material materialOff;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(entered_time > 0)
		{
			// you're looking at it
			if(Time.timeSinceLevelLoad > entered_time + 3)
			{
				// change scene - you're looking for 3 seconds
				SceneManager.LoadScene(sceneName);
			}
		}
	}

	void OnTriggerEnter(Collider c)
	{
		print("entered");
		entered_time = Time.timeSinceLevelLoad;
		this.gameObject.GetComponent<MeshRenderer>().material = materialOn;
	}

	void OnTriggerExit(Collider c)
	{
		print("exit");
		entered_time = -1f;
		this.gameObject.GetComponent<MeshRenderer>().material = materialOff;
	}
}
