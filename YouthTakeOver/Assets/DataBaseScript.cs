using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
public class DataBaseScript : MonoBehaviour {

		public GameObject scriptAdd;
		// Use this for initialization
		void Start () {
		FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://youthtakeover-5c59c.firebaseio.com/");
			DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
			StartListener ();
		}

		// Update is called once per frame
		void Update () {
		//FirebaseDatabase.DefaultInstance.GetReference ("/battles/" + "/123/" + "/attacks/").Child ("3").SetValueAsync (0);
		FirebaseDatabase.DefaultInstance.GetReference ("/3").SetValueAsync (123);
		}
		public void StartListener ()
		{
			Debug.Log ("Listaner");
			FirebaseDatabase.DefaultInstance
				.GetReference ("Button")
				.ValueChanged += HandleValueChanged;
		
		}

		void HandleValueChanged(object sender, ValueChangedEventArgs args) {
			if (args.DatabaseError != null) {
				Debug.LogError(args.DatabaseError.Message);
				return;
			}
			Debug.Log(args.Snapshot.Value);
			
		}
	}

