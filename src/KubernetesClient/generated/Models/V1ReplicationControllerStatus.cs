// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// ReplicationControllerStatus represents the current status of a replication
        /// controller.
    /// </summary>
    public partial class V1ReplicationControllerStatus
    {
        /// <summary>
        /// Initializes a new instance of the V1ReplicationControllerStatus class.
        /// </summary>
        public V1ReplicationControllerStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ReplicationControllerStatus class.
        /// </summary>
        /// <param name="replicas">
        /// Replicas is the most recently oberved number of replicas. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#what-is-a-replicationcontroller
        /// </param>
        /// <param name="availableReplicas">
        /// The number of available replicas (ready for at least minReadySeconds) for this
        /// replication controller.
        /// </param>
        /// <param name="conditions">
        /// Represents the latest available observations of a replication controller&apos;s
        /// current state.
        /// </param>
        /// <param name="fullyLabeledReplicas">
        /// The number of pods that have labels matching the labels of the pod template of
        /// the replication controller.
        /// </param>
        /// <param name="observedGeneration">
        /// ObservedGeneration reflects the generation of the most recently observed
        /// replication controller.
        /// </param>
        /// <param name="readyReplicas">
        /// The number of ready replicas for this replication controller.
        /// </param>
        public V1ReplicationControllerStatus(int replicas, int? availableReplicas = null, IList<V1ReplicationControllerCondition> conditions = null, int? fullyLabeledReplicas = null, long? observedGeneration = null, int? readyReplicas = null)
        {
            AvailableReplicas = availableReplicas;
            Conditions = conditions;
            FullyLabeledReplicas = fullyLabeledReplicas;
            ObservedGeneration = observedGeneration;
            ReadyReplicas = readyReplicas;
            Replicas = replicas;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// The number of available replicas (ready for at least minReadySeconds) for this
        /// replication controller.
        /// </summary>
        [JsonPropertyName("availableReplicas")]
        public int? AvailableReplicas { get; set; }

        /// <summary>
        /// Represents the latest available observations of a replication controller&apos;s
        /// current state.
        /// </summary>
        [JsonPropertyName("conditions")]
        public IList<V1ReplicationControllerCondition> Conditions { get; set; }

        /// <summary>
        /// The number of pods that have labels matching the labels of the pod template of
        /// the replication controller.
        /// </summary>
        [JsonPropertyName("fullyLabeledReplicas")]
        public int? FullyLabeledReplicas { get; set; }

        /// <summary>
        /// ObservedGeneration reflects the generation of the most recently observed
        /// replication controller.
        /// </summary>
        [JsonPropertyName("observedGeneration")]
        public long? ObservedGeneration { get; set; }

        /// <summary>
        /// The number of ready replicas for this replication controller.
        /// </summary>
        [JsonPropertyName("readyReplicas")]
        public int? ReadyReplicas { get; set; }

        /// <summary>
        /// Replicas is the most recently oberved number of replicas. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#what-is-a-replicationcontroller
        /// </summary>
        [JsonPropertyName("replicas")]
        public int Replicas { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Conditions != null){
                foreach(var obj in Conditions)
                {
                    obj.Validate();
                }
            }
        }
    }
}
