using Newtonsoft.Json;

namespace MultipleHtppClient.API;

public class ProductData
{
    [JsonProperty("color")]
    public string Color { get; set; }
    [JsonProperty("capacity")]
    public string Capacity { get; set; }
    [JsonProperty("price")]
    public double? Price { get; set; }
    [JsonProperty("generation")]
    public string Generation { get; set; }
    [JsonProperty("year")]
    public int? Year { get; set; }
    [JsonProperty("CPU model")]
    public string CPUModel { get; set; }
    [JsonProperty("Hard disk size")]
    public string HardDiskSize { get; set; }
    [JsonProperty("Strap Colour")]
    public string StrapColour { get; set; }
    [JsonProperty("Case Size")]
    public string CaseSize { get; set; }
    [JsonProperty("Color")]
    public string ColorAlt { get; set; } // For the Beats Studio3 Wireless
    [JsonProperty("Description")]
    public string Description { get; set; }
    [JsonProperty("Screen size")]
    public double? ScreenSize { get; set; }
}
