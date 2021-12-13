// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// NonResourceRule holds information that describes a rule for the non-resource
    /// </summary>
    public partial class V1NonResourceRule
    {
        /// <summary>
        /// Initializes a new instance of the V1NonResourceRule class.
        /// </summary>
        public V1NonResourceRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1NonResourceRule class.
        /// </summary>
        /// <param name="verbs">
        /// Verb is a list of kubernetes non-resource API verbs, like: get, post, put,
        /// delete, patch, head, options.  &quot;*&quot; means all.
        /// </param>
        /// <param name="nonResourceURLs">
        /// NonResourceURLs is a set of partial urls that a user should have access to.  *s
        /// are allowed, but only as the full, final step in the path.  &quot;*&quot; means all.
        /// </param>
        public V1NonResourceRule(IList<string> verbs, IList<string> nonResourceURLs = null)
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
        /// NonResourceURLs is a set of partial urls that a user should have access to.  *s
        /// are allowed, but only as the full, final step in the path.  &quot;*&quot; means all.
        /// </summary>
        [JsonPropertyName("nonResourceURLs")]
        public IList<string> NonResourceURLs { get; set; }

        /// <summary>
        /// Verb is a list of kubernetes non-resource API verbs, like: get, post, put,
        /// delete, patch, head, options.  &quot;*&quot; means all.
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
