using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButtonChoices : MonoBehaviour {
	public Canvas createServerCanvas;
	public Canvas joinServerCanvas;
	// Use this for initialization
	void Start () {
		createServerCanvas = GameObject.Find("CanvasCreateServer").GetComponent<Canvas>();
		joinServerCanvas = GameObject.Find("CanvasJoinServer").GetComponent<Canvas>();
		createServerCanvas.enabled = false;
		joinServerCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//OnClick load and enable CreateServer Scene and Canvas 
	public void onClickCreateServer()
	{
		//Scene createServerScene = SceneManager.GetSceneByName("createServerScreen");
		SceneManager.LoadScene("createServerScreen");
		//SceneManager.SetActiveScene(createServerScene);
		createServerCanvas.enabled = true;
		print("createServerScreen loaded !");

	}

	//OnClick load and enable JoinServer Scene and Canvas 
	public onClickJoinserver()
	{
		//Scene joinServerScene = SceneManager.GetSceneByName("joinServerScreen");
		SceneManager.LoadScene("joinServerScreen");
		joinServerCanvas.enabled = true;
		print("joinServerScreen Loaded !"):
	}
}
