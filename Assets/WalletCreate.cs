
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.IO;
using System.Net;
using System.Text;

public class JResult {
	public string address { get; set; }
}


public class WalletCreate : MonoBehaviour {

	public InputField email;
	public InputField password;

	private string strEmail;
	private string strPassword;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


	}

	void SendMessage(string word){
	//	Application.LoadLevel (word);
		strEmail = email.text;
		strPassword = password.text;
		string url = "https://blockchain.info/api/v2/create_wallet?email=" + 
			strEmail + "&password=" + strPassword + 
			"&api_code=82d78766-eae4-4aa2-914e-95ad9931d242";

		string[] stringSeparators = new string[] {"address\":\""};
		string[] stringSeparators2 = new string[] {"\",\"link"};
		string[] m;

		WebRequest request = WebRequest.Create (url);
		WebResponse response = request.GetResponse ();

		Debug.Log (((HttpWebResponse)response).StatusDescription);

		Stream dataStream = response.GetResponseStream ();
		StreamReader reader = new StreamReader (dataStream);

		string responseFromServer = reader.ReadToEnd ();


		m =  responseFromServer.Split (stringSeparators, StringSplitOptions.RemoveEmptyEntries);
		m = m[1].Split (stringSeparators2, StringSplitOptions.RemoveEmptyEntries);

		Debug.Log (m[0]);


		reader.Close ();
		response.Close ();
	}

}
