using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;
//using System.Web.Script.Serialization.JavaScriptSerializer;
class Program
{
    static void Main()
    {
        //Get JSON object.
        using (var webClient = new System.Net.WebClient()) {
        var json = webClient.DownloadString("http://blockchain.info/");
		//Compilation on this version of .NET for my online compiler; should work in .NET 4.0+
		//List<PlottedData> jsonParsed = new JavaScriptSerializer().Deserialize<PlottedData>(json);        
	}
    }
    public IEnumerable<KeyValuePair<string, object>> getTimePrices(String start, String end, SortedDictionary<string,object> array)
    {
        var keys = new List<String>(array.Keys);
        int index = keys.BinarySearch(start);
        
        //BinarySearch returns either the index (>=0) if it exists, or the bitwise NOT of the result.
        int startPoint =0;
        startPoint = index<0 ? ~index-1 : index;
        index = keys.BinarySearch(end);
        int endPoint =0;
        endPoint = index<0 ? ~index-1 : index;
        
        //Using LINQ, skip the first X number of elements, then take the ones in between the start and endpoint.
        var subset = array.Skip(startPoint).Take(startPoint-endPoint);
        
        
        return subset;
    }
    public void updatePrice(KeyValuePair<string,object> newCombo)
    {
        //Pseudo code:
        //This loop is run every X number of seconds
        //price = newCombo.Value
    }
}
//class PlottedData
//{
  //  public string time {get;set;}
  //  public string price {get;set;}
//}