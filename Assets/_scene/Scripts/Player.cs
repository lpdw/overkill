using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour {

	private string pseudo;
	private int lifePoint;
	private int shoot;
	private int killNumber;
	public Gun gun;
	private List<Gun> guns;

	public Player() {
		this.pseudo = "over00";
		this.lifePoint = 3;
		this.killNumber = 0;
		this.shoot = 0;
		this.gun = new Revolver ();

		// add default gun
		Revolver revolver = new Revolver ();
		this.guns = new List<Gun> ();
		this.guns.Add (revolver);
	}

	#region Getter/Setter
	public string Pseudo { get; set;}

	public int Shoot { get; set;}

	public int LifePoint { get; set;}

	public int KillNumber { get; set;}
	
	public List<Gun> Guns { get; set;}
	#endregion

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
