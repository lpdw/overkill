﻿#pragma strict
import UnityEngine.Networking;
//we create a playernetwork class the extents the network class
public class PlayerNetworkManagerFP extends Networking.NetworkBehaviour{

var MainCamera:Transform;

var rigidBodyController:UnityStandardAssets.Characters.FirstPersonCharacter.RigidbodyFirstPersonController;


function Start(){
 rigidBodyController=transform.GetComponent(UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController);
 MainCamera=transform.GetComponentInChildren(Camera).transform;
 if(isLocalPlayer){
 rigidBodyController.isMine=true;
 }else{
 //what to do if we arent the ownwer of this network
 MainCamera.GetComponent.<Camera>().enabled=false;
 MainCamera.GetComponent(AudioListener).enabled=false;	
 rigidBodyController.isMine=false;
 }
 }
}