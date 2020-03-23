// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    public partial class KeysResult
    {
        internal static KeysResult DeserializeKeysResult(JsonElement element)
        {
            IReadOnlyDictionary<string, IReadOnlyList<string>> clusters = new Dictionary<string, IReadOnlyList<string>>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusters"))
                {
                    Dictionary<string, IReadOnlyList<string>> dictionary = new Dictionary<string, IReadOnlyList<string>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        List<string> array = new List<string>();
                        foreach (var item in property0.Value.EnumerateArray())
                        {
                            array.Add(item.GetString());
                        }
                        dictionary.Add(property0.Name, array);
                    }
                    clusters = dictionary;
                    continue;
                }
            }
            return new KeysResult(clusters);
        }
    }
}
