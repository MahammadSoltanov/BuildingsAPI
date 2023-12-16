using BuildingsAPI.Models;
using NetTopologySuite.Features;
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
                    coordinates = GeoJsonConverter.GetPolygonCoordinates(bina.Hendese)
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

        public static string ToGeoJson(this IEnumerable<Poi> pois)
        {
            var features = pois.Select(poi => new {
                type = "Feature",
                geometry = new
                {
                    type = poi.WkbGeometry.GeometryType,
                    coordinates = poi.WkbGeometry.Coordinate
                },
                //Not all properties are mapped
                properties = new
                {
                    addr_city = poi.AddrCity,                    
                    addr_housenumber = poi.AddrHousenumber,
                    addr_postcode = poi.AddrPostcode,
                    addr_street = poi.AddrStreet,                                        
                    name = poi.Name,
                    phone = poi.Phone,
                    website = poi.Website,
                    opening_hours = poi.OpeningHours,                    
                    index = poi.Index,
                }
            });


            var featureCollection = new
            {
                type = "FeatureCollection",
                features
            };

            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            return JsonConvert.SerializeObject(featureCollection, settings);                        
        }

        public static string ToGeoJson(this IEnumerable<Bina> binas)
        {
            var features = binas.Select(bina => new
            {
                type = "Feature",
                geometry = new
                {
                    type = bina.Hendese.GeometryType,
                    coordinates = GeoJsonConverter.GetPolygonCoordinates(bina.Hendese)
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

            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            return JsonConvert.SerializeObject(featureCollection, settings);            
        }


        private static List<List<List<double>>> GetPolygonCoordinates(Geometry geometry)
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
