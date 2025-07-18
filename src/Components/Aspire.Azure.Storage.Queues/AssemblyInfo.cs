// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using Aspire;
using Aspire.Azure.Storage.Queues;
using Azure.Storage.Queues;

[assembly: ConfigurationSchema("Aspire:Azure:Storage:Queues", typeof(AzureStorageQueuesSettings))]
[assembly: ConfigurationSchema("Aspire:Azure:Storage:Queues:ClientOptions", typeof(QueueClientOptions), exclusionPaths: ["Default"])]

[assembly: LoggingCategories(
    "Azure",
    "Azure.Core",
    "Azure.Identity")]

[assembly: InternalsVisibleTo("Aspire.Azure.Storage.Queues.Tests, PublicKey=00240000048000009400000006020000002400005253413100040000010001004b86c4cb78549b34bab61a3b1800e23bfeb5b3ec390074041536a7e3cbd97f5f04cf0f857155a8928eaa29ebfd11cfbbad3ba70efea7bda3226c6a8d370a4cd303f714486b6ebc225985a638471e6ef571cc92a4613c00b8fa65d61ccee0cbe5f36330c9a01f4183559f1bef24cc2917c6d913e3a541333a1d05d9bed22b38cb")]
