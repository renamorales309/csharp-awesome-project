// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// ResourceQuotaStatus defines the enforced hard limits and observed use.
    /// </summary>
    public partial class V1ResourceQuotaStatus
    {
        /// <summary>
        /// Initializes a new instance of the V1ResourceQuotaStatus class.
        /// </summary>
        public V1ResourceQuotaStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ResourceQuotaStatus class.
        /// </summary>
        /// <param name="hard">
        /// Hard is the set of enforced hard limits for each named resource. More info:
        /// https://kubernetes.io/docs/concepts/policy/resource-quotas/
        /// </param>
        /// <param name="used">
        /// Used is the current observed total usage of the resource in the namespace.
        /// </param>
        public V1ResourceQuotaStatus(IDictionary<string, ResourceQuantity> hard = null, IDictionary<string, ResourceQuantity> used = null)
        {
            Hard = hard;
            Used = used;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Hard is the set of enforced hard limits for each named resource. More info:
        /// https://kubernetes.io/docs/concepts/policy/resource-quotas/
        /// </summary>
        [JsonPropertyName("hard")]
        public IDictionary<string, ResourceQuantity> Hard { get; set; }

        /// <summary>
        /// Used is the current observed total usage of the resource in the namespace.
        /// </summary>
        [JsonPropertyName("used")]
        public IDictionary<string, ResourceQuantity> Used { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
