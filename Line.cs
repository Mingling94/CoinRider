using UnityEngine;
using System;
using System.Collections;

public class Line : MonoBehaviour {
	float linex;
	float height;
	int lengthOfArray = 3;
	int i = 0;
	Vector3 scale;
	LineRenderer LR;
	Vector3[] pos;
	GameObject Linea;
	// Use this for initialization
	void Start () {
		pos [0].x = 0;
		pos [0].y = 0;
		pos [0].z = 0;
		pos [1].x = 5;
		pos [1].y = 5;
		pos [1].z = 5;
		LR = GetComponent<LineRenderer> ();
		//LR.SetPosition (i, pos[0]);


//		scale = transform.localScale;
//		scale.x = targetSize;
//		pos = transform.position;
//		transform.localScale = scale;
	}
	
	// Update is called once per frame
	void Update () {
		//linex += 1;
		//Instantiate (Linea, new Vector3(linex+=10, height, transform.position.z), Quaternion.identity); 
//		pos.x -= 1;
//		transform.position = pos;
	}
}