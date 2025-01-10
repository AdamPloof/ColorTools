using System;

namespace ColorTools.Colors;

public class Rgb : IColor {
    public byte Red { get; set; }
    public byte Green { get; set; }
    public byte Blue { get; set; }

    public Rgb() {}

    public Rgb(Hsv hsv) {
        double h = hsv.Hue;
        double s = hsv.Saturation;
        double v = hsv.Value;

        if (s == 0) {
            // Grayscale: R = G = B = V * 255
            double gray = Math.Round(v * 255);
            Red = (byte)gray;
            Green = (byte)gray;
            Blue = (byte)gray;

            return;
        }

        double c = v * s;
        double hPrime = h / 60.0;
        double x = c * (1 - Math.Abs(hPrime % 2 - 1));
        double m = v - c;

        double r1, g1, b1;
        if (0 <= hPrime && hPrime < 1) {
            r1 = c; g1 = x; b1 = 0;
        } else if (1 <= hPrime && hPrime < 2) {
            r1 = x; g1 = c; b1 = 0;
        } else if (2 <= hPrime && hPrime < 3) {
            r1 = 0; g1 = c; b1 = x;
        } else if (3 <= hPrime && hPrime < 4) {
            r1 = 0; g1 = x; b1 = c;
        } else if (4 <= hPrime && hPrime < 5) {
            r1 = x; g1 = 0; b1 = c;
        } else if (5 <= hPrime && hPrime < 6) {
            r1 = c; g1 = 0; b1 = x;
        } else {
            // undefined hue
            r1 = 0; g1 = 0; b1 = 0;
        }

        Red = (byte)((r1 + m) * 255);
        Green = (byte)((g1 + m) * 255);
        Blue = (byte)((b1 + m) * 255);
    }

    public override string ToString() {
        return $"({Red}, {Green}, {Blue})";
    }

    public string ToHex() {
        string xR = Red.ToString("X2");
        string xG = Green.ToString("X2");
        string xB = Blue.ToString("X2");

        return $"#{xR}{xG}{xB}";
    }
}
