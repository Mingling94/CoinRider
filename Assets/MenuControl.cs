using UnityEngine;
using System.Collections;

public class MenuControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SendMessage(string word){
		Application.LoadLevel (word);
		
	}
}
