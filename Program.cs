using System;
using System.Xml;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using HillEditor.Models;

namespace HillEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Hill hill = new Hill();
            hill.location = new Hill.Location();
            hill.weather = new Hill.Weather();
            hill.inrun = new Hill.Inrun();
            hill.inrun.profile = new Hill.Inrun.InrunProfile();
            hill.inrun.track = new Hill.Inrun.Track();
            hill.inrun.guardrail = new Hill.Inrun.Guardrail();
            hill.inrun.startgate = new Hill.Inrun.Startgate();
            hill.inrun.startbanner = new Hill.Inrun.Startbanner();
            hill.inrun.frame = new Hill.Inrun.Frame();
            hill.inrun.flag = new Hill.Inrun.Flag();
            hill.inrun.twigs = new Hill.Inrun.Twigs();
            hill.dhill = new Hill.Dhill();
            hill.dhill.profile = new Hill.Dhill.DhillProfile();
            hill.dhill.fence = new Hill.Dhill.Fence();
            hill.dhill.judgetower = new Hill.Dhill.Judgetower();
            hill.dhill.windflags = new Hill.Dhill.Windflags();
            hill.dhill.measurers = new Hill.Dhill.Measurers();
            hill.dhill.label = new Hill.Dhill.Label();
            hill.dhill.plastic = new Hill.Dhill.Plastic();
            hill.dhill.lines = new Hill.Dhill.Lines();
            hill.dhill.numbers = new Hill.Dhill.Numbers();
            hill.profile = new Hill.RightProfile();
            hill.profile.start = new Hill.RightProfile.Start();
            hill.profile.line = new Hill.RightProfile.Line();
            hill.terrain = new Hill.Terrain();
            hill.terrain.profile = new Hill.Terrain.TerrainProfile();
            hill.terrain.trees = new Hill.Terrain.Trees();
            hill.terrain.blocks = new Hill.Terrain.Blocks();
            hill.terrain.houses = new Hill.Terrain.Houses();
            hill.terrain.audience = new Hill.Terrain.Audience();
            
            
            hill.version = "DSJ4-1.8.0";
            hill.location.latitude = "49.1976";
            hill.location.longitude = "49.1976";
            hill.location.orientation = "245";
            hill.location.timezone = "2";
            hill.location.altitude = "1300";
            hill.weather.firstsnow = "300";
            hill.weather.lastsnow = "90";
            hill.weather.maxsnow = "1.5";
            hill.weather.precipitationprobability = "0.1";
            hill.weather.fogprobability = "0.1";
            hill.weather.pollution = "0.0";
            hill.Save("createdhill.xml");

        }

    }
}
