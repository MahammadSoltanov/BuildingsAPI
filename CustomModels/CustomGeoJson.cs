using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BuildingsAPI.CustomModels;

public class GeoJsonFeature
{
    public string Type { get; set; }
    public GeoJsonGeometry Geometry { get; set; }
    public GeoJsonProperties Properties { get; set; }

}
public class GeoJsonGeometry
{
    public string Type { get; set; }
    public List<List<List<double>>> Coordinates { get; set; }
}

public class GeoJsonProperties
{
    public int Index { get; set; }
    public string Geotype { get; set; }
    [JsonPropertyName("addr:city")]
    public string AddrCity { get; set; }
    [JsonPropertyName("addr:country")]
    public string AddrCountry { get; set; }
    [JsonPropertyName("addr:housenumber")]
    public string AddrHousenumber { get; set; }
    [JsonPropertyName("addr:postcode")]
    public string AddrPostcode { get; set; }
    [JsonPropertyName("addr:street")]
    public string AddrStreet { get; set; }
    public string Building { get; set; }
    [JsonPropertyName("building:levels")]
    public string BuildingLevels { get; set; }
    public string Name { get; set; }
    [JsonPropertyName("name:az")]
    public string NameAz { get; set; }
    [JsonPropertyName("name:en")]
    public string NameEn { get; set; }
    [JsonPropertyName("name:ru")]
    public string NameRu { get; set; }

}