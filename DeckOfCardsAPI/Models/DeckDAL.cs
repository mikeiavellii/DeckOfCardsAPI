using Newtonsoft.Json;
using System.Net;

namespace DeckOfCardsAPI.Models
{
    public class DeckDAL
    {

        public static DrawModel GetDraw()//Adjust here maybe response or method 
        {
            //adjust here
            //Setup
            string url = $"https://deckofcardsapi.com/api/deck/new/draw/?count=5";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url); //go to this address
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();//get a response and saves it
            //we use (HttpWebResponse) to convert it (cast it) into that data type

            //Convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();


            //Convert to C#
            //the next to linees can be combined
            //Adjust here to change object you're working with
            DrawModel result = JsonConvert.DeserializeObject<DrawModel>(JSON);
            return result;

        }
    }
}
