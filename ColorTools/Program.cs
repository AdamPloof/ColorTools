using System.IO;

using ColorTools.Colors;
using ColorTools.Services;

Rgb black = new Rgb() {Red = 0, Green = 0, Blue = 0};
Hsv hsv = new Hsv(black);
Console.WriteLine($"Black HSV: {hsv}");
