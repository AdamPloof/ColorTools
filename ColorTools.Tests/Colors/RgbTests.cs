using System;
using Xunit;

using ColorTools.Colors;

namespace ColorTools.Tests.Colors;

public class RgbTests {
    [Fact]
    public void ToHexWhiteCorrect() {
        Rgb rgb = new Rgb() {R = 255, G = 255, B = 255};
        string xWhite = "#FFFFFF";

        Assert.Equal(xWhite, rgb.toHex());
    }

    [Fact]
    public void ToHexBlackCorrect() {
        Rgb rgb = new Rgb() {R = 0, G = 0, B = 0};
        string xWhite = "#000000";

        Assert.Equal(xWhite, rgb.toHex());
    }

    [Fact]
    public void ToHexRedCorrect() {
        Rgb rgb = new Rgb() {R = 255, G = 0, B = 0};
        string xWhite = "#FF0000";

        Assert.Equal(xWhite, rgb.toHex());
    }

    [Fact]
    public void ToHexGreenCorrect() {
        Rgb rgb = new Rgb() {R = 0, G = 255, B = 0};
        string xWhite = "#00FF00";

        Assert.Equal(xWhite, rgb.toHex());
    }

    [Fact]
    public void ToHexBlueCorrect() {
        Rgb rgb = new Rgb() {R = 0, G = 0, B = 255};
        string xWhite = "#0000FF";

        Assert.Equal(xWhite, rgb.toHex());
    }

    [Fact]
    public void ToHexPurpleCorrect() {
        Rgb rgb = new Rgb() {R = 136, G = 35, B = 176};
        string xWhite = "#8823B0";

        Assert.Equal(xWhite, rgb.toHex());
    }

    [Fact]
    public void ToHexTealCorrect() {
        Rgb rgb = new Rgb() {R = 47, G = 235, B = 185};
        string xWhite = "#2FEBB9";

        Assert.Equal(xWhite, rgb.toHex());
    }
}
