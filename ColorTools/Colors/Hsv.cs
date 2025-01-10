using System;

namespace ColorTools.Colors;

public class Hsv : IColor {
    private double _hue;
    private double _saturation;
    private double _value;

    public Hsv() {}

    public Hsv(Rgb rgb) {
        double r = rgb.Red / 255.0;
        double g = rgb.Green / 255.0;
        double b = rgb.Blue / 255.0;
        List<double> components = new List<double>() {r, g, b};
        double max = components.Max();
        double min = components.Min();
        double delta = max - min;

        if (max == 0) {
            // Normalize to "true" black for consistency
            // the is because max color channel of 0 translates to
            // a value of 0, which is black
            Hue = 0;
            Saturation = 0;
            Value = 0;

            return;
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

        Hue = h;
        Saturation = s;
        Value = v;
    }

    public double Hue {
        get => _hue;
        set {
            if (value > 360 || value < 0) {
                throw new ArgumentException($"Hue must be between 0 and 360 got: {value}");
            }
        
            _hue = value;
        }
    }

    public double Saturation {
        get => _saturation;
        set {
            if (value > 1 || value < 0) {
                throw new ArgumentException($"Saturation must be between 0 and 1 got: {value}");
            }
        
            _saturation = value;
        }
    }

    public double Value {
        get => _value;
        set {
            if (value > 1 || value < 0) {
                throw new ArgumentException($"Value must be between 0 and 1 got: {value}");
            }
        
            _value = value;
        }
    }

    public override string ToString() {
        return $"({_hue}, {_saturation}, {_value})";
    }

    public string ToHex() {
        Rgb rgb = new Rgb(this);
        return rgb.ToHex();
    }
}
