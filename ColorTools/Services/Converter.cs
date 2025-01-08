using System;
using System.Collections.Generic;
using ColorTools.Colors;

namespace ColorTools.Services;

public static class Converter {
    public static Hsv ConvertToHsv(Rgb rgb) {
        double r = rgb.R / 255.0;
        double g = rgb.G / 255.0;
        double b = rgb.B / 255.0;
        List<double> components = new List<double>() {r, g, b};
        double max = components.Max();
        double min = components.Min();
        double delta = max - min;

        if (max == 0) {
            // Normalize to "true" black for consistency
            // the is because max color channel of 0 translates to
            // a value of 0, which is black
            return new Hsv() {Hue = 0, Saturation = 0, Value = 0};
        }

        double h;
        if (delta == 0) {
            h = 0;
        } else if (max == r) {
            h = 60 * (((g - b) / delta) % 6);
        } else if (max == g) {
            h = 60 * (((b - r) / delta) + 2);
        } else {
            h = 60 * (((r - g) / delta) + 4);
        }

        // Ensure hue is positive
        if (h < 0) {
            h += 360;
        }

        double s;
        if (max == 0) {
            s = 0;
        } else {
            s = delta / max;
        }

        double v = max;

        return new Hsv() { Hue = h, Saturation = s, Value = v};
    }

    // public Rgb ConvertToRgb(Hsv hsv) {
        
    // }
}
