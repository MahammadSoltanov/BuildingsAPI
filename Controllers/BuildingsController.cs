using BuildingsAPI.Helpers;
using BuildingsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using NetTopologySuite.IO.Converters;
using NetTopologySuite.IO;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using BuildingsAPI.CustomModels;
using NetTopologySuite.Geometries;

namespace BuildingsAPI.Controllers
{
    [Route("api/v1/buildings")]
    [ApiController]
    public class BuildingsController : Controller
    {

        private readonly MinaContext _context;

        public BuildingsController(MinaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBuildings()
        {
            var buildings = await _context.Binas.ToListAsync();

            return Ok(buildings.ToGeoJson());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBuildingById(int id)
        {
            var building = await _context.Binas.FindAsync(new object[] { id });

            if(building == null)
            {
                return NotFound();
            }

            return Ok(building.ToGeoJson());
        }

        [HttpGet("getPoi/{id}")]
        public async Task<IActionResult> GetPointsWithinBuildingById(int id)
        {
            var building = await _context.Binas.FindAsync(new object[] { id });

            var geometry = building.Hendese;

            var pointsWithinBuilding = await _context.Pois.Where(p => p.WkbGeometry.Within(geometry)).ToListAsync();

            return Ok(pointsWithinBuilding.ToGeoJson());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ChangeBuildingById(int id, [FromBody] GeoJsonFeature geoJsonFeature)
        {
            var buildingToChange = await _context.Binas.FindAsync(new object[] { id });
            UpdateBina(buildingToChange, geoJsonFeature);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBuilding([FromBody] GeoJsonFeature geoJsonFeature)
        {
            var building = new Bina()
            {
                Hendese = GetPolygonFromGeoJson(geoJsonFeature),
                Geotype = geoJsonFeature.Properties.Geotype,
                Index = geoJsonFeature.Properties.Index
            };


            _context.Binas.Add(building);
            await _context.SaveChangesAsync();            

            return CreatedAtAction(nameof(GetBuildingById), new { id = building.Id }, building.ToGeoJson());
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBuildingById(int id)
        {
            var buildingToDelete = _context.Binas.Find(new object[] { id });

            _context.Binas.Remove(buildingToDelete);

            _context.SaveChanges();

            return NoContent();
        }

        private Polygon GetPolygonFromGeoJson(GeoJsonFeature geoJsonFeature)
        {
            var innerList = geoJsonFeature.Geometry.Coordinates[0].ToList();
            var coordinates = innerList.Select(points => new Coordinate(points[0], points[1])).ToArray();
            var linearRing = new LinearRing(coordinates);
            var polygon = new Polygon(linearRing);

            return polygon;
        }

        private void UpdateBina(Bina buildingToChange, GeoJsonFeature geoJsonFeature) 
        {
            var newProperties = geoJsonFeature.Properties;

            buildingToChange.Hendese = GetPolygonFromGeoJson(geoJsonFeature);
            buildingToChange.AddrCity = newProperties.AddrCity;
            buildingToChange.Name = newProperties.Name;
            buildingToChange.AddrCountry = newProperties.AddrCountry;
            buildingToChange.AddrCity = newProperties.AddrCity;
            buildingToChange.AddrHousenumber = newProperties.AddrHousenumber;
            buildingToChange.AddrPostcode = newProperties.AddrPostcode;
            buildingToChange.AddrStreet = newProperties.AddrStreet;
            buildingToChange.NameAz = newProperties.NameAz;
            buildingToChange.NameRu = newProperties.NameRu;
            buildingToChange.NameEn = newProperties.NameEn;
            buildingToChange.Building = newProperties.Building;
            buildingToChange.BuildingLevels = newProperties.BuildingLevels;
            buildingToChange.Index = newProperties.Index;
        }
    }
}
