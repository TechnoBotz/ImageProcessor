﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQuantizer.cs" company="James South">
//   Copyright (c) James South.
//   Licensed under the Apache License, Version 2.0.
// </copyright>
// <summary>
//   Encapsulates methods to calculate the color palette of an image.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ImageProcessor.Imaging.Quantizers
{
    using System.Drawing;

    /// <summary>
    /// Encapsulates methods to calculate the color palette of an image.
    /// </summary>
    public interface IQuantizer
    {
        /// <summary>
        /// Quantize an image and return the resulting output bitmap.
        /// </summary>
        /// <param name="source">
        /// The image to quantize.
        /// </param>
        /// <returns>
        /// A quantized version of the image.
        /// </returns>
        Bitmap Quantize(Image source);
    }
}