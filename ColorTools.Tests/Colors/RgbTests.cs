using System;
using Xunit;

using ColorTools.Colors;

namespace ColorTools.Tests.Colors;

public class RgbTests {
    [Fact]
    public void InvalidChannelThrows() {
        
    }

    [Fact]
    public void ToHexWhiteCorrect() {
        Rgb rgb = new Rgb() {Red = 255, Green = 255, Blue = 255};
        string xWhite = "#FFFFFF";

        Assert.Equal(xWhite, rgb.ToHex());
    }

    [Fact]
    public void ToHexBlackCorrect() {
        Rgb rgb = new Rgb() {Red = 0, Green = 0, Blue = 0};
        string xWhite = "#000000";

        Assert.Equal(xWhite, rgb.ToHex());
    }

    [Fact]
    public void ToHexRedCorrect() {
        Rgb rgb = new Rgb() {Red = 255, Green = 0, Blue = 0};
        string xWhite = "#FF0000";

        Assert.Equal(xWhite, rgb.ToHex());
    }

    [Fact]
    public void ToHexGreenCorrect() {
        Rgb rgb = new Rgb() {Red = 0, Green = 255, Blue = 0};
        string xWhite = "#00FF00";

        Assert.Equal(xWhite, rgb.ToHex());
    }

    [Fact]
    public void ToHexBlueCorrect() {
        Rgb rgb = new Rgb() {Red = 0, Green = 0, Blue = 255};
        string xWhite = "#0000FF";

        Assert.Equal(xWhite, rgb.ToHex());
    }

    [Fact]
    public void ToHexPurpleCorrect() {
        Rgb rgb = new Rgb() {Red = 136, Green = 35, Blue = 176};
        string xWhite = "#8823B0";

        Assert.Equal(xWhite, rgb.ToHex());
    }

    [Fact]
    public void ToHexTealCorrect() {
        Rgb rgb = new Rgb() {Red = 47, Green = 235, Blue = 185};
        string xWhite = "#2FEBB9";

        Assert.Equal(xWhite, rgb.ToHex());
    }

    [Fact]
    public void WhiteHsvToRgbConvertSuccess() {
        Hsv white = new Hsv() {Hue = 0.0, Saturation = 0.0, Value = 1.0};
        Rgb rgb = new Rgb(white);

        Assert.Equal(255, rgb.Red);
        Assert.Equal(255, rgb.Green);
        Assert.Equal(255, rgb.Blue);
    }

    [Fact]
    public void BlackHsvToRgbConvertSuccess() {
        Hsv black = new Hsv() {Hue = 0.0, Saturation = 0.0, Value = 0.0};
        Rgb rgb = new Rgb(black);

        Assert.Equal(0, rgb.Red);
        Assert.Equal(0, rgb.Green);
        Assert.Equal(0, rgb.Blue);
    }

    [Fact]
    public void RedHsvToRgbConvertSuccess() {
        Hsv red = new Hsv() {Hue = 0.0, Saturation = 1.0, Value = 1.0};
        Rgb rgb = new Rgb(red);

        Assert.Equal(255, rgb.Red);
        Assert.Equal(0, rgb.Green);
        Assert.Equal(0, rgb.Blue);
    }

    [Fact]
    public void GreenHsvToRgbConvertSuccess() {
        Hsv green = new Hsv() {Hue = 120.0, Saturation = 1.0, Value = 1.0};
        Rgb rgb = new Rgb(green);

        Assert.Equal(0, rgb.Red);
        Assert.Equal(255, rgb.Green);
        Assert.Equal(0, rgb.Blue);
    }

    [Fact]
    public void BlueHsvToRgbConvertSuccess() {
        Hsv blue = new Hsv() {Hue = 240.0, Saturation = 1.0, Value = 1.0};
        Rgb rgb = new Rgb(blue);

        Assert.Equal(0, rgb.Red);
        Assert.Equal(0, rgb.Green);
        Assert.Equal(255, rgb.Blue);
    }

    [Fact]
    public void OrangeHsvToRgbConvertSuccess() {
        Hsv orange = new Hsv() {Hue = 22.0, Saturation = 0.8, Value = 0.86};
        Rgb rgb = new Rgb(orange);

        // RGB 219, 108, 44    
        Assert.Equal(219, rgb.Red);
        Assert.Equal(108, rgb.Green);
        Assert.Equal(44, rgb.Blue);
    }

    [Fact]
    public void TealHsvToRgbConvertSuccess() {
        Hsv teal = new Hsv() {Hue = 169, Saturation = 0.66, Value = 0.79};
        Rgb rgb = new Rgb(teal);

        // RGB 68, 201, 177
        Assert.Equal(68, rgb.Red);
        Assert.Equal(201, rgb.Green);
        Assert.Equal(177, rgb.Blue);
    }

    [Fact]
    public void PurpleHsvToRgbConvertSuccess() {
        Hsv purple = new Hsv() {Hue = 267.0, Saturation = 0.96, Value = 0.74};
        Rgb rgb = new Rgb(purple);

        // RGB 89, 8, 189
        Assert.Equal(89, rgb.Red);
        Assert.Equal(8, rgb.Green);
        Assert.Equal(189, rgb.Blue);
    }
}
