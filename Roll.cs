using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Roll : MonoBehaviour {
	float coinval;
	Vector3[] position;
	float fracJourney;
	float[] posx = {0, 50,100,150, 200, 250, 300, 350, 400, 550, 600, 650, 700, 750, 800, 850, 900, 950, 1000, 1050, 1100, 1150, 1200, 1250, 1300};
	float[] posy = {0, 10, 25, 50, 78, 63, 42, 58, 80, 43, 38, 76, 35, 25, 42, 45, 78, 44, 43, 50, 36, 80, 34, 30, 24};
	float length = 25;
	Vector3 temp;
	int i=0;
	public Text textbox;


	void Start(){
		temp = transform.position;
	}
	void FixedUpdate()
	{
		temp.x = posx [i];
		temp.y = posy [i];
		transform.position = temp;
		coinval = posy[i] * 4.0f;
		i++;

		textbox.text = "1 BTC = " + coinval + " USD";
	}
	
}
