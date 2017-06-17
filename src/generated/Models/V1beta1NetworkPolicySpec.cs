// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class V1beta1NetworkPolicySpec
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1NetworkPolicySpec class.
        /// </summary>
        public V1beta1NetworkPolicySpec()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1NetworkPolicySpec class.
        /// </summary>
        /// <param name="podSelector">Selects the pods to which this
        /// NetworkPolicy object applies.  The array of ingress rules is
        /// applied to any pods selected by this field. Multiple network
        /// policies can select the same set of pods.  In this case, the
        /// ingress rules for each are combined additively. This field is NOT
        /// optional and follows standard label selector semantics. An empty
        /// podSelector matches all pods in this namespace.</param>
        /// <param name="ingress">List of ingress rules to be applied to the
        /// selected pods. Traffic is allowed to a pod if
        /// namespace.networkPolicy.ingress.isolation is undefined and cluster
        /// policy allows it, OR if the traffic source is the pod's local node,
        /// OR if the traffic matches at least one ingress rule across all of
        /// the NetworkPolicy objects whose podSelector matches the pod. If
        /// this field is empty then this NetworkPolicy does not affect ingress
        /// isolation. If this field is present and contains at least one rule,
        /// this policy allows any traffic which matches at least one of the
        /// ingress rules in this list.</param>
        public V1beta1NetworkPolicySpec(V1LabelSelector podSelector, IList<V1beta1NetworkPolicyIngressRule> ingress = default(IList<V1beta1NetworkPolicyIngressRule>))
        {
            Ingress = ingress;
            PodSelector = podSelector;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of ingress rules to be applied to the selected
        /// pods. Traffic is allowed to a pod if
        /// namespace.networkPolicy.ingress.isolation is undefined and cluster
        /// policy allows it, OR if the traffic source is the pod's local node,
        /// OR if the traffic matches at least one ingress rule across all of
        /// the NetworkPolicy objects whose podSelector matches the pod. If
        /// this field is empty then this NetworkPolicy does not affect ingress
        /// isolation. If this field is present and contains at least one rule,
        /// this policy allows any traffic which matches at least one of the
        /// ingress rules in this list.
        /// </summary>
        [JsonProperty(PropertyName = "ingress")]
        public IList<V1beta1NetworkPolicyIngressRule> Ingress { get; set; }

        /// <summary>
        /// Gets or sets selects the pods to which this NetworkPolicy object
        /// applies.  The array of ingress rules is applied to any pods
        /// selected by this field. Multiple network policies can select the
        /// same set of pods.  In this case, the ingress rules for each are
        /// combined additively. This field is NOT optional and follows
        /// standard label selector semantics. An empty podSelector matches all
        /// pods in this namespace.
        /// </summary>
        [JsonProperty(PropertyName = "podSelector")]
        public V1LabelSelector PodSelector { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PodSelector == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PodSelector");
            }
        }
    }
}
