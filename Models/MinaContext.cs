using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BuildingsAPI.Models;

public partial class MinaContext : DbContext
{
    public MinaContext()
    {
    }

    public MinaContext(DbContextOptions<MinaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bina> Binas { get; set; }

    public virtual DbSet<ErrorTable> ErrorTables { get; set; }

    public virtual DbSet<Poi> Pois { get; set; }

    public virtual DbSet<Yollar> Yollars { get; set; }

    public virtual DbSet<Yollartest> Yollartests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("postgis");

        modelBuilder.Entity<Bina>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("bina_pkey");

            entity.ToTable("bina");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddrCity)
                .HasColumnType("character varying")
                .HasColumnName("addr:city");
            entity.Property(e => e.AddrCountry)
                .HasColumnType("character varying")
                .HasColumnName("addr:country");
            entity.Property(e => e.AddrHousenumber)
                .HasColumnType("character varying")
                .HasColumnName("addr:housenumber");
            entity.Property(e => e.AddrPostcode)
                .HasColumnType("character varying")
                .HasColumnName("addr:postcode");
            entity.Property(e => e.AddrStreet)
                .HasColumnType("character varying")
                .HasColumnName("addr:street");
            entity.Property(e => e.Amenity)
                .HasColumnType("character varying")
                .HasColumnName("amenity");
            entity.Property(e => e.BathOpenAir)
                .HasColumnType("character varying")
                .HasColumnName("bath:open_air");
            entity.Property(e => e.BathSandBath)
                .HasColumnType("character varying")
                .HasColumnName("bath:sand_bath");
            entity.Property(e => e.Brand)
                .HasColumnType("character varying")
                .HasColumnName("brand");
            entity.Property(e => e.Building)
                .HasColumnType("character varying")
                .HasColumnName("building");
            entity.Property(e => e.BuildingLevels)
                .HasColumnType("character varying")
                .HasColumnName("building:levels");
            entity.Property(e => e.Charge)
                .HasColumnType("character varying")
                .HasColumnName("charge");
            entity.Property(e => e.Country)
                .HasColumnType("character varying")
                .HasColumnName("country");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.Diplomatic)
                .HasColumnType("character varying")
                .HasColumnName("diplomatic");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Embassy)
                .HasColumnType("character varying")
                .HasColumnName("embassy");
            entity.Property(e => e.Facebook)
                .HasColumnType("character varying")
                .HasColumnName("facebook");
            entity.Property(e => e.Fax)
                .HasColumnType("character varying")
                .HasColumnName("fax");
            entity.Property(e => e.Fee)
                .HasColumnType("character varying")
                .HasColumnName("fee");
            entity.Property(e => e.Geotype)
                .HasColumnType("character varying")
                .HasColumnName("geotype");
            entity.Property(e => e.Government)
                .HasColumnType("character varying")
                .HasColumnName("government");
            entity.Property(e => e.Hendese)
                .HasColumnType("geometry(Geometry,4326)")
                .HasColumnName("hendese");
            entity.Property(e => e.Image)
                .HasColumnType("character varying")
                .HasColumnName("image");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.InternetAccess)
                .HasColumnType("character varying")
                .HasColumnName("internet_access");
            entity.Property(e => e.InternetAccessFee)
                .HasColumnType("character varying")
                .HasColumnName("internet_access:fee");
            entity.Property(e => e.Leisure)
                .HasColumnType("character varying")
                .HasColumnName("leisure");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Name1)
                .HasColumnType("character varying")
                .HasColumnName("name_1");
            entity.Property(e => e.Name2)
                .HasColumnType("character varying")
                .HasColumnName("name_2");
            entity.Property(e => e.NameAr)
                .HasColumnType("character varying")
                .HasColumnName("name:ar");
            entity.Property(e => e.NameAz)
                .HasColumnType("character varying")
                .HasColumnName("name:az");
            entity.Property(e => e.NameEn)
                .HasColumnType("character varying")
                .HasColumnName("name:en");
            entity.Property(e => e.NameFr)
                .HasColumnType("character varying")
                .HasColumnName("name:fr");
            entity.Property(e => e.NameRu)
                .HasColumnType("character varying")
                .HasColumnName("name:ru");
            entity.Property(e => e.Office)
                .HasColumnType("character varying")
                .HasColumnName("office");
            entity.Property(e => e.OpeningHours)
                .HasColumnType("character varying")
                .HasColumnName("opening_hours");
            entity.Property(e => e.OpeningHoursCovid19)
                .HasColumnType("character varying")
                .HasColumnName("opening_hours:covid19");
            entity.Property(e => e.Operator)
                .HasColumnType("character varying")
                .HasColumnName("operator");
            entity.Property(e => e.PaymentCash)
                .HasColumnType("character varying")
                .HasColumnName("payment:cash");
            entity.Property(e => e.PaymentMastercard)
                .HasColumnType("character varying")
                .HasColumnName("payment:mastercard");
            entity.Property(e => e.PaymentVisa)
                .HasColumnType("character varying")
                .HasColumnName("payment:visa");
            entity.Property(e => e.Phone)
                .HasColumnType("character varying")
                .HasColumnName("phone");
            entity.Property(e => e.Phone1)
                .HasColumnType("character varying")
                .HasColumnName("phone_1");
            entity.Property(e => e.Religion)
                .HasColumnType("character varying")
                .HasColumnName("religion");
            entity.Property(e => e.Shop)
                .HasColumnType("character varying")
                .HasColumnName("shop");
            entity.Property(e => e.Source)
                .HasColumnType("character varying")
                .HasColumnName("source");
            entity.Property(e => e.SourceRef)
                .HasColumnType("character varying")
                .HasColumnName("source_ref");
            entity.Property(e => e.Target)
                .HasColumnType("character varying")
                .HasColumnName("target");
            entity.Property(e => e.Tourism)
                .HasColumnType("character varying")
                .HasColumnName("tourism");
            entity.Property(e => e.Website)
                .HasColumnType("character varying")
                .HasColumnName("website");
            entity.Property(e => e.Wikidata)
                .HasColumnType("character varying")
                .HasColumnName("wikidata");
            entity.Property(e => e.Wikipedia)
                .HasColumnType("character varying")
                .HasColumnName("wikipedia");
        });

        modelBuilder.Entity<ErrorTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("error_table_pkey");

            entity.ToTable("error_table");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ErrorMessage).HasColumnName("error_message");
        });

        modelBuilder.Entity<Poi>(entity =>
        {
            entity.HasKey(e => e.OgcFid).HasName("poi_pkey");

            entity.ToTable("poi");

            entity.HasIndex(e => e.WkbGeometry, "poi_wkb_geometry_geom_idx").HasMethod("gist");

            entity.Property(e => e.OgcFid).HasColumnName("ogc_fid");
            entity.Property(e => e.AddrCity)
                .HasColumnType("character varying")
                .HasColumnName("addr:city");
            entity.Property(e => e.AddrHousenumber)
                .HasColumnType("character varying")
                .HasColumnName("addr:housenumber");
            entity.Property(e => e.AddrPostcode)
                .HasColumnType("character varying")
                .HasColumnName("addr:postcode");
            entity.Property(e => e.AddrStreet)
                .HasColumnType("character varying")
                .HasColumnName("addr:street");
            entity.Property(e => e.AltName)
                .HasColumnType("character varying")
                .HasColumnName("alt_name");
            entity.Property(e => e.Amenity)
                .HasColumnType("character varying")
                .HasColumnName("amenity");
            entity.Property(e => e.Atm)
                .HasColumnType("character varying")
                .HasColumnName("atm");
            entity.Property(e => e.Backrest)
                .HasColumnType("character varying")
                .HasColumnName("backrest");
            entity.Property(e => e.Brand)
                .HasColumnType("character varying")
                .HasColumnName("brand");
            entity.Property(e => e.BrandWikidata)
                .HasColumnType("character varying")
                .HasColumnName("brand:wikidata");
            entity.Property(e => e.BrandWikipedia)
                .HasColumnType("character varying")
                .HasColumnName("brand:wikipedia");
            entity.Property(e => e.ContactEmail)
                .HasColumnType("character varying")
                .HasColumnName("contact:email");
            entity.Property(e => e.ContactFacebook)
                .HasColumnType("character varying")
                .HasColumnName("contact:facebook");
            entity.Property(e => e.ContactInstagram)
                .HasColumnType("character varying")
                .HasColumnName("contact:instagram");
            entity.Property(e => e.ContactPhone)
                .HasColumnType("character varying")
                .HasColumnName("contact:phone");
            entity.Property(e => e.ContactWebsite)
                .HasColumnType("character varying")
                .HasColumnName("contact:website");
            entity.Property(e => e.Cuisine)
                .HasColumnType("character varying")
                .HasColumnName("cuisine");
            entity.Property(e => e.Delivery)
                .HasColumnType("character varying")
                .HasColumnName("delivery");
            entity.Property(e => e.DietHalal)
                .HasColumnType("character varying")
                .HasColumnName("diet:halal");
            entity.Property(e => e.DietMeat)
                .HasColumnType("character varying")
                .HasColumnName("diet:meat");
            entity.Property(e => e.DietVegan)
                .HasColumnType("character varying")
                .HasColumnName("diet:vegan");
            entity.Property(e => e.DietVegetarian)
                .HasColumnType("character varying")
                .HasColumnName("diet:vegetarian");
            entity.Property(e => e.DriveThrough)
                .HasColumnType("character varying")
                .HasColumnName("drive_through");
            entity.Property(e => e.Facebook)
                .HasColumnType("character varying")
                .HasColumnName("facebook");
            entity.Property(e => e.Geotype)
                .HasColumnType("character varying")
                .HasColumnName("geotype");
            entity.Property(e => e.Id)
                .HasColumnType("character varying")
                .HasColumnName("id");
            entity.Property(e => e.Image)
                .HasColumnType("character varying")
                .HasColumnName("image");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.InternetAccess)
                .HasColumnType("character varying")
                .HasColumnName("internet_access");
            entity.Property(e => e.InternetAccessFee)
                .HasColumnType("character varying")
                .HasColumnName("internet_access:fee");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.NameAr)
                .HasColumnType("character varying")
                .HasColumnName("name:ar");
            entity.Property(e => e.NameAz)
                .HasColumnType("character varying")
                .HasColumnName("name:az");
            entity.Property(e => e.NameEn)
                .HasColumnType("character varying")
                .HasColumnName("name:en");
            entity.Property(e => e.NameFa)
                .HasColumnType("character varying")
                .HasColumnName("name:fa");
            entity.Property(e => e.NameRu)
                .HasColumnType("character varying")
                .HasColumnName("name:ru");
            entity.Property(e => e.NameTr)
                .HasColumnType("character varying")
                .HasColumnName("name:tr");
            entity.Property(e => e.OfficialName)
                .HasColumnType("character varying")
                .HasColumnName("official_name");
            entity.Property(e => e.OpeningHours)
                .HasColumnType("character varying")
                .HasColumnName("opening_hours");
            entity.Property(e => e.OpeningHoursCovid19)
                .HasColumnType("character varying")
                .HasColumnName("opening_hours:covid19");
            entity.Property(e => e.Operator)
                .HasColumnType("character varying")
                .HasColumnName("operator");
            entity.Property(e => e.OutdoorSeating)
                .HasColumnType("character varying")
                .HasColumnName("outdoor_seating");
            entity.Property(e => e.Phone)
                .HasColumnType("character varying")
                .HasColumnName("phone");
            entity.Property(e => e.RefVatin)
                .HasColumnType("character varying")
                .HasColumnName("ref:vatin");
            entity.Property(e => e.SourceRefUrl)
                .HasColumnType("character varying")
                .HasColumnName("source_ref:url");
            entity.Property(e => e.Takeaway)
                .HasColumnType("character varying")
                .HasColumnName("takeaway");
            entity.Property(e => e.Website)
                .HasColumnType("character varying")
                .HasColumnName("website");
            entity.Property(e => e.Wikidata)
                .HasColumnType("character varying")
                .HasColumnName("wikidata");
            entity.Property(e => e.Wikipedia)
                .HasColumnType("character varying")
                .HasColumnName("wikipedia");
            entity.Property(e => e.WkbGeometry)
                .HasColumnType("geometry(Point,4326)")
                .HasColumnName("wkb_geometry");
        });

        modelBuilder.Entity<Yollar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("yollar");

            entity.Property(e => e.Access)
                .HasColumnType("character varying")
                .HasColumnName("access");
            entity.Property(e => e.AltName)
                .HasColumnType("character varying")
                .HasColumnName("alt_name");
            entity.Property(e => e.Bicycle)
                .HasColumnType("character varying")
                .HasColumnName("bicycle");
            entity.Property(e => e.Bridge)
                .HasColumnType("character varying")
                .HasColumnName("bridge");
            entity.Property(e => e.Covered)
                .HasColumnType("character varying")
                .HasColumnName("covered");
            entity.Property(e => e.Crossing)
                .HasColumnType("character varying")
                .HasColumnName("crossing");
            entity.Property(e => e.Foot)
                .HasColumnType("character varying")
                .HasColumnName("foot");
            entity.Property(e => e.Footway)
                .HasColumnType("character varying")
                .HasColumnName("footway");
            entity.Property(e => e.Geotype)
                .HasColumnType("character varying")
                .HasColumnName("geotype");
            entity.Property(e => e.Highway)
                .HasColumnType("character varying")
                .HasColumnName("highway");
            entity.Property(e => e.Horse)
                .HasColumnType("character varying")
                .HasColumnName("horse");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.IntName)
                .HasColumnType("character varying")
                .HasColumnName("int_name");
            entity.Property(e => e.IntRef)
                .HasColumnType("character varying")
                .HasColumnName("int_ref");
            entity.Property(e => e.Junction)
                .HasColumnType("character varying")
                .HasColumnName("junction");
            entity.Property(e => e.LaneMarkings)
                .HasColumnType("character varying")
                .HasColumnName("lane_markings");
            entity.Property(e => e.Lanes)
                .HasColumnType("character varying")
                .HasColumnName("lanes");
            entity.Property(e => e.Layer)
                .HasColumnType("character varying")
                .HasColumnName("layer");
            entity.Property(e => e.Lit)
                .HasColumnType("character varying")
                .HasColumnName("lit");
            entity.Property(e => e.Maxspeed)
                .HasColumnType("character varying")
                .HasColumnName("maxspeed");
            entity.Property(e => e.Maxwidth)
                .HasColumnType("character varying")
                .HasColumnName("maxwidth");
            entity.Property(e => e.MotorVehicle)
                .HasColumnType("character varying")
                .HasColumnName("motor_vehicle");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.NameAz)
                .HasColumnType("character varying")
                .HasColumnName("name:az");
            entity.Property(e => e.NameAzCyr)
                .HasColumnType("character varying")
                .HasColumnName("name:az_cyr");
            entity.Property(e => e.NameEn)
                .HasColumnType("character varying")
                .HasColumnName("name:en");
            entity.Property(e => e.NameRu)
                .HasColumnType("character varying")
                .HasColumnName("name:ru");
            entity.Property(e => e.OldName)
                .HasColumnType("character varying")
                .HasColumnName("old_name");
            entity.Property(e => e.OldNameRu)
                .HasColumnType("character varying")
                .HasColumnName("old_name:ru");
            entity.Property(e => e.Oneway)
                .HasColumnType("character varying")
                .HasColumnName("oneway");
            entity.Property(e => e.Service)
                .HasColumnType("character varying")
                .HasColumnName("service");
            entity.Property(e => e.SourceGeometry)
                .HasColumnType("character varying")
                .HasColumnName("source:geometry");
            entity.Property(e => e.Surface)
                .HasColumnType("character varying")
                .HasColumnName("surface");
            entity.Property(e => e.Tunnel)
                .HasColumnType("character varying")
                .HasColumnName("tunnel");
            entity.Property(e => e.WkbGeometry)
                .HasColumnType("geometry(LineString,4326)")
                .HasColumnName("wkb_geometry");
        });

        modelBuilder.Entity<Yollartest>(entity =>
        {
            entity.HasKey(e => e.OgcFid).HasName("yollartest_pkey");

            entity.ToTable("yollartest");

            entity.HasIndex(e => e.WkbGeometry, "yollartest_wkb_geometry_geom_idx").HasMethod("gist");

            entity.Property(e => e.OgcFid).HasColumnName("ogc_fid");
            entity.Property(e => e.Access)
                .HasColumnType("character varying")
                .HasColumnName("access");
            entity.Property(e => e.AltName)
                .HasColumnType("character varying")
                .HasColumnName("alt_name");
            entity.Property(e => e.Bicycle)
                .HasColumnType("character varying")
                .HasColumnName("bicycle");
            entity.Property(e => e.Bridge)
                .HasColumnType("character varying")
                .HasColumnName("bridge");
            entity.Property(e => e.Covered)
                .HasColumnType("character varying")
                .HasColumnName("covered");
            entity.Property(e => e.Crossing)
                .HasColumnType("character varying")
                .HasColumnName("crossing");
            entity.Property(e => e.Foot)
                .HasColumnType("character varying")
                .HasColumnName("foot");
            entity.Property(e => e.Footway)
                .HasColumnType("character varying")
                .HasColumnName("footway");
            entity.Property(e => e.Geotype)
                .HasColumnType("character varying")
                .HasColumnName("geotype");
            entity.Property(e => e.Highway)
                .HasColumnType("character varying")
                .HasColumnName("highway");
            entity.Property(e => e.Horse)
                .HasColumnType("character varying")
                .HasColumnName("horse");
            entity.Property(e => e.Id)
                .HasColumnType("character varying")
                .HasColumnName("id");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.IntName)
                .HasColumnType("character varying")
                .HasColumnName("int_name");
            entity.Property(e => e.IntRef)
                .HasColumnType("character varying")
                .HasColumnName("int_ref");
            entity.Property(e => e.Junction)
                .HasColumnType("character varying")
                .HasColumnName("junction");
            entity.Property(e => e.LaneMarkings)
                .HasColumnType("character varying")
                .HasColumnName("lane_markings");
            entity.Property(e => e.Lanes)
                .HasColumnType("character varying")
                .HasColumnName("lanes");
            entity.Property(e => e.Layer)
                .HasColumnType("character varying")
                .HasColumnName("layer");
            entity.Property(e => e.Lit)
                .HasColumnType("character varying")
                .HasColumnName("lit");
            entity.Property(e => e.Maxspeed)
                .HasColumnType("character varying")
                .HasColumnName("maxspeed");
            entity.Property(e => e.Maxwidth)
                .HasColumnType("character varying")
                .HasColumnName("maxwidth");
            entity.Property(e => e.MotorVehicle)
                .HasColumnType("character varying")
                .HasColumnName("motor_vehicle");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.NameAz)
                .HasColumnType("character varying")
                .HasColumnName("name:az");
            entity.Property(e => e.NameAzCyr)
                .HasColumnType("character varying")
                .HasColumnName("name:az_cyr");
            entity.Property(e => e.NameEn)
                .HasColumnType("character varying")
                .HasColumnName("name:en");
            entity.Property(e => e.NameRu)
                .HasColumnType("character varying")
                .HasColumnName("name:ru");
            entity.Property(e => e.OldName)
                .HasColumnType("character varying")
                .HasColumnName("old_name");
            entity.Property(e => e.OldNameRu)
                .HasColumnType("character varying")
                .HasColumnName("old_name:ru");
            entity.Property(e => e.Oneway)
                .HasColumnType("character varying")
                .HasColumnName("oneway");
            entity.Property(e => e.Service)
                .HasColumnType("character varying")
                .HasColumnName("service");
            entity.Property(e => e.SourceGeometry)
                .HasColumnType("character varying")
                .HasColumnName("source:geometry");
            entity.Property(e => e.Surface)
                .HasColumnType("character varying")
                .HasColumnName("surface");
            entity.Property(e => e.Tunnel)
                .HasColumnType("character varying")
                .HasColumnName("tunnel");
            entity.Property(e => e.WkbGeometry)
                .HasColumnType("geometry(LineString,4326)")
                .HasColumnName("wkb_geometry");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
