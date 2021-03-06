﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Azure.Core.Pipeline;
using Azure.Core.Pipeline.Policies;
using Azure.Core.Testing;
using NUnit.Framework;

namespace Azure.Core.Tests
{
    public class TelemetryPolicyTests: PolicyTestBase
    {
        [Test]
        public async Task ComponentNameAndVersionReadFromAssembly()
        {
            var transport = new MockTransport(new MockResponse(200));
            var testOptions = new TestOptions();
            var telemetryPolicy = testOptions.TelemetryPolicy;

            var assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            await SendGetRequest(transport, telemetryPolicy);

            Assert.True(transport.SingleRequest.TryGetHeader("User-Agent", out var userAgent));
            Assert.AreEqual(userAgent, $"azsdk-net-base-test/{assemblyVersion} ({RuntimeInformation.FrameworkDescription}; {RuntimeInformation.OSDescription})");
        }

        [Test]
        public async Task ApplicationIdIsIncluded()
        {
            var transport = new MockTransport(new MockResponse(200));
            var testOptions = new TestOptions();
            var telemetryPolicy = testOptions.TelemetryPolicy;
            telemetryPolicy.ApplicationId = "application-id";

            await SendGetRequest(transport, telemetryPolicy);

            Assert.True(transport.SingleRequest.TryGetHeader("User-Agent", out var userAgent));
            StringAssert.StartsWith("application-id ", userAgent);
        }

        [NonParallelizable]
        [Theory]
        [TestCase("true")]
        [TestCase("TRUE")]
        [TestCase("1")]
        public async Task CanDisableTelemetryWithEnvironmentVariable(string value)
        {
            try
            {
                Environment.SetEnvironmentVariable("AZURE_TELEMETRY_DISABLED", value);

                var transport = new MockTransport(new MockResponse(200));
                var testOptions = new TestOptions();
                var telemetryPolicy = testOptions.TelemetryPolicy;
                await SendGetRequest(transport, telemetryPolicy);

                Assert.False(transport.SingleRequest.TryGetHeader("User-Agent", out var userAgent));
            }
            finally
            {
                Environment.SetEnvironmentVariable("AZURE_TELEMETRY_DISABLED", null);
            }
        }

        [NonParallelizable]
        [Test]
        public async Task UsesDefaultApplicationId()
        {
            try
            {
                TelemetryPolicy.DefaultApplicationId = "Global-application-id";

                var transport = new MockTransport(new MockResponse(200));
                var testOptions = new TestOptions();
                var telemetryPolicy = testOptions.TelemetryPolicy;

                await SendGetRequest(transport, telemetryPolicy);

                Assert.True(transport.SingleRequest.TryGetHeader("User-Agent", out var userAgent));
                StringAssert.StartsWith("Global-application-id ", userAgent);
            }
            finally
            {
                TelemetryPolicy.DefaultApplicationId = null;
            }
        }

        private class TestOptions: ClientOptions
        {

        }
    }
}
