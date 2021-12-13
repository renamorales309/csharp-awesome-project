// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// ExternalMetricStatus indicates the current value of a global metric not
        /// associated with any Kubernetes object.
    /// </summary>
    public partial class V2beta2ExternalMetricStatus
    {
        /// <summary>
        /// Initializes a new instance of the V2beta2ExternalMetricStatus class.
        /// </summary>
        public V2beta2ExternalMetricStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V2beta2ExternalMetricStatus class.
        /// </summary>
        /// <param name="current">
        /// current contains the current value for the given metric
        /// </param>
        /// <param name="metric">
        /// metric identifies the target metric by name and selector
        /// </param>
        public V2beta2ExternalMetricStatus(V2beta2MetricValueStatus current, V2beta2MetricIdentifier metric)
        {
            Current = current;
            Metric = metric;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// current contains the current value for the given metric
        /// </summary>
        [JsonPropertyName("current")]
        public V2beta2MetricValueStatus Current { get; set; }

        /// <summary>
        /// metric identifies the target metric by name and selector
        /// </summary>
        [JsonPropertyName("metric")]
        public V2beta2MetricIdentifier Metric { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Current == null)
            {
                throw new ArgumentNullException("Current");    
            }
            if (Metric == null)
            {
                throw new ArgumentNullException("Metric");    
            }
            Current?.Validate();
            Metric?.Validate();
        }
    }
}
