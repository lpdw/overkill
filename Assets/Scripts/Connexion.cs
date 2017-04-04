using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connexion : MonoBehaviour {
	private string ip_address;
	private int port;
	private int nbrGamers;
	public Rect inputLabel;
	public Rect inputField;
	public Rect inputValidate;
	public Rect inputCreateServer;
	// Use this for initialization
	public Connexion()
	{
		this.ip_address = "";
		this.port = 25565;
		this.nbrGamers = 15;
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnGUI(){
		this.inputField = new Rect(150, 10, 100, 20);
		this.inputLabel = new Rect(5, 10, 200, 20);
		this.inputValidate = new Rect(50,40,100, 25);
		this.inputCreateServer = new Rect(300, 40, 150, 25);

		GUI.Label(this.inputLabel, "Adress IP du serveur:");
		//ip_address = GUI.(Rect(150, 10, 100, 20), ip_address);
		this.ip_address = GUI.TextField(this.inputField, this.ip_address);

		if (GUI.Button(inputValidate, "Connexion") & this.ip_address.Length != 0) {
			Network.Connect(this.ip_address, this.port);
		}

		if (GUI.Button (inputCreateServer, "Créer un serveur")) {
			Network.InitializeServer(this.nbrGamers, this.port, false);
		}
	}

	public void OnServerInitialized()
	{
		print("Server created");
	}

	public void OnFailedToConnect()
	{
		print("Impossible de se connecter au serveur: " + this.ip_address);
	}

	public void OnConnectedToServer()
	{
		print("Connexion au serveur réussie: " + this.ip_address);
	}
}
