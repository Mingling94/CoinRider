using UnityEngine;
using System.Collections;

public class LineRendererx : MonoBehaviour {
	LineRenderer linea;
	static int i, length = 25;
	float[] posx = {0, 50,100,150, 200, 250, 300, 350, 400, 550, 600, 650, 700, 750, 800, 850, 900, 950, 1000, 1050, 1100, 1150, 1200, 1250, 1300};
	float[] posy = {0, 10, 25, 50, 78, 63, 42, 58, 80, 43, 38, 76, 35, 25, 42, 45, 78, 44, 43, 50, 36, 80, 34, 30, 24};
	Vector3 pos;
	// Use this for initialization
	void Start () {
		linea = gameObject.GetComponent<LineRenderer> ();
		linea.SetVertexCount (length);

	}
	
	// Update is called once per frame
	void Update () {
		for(i = 0; i < length; i++)
		{
			pos = new Vector3(posx[i], posy[i], 0);
			linea.SetPosition (i, pos);
		}
	}
}
