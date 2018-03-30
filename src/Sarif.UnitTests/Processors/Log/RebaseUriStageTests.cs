﻿// Copyright (c) Microsoft. All rights reserved. Licensed under the MIT        
// license. See LICENSE file in the project root for full license information. 

using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.CodeAnalysis.Sarif.Visitors;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.CodeAnalysis.Sarif.Processors
{
    public class RebaseUriStageTests
    {
        private readonly ITestOutputHelper output;

        public RebaseUriStageTests(ITestOutputHelper outputHelper)
        {
            output = outputHelper;
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        public void RewriteUri_RewritesAllFiles(int fileCount)
        {
            Random random = RandomSarifLogGenerator.GenerateRandomAndLog(this.output);
            List<SarifLog> logs = new List<SarifLog>();
            for (int i = 0; i < fileCount; i++)
            {
                logs.Add(RandomSarifLogGenerator.GenerateSarifLogWithRuns(random, random.Next(10)));
            }

            var RewriteUri = SarifLogProcessorFactory.GetActionStage(SarifLogAction.RebaseUri, new string[] { "SRCROOT", @"C:\src\" });

            IEnumerable<SarifLog> rewrittenLogs = RewriteUri.Act(logs.AsEnumerable());

            rewrittenLogs.Should().HaveCount(logs.Count);

            // We just check that the log rewriter hit each run.  We'll test the RewriteUriVisitor more comprehensively in its own test class.
            foreach (var rewrittenLog in rewrittenLogs)
            {
                if (rewrittenLog.Runs != null)
                {
                    foreach (var run in rewrittenLog.Runs)
                    {
                        run.Properties.Should().ContainKey(RebaseUriVisitor.BaseUriDictionaryName);
                    }
                }
            }
        }
    }
}
