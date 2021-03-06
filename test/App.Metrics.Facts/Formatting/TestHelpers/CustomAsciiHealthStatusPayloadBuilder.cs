﻿using System.IO;
using App.Metrics.Health;
using App.Metrics.Reporting.Abstractions;

namespace App.Metrics.Facts.Formatting.TestHelpers
{
    public class CustomAsciiHealthStatusPayloadBuilder : IHealthStatusPayloadBuilder<CustomAsciiHealthStatusPayload>
    {
        private CustomAsciiHealthStatusPayload _payload;

        public CustomAsciiHealthStatusPayloadBuilder() { _payload = new CustomAsciiHealthStatusPayload(); }

        public void Clear() { _payload = null; }

        /// <inheritdoc />
        public void Init()
        {
            _payload = new CustomAsciiHealthStatusPayload();
        }

        /// <inheritdoc />
        public void Pack(string name, string message, HealthCheckStatus status)
        {
            _payload.Add(new CustomAsciiHealthCheckResult(name, message, status));
        }

        /// <inheritdoc />
        public CustomAsciiHealthStatusPayload Payload()
        {
            return _payload;
        }

        /// <inheritdoc />
        public string PayloadFormatted()
        {
            var result = new StringWriter();
            _payload.Format(result);
            return result.ToString();
        }
    }
}