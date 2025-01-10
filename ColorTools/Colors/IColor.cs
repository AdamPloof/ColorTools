using System;

namespace ColorTools.Colors;

public interface IColor {
    /// <summary>
    /// Return the string representation of the color
    /// </summary>
    /// <returns>The color in the format appropriate for the color type</returns>
    public string ToString();

    /// <summary>
    /// Convert the color to a hexidecimal string
    /// </summary>
    /// <returns>A hex string of the color</returns>
    public string ToHex();
}
