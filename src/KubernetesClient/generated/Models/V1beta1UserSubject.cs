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
    /// UserSubject holds detailed information for user-kind subject.
    /// </summary>
    public partial class V1beta1UserSubject
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1UserSubject class.
        /// </summary>
        public V1beta1UserSubject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1UserSubject class.
        /// </summary>
        /// <param name="name">
        /// `name` is the username that matches, or &quot;*&quot; to match all usernames. Required.
        /// </param>
        public V1beta1UserSubject(string name)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// `name` is the username that matches, or &quot;*&quot; to match all usernames. Required.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

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
