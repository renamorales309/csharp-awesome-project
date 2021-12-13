// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// Scheduling specifies the scheduling constraints for nodes supporting a
        /// RuntimeClass.
    /// </summary>
    public partial class V1Scheduling
    {
        /// <summary>
        /// Initializes a new instance of the V1Scheduling class.
        /// </summary>
        public V1Scheduling()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1Scheduling class.
        /// </summary>
        /// <param name="nodeSelector">
        /// nodeSelector lists labels that must be present on nodes that support this
        /// RuntimeClass. Pods using this RuntimeClass can only be scheduled to a node
        /// matched by this selector. The RuntimeClass nodeSelector is merged with a pod&apos;s
        /// existing nodeSelector. Any conflicts will cause the pod to be rejected in
        /// admission.
        /// </param>
        /// <param name="tolerations">
        /// tolerations are appended (excluding duplicates) to pods running with this
        /// RuntimeClass during admission, effectively unioning the set of nodes tolerated
        /// by the pod and the RuntimeClass.
        /// </param>
        public V1Scheduling(IDictionary<string, string> nodeSelector = null, IList<V1Toleration> tolerations = null)
        {
            NodeSelector = nodeSelector;
            Tolerations = tolerations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// nodeSelector lists labels that must be present on nodes that support this
        /// RuntimeClass. Pods using this RuntimeClass can only be scheduled to a node
        /// matched by this selector. The RuntimeClass nodeSelector is merged with a pod&apos;s
        /// existing nodeSelector. Any conflicts will cause the pod to be rejected in
        /// admission.
        /// </summary>
        [JsonPropertyName("nodeSelector")]
        public IDictionary<string, string> NodeSelector { get; set; }

        /// <summary>
        /// tolerations are appended (excluding duplicates) to pods running with this
        /// RuntimeClass during admission, effectively unioning the set of nodes tolerated
        /// by the pod and the RuntimeClass.
        /// </summary>
        [JsonPropertyName("tolerations")]
        public IList<V1Toleration> Tolerations { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Tolerations != null){
                foreach(var obj in Tolerations)
                {
                    obj.Validate();
                }
            }
        }
    }
}
