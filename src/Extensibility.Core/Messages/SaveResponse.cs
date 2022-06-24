// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Extensibility.Core.Data;

namespace Extensibility.Core.Messages
{
    public class SaveResponse
    {
        public ExtensibleResourceBody? Body { get; set; }

        public ExtensibilityErrorContainer? Error { get; set; }
    }
}
