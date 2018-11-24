using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetector : MonoBehaviour {
	public GameObject ConnectedObject; 
	void OnCollisionEnter (Collision col)
	{
		Debug.Log ("col");
	}



	void  OnTriggerEnter (Collider col)
	{
		Debug.Log ("col");
	}

	void OnTriggerStay2D(Collider2D coll)
	{
		string name = coll.gameObject.transform.name;
		Debug.Log (name);
		// Debug.Log (name);
		if (name == "ConnectionPart1") {
			//coll.gameObject.transform.parent.transform.position = new Vector3 (gameObject.transform.position.x + coll.gameObject.transform.parent.GetComponent<BoxCollider2D> ().size.x / 2 + gameObject.transform.parent.GetComponent<BoxCollider2D> ().size.x / 2, gameObject.transform.position.y, 0f);
			coll.gameObject.transform.parent.transform.position = new Vector3(gameObject.transform.position.x + (coll.gameObject.transform.parent.GetComponent<BoxCollider2D> ().size.x) / 4 , gameObject.transform.position.y);
			ConnectedObject = coll.gameObject.transform.parent.transform.gameObject;
		}
	}
}
