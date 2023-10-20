// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Web;
using System.Xml;
using System.Xml.Linq;

var client = new HttpClient();
client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", $"Bearer {"Your_Token"}");

var content = new
{
    long_url = "https://tarikdavulcu.com"
};

//HTTP POST
var resp = await client.PostAsJsonAsync("https://api-ssl.bitly.com/v4/shorten", content);
var rr= JsonSerializer.Deserialize<Root>(await resp.Content.ReadAsStringAsync());
Console.WriteLine("ShortUrl: "+ rr.link.ToString());
Console.ReadLine();
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class References
{
    public string group { get; set; }
}

public class Root
{
    public string created_at { get; set; }
    public string id { get; set; }
    public string link { get; set; }
    public List<object> custom_bitlinks { get; set; }
    public string long_url { get; set; }
    public bool archived { get; set; }
    public List<object> tags { get; set; }
    public List<object> deeplinks { get; set; }
    public References references { get; set; }
}