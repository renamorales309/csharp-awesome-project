// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// NonResourcePolicyRule is a predicate that matches non-resource requests
        /// according to their verb and the target non-resource URL. A NonResourcePolicyRule
        /// matches a request if and only if both (a) at least one member of verbs matches
        /// the request and (b) at least one member of nonResourceURLs matches the request.
    /// </summary>
    public partial class V1beta2NonResourcePolicyRule
    {
        /// <summary>
        /// Initializes a new instance of the V1beta2NonResourcePolicyRule class.
        /// </summary>
        public V1beta2NonResourcePolicyRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta2NonResourcePolicyRule class.
        /// </summary>
        /// <param name="nonResourceURLs">
        /// `nonResourceURLs` is a set of url prefixes that a user should have access to and
        /// may not be empty. For example:
        /// - &quot;/healthz&quot; is legal
        /// - &quot;/hea*&quot; is illegal
        /// - &quot;/hea&quot; is legal but matches nothing
        /// - &quot;/hea/*&quot; also matches nothing
        /// - &quot;/healthz/*&quot; matches all per-component health checks.
        /// &quot;*&quot; matches all non-resource urls. if it is present, it must be the only entry.
        /// Required.
        /// </param>
        /// <param name="verbs">
        /// `verbs` is a list of matching verbs and may not be empty. &quot;*&quot; matches all verbs.
        /// If it is present, it must be the only entry. Required.
        /// </param>
        public V1beta2NonResourcePolicyRule(IList<string> nonResourceURLs, IList<string> verbs)
        {
            NonResourceURLs = nonResourceURLs;
            Verbs = verbs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// `nonResourceURLs` is a set of url prefixes that a user should have access to and
        /// may not be empty. For example:
        /// - &quot;/healthz&quot; is legal
        /// - &quot;/hea*&quot; is illegal
        /// - &quot;/hea&quot; is legal but matches nothing
        /// - &quot;/hea/*&quot; also matches nothing
        /// - &quot;/healthz/*&quot; matches all per-component health checks.
        /// &quot;*&quot; matches all non-resource urls. if it is present, it must be the only entry.
        /// Required.
        /// </summary>
        [JsonPropertyName("nonResourceURLs")]
        public IList<string> NonResourceURLs { get; set; }

        /// <summary>
        /// `verbs` is a list of matching verbs and may not be empty. &quot;*&quot; matches all verbs.
        /// If it is present, it must be the only entry. Required.
        /// </summary>
        [JsonPropertyName("verbs")]
        public IList<string> Verbs { get; set; }

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
