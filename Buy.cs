using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class Buy : MonoBehaviour {

	public Slider money;
	public Slider btc;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void SendMessage(string word){
		money.value -= 10;
		btc.value += 2;
	}
}
