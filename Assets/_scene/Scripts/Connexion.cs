using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Connexion : MonoBehaviour {
	
	private string ip_Address;
	private int port;
	private int nbrGamers;
	public InputField InputJoinServer;
	public InputField InputCreateServer;

	// Use this for initialization
	public Connexion()
	{
		this.ip_Address = "";
		this.port = 25565;
		this.nbrGamers = 15;
	}
	void Start () {

	}

	// Join the server -> Get text related to the InputField
	public void joinServer()
	{
		InputJoinServer = GameObject.Find("InputJoinServer").GetComponent<InputField>();
		this.ip_Address = InputJoinServer.text.ToString();

		if (this.ip_Address.Length != 0) {
			Network.Connect(ip_Address,this.port);
			print(ip_Address);
		}

	}

	// Create the server with default ip address of player
	public void createServer()
	{
		InputCreateServer = GameObject.Find("InputCreateServer").GetComponent<InputField>();

		//string ip_Address = InputCreateServer.text.ToString();
		if (this.ip_Address.Length != 0) {
			Network.InitializeServer(this.nbrGamers,this.port,false);
		}
	}

	// Server correctly initialized
	public void OnServerInitialized()
	{
		print("Server created");
	}

	// Errors during connection to server 
	public void OnFailedToConnect()
	{
		print("Impossible de se connecter au serveur: " + this.ip_Address);
	}

	// Connected successfully
	public void OnConnectedToServer()
	{
		print("Connexion au serveur réussie: " + this.ip_Address);
	}

}
