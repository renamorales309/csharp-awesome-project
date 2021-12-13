// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// TypedLocalObjectReference contains enough information to let you locate the
        /// typed referenced object inside the same namespace.
    /// </summary>
    public partial class V1TypedLocalObjectReference
    {
        /// <summary>
        /// Initializes a new instance of the V1TypedLocalObjectReference class.
        /// </summary>
        public V1TypedLocalObjectReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1TypedLocalObjectReference class.
        /// </summary>
        /// <param name="kind">
        /// Kind is the type of resource being referenced
        /// </param>
        /// <param name="name">
        /// Name is the name of resource being referenced
        /// </param>
        /// <param name="apiGroup">
        /// APIGroup is the group for the resource being referenced. If APIGroup is not
        /// specified, the specified Kind must be in the core API group. For any other
        /// third-party types, APIGroup is required.
        /// </param>
        public V1TypedLocalObjectReference(string kind, string name, string apiGroup = null)
        {
            ApiGroup = apiGroup;
            Kind = kind;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// APIGroup is the group for the resource being referenced. If APIGroup is not
        /// specified, the specified Kind must be in the core API group. For any other
        /// third-party types, APIGroup is required.
        /// </summary>
        [JsonPropertyName("apiGroup")]
        public string ApiGroup { get; set; }

        /// <summary>
        /// Kind is the type of resource being referenced
        /// </summary>
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Name is the name of resource being referenced
        /// </summary>
        [JsonPropertyName("name")]
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
