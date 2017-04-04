using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScreenScript : MonoBehaviour {

	public Button buttonCreateServer;

	void Start()
	{
		Button btn = buttonCreateServer.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
