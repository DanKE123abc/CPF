﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace CPF.Razor
{
    /// <summary>
    /// Marker interface to indicate that this element is a container of elements that are not
    /// true children of their parent. For example, a host for elements that go in a modal dialog
    /// are not true children of their parent.
    /// </summary>
#pragma warning disable CA1040 // Avoid empty interfaces
    public interface INonChildContainerElement
#pragma warning restore CA1040 // Avoid empty interfaces
    {
    }
}
