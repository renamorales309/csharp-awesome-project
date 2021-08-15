// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;

    /// <summary>
    /// The pod this Toleration is attached to tolerates any taint that matches the
        /// triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.
    /// </summary>
    public partial class V1Toleration
    {
        /// <summary>
        /// Initializes a new instance of the V1Toleration class.
        /// </summary>
        public V1Toleration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1Toleration class.
        /// </summary>
        /// <param name="effect">
        /// Effect indicates the taint effect to match. Empty means match all taint effects.
        /// When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.
        /// </param>
        /// <param name="key">
        /// Key is the taint key that the toleration applies to. Empty means match all taint
        /// keys. If the key is empty, operator must be Exists; this combination means to
        /// match all values and all keys.
        /// </param>
        /// <param name="operatorProperty">
        /// Operator represents a key&apos;s relationship to the value. Valid operators are
        /// Exists and Equal. Defaults to Equal. Exists is equivalent to wildcard for value,
        /// so that a pod can tolerate all taints of a particular category.
        /// </param>
        /// <param name="tolerationSeconds">
        /// TolerationSeconds represents the period of time the toleration (which must be of
        /// effect NoExecute, otherwise this field is ignored) tolerates the taint. By
        /// default, it is not set, which means tolerate the taint forever (do not evict).
        /// Zero and negative values will be treated as 0 (evict immediately) by the system.
        /// </param>
        /// <param name="value">
        /// Value is the taint value the toleration matches to. If the operator is Exists,
        /// the value should be empty, otherwise just a regular string.
        /// </param>
        public V1Toleration(string effect = null, string key = null, string operatorProperty = null, long? tolerationSeconds = null, string value = null)
        {
            Effect = effect;
            Key = key;
            OperatorProperty = operatorProperty;
            TolerationSeconds = tolerationSeconds;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Effect indicates the taint effect to match. Empty means match all taint effects.
        /// When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.
        /// </summary>
        [JsonProperty(PropertyName = "effect")]
        public string Effect { get; set; }

        /// <summary>
        /// Key is the taint key that the toleration applies to. Empty means match all taint
        /// keys. If the key is empty, operator must be Exists; this combination means to
        /// match all values and all keys.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Operator represents a key&apos;s relationship to the value. Valid operators are
        /// Exists and Equal. Defaults to Equal. Exists is equivalent to wildcard for value,
        /// so that a pod can tolerate all taints of a particular category.
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public string OperatorProperty { get; set; }

        /// <summary>
        /// TolerationSeconds represents the period of time the toleration (which must be of
        /// effect NoExecute, otherwise this field is ignored) tolerates the taint. By
        /// default, it is not set, which means tolerate the taint forever (do not evict).
        /// Zero and negative values will be treated as 0 (evict immediately) by the system.
        /// </summary>
        [JsonProperty(PropertyName = "tolerationSeconds")]
        public long? TolerationSeconds { get; set; }

        /// <summary>
        /// Value is the taint value the toleration matches to. If the operator is Exists,
        /// the value should be empty, otherwise just a regular string.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

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
