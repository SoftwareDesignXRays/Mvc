﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Mvc.Internal
{
    public struct FilterCursorItem<TFilter, TFilterAsync>
    {
        public FilterCursorItem(int index, TFilter filter, TFilterAsync filterAsync)
        {
            Index = index;
            Filter = filter;
            FilterAsync = filterAsync;
        }

        public int Index { get; }

        public TFilter Filter { get; }

        public TFilterAsync FilterAsync { get; }
    }
}
