using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragScript : MonoBehaviour {

	private Vector3 offset;

	void OnMouseDown()
	{

		offset = gameObject.transform.position -
			Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
	}

	void OnMouseDrag()
	{
		Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
		transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
	}


//
//	void OnMouseDrag() {
//		Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//		transform.position = new Vector3(point.x, point.y , 0f);
//	}

}
