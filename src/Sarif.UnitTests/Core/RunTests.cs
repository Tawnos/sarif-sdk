﻿// Copyright (c) Microsoft.  All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Xunit;
using Newtonsoft.Json;
using FluentAssertions;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.Sarif
{
    public class RunTests
    {
        [Fact]
        public void Run_ColumnKindSerializesProperly()
        {
            // In our Windows-specific SDK, if no one has explicitly set ColumnKind, we
            // will set it to the windows-specific value of Utf16CodeUnits. Otherwise,
            // the SARIF file will pick up the ColumnKind default value of 
            // UnicodeCodePoints, which is not appropriate for Windows frameworks.
            RoundTripColumnKind(persistedValue: ColumnKind.None, expectedRoundTrippedValue: ColumnKind.Utf16CodeUnits);

            // When explicitly set, we should always preserve that setting
            RoundTripColumnKind(persistedValue: ColumnKind.Utf16CodeUnits, expectedRoundTrippedValue: ColumnKind.Utf16CodeUnits);
            RoundTripColumnKind(persistedValue: ColumnKind.UnicodeCodePoints, expectedRoundTrippedValue: ColumnKind.UnicodeCodePoints);
        }

        private void RoundTripColumnKind(ColumnKind persistedValue, ColumnKind expectedRoundTrippedValue)
        {
            var sarifLog = new SarifLog
            {
                Runs = new[]
                {
                    new Run
                    {
                        Tool = new Tool { Driver = new ToolComponent { Name = "Test tool"} },
                        ColumnKind = persistedValue
                    }
                }
            };

            string json = JsonConvert.SerializeObject(sarifLog);

            sarifLog = JsonConvert.DeserializeObject<SarifLog>(json);
            sarifLog.Runs[0].ColumnKind.Should().Be(expectedRoundTrippedValue);
        }

        private const string s_UriBaseId = "$$SomeUriBaseId$$";
        private readonly Uri s_Uri = new Uri("relativeUri/toSomeFile.txt", UriKind.Relative);

        [Fact]
        public void Run_RetrievesExistingFileDataObject()
        {
            Run run = BuildDefaultRunObject();

            ArtifactLocation fileLocation = BuildDefaultFileLocation();
            fileLocation.Index.Should().Be(-1);

            // Retrieve existing file location. Our input file location should have its
            // fileIndex property set as well.
            RetrieveFileIndexAndValidate(run, fileLocation, expectedFileIndex: 1);

            // Repeat look-up with bad file index value. This should succeed and reset
            // the fileIndex to the appropriate value.
            fileLocation = BuildDefaultFileLocation();
            fileLocation.Index = Int32.MaxValue;
            RetrieveFileIndexAndValidate(run, fileLocation, expectedFileIndex: 1);

            // Now set a unique property bag on the file location. The property bag
            // should not interfere with retrieving the file data object. The property bag should
            // not be modified as a result of retrieving the file data index.
            fileLocation = BuildDefaultFileLocation();
            fileLocation.Index = Int32.MaxValue;
            RetrieveFileIndexAndValidate(run, fileLocation, expectedFileIndex: 1);
        }

        private void RetrieveFileIndexAndValidate(Run run, ArtifactLocation fileLocation, int expectedFileIndex)
        {
            int fileIndex = run.GetFileIndex(fileLocation, addToFilesTableIfNotPresent: false);
            fileLocation.Index.Should().Be(fileIndex);
            fileIndex.Should().Be(expectedFileIndex);
        }

        private ArtifactLocation BuildDefaultFileLocation()
        {
            return new ArtifactLocation { Uri = s_Uri, UriBaseId = s_UriBaseId};
        }

        private Run BuildDefaultRunObject()
        {
            var run = new Run()
            {
                Artifacts = new[]
                {
                    new Artifact
                    {
                        // This unused fileLocation exists simply to move testing
                        // to the second array element. Tests that depend on a fileIndex
                        // of '0' are suspect because 0 is a value that might be set as
                        // a default in some code paths, due to a bug
                        Location = new ArtifactLocation{ Uri = new Uri("unused", UriKind.RelativeOrAbsolute)}
                    },
                    new Artifact
                    {
                        Location = BuildDefaultFileLocation(),
                        Properties = new Dictionary<string, SerializedPropertyInfo>
                        {
                            [Guid.NewGuid().ToString()] = null
                        }
                    }
                }
            };
            run.Artifacts[0].Location.Index = 0;

            return run;
        }
    }
}
