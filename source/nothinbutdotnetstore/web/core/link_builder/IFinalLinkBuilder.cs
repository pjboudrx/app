﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace nothinbutdotnetstore.web.core.link_builder
{
    public interface IFinalLinkBuilder
    {
        IDictionary<string, string> tokens { get; set; }
        IFinalLinkBuilder include<T>(T type, Expression<Func<T, object>> property);
    }
}