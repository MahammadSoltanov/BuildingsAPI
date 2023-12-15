using System.Text.Json;
using NetTopologySuite.Geometries;
using Newtonsoft.Json;

namespace BuildingsAPI.Models;

public partial class Bina
{
    public int Id { get; set; }

    public Geometry Hendese { get; set; }

    [JsonProperty("addr:city")]
    public string AddrCity { get; set; }

    [JsonProperty("addr:country")]
    public string AddrCountry { get; set; }

    [JsonProperty("addr:housenumber")]
    public string AddrHousenumber { get; set; }

    [JsonProperty("addr:postcode")]
    public string AddrPostcode { get; set; }

    [JsonProperty("addr:street")]
    public string AddrStreet { get; set; }

    public string Amenity { get; set; }

    public string BathOpenAir { get; set; }

    public string BathSandBath { get; set; }

    public string Brand { get; set; }

    public string Building { get; set; }

    [JsonProperty("building:levels")]
    public string BuildingLevels { get; set; }

    public string Charge { get; set; }

    public string Description { get; set; }

    public string Fee { get; set; }

    public string InternetAccess { get; set; }

    public string InternetAccessFee { get; set; }

    public string Leisure { get; set; }

    public string Name { get; set; }

    public string NameAr { get; set; }
    [JsonProperty("name:az")]
    public string NameAz { get; set; }

    [JsonProperty("name:en")]
    public string NameEn { get; set; }

    [JsonProperty("name:ru")]
    public string NameRu { get; set; }

    public string OpeningHours { get; set; }

    public string OpeningHoursCovid19 { get; set; }

    public string Operator { get; set; }

    public string PaymentCash { get; set; }

    public string PaymentMastercard { get; set; }

    public string PaymentVisa { get; set; }

    public string Phone { get; set; }

    public string Phone1 { get; set; }

    public string Shop { get; set; }

    public string Source { get; set; }

    public string Tourism { get; set; }

    public string Geotype { get; set; }

    public int? Index { get; set; }

    public string Country { get; set; }

    public string Diplomatic { get; set; }

    public string Email { get; set; }

    public string Embassy { get; set; }

    public string Facebook { get; set; }

    public string Fax { get; set; }

    public string Government { get; set; }

    public string Image { get; set; }

    public string NameFr { get; set; }

    public string Name1 { get; set; }

    public string Name2 { get; set; }

    public string Office { get; set; }

    public string Religion { get; set; }

    public string SourceRef { get; set; }

    public string Target { get; set; }

    public string Website { get; set; }

    public string Wikidata { get; set; }

    public string Wikipedia { get; set; }
}
