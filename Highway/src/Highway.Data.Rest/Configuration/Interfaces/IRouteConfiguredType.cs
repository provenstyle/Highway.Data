﻿using System;
using System.Linq.Expressions;

namespace Highway.Data.Rest.Configuration.Interfaces
{
    public interface IRouteConfiguredType<T>
    {
        IKeyConfiguredType WithKey(string id);
        IKeyConfiguredType WithKey<TK>(Expression<Func<T, TK>> selector);
    }
}