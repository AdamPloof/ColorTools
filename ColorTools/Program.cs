using System.IO;

using ColorTools.Colors;
using ColorTools.Services;

Rgb black = new Rgb() {R = 0, G = 0, B = 0};
Hsv hsv = Converter.ConvertToHsv(black);
Console.WriteLine($"Black HSV: {hsv.toString()}");
