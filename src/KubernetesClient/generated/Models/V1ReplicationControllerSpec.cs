// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// ReplicationControllerSpec is the specification of a replication controller.
    /// </summary>
    public partial class V1ReplicationControllerSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1ReplicationControllerSpec class.
        /// </summary>
        public V1ReplicationControllerSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ReplicationControllerSpec class.
        /// </summary>
        /// <param name="minReadySeconds">
        /// Minimum number of seconds for which a newly created pod should be ready without
        /// any of its container crashing, for it to be considered available. Defaults to 0
        /// (pod will be considered available as soon as it is ready)
        /// </param>
        /// <param name="replicas">
        /// Replicas is the number of desired replicas. This is a pointer to distinguish
        /// between explicit zero and unspecified. Defaults to 1. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#what-is-a-replicationcontroller
        /// </param>
        /// <param name="selector">
        /// Selector is a label query over pods that should match the Replicas count. If
        /// Selector is empty, it is defaulted to the labels present on the Pod template.
        /// Label keys and values that must match in order to be controlled by this
        /// replication controller, if empty defaulted to labels on Pod template. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
        /// </param>
        /// <param name="template">
        /// Template is the object that describes the pod that will be created if
        /// insufficient replicas are detected. This takes precedence over a TemplateRef.
        /// More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template
        /// </param>
        public V1ReplicationControllerSpec(int? minReadySeconds = null, int? replicas = null, IDictionary<string, string> selector = null, V1PodTemplateSpec template = null)
        {
            MinReadySeconds = minReadySeconds;
            Replicas = replicas;
            Selector = selector;
            Template = template;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Minimum number of seconds for which a newly created pod should be ready without
        /// any of its container crashing, for it to be considered available. Defaults to 0
        /// (pod will be considered available as soon as it is ready)
        /// </summary>
        [JsonPropertyName("minReadySeconds")]
        public int? MinReadySeconds { get; set; }

        /// <summary>
        /// Replicas is the number of desired replicas. This is a pointer to distinguish
        /// between explicit zero and unspecified. Defaults to 1. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#what-is-a-replicationcontroller
        /// </summary>
        [JsonPropertyName("replicas")]
        public int? Replicas { get; set; }

        /// <summary>
        /// Selector is a label query over pods that should match the Replicas count. If
        /// Selector is empty, it is defaulted to the labels present on the Pod template.
        /// Label keys and values that must match in order to be controlled by this
        /// replication controller, if empty defaulted to labels on Pod template. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
        /// </summary>
        [JsonPropertyName("selector")]
        public IDictionary<string, string> Selector { get; set; }

        /// <summary>
        /// Template is the object that describes the pod that will be created if
        /// insufficient replicas are detected. This takes precedence over a TemplateRef.
        /// More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template
        /// </summary>
        [JsonPropertyName("template")]
        public V1PodTemplateSpec Template { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            Template?.Validate();
        }
    }
}
