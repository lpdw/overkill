using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	public Transform gamer;
	public string team;
	public bool isDead = true;
	public GameObject spawn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void spawnOnMap() {
		if (Network.peerType == NetworkPeerType.Client || Network.peerType == NetworkPeerType.Server) {
			Network.Instantiate(gamer,spawn.transform.position,spawn.transform.rotation,0);
			isDead = false;
		}
	}
}
