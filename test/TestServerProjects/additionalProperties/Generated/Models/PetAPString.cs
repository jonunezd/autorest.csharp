// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections;
using System.Collections.Generic;

namespace additionalProperties.Models
{
    /// <summary> The PetApString. </summary>
    public partial class PetApString : IDictionary<string, string>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; internal set; }
        private readonly IDictionary<string, string> _additionalProperties = new System.Collections.Generic.Dictionary<string, string>();
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, string>> GetEnumerator() => _additionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => _additionalProperties.GetEnumerator();
        /// <inheritdoc />
        public ICollection<string> Keys => _additionalProperties.Keys;
        /// <inheritdoc />
        public ICollection<string> Values => _additionalProperties.Values;
        /// <inheritdoc />
        public bool TryGetValue(string key, out string value) => _additionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public void Add(string key, string value) => _additionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => _additionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public bool Remove(string key) => _additionalProperties.Remove(key);
        /// <inheritdoc />
        int ICollection<KeyValuePair<string, string>>.Count => _additionalProperties.Count;
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, string>>.IsReadOnly => _additionalProperties.IsReadOnly;
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, string>>.Add(KeyValuePair<string, string> value) => _additionalProperties.Add(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, string>>.Remove(KeyValuePair<string, string> value) => _additionalProperties.Remove(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, string>>.Contains(KeyValuePair<string, string> value) => _additionalProperties.Contains(value);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, string>>.CopyTo(KeyValuePair<string, string>[] destination, int offset) => _additionalProperties.CopyTo(destination, offset);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, string>>.Clear() => _additionalProperties.Clear();
        /// <inheritdoc />
        public string this[string key]
        {
            get => _additionalProperties[key];
            set => _additionalProperties[key] = value;
        }
    }
}
