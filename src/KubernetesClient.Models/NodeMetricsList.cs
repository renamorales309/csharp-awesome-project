namespace k8s.Models
{
    public class NodeMetricsList : IMetadata<V1ObjectMeta>
    {
        /// <summary>
        /// Defines the versioned schema of this representation of an object.
        /// </summary>
        [JsonPropertyName("apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Defines the REST resource this object represents.
        /// </summary>
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// The kubernetes standard object's metadata.
        /// </summary>
        [JsonPropertyName("metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// The list of node metrics.
        /// </summary>
        [JsonPropertyName("items")]
        public IEnumerable<NodeMetrics> Items { get; set; }
    }
}
