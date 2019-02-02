﻿using System;

namespace FloxDc.CacheFlow
{
    /// <summary>
    /// Represents CacheFlow options.
    /// </summary>
    public class FlowOptions
    {
        /// <summary>
        /// The ratio between caching times in a memory and in a distributed cache when DoubleFlow is used.
        /// </summary>
        public double DistributedToMemoryExpirationRatio { get; set; } = 10.0;
        /// <summary>
        /// Cache will be skipped for that time span if any error occurs in the request process.
        /// </summary>
        public TimeSpan SkipRetryInterval { get; set; } = TimeSpan.FromMinutes(1);

        /// <summary>
        /// Enables suppression of throwing exceptions, caused by caching service itself. Default: true.
        /// </summary>
        public bool SuppressCacheExceptions { get; set; } = true;
    }
}
