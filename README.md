# ColorTools
ColorTools is a set of classes and utilities for working with colors in C#. It's a work in progress but currently provides a couple of color types and means for converting between them.

## Colors
The color types provided are

- RGB
- HSV

Each color type has a constructor that takes in an instance of the other color type to make it easy to convert between them.

```C#
Rgb rgbTeal = new Rgb() {Red = 68, Green = 201, Blue = 177};
Hsv hsvTeal = new Hsv(rgbTeal);
```

## Shading
Use the `Shader` static class for lightening/darken a color while maintaining its hue.

```C#
Rgb teal = new Rgb() {Red = 68, Green = 201, Blue = 177};
// Shade the color betwen -1.0 and 1.0
Rgb lighterTeal = Shader.Shade(teal, .25);

// Shade the color betwen -1.0 and 1.0
Rgb darkerTeal = Shader.Shade(teal, .25);
```
