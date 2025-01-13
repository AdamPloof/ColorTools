using System;
using Xunit;

using ColorTools.Colors;

namespace ColorTools.Tests.Services;

public class HsvTests {
    [Fact]
    public void InvalidHueThrows() {
        Assert.Throws<ArgumentException>(() => new Hsv() {Hue= 361, Saturation = 0.5, Value = 0.4});
    }

    [Fact]
    public void InvalidSaturationThrows() {
        Assert.Throws<ArgumentException>(() => new Hsv() {Hue= 241, Saturation = 1.5, Value = 0.4});
    }

    [Fact]
    public void InvalidValueThrows() {
        Assert.Throws<ArgumentException>(() => new Hsv() {Hue= 240, Saturation = 0.5, Value = 4.4});
    }

    [Fact]
    public void WhiteRgbToHsv() {
        Rgb white = new Rgb() {Red = 255, Green = 255, Blue = 255};
        Hsv hsv = new Hsv(white);

        Assert.Equal(0.0, hsv.Saturation);
        Assert.Equal(1.0, hsv.Value);
    }

    [Fact]
    public void BlackRgbToHsv() {
        Rgb black = new Rgb() {Red = 0, Green = 0, Blue = 0};
        Hsv hsv = new Hsv(black);

        Assert.Equal(0.0, hsv.Saturation);
        Assert.Equal(0.0, hsv.Value);
    }

    [Fact]
    public void RedRgbToHsv() {
        Rgb red = new Rgb() {Red = 255, Green = 0, Blue = 0};
        Hsv hsv = new Hsv(red);

        Assert.Equal(0, Math.Round(hsv.Hue), 2);
        Assert.Equal(1.0, hsv.Saturation);
        Assert.Equal(1.0, hsv.Value);
    }

    [Fact]
    public void GreenRgbToHsv() {
        Rgb green = new Rgb() {Red = 0, Green = 255, Blue = 0};
        Hsv hsv = new Hsv(green);

        Assert.Equal(120, Math.Round(hsv.Hue), 2);
        Assert.Equal(1.0, hsv.Saturation);
        Assert.Equal(1.0, hsv.Value);
    }

    [Fact]
    public void BlueRgbToHsv() {
        Rgb blue = new Rgb() {Red = 0, Green = 0, Blue = 255};
        Hsv hsv = new Hsv(blue);

        Assert.Equal(240, Math.Round(hsv.Hue), 2);
        Assert.Equal(1.0, hsv.Saturation);
        Assert.Equal(1.0, hsv.Value);
    }

    [Fact]
    public void PurpleRgbToHsv() {
        Rgb purple = new Rgb() {Red = 132, Green = 52, Blue = 163};
        Hsv hsv = new Hsv(purple);

        Assert.Equal(283, Math.Round(hsv.Hue), 2);
        Assert.Equal(0.68, Math.Round(hsv.Saturation, 2), 2);
        Assert.Equal(0.64, Math.Round(hsv.Value, 2), 2);
    }

    [Fact]
    public void TealRgbToHsv() {
        Rgb teal = new Rgb() {Red = 159, Green = 227, Blue = 203};
        Hsv hsv = new Hsv(teal);

        Assert.Equal(159, Math.Round(hsv.Hue), 2);
        Assert.Equal(0.30, Math.Round(hsv.Saturation, 2), 2);
        Assert.Equal(0.89, Math.Round(hsv.Value, 2), 2);
    }

    [Fact]
    public void OrangeRgbToHsv() {
        Rgb orange = new Rgb() {Red = 125, Green = 64, Blue = 10};
        Hsv hsv = new Hsv(orange);

        Assert.Equal(28, Math.Round(hsv.Hue), 2);
        Assert.Equal(0.92, Math.Round(hsv.Saturation, 2), 2);
        Assert.Equal(0.49, Math.Round(hsv.Value, 2), 2);
    }
}
