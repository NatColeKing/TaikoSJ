using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {
	int scene = 0;
	public GameObject pointer;
	public GameObject to_scene01;
	public GameObject to_scene02;
	public GameObject to_scene03;
		// scene 0 - menu
		// scene 1 - history
		// scene 2 - personal stories
		// scene 3 - why they joined

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this.gameObject);
	}

	// Update is called once per frame
	void Update () {
		if(scene == 3)
		{
			// go to why the joined
			SceneManager.LoadScene("TaikoReasonsForJoining");
			if(Time.timeSinceLevelLoad > 10)
			{
				// go back to menu
				scene = 0;
				SceneManager.LoadScene("Menu");
			}
		}
		if(scene == 2)
		{
			// go to personal stories
			SceneManager.LoadScene("TaikoReasonsForJoining");
			if(Time.timeSinceLevelLoad > 10)
			{
				// go back to menu
				scene = 0;
				SceneManager.LoadScene("Menu");
			}
		}
		if(scene == 1)
		{
			// go to history of Taiko
			SceneManager.LoadScene("TaikoHistory");
			if(Time.timeSinceLevelLoad > 10)
			{
				// go back to menu
				scene = 0;
				SceneManager.LoadScene("Menu");
			}
		}
		// if(scene == 0)
		// {
		// 	// in menu scene
		// 	// fml
		//
		// }
	}
}
