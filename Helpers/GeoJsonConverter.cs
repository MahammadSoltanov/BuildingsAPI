using BuildingsAPI.Models;
using NetTopologySuite.Geometries;
using Newtonsoft.Json;

namespace BuildingsAPI.Helpers
{
    public static class GeoJsonConverter
    {

        public static string ToGeoJson(this Bina bina)
        {
            var feature = new
            {
                type = "Feature",
                geometry = new
                {
                    type = bina.Hendese.GeometryType,
                    coordinates = GeoJsonConverter.GetCoordinates(bina.Hendese)
                },
                properties = new
                {
                    addr_city = bina.AddrCity,
                    addr_country = bina.AddrCountry,
                    addr_housenumber = bina.AddrHousenumber,
                    addr_postcode = bina.AddrPostcode,
                    addr_street = bina.AddrStreet,
                    building = bina.Building,
                    building_levels = bina.BuildingLevels,
                    name = bina.Name,
                    name_az = bina.NameAz,
                    name_en = bina.NameEn,
                    name_ru = bina.NameRu,
                    geotype = bina.Geotype,
                    index = bina.Index,
                },

                id = bina.Id
            };

            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            return JsonConvert.SerializeObject(feature, settings);
        }

        public static string ToGeoJson(this IEnumerable<Bina> binas)
        {
            var features = binas.Select(bina => new
            {
                type = "Feature",
                geometry = new
                {
                    type = bina.Hendese.GeometryType,
                    coordinates = GeoJsonConverter.GetCoordinates(bina.Hendese)
                },
                properties = new
                {
                    addr_city = bina.AddrCity,
                    addr_coutnry = bina.AddrCountry,
                    addr_housenumber = bina.AddrHousenumber,
                    addr_postcode = bina.AddrPostcode,
                    addr_street = bina.AddrStreet,
                    building = bina.Building,
                    building_levels = bina.BuildingLevels,
                    name = bina.Name,
                    name_az = bina.NameAz,
                    name_en = bina.NameEn,
                    name_ru = bina.NameRu,
                    geotype = bina.Geotype,
                    index = bina.Index,
                },

                id = bina.Id
            });

            var featureCollection = new
            {
                type = "FeatureCollection",
                features
            };


            return JsonConvert.SerializeObject(featureCollection);
        }


        private static List<List<List<double>>> GetCoordinates(Geometry geometry)
        {

            var coordinates = new List<List<List<double>>>();
            var secondList = new List<List<double>>();

            foreach (Coordinate c in geometry.Coordinates)
            {
                
                var oneCoordinate = new List<double>
                    {
                        c.X,
                        c.Y
                    };

                secondList.Add(oneCoordinate);
            }

            coordinates.Add(secondList);

            return coordinates;
        }
    }
}
