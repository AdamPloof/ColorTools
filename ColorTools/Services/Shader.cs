using System;

using ColorTools.Colors;

namespace ColorTools.Services;

/// <summary>
/// Shade provides utilities for adjusting the shade of a color.
/// </summary>
public static class Shader {
    /// <summary>
    /// Lighten or darken an HSV color by an amount t
    /// </summary>
    /// <remarks>
    /// Reduces the saturation linearly and increase the brightness logarithmically.
    /// </remarks>
    /// <param name="hsv">The color</param>
    /// <param name="t">The amount to lighten or darken by, must be between -1 and 1</param>
    /// <param name="rate">
    /// The rate that higher values for t should be lighter and negative values for t
    /// should be darker.
    /// </param>
    /// <returns></returns>
    public static Hsv Shade(Hsv hsv, double t, double rate = 2.0) {
        if (t < -1 || t > 1) {
            throw new ArgumentException("Adjustment factore 't' must be between -1 and 1");
        }

        double hue = hsv.Hue;
        double saturation = hsv.Saturation * (1 - t);
        double value = hsv.Value + (1 - hsv.Value) * Math.Log(1 + t * (rate - 1), rate);
        saturation = Math.Clamp(saturation, 0, 1);
        value = Math.Clamp(value, 0, 1);

        return new Hsv() {Hue = hue, Saturation = saturation, Value = value};
    }

    /// <summary>
    /// Lighten or darken an HSV color by an amount t
    /// </summary>
    /// <remarks>
    /// Reduces the saturation linearly and increase the brightness logarithmically.
    /// </remarks>
    /// <param name="rgb">The color</param>
    /// <param name="t">The amount to lighten or darken by, must be between -1 and 1</param>
    /// <param name="rate">
    /// The rate that higher values for t should be lighter and negative values for t
    /// should be darker.
    /// </param>
    /// <returns></returns>
    public static Rgb Shade(Rgb rgb, double t, double rate = 2.0) {
        Hsv hsv = new Hsv(rgb);
        return new Rgb(Shader.Shade(hsv, t, rate));
    }
}
