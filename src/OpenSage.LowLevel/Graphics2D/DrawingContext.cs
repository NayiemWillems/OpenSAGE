﻿using System.Numerics;
using OpenSage.LowLevel.Graphics3D;

namespace OpenSage.LowLevel.Graphics2D
{
    public sealed partial class DrawingContext : DisposableBase
    {
        public DrawingContext(GraphicsDevice2D graphicsDevice, Texture targetTexture)
        {
            PlatformConstruct(graphicsDevice, targetTexture);
        }

        public void Begin()
        {
            PlatformBegin();
        }

        public void Clear(in ColorRgbaF color)
        {
            PlatformClear(color);
        }

        public void DrawImage(Texture image, in RawRectangleF sourceRect, in RawRectangleF destinationRect, bool interpolate)
        {
            PlatformDrawImage(image, sourceRect, destinationRect, interpolate);
        }

        public void DrawText(string text, TextFormat textFormat, in ColorRgbaF color, in RawRectangleF rect)
        {
            PlatformDrawText(text, textFormat, color, rect);
        }

        public void DrawRectangle(in RawRectangleF rect, in ColorRgbaF strokeColor, float strokeWidth)
        {
            PlatformDrawRectangle(rect, strokeColor, strokeWidth);
        }

        public void DrawLine(in RawLineF line, in ColorRgbaF strokeColor)
        {
            PlatformDrawLine(line, strokeColor);
        }

        public void FillTriangle(in RawTriangleF triangle, in ColorRgbaF fillColor)
        {
            PlatformFillTriangle(triangle, fillColor);
        }

        public void FillTriangle(in RawTriangleF triangle, Texture texture, in ColorRgbaF tintColor, in Matrix3x2 brushTransform)
        {
            PlatformFillTriangle(triangle, texture, tintColor, brushTransform);
        }

        public void FillRectangle(in RawRectangleF rect, in ColorRgbaF fillColor)
        {
            PlatformFillRectangle(rect, fillColor);
        }

        public void Transform(in Matrix3x2 transform)
        {
            PlatformTransform(transform);
        }

        public void End()
        {
            PlatformEnd();
        }
    }
}
