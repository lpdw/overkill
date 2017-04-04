using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Revolver : MonoBehaviour , Gun {

	private string type;
	private int bullet;

	public Revolver() {
		this.name = "revolver";
		this.bullet = 6;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	#region Getter/Setter
	public string Type { get; set;}

	public int Bullet { get; set;}
	#endregion

	#region Gun implementation
	//public int Shoot { get; set;}
	
	void Gun.ToString ()
	{
		Console.WriteLine ("arme : revolver");
	}

	#endregion
}
