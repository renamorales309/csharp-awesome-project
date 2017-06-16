// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

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
        /// <param name="hard">Hard is the set of enforced hard limits for each
        /// named resource. More info:
        /// http://releases.k8s.io/HEAD/docs/design/admission_control_resource_quota.md#admissioncontrol-plugin-resourcequota</param>
        /// <param name="used">Used is the current observed total usage of the
        /// resource in the namespace.</param>
        public V1ResourceQuotaStatus(IDictionary<string, string> hard = default(IDictionary<string, string>), IDictionary<string, string> used = default(IDictionary<string, string>))
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
        /// Gets or sets hard is the set of enforced hard limits for each named
        /// resource. More info:
        /// http://releases.k8s.io/HEAD/docs/design/admission_control_resource_quota.md#admissioncontrol-plugin-resourcequota
        /// </summary>
        [JsonProperty(PropertyName = "hard")]
        public IDictionary<string, string> Hard { get; set; }

        /// <summary>
        /// Gets or sets used is the current observed total usage of the
        /// resource in the namespace.
        /// </summary>
        [JsonProperty(PropertyName = "used")]
        public IDictionary<string, string> Used { get; set; }

    }
}
