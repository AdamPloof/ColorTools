using System;

namespace ColorTools.Colors;

public class Rgb : IColor {
    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }

    public string toString() {
        return $"({R}, {G}, {B})";
    }

    public string toHex() {
        string xR = R.ToString("X2");
        string xG = G.ToString("X2");
        string xB = B.ToString("X2");

        return $"#{xR}{xG}{xB}";
    }
}
