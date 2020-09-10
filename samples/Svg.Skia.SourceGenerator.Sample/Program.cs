﻿using System;
using System.Diagnostics;
using System.IO;
using SkiaSharp;
using Svg;
using Svg.Skia;

namespace Svg.Skia.SourceGenerator.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Generated class {typeof(Svg___AJ_Digital_Camera)} from Svg file.");
            Console.WriteLine($"Generated class {typeof(Svg___tiger)} from Svg file.");
            Console.WriteLine($"Generated class {typeof(Svg_e_ellipse_001)} from Svg file.");
            Console.WriteLine($"Generated class {typeof(Svg_e_rect_001)} from Svg file.");
            Console.WriteLine($"Generated class {typeof(Svg_pservers_pattern_01_b)} from Svg file.");

            var sw = new Stopwatch();

            sw.Start();
            using var cameraStream = File.OpenWrite("__AJ_Digital_Camera.png");
            Svg___AJ_Digital_Camera.Picture.ToImage(cameraStream, SKColors.Transparent, SKEncodedImageFormat.Png, 100, 1, 1, SKImageInfo.PlatformColorType, SKAlphaType.Unpremul);
            sw.Stop();
            Console.WriteLine($"Created __AJ_Digital_Camera.png in {sw.Elapsed.TotalMilliseconds}ms");

            sw.Reset();
            sw.Start();
            using var tigerStream = File.OpenWrite("__tiger.png");
            Svg___tiger.Picture.ToImage(tigerStream, SKColors.Transparent, SKEncodedImageFormat.Png, 100, 1, 1, SKImageInfo.PlatformColorType, SKAlphaType.Unpremul);
            sw.Stop();
            Console.WriteLine($"Created __tiger.png in {sw.Elapsed.TotalMilliseconds}ms");

            sw.Reset();
            sw.Start();
            using var ellipseStream = File.OpenWrite("e-ellipse-001.png");
            Svg_e_ellipse_001.Picture.ToImage(ellipseStream, SKColors.Transparent, SKEncodedImageFormat.Png, 100, 1, 1, SKImageInfo.PlatformColorType, SKAlphaType.Unpremul);
            sw.Stop();
            Console.WriteLine($"Created e-ellipse-001.png in {sw.Elapsed.TotalMilliseconds}ms");

            sw.Reset();
            sw.Start();
            using var rectStream = File.OpenWrite("e-rect-001.png");
            Svg_e_rect_001.Picture.ToImage(rectStream, SKColors.Transparent, SKEncodedImageFormat.Png, 100, 1, 1, SKImageInfo.PlatformColorType, SKAlphaType.Unpremul);
            sw.Stop();
            Console.WriteLine($"Created e-rect-001.png in {sw.Elapsed.TotalMilliseconds}ms");

            sw.Reset();
            sw.Start();
            using var patternStream = File.OpenWrite("pservers-pattern-01-b.png");
            Svg_pservers_pattern_01_b.Picture.ToImage(patternStream, SKColors.Transparent, SKEncodedImageFormat.Png, 100, 1, 1, SKImageInfo.PlatformColorType, SKAlphaType.Unpremul);
            sw.Stop();
            Console.WriteLine($"Created pservers-pattern-01-b.png in {sw.Elapsed.TotalMilliseconds}ms");
        }
    }
}
