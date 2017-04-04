using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;

public class GameManager : MonoBehaviour {

	private List<Player> players;
	private bool endOfGame;

	public GameManager() {
		this.endOfGame = false;

		this.players = new List<Player> ();

		Player player1 = new Player ();
		player1.Pseudo = "player1";

		this.players.Add (player1);

	}

	#region Getter/Setter

	public List<Player> Players { get; set;}

	public bool EndOfGame { get; set;}

	#endregion

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
