﻿// <copyright file="IMetricsResponseWriter.cs" company="Allan Hardy">
// Copyright (c) Allan Hardy. All rights reserved.
// </copyright>

using System.Threading;
using System.Threading.Tasks;
using App.Metrics.Core;
using Microsoft.AspNetCore.Http;

namespace App.Metrics.Extensions.Middleware.Abstractions
{
    public interface IMetricsResponseWriter
    {
        string ContentType { get; }

        Task WriteAsync(HttpContext context, MetricsDataValueSource metricsData, CancellationToken token = default(CancellationToken));
    }
}