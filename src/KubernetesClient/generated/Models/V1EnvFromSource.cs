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
    /// EnvFromSource represents the source of a set of ConfigMaps
    /// </summary>
    public partial class V1EnvFromSource
    {
        /// <summary>
        /// Initializes a new instance of the V1EnvFromSource class.
        /// </summary>
        public V1EnvFromSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1EnvFromSource class.
        /// </summary>
        /// <param name="configMapRef">
        /// The ConfigMap to select from
        /// </param>
        /// <param name="prefix">
        /// An optional identifier to prepend to each key in the ConfigMap. Must be a
        /// C_IDENTIFIER.
        /// </param>
        /// <param name="secretRef">
        /// The Secret to select from
        /// </param>
        public V1EnvFromSource(V1ConfigMapEnvSource configMapRef = null, string prefix = null, V1SecretEnvSource secretRef = null)
        {
            ConfigMapRef = configMapRef;
            Prefix = prefix;
            SecretRef = secretRef;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// The ConfigMap to select from
        /// </summary>
        [JsonProperty(PropertyName = "configMapRef")]
        public V1ConfigMapEnvSource ConfigMapRef { get; set; }

        /// <summary>
        /// An optional identifier to prepend to each key in the ConfigMap. Must be a
        /// C_IDENTIFIER.
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// The Secret to select from
        /// </summary>
        [JsonProperty(PropertyName = "secretRef")]
        public V1SecretEnvSource SecretRef { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            ConfigMapRef?.Validate();
            SecretRef?.Validate();
        }
    }
}
