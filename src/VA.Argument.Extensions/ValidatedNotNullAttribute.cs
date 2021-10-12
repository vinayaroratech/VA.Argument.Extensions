// <copyright file="ValidatedNotNullAttribute.cs" company="VinayArora">
// Copyright (c) VinayArora. All rights reserved.
// </copyright>

using System;

namespace VA.Argument.Extensions
{
    /// <summary>
    /// This empty attribute is used to remove compiler warning for reference type paramter.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    internal sealed class ValidatedNotNullAttribute : Attribute
    {
    }
}
