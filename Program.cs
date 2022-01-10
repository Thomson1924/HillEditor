using System;
using System.Xml;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using HillEditor.Models;
using static HillEditor.Models.Hill;

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
            //hill.rightprofile = new Hill.RightProfile();
            //hill.rightprofile.start = new Hill.RightProfile.StartRight();
            //hill.rightprofile.line = new Hill.RightProfile.LineRight();

            hill.terrain = new Hill.Terrain();
            hill.terrain.profile = new Hill.Terrain.TerrainProfile();
            hill.terrain.trees = new Hill.Terrain.Trees();
            hill.terrain.blocks = new Hill.Terrain.Blocks();
            hill.terrain.houses = new Hill.Terrain.Houses();
            hill.terrain.audience = new Hill.Terrain.Audience();
            //hill.railingInrun = new Hill.RailingInrun();
            //hill.leftStairs = new Hill.LeftStairs();
            //hill.rightStairs = new Hill.RightStairs();
            //hill.railingLeft = new Hill.RailingLeft();
            //hill.railingRight = new Hill.RailingRight();
            
            
            hill.railings = new List<Railing>();
            hill.railings.Add(new Railing{
                t = @"Textures\railing-glass.png",
                y="-2.1",
                c= "0xf2e5c7",
                m = @"Materials\material1.xml",
                h = "2.0",
                refx1 = "inrun",
                refx2 = "dhill",
                w = "4.0"
            });
            hill.railings.Add(new Railing
            {
                refx1 = "inrun",
                refx2 = "dhill",
                type = "glass",
                h = "1",
                w = "0.1",
                z1 = "2",
                z2 = "2",
                t = @"Textures\railing-glass.png",
                m = @"Materials\window.xml",
                c = "0xffffffff", 
                t3 = @"Textures\railing-glass-cut.png",
                m3 = @"Materials\window.xml",
                c3 = "0xffffffff",
                t6 = @"Textures\railing-glass-cut.png",
                m6 = @"Materials\window.xml",
                c6 = "0xffffffff"
            });
            hill.railings.Add(new Railing
            {
                refx1 = "inrun",
                refx2 = "dhill",
                guard = "false",
                type = "glass",
                h = "1",
                w = "0.1",
                z1 = "-2",
                z2 = "-2",
                t = @"Textures\railing-glass.png",
                m = @"Materials\window.xml",
                c = "0xffffffff",
                t3 = @"Textures\railing-glass-cut.png",
                m3 = @"Materials\window.xml",
                c3 = "0xffffffff",
                t6 = @"Textures\railing-glass-cut.png",
                m6 = @"Materials\window.xml",
                c6 = "0xffffffff"
            });

            hill.stairs = new List<Stairs>();
            hill.stairs.Add(new Stairs { });
            hill.stairs.Add(new Stairs
            {
                lz="-1",
                rz="-2",
            });
                                 
            hill.pillar = new Hill.Pillar();

            hill.profile = new List<Profile>();
            hill.profile.Add(new Profile 
            { 
                start = new Profile.Start(), 
                line = new Profile.Line(),
            });
            hill.profile.Add(new Profile
            {
                id = "inrun-left",
                start = new Profile.Start { y = "1.0" },
                line = new Profile.Line { y = "1.0" }

            });
            //hill.profile.ElementAt(1)
            //hill.version = "DSJ4-1.8.0";
            //hill.location.latitude = "49.1976";
            //hill.location.longitude = "49.1976";
            //hill.location.orientation = "245";
            //hill.location.timezone = "2";
            //hill.location.altitude = "1300";
            //hill.weather.firstsnow = "300";
            //hill.weather.lastsnow = "90";
            //hill.weather.maxsnow = "1.5";
            //hill.weather.precipitationprobability = "0.1";
            //hill.weather.fogprobability = "0.1";
            //hill.weather.pollution = "0.0";
            hill.Save("createdhill.xml");

        }

    }
}
