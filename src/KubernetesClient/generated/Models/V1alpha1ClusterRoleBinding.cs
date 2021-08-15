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
    /// ClusterRoleBinding references a ClusterRole, but not contain it.  It can
        /// reference a ClusterRole in the global namespace, and adds who information via
        /// Subject. Deprecated in v1.17 in favor of rbac.authorization.k8s.io/v1
        /// ClusterRoleBinding, and will no longer be served in v1.22.
    /// </summary>
    public partial class V1alpha1ClusterRoleBinding
    {
        /// <summary>
        /// Initializes a new instance of the V1alpha1ClusterRoleBinding class.
        /// </summary>
        public V1alpha1ClusterRoleBinding()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1alpha1ClusterRoleBinding class.
        /// </summary>
        /// <param name="roleRef">
        /// RoleRef can only reference a ClusterRole in the global namespace. If the RoleRef
        /// cannot be resolved, the Authorizer must return an error.
        /// </param>
        /// <param name="apiVersion">
        /// APIVersion defines the versioned schema of this representation of an object.
        /// Servers should convert recognized schemas to the latest internal value, and may
        /// reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </param>
        /// <param name="kind">
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </param>
        /// <param name="metadata">
        /// Standard object&apos;s metadata.
        /// </param>
        /// <param name="subjects">
        /// Subjects holds references to the objects the role applies to.
        /// </param>
        public V1alpha1ClusterRoleBinding(V1alpha1RoleRef roleRef, string apiVersion = null, string kind = null, V1ObjectMeta metadata = null, IList<V1alpha1Subject> subjects = null)
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            RoleRef = roleRef;
            Subjects = subjects;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object.
        /// Servers should convert recognized schemas to the latest internal value, and may
        /// reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Standard object&apos;s metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// RoleRef can only reference a ClusterRole in the global namespace. If the RoleRef
        /// cannot be resolved, the Authorizer must return an error.
        /// </summary>
        [JsonProperty(PropertyName = "roleRef")]
        public V1alpha1RoleRef RoleRef { get; set; }

        /// <summary>
        /// Subjects holds references to the objects the role applies to.
        /// </summary>
        [JsonProperty(PropertyName = "subjects")]
        public IList<V1alpha1Subject> Subjects { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RoleRef == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RoleRef");    
            }
            Metadata?.Validate();
            RoleRef?.Validate();
            foreach(var obj in Subjects)
            {
                obj.Validate();
            }
        }
    }
}
