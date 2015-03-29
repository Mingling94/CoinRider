using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class Sell : MonoBehaviour {
	
	public Slider money;
	public Slider btc;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void SendMessage(string word){
		btc.value -= 10;
		money.value += 2;
	}
}
