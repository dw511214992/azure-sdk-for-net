// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class Repository : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("url");
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (Optional.IsDefined(Branch))
            {
                writer.WritePropertyName("branch");
                writer.WriteStringValue(Branch);
            }
            if (Optional.IsDefined(DisplayUri))
            {
                writer.WritePropertyName("displayUrl");
                writer.WriteStringValue(DisplayUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DeploymentLogsUri))
            {
                writer.WritePropertyName("deploymentLogsUrl");
                writer.WriteStringValue(DeploymentLogsUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(PathMapping))
            {
                writer.WritePropertyName("pathMapping");
                writer.WriteStartArray();
                foreach (var item in PathMapping)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static Repository DeserializeRepository(JsonElement element)
        {
            Optional<Uri> url = default;
            Optional<string> branch = default;
            Optional<Uri> displayUrl = default;
            Optional<Uri> deploymentLogsUrl = default;
            Optional<IList<ContentPathMap>> pathMapping = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        url = null;
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("branch"))
                {
                    branch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        displayUrl = null;
                        continue;
                    }
                    displayUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deploymentLogsUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deploymentLogsUrl = null;
                        continue;
                    }
                    deploymentLogsUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("pathMapping"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ContentPathMap> array = new List<ContentPathMap>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContentPathMap.DeserializeContentPathMap(item));
                    }
                    pathMapping = array;
                    continue;
                }
            }
            return new Repository(url.Value, branch.Value, displayUrl.Value, deploymentLogsUrl.Value, Optional.ToList(pathMapping));
        }
    }
}
