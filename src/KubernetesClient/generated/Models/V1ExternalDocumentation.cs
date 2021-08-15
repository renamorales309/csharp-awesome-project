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
    /// ExternalDocumentation allows referencing an external resource for extended
        /// documentation.
    /// </summary>
    public partial class V1ExternalDocumentation
    {
        /// <summary>
        /// Initializes a new instance of the V1ExternalDocumentation class.
        /// </summary>
        public V1ExternalDocumentation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ExternalDocumentation class.
        /// </summary>
        /// <param name="description">
        /// 
        /// </param>
        /// <param name="url">
        /// 
        /// </param>
        public V1ExternalDocumentation(string description = null, string url = null)
        {
            Description = description;
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

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
