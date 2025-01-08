using System;
using Xunit;

using ColorTools.Colors;
using ColorTools.Services;

namespace ColorTools.Tests.Services;

public class ConvertTests {
    [Fact]
    public void WhiteRgbToHsv() {
        Rgb white = new Rgb() {R = 255, G = 255, B = 255};
        Hsv hsv = Converter.ConvertToHsv(white);

        Assert.Equal(0.0, hsv.Saturation);
        Assert.Equal(1.0, hsv.Value);
    }

    [Fact]
    public void BlackRgbToHsv() {
        Rgb black = new Rgb() {R = 0, G = 0, B = 0};
        Hsv hsv = Converter.ConvertToHsv(black);

        Assert.Equal(0.0, hsv.Saturation);
        Assert.Equal(0.0, hsv.Value);
    }

    [Fact]
    public void RedRgbToHsv() {
        Rgb red = new Rgb() {R = 255, G = 0, B = 0};
        Hsv hsv = Converter.ConvertToHsv(red);

        Assert.Equal(0, Math.Round(hsv.Hue), 2);
        Assert.Equal(1.0, hsv.Saturation);
        Assert.Equal(1.0, hsv.Value);
    }

    [Fact]
    public void GreenRgbToHsv() {
        Rgb green = new Rgb() {R = 0, G = 255, B = 0};
        Hsv hsv = Converter.ConvertToHsv(green);

        Assert.Equal(120, Math.Round(hsv.Hue), 2);
        Assert.Equal(1.0, hsv.Saturation);
        Assert.Equal(1.0, hsv.Value);
    }

    [Fact]
    public void BlueRgbToHsv() {
        Rgb blue = new Rgb() {R = 0, G = 0, B = 255};
        Hsv hsv = Converter.ConvertToHsv(blue);

        Assert.Equal(240, Math.Round(hsv.Hue), 2);
        Assert.Equal(1.0, hsv.Saturation);
        Assert.Equal(1.0, hsv.Value);
    }

    [Fact]
    public void PurpleRgbToHsv() {
        Rgb purple = new Rgb() {R = 132, G = 52, B = 163};
        Hsv hsv = Converter.ConvertToHsv(purple);

        Assert.Equal(283, Math.Round(hsv.Hue), 2);
        Assert.Equal(0.68, Math.Round(hsv.Saturation, 2), 2);
        Assert.Equal(0.64, Math.Round(hsv.Value, 2), 2);
    }

    [Fact]
    public void TealRgbToHsv() {
        Rgb teal = new Rgb() {R = 159, G = 227, B = 203};
        Hsv hsv = Converter.ConvertToHsv(teal);

        Assert.Equal(159, Math.Round(hsv.Hue), 2);
        Assert.Equal(0.30, Math.Round(hsv.Saturation, 2), 2);
        Assert.Equal(0.89, Math.Round(hsv.Value, 2), 2);
    }

    [Fact]
    public void OrangeRgbToHsv() {
        Rgb orange = new Rgb() {R = 125, G = 64, B = 10};
        Hsv hsv = Converter.ConvertToHsv(orange);

        Assert.Equal(28, Math.Round(hsv.Hue), 2);
        Assert.Equal(0.92, Math.Round(hsv.Saturation, 2), 2);
        Assert.Equal(0.49, Math.Round(hsv.Value, 2), 2);
    }
}
