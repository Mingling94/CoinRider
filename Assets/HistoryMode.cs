using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Web.Script.Serialization.JavaScriptSerializer;

class HistoryMode
{
	List<PlottedData> btcHistory;
	Wallet w;
	int counter;

	public HistoryMode()
	{
		// Get JSON
		using (var webClient = new System.Net.WebClient()) {
			var json = webClient.DownloadString("http://blockchain.info/");
			//Compilation on this version of .NET for my online compiler; should work in .NET 4.0+
			btcHistory = new JavaScriptSerializer().Deserialize<PlottedData>(json);        
		}
		counter = 0;

	}

	public void updateStats()
	{

	}
    public void updatePrice()
    {
        //Pseudo code:
        //This loop is run every X number of seconds
        //price = newCombo.Value
    }
	public float NetWorth(Wallet w, float price)
	{
		return w.Usd + (price * w.Btc);
	}
	public float PercentDiff(Wallet w, float price, float initial)
	{
		float current = NetWorth(w, price);
		float diff = current - inital;
		return (diff/ initial) * 100;
	}
}
class PlottedData
{
    public string time {get;set;}
    public string price {get;set;}
}