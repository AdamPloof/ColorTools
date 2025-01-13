using System;
using Xunit;

using ColorTools.Colors;
using ColorTools.Services;

namespace ColorTools.Tests.Services;

public class ShaderTests {
    [Fact]
    public void WhiteDoesNotGetLighter() {
        Hsv white = new Hsv() {Hue = 0, Saturation = 0, Value = 1.0};
        Hsv brighter = Shader.Shade(white, 0.5);
        Assert.Equal(white.Hue, brighter.Hue);
        Assert.Equal(white.Saturation, brighter.Saturation);
        Assert.Equal(white.Value, brighter.Value);
    }

    [Fact]
    public void BlackDoesNotGetDarker() {
        Hsv black = new Hsv() {Hue = 0, Saturation = 0.0, Value = 0.0};
        Hsv brighter = Shader.Shade(black, -0.5);
        Assert.Equal(black.Hue, brighter.Hue);
        Assert.Equal(black.Saturation, brighter.Saturation);
        Assert.Equal(black.Value, brighter.Value);
    }

    [Fact]
    public void ColorIsLighter() {
        Hsv original = new Hsv() {Hue = 218, Saturation = 0.65, Value = 0.64};
        Hsv lighter = Shader.Shade(original, 0.2);

        Assert.True(original.Hue == lighter.Hue);
        Assert.True(original.Saturation > lighter.Saturation);
        Assert.True(original.Value < lighter.Value);
    }

    [Fact]
    public void ColorIsMuchLighter() {
        Hsv original = new Hsv() {Hue = 218, Saturation = 0.65, Value = 0.64};
        Hsv lighter = Shader.Shade(original, 0.2);
        Hsv muchLighter = Shader.Shade(lighter, 0.2);

        Assert.True(lighter.Hue == muchLighter.Hue);
        Assert.True(lighter.Saturation > muchLighter.Saturation);
        Assert.True(lighter.Value < muchLighter.Value);
    }

    [Fact]
    public void ColorIsWhite() {
        Hsv original = new Hsv() {Hue = 218, Saturation = 0.65, Value = 0.64};
        Hsv white = Shader.Shade(original, 1.0);

        Assert.Equal(0, white.Hue);
        Assert.Equal(0.0, white.Saturation);
        Assert.Equal(1.0, white.Value);
    }

    [Fact]
    public void ColorIsDarker() {
        Hsv original = new Hsv() {Hue = 218, Saturation = 0.65, Value = 0.64};
        Hsv darker = Shader.Shade(original, -0.2);

        Assert.True(original.Hue == darker.Hue);
        Assert.True(original.Saturation < darker.Saturation);
        Assert.True(original.Value > darker.Value);
    }

    [Fact]
    public void ColorIsMuchDarker() {
        Hsv original = new Hsv() {Hue = 218, Saturation = 0.65, Value = 0.64};
        Hsv darker = Shader.Shade(original, -0.2);
        Hsv muchDarker = Shader.Shade(darker, -0.2);

        Assert.True(darker.Hue == muchDarker.Hue);
        Assert.True(darker.Saturation < muchDarker.Saturation);
        Assert.True(darker.Value > muchDarker.Value);
    }

    [Fact]
    public void ColorIsBlack() {
        Hsv original = new Hsv() {Hue = 218, Saturation = 0.65, Value = 0.64};
        Hsv black = Shader.Shade(original, -1.0);

        Assert.Equal(0, black.Hue);
        Assert.Equal(0.0, black.Saturation);
        Assert.Equal(0.0, black.Value);        
    }
}
