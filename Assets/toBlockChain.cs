using UnityEngine;
using System.Collections;

public class toBlockChain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SendMessage(string word){
		System.Diagnostics.Process.Start("https://blockchain.info/wallet");

	}

}
