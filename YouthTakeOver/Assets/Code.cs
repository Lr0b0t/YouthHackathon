using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;

public class Code : MonoBehaviour {

	public string code = "";
	public GameObject firstConnection; 

	// Use this for initialization
	void Start () {
		FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://youthtakeover-5c59c.firebaseio.com/");
		DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CreateCode(){
		code = "";
		AddToCode(firstConnection.GetComponent<collisionDetector>().ConnectedObject);
	}

	public void AddToCode(GameObject objectToAdd){
		code += "/";
		code += objectToAdd.transform.name; 
		Debug.Log (code);
		FirebaseDatabase.DefaultInstance.GetReference ("/code").SetValueAsync (code);
		if (objectToAdd.transform.Find ("ConnectionPart2").transform.gameObject) {
			GameObject nextConnection = objectToAdd.transform.Find ("ConnectionPart2").transform.gameObject;
			AddToCode (nextConnection.GetComponent<collisionDetector> ().ConnectedObject);
		} else {
			return;
		}
	}
}
