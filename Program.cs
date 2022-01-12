using System;
using System.Xml;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using HillEditor.Models;
using static HillEditor.Models.Hill;
using System.Globalization;

namespace HillEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Hill hill = new Hill();
            hill.location = new Location();
            hill.weather = new Weather();
            hill.inrun = new Inrun();
            hill.inrun.profile = new Inrun.InrunProfile();
            hill.inrun.track = new Inrun.Track();
            hill.inrun.guardrail = new Inrun.Guardrail();
            hill.inrun.startgate = new Inrun.Startgate();
            hill.inrun.startbanner = new Inrun.Startbanner();
            hill.inrun.frame = new Inrun.Frame();
            hill.inrun.flag = new Inrun.Flag();
            hill.inrun.twigs = new Inrun.Twigs();
            hill.dhill = new Dhill();
            hill.dhill.profile = new Dhill.DhillProfile();
            hill.dhill.fence = new Dhill.Fence();
            hill.dhill.judgetower = new Dhill.Judgetower();
            hill.dhill.windflags = new Dhill.Windflags();
            hill.dhill.measurers = new Dhill.Measurers();
            hill.dhill.label = new Dhill.Label();
            hill.dhill.plastic = new Dhill.Plastic();
            hill.dhill.lines = new Dhill.Lines();
            hill.dhill.numbers = new Dhill.Numbers();
            hill.dhill.lights = new Dhill.Lights();
            hill.terrain = new Terrain();
            hill.terrain.profile = new Terrain.TerrainProfile();
            hill.terrain.trees = new Terrain.Trees();
            hill.terrain.blocks = new Terrain.Blocks();
            hill.terrain.houses = new Terrain.Houses();
            hill.terrain.audience = new Terrain.Audience();

            
            
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
                h = "0.4",
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
                h = "0.4",
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
                                 
            hill.pillar = new Pillar();

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
            hill.profile.ElementAt(1);

            var userhs = Console.ReadLine();
            var scale = hill.ScaleCounter(userhs, hill.dhill.profile.hs);
            Console.WriteLine(scale);
            Console.WriteLine(hill.inrun.profile.e);

            hill.BasicEditor(hill, scale, Convert.ToDouble(userhs));

            hill.Save("createdhill.xml");

        }

    }
}
