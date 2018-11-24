using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBlock : MonoBehaviour {
	
	public GameObject PrefabMotorHigh;
	public GameObject PrefabMotorLow;
	public GameObject PrefabDelay;
	public GameObject PrefabEnd;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {
	}

	public void CreateDelayBlock(){
		Instantiate (PrefabDelay);
	}

	public void CreateMotorHighBlock(){
		Instantiate (PrefabMotorHigh);
	}

	public void CreateMotorLowBlock(){
		Instantiate (PrefabMotorLow);

	}

	public void CreateEndBlock(){
		Instantiate (PrefabEnd);
	}
}
