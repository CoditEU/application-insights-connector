﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace TomKerkhove.Connectors.ApplicationInsights.Contracts.v1
{
    /// <summary>
    /// Metadata about a trace to be made
    /// </summary>
    [DataContract]
    public class TraceMetadata
    {
        /// <summary>
        ///     Message to trace
        /// </summary>
        [Required]
        [DataMember]
        public string Message { get; set; }

        /// <summary>
        ///     Context about a specific trace (Optional)
        /// </summary>
        [DataMember]
        public Dictionary<string, string> CustomProperties { get; set; }
    }
}