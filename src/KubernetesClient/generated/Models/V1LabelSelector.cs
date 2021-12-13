// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// A label selector is a label query over a set of resources. The result of
        /// matchLabels and matchExpressions are ANDed. An empty label selector matches all
        /// objects. A null label selector matches no objects.
    /// </summary>
    public partial class V1LabelSelector
    {
        /// <summary>
        /// Initializes a new instance of the V1LabelSelector class.
        /// </summary>
        public V1LabelSelector()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1LabelSelector class.
        /// </summary>
        /// <param name="matchExpressions">
        /// matchExpressions is a list of label selector requirements. The requirements are
        /// ANDed.
        /// </param>
        /// <param name="matchLabels">
        /// matchLabels is a map of {key,value} pairs. A single {key,value} in the
        /// matchLabels map is equivalent to an element of matchExpressions, whose key field
        /// is &quot;key&quot;, the operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The
        /// requirements are ANDed.
        /// </param>
        public V1LabelSelector(IList<V1LabelSelectorRequirement> matchExpressions = null, IDictionary<string, string> matchLabels = null)
        {
            MatchExpressions = matchExpressions;
            MatchLabels = matchLabels;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// matchExpressions is a list of label selector requirements. The requirements are
        /// ANDed.
        /// </summary>
        [JsonPropertyName("matchExpressions")]
        public IList<V1LabelSelectorRequirement> MatchExpressions { get; set; }

        /// <summary>
        /// matchLabels is a map of {key,value} pairs. A single {key,value} in the
        /// matchLabels map is equivalent to an element of matchExpressions, whose key field
        /// is &quot;key&quot;, the operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The
        /// requirements are ANDed.
        /// </summary>
        [JsonPropertyName("matchLabels")]
        public IDictionary<string, string> MatchLabels { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MatchExpressions != null){
                foreach(var obj in MatchExpressions)
                {
                    obj.Validate();
                }
            }
        }
    }
}
