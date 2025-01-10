using System;
using Xunit;

using ColorTools.Colors;
using ColorTools.Services;

namespace ColorTools.Tests.Services;

public class ShaderTests {
    [Fact]
    public void WhiteDoesNotGetLighter() {
        Hsv white = new Hsv() {Hue = 0, Saturation = 0, Value = 0};
        Hsv brighter = Shader.Shade(white, 0.5);
        Assert.Equal(white.Hue, brighter.Hue);
        Assert.Equal(white.Saturation, brighter.Saturation);
        Assert.Equal(white.Value, brighter.Value);
    }

    [Fact]
    public void BlackDoesNotGetDarker() {
        Hsv black = new Hsv() {Hue = 0, Saturation = 100, Value = 100};
        Hsv brighter = Shader.Shade(black, 0.5);
        Assert.Equal(black.Hue, brighter.Hue);
        Assert.Equal(black.Saturation, brighter.Saturation);
        Assert.Equal(black.Value, brighter.Value);
    }

    [Fact]
    public void ColorIsLighter() {
        
    }

    [Fact]
    public void ColorIsMuchLighter() {
        
    }

    [Fact]
    public void ColorIsWhite() {
        
    }

    [Fact]
    public void ColorIsDarker() {
        
    }

    [Fact]
    public void ColorIsMuchDarker() {
        
    }

    [Fact]
    public void ColorIsMuchBlack() {
        
    }
}
