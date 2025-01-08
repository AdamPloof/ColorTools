using System;

namespace ColorTools.Colors;

public class Hsv : IColor {
    private double _hue;
    private double _saturation;
    private double _value;

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

    public string toString() {
        return $"({_hue}, {_saturation}, {_value})";
    }
}
