using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
namespace AssemblyCSharp
{
	class HistoryMode
	{
		// displayed variables
		float[] btcHistory;
		GameWallet w;
		float currentPrice;
		// hidden variables
		int counter;
		int totalCount;
		float netWorth;
		float percentDiff;
		
		public HistoryMode()
		{
			List<PlottedData> tempList;
			// Get JSON
			using (var webClient = new System.Net.WebClient()) {
				var json = webClient.DownloadString(
					"https://blockchain.info/charts/market-price?showDataPoints=false&timespan=all&show_header=true&daysAverageString=1&scale=0&format=json&address=");
				//Compilation on this version of .NET for my online compiler; should work in .NET 4.0+
				tempList = JsonConvert.DeserializeObject<List<PlottedData>>(json);     
			}
			//Hardcoded for october 1, 2010.
			tempList = (List<PlottedData>)getTimePrices("1285891200",(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds.ToString(), tempList);
			totalCount = tempList.Count;
			btcHistory = new float[totalCount];
			for(int i = 0; i < totalCount; i++) {
				btcHistory[i] = float.Parse(tempList[i].price);
			}
			counter = 0;
			w = new GameWallet (100);
			netWorth = 100;
			currentPrice = btcHistory [0];
			percentDiff = 0;
			
			// Update display
		}
		
		public IEnumerable<PlottedData> getTimePrices(String start, String end, List<PlottedData> history)
		{
			PlottedData comparison = new PlottedData (start, "DOES NOT MATTER");
			int index = history.BinarySearch(comparison);
			
			//BinarySearch returns either the index (>=0) if it exists, or the bitwise NOT of the result.
			int startPoint =0;
			startPoint = index<0 ? ~index-1 : index;
			comparison.time = end;
			index = history.BinarySearch(comparison);
			int endPoint =0;
			endPoint = index<0 ? ~index-1 : index;
			
			//Using LINQ, skip the first X number of elements, then take the ones in between the start and endpoint.
			var subset = history.Skip(startPoint).Take(startPoint-endPoint);
			
			return subset;
		}
		
		// Updating functions
		public void updateStats()
		{
			counter++;
			currentPrice = Price();
			netWorth = NetWorth();
			percentDiff = 0;
			// Update size
			// Update display
		}
		public float Price()
		{
			return btcHistory[counter];
		}
		public float NetWorth()
		{
			return w.Usd + (currentPrice * w.Btc);
		}
		public float PercentDiff()
		{
			float current = NetWorth();
			float diff = current - 100; //initial value is 100, hardcoded
			return (diff/100) * 100;	//same here
		}
		
		// Action functions
		public void Buy(float percent) 
		{
			float amount = percent * netWorth / 100;
			w.Buy(amount, currentPrice);
		}
		public void Sell(float percent) 
		{
			float amount = percent * netWorth / 100;
			w.Sell(amount/currentPrice, currentPrice);
		}
	}
	class PlottedData : IComparable
	{
		public string time {get;set;}
		public string price {get;set;}
		
		public PlottedData(string t, string p)
		{
			time = t;
			price = p;
		}
		int IComparable.CompareTo(object other)
		{
			PlottedData other1 = (PlottedData)other;
			return this.time.CompareTo (other1.time);
		}
	}
}