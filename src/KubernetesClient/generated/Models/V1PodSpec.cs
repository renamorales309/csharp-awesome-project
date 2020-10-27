// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// PodSpec is a description of a pod.
    /// </summary>
    public partial class V1PodSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1PodSpec class.
        /// </summary>
        public V1PodSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1PodSpec class.
        /// </summary>
        /// <param name="containers">List of containers belonging to the pod.
        /// Containers cannot currently be added or removed. There must be at
        /// least one container in a Pod. Cannot be updated.</param>
        /// <param name="activeDeadlineSeconds">Optional duration in seconds
        /// the pod may be active on the node relative to StartTime before the
        /// system will actively try to mark it failed and kill associated
        /// containers. Value must be a positive integer.</param>
        /// <param name="affinity">If specified, the pod's scheduling
        /// constraints</param>
        /// <param
        /// name="automountServiceAccountToken">AutomountServiceAccountToken
        /// indicates whether a service account token should be automatically
        /// mounted.</param>
        /// <param name="dnsConfig">Specifies the DNS parameters of a pod.
        /// Parameters specified here will be merged to the generated DNS
        /// configuration based on DNSPolicy.</param>
        /// <param name="dnsPolicy">Set DNS policy for the pod. Defaults to
        /// "ClusterFirst". Valid values are 'ClusterFirstWithHostNet',
        /// 'ClusterFirst', 'Default' or 'None'. DNS parameters given in
        /// DNSConfig will be merged with the policy selected with DNSPolicy.
        /// To have DNS options set along with hostNetwork, you have to specify
        /// DNS policy explicitly to 'ClusterFirstWithHostNet'.</param>
        /// <param name="enableServiceLinks">EnableServiceLinks indicates
        /// whether information about services should be injected into pod's
        /// environment variables, matching the syntax of Docker links.
        /// Optional: Defaults to true.</param>
        /// <param name="ephemeralContainers">List of ephemeral containers run
        /// in this pod. Ephemeral containers may be run in an existing pod to
        /// perform user-initiated actions such as debugging. This list cannot
        /// be specified when creating a pod, and it cannot be modified by
        /// updating the pod spec. In order to add an ephemeral container to an
        /// existing pod, use the pod's ephemeralcontainers subresource. This
        /// field is alpha-level and is only honored by servers that enable the
        /// EphemeralContainers feature.</param>
        /// <param name="hostAliases">HostAliases is an optional list of hosts
        /// and IPs that will be injected into the pod's hosts file if
        /// specified. This is only valid for non-hostNetwork pods.</param>
        /// <param name="hostIPC">Use the host's ipc namespace. Optional:
        /// Default to false.</param>
        /// <param name="hostNetwork">Host networking requested for this pod.
        /// Use the host's network namespace. If this option is set, the ports
        /// that will be used must be specified. Default to false.</param>
        /// <param name="hostPID">Use the host's pid namespace. Optional:
        /// Default to false.</param>
        /// <param name="hostname">Specifies the hostname of the Pod If not
        /// specified, the pod's hostname will be set to a system-defined
        /// value.</param>
        /// <param name="imagePullSecrets">ImagePullSecrets is an optional list
        /// of references to secrets in the same namespace to use for pulling
        /// any of the images used by this PodSpec. If specified, these secrets
        /// will be passed to individual puller implementations for them to
        /// use. For example, in the case of docker, only DockerConfig type
        /// secrets are honored. More info:
        /// https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod</param>
        /// <param name="initContainers">List of initialization containers
        /// belonging to the pod. Init containers are executed in order prior
        /// to containers being started. If any init container fails, the pod
        /// is considered to have failed and is handled according to its
        /// restartPolicy. The name for an init container or normal container
        /// must be unique among all containers. Init containers may not have
        /// Lifecycle actions, Readiness probes, Liveness probes, or Startup
        /// probes. The resourceRequirements of an init container are taken
        /// into account during scheduling by finding the highest request/limit
        /// for each resource type, and then using the max of of that value or
        /// the sum of the normal containers. Limits are applied to init
        /// containers in a similar fashion. Init containers cannot currently
        /// be added or removed. Cannot be updated. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/init-containers/</param>
        /// <param name="nodeName">NodeName is a request to schedule this pod
        /// onto a specific node. If it is non-empty, the scheduler simply
        /// schedules this pod onto that node, assuming that it fits resource
        /// requirements.</param>
        /// <param name="nodeSelector">NodeSelector is a selector which must be
        /// true for the pod to fit on a node. Selector which must match a
        /// node's labels for the pod to be scheduled on that node. More info:
        /// https://kubernetes.io/docs/concepts/configuration/assign-pod-node/</param>
        /// <param name="overhead">Overhead represents the resource overhead
        /// associated with running a pod for a given RuntimeClass. This field
        /// will be autopopulated at admission time by the RuntimeClass
        /// admission controller. If the RuntimeClass admission controller is
        /// enabled, overhead must not be set in Pod create requests. The
        /// RuntimeClass admission controller will reject Pod create requests
        /// which have the overhead already set. If RuntimeClass is configured
        /// and selected in the PodSpec, Overhead will be set to the value
        /// defined in the corresponding RuntimeClass, otherwise it will remain
        /// unset and treated as zero. More info:
        /// https://git.k8s.io/enhancements/keps/sig-node/20190226-pod-overhead.md
        /// This field is alpha-level as of Kubernetes v1.16, and is only
        /// honored by servers that enable the PodOverhead feature.</param>
        /// <param name="preemptionPolicy">PreemptionPolicy is the Policy for
        /// preempting pods with lower priority. One of Never,
        /// PreemptLowerPriority. Defaults to PreemptLowerPriority if unset.
        /// This field is beta-level, gated by the NonPreemptingPriority
        /// feature-gate.</param>
        /// <param name="priority">The priority value. Various system
        /// components use this field to find the priority of the pod. When
        /// Priority Admission Controller is enabled, it prevents users from
        /// setting this field. The admission controller populates this field
        /// from PriorityClassName. The higher the value, the higher the
        /// priority.</param>
        /// <param name="priorityClassName">If specified, indicates the pod's
        /// priority. "system-node-critical" and "system-cluster-critical" are
        /// two special keywords which indicate the highest priorities with the
        /// former being the highest priority. Any other name must be defined
        /// by creating a PriorityClass object with that name. If not
        /// specified, the pod priority will be default or zero if there is no
        /// default.</param>
        /// <param name="readinessGates">If specified, all readiness gates will
        /// be evaluated for pod readiness. A pod is ready when all its
        /// containers are ready AND all conditions specified in the readiness
        /// gates have status equal to "True" More info:
        /// https://git.k8s.io/enhancements/keps/sig-network/0007-pod-ready%2B%2B.md</param>
        /// <param name="restartPolicy">Restart policy for all containers
        /// within the pod. One of Always, OnFailure, Never. Default to Always.
        /// More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#restart-policy</param>
        /// <param name="runtimeClassName">RuntimeClassName refers to a
        /// RuntimeClass object in the node.k8s.io group, which should be used
        /// to run this pod.  If no RuntimeClass resource matches the named
        /// class, the pod will not be run. If unset or empty, the "legacy"
        /// RuntimeClass will be used, which is an implicit class with an empty
        /// definition that uses the default runtime handler. More info:
        /// https://git.k8s.io/enhancements/keps/sig-node/runtime-class.md This
        /// is a beta feature as of Kubernetes v1.14.</param>
        /// <param name="schedulerName">If specified, the pod will be
        /// dispatched by specified scheduler. If not specified, the pod will
        /// be dispatched by default scheduler.</param>
        /// <param name="securityContext">SecurityContext holds pod-level
        /// security attributes and common container settings. Optional:
        /// Defaults to empty.  See type description for default values of each
        /// field.</param>
        /// <param name="serviceAccount">DeprecatedServiceAccount is a
        /// depreciated alias for ServiceAccountName. Deprecated: Use
        /// serviceAccountName instead.</param>
        /// <param name="serviceAccountName">ServiceAccountName is the name of
        /// the ServiceAccount to use to run this pod. More info:
        /// https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/</param>
        /// <param name="setHostnameAsFQDN">If true the pod's hostname will be
        /// configured as the pod's FQDN, rather than the leaf name (the
        /// default). In Linux containers, this means setting the FQDN in the
        /// hostname field of the kernel (the nodename field of struct
        /// utsname). In Windows containers, this means setting the registry
        /// value of hostname for the registry key
        /// HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters
        /// to FQDN. If a pod does not have FQDN, this has no effect. Default
        /// to false.</param>
        /// <param name="shareProcessNamespace">Share a single process
        /// namespace between all of the containers in a pod. When this is set
        /// containers will be able to view and signal processes from other
        /// containers in the same pod, and the first process in each container
        /// will not be assigned PID 1. HostPID and ShareProcessNamespace
        /// cannot both be set. Optional: Default to false.</param>
        /// <param name="subdomain">If specified, the fully qualified Pod
        /// hostname will be "&lt;hostname&gt;.&lt;subdomain&gt;.&lt;pod
        /// namespace&gt;.svc.&lt;cluster domain&gt;". If not specified, the
        /// pod will not have a domainname at all.</param>
        /// <param name="terminationGracePeriodSeconds">Optional duration in
        /// seconds the pod needs to terminate gracefully. May be decreased in
        /// delete request. Value must be non-negative integer. The value zero
        /// indicates delete immediately. If this value is nil, the default
        /// grace period will be used instead. The grace period is the duration
        /// in seconds after the processes running in the pod are sent a
        /// termination signal and the time when the processes are forcibly
        /// halted with a kill signal. Set this value longer than the expected
        /// cleanup time for your process. Defaults to 30 seconds.</param>
        /// <param name="tolerations">If specified, the pod's
        /// tolerations.</param>
        /// <param name="topologySpreadConstraints">TopologySpreadConstraints
        /// describes how a group of pods ought to spread across topology
        /// domains. Scheduler will schedule pods in a way which abides by the
        /// constraints. All topologySpreadConstraints are ANDed.</param>
        /// <param name="volumes">List of volumes that can be mounted by
        /// containers belonging to the pod. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes</param>
        public V1PodSpec(IList<V1Container> containers, long? activeDeadlineSeconds = default(long?), V1Affinity affinity = default(V1Affinity), bool? automountServiceAccountToken = default(bool?), V1PodDNSConfig dnsConfig = default(V1PodDNSConfig), string dnsPolicy = default(string), bool? enableServiceLinks = default(bool?), IList<V1EphemeralContainer> ephemeralContainers = default(IList<V1EphemeralContainer>), IList<V1HostAlias> hostAliases = default(IList<V1HostAlias>), bool? hostIPC = default(bool?), bool? hostNetwork = default(bool?), bool? hostPID = default(bool?), string hostname = default(string), IList<V1LocalObjectReference> imagePullSecrets = default(IList<V1LocalObjectReference>), IList<V1Container> initContainers = default(IList<V1Container>), string nodeName = default(string), IDictionary<string, string> nodeSelector = default(IDictionary<string, string>), IDictionary<string, ResourceQuantity> overhead = default(IDictionary<string, ResourceQuantity>), string preemptionPolicy = default(string), int? priority = default(int?), string priorityClassName = default(string), IList<V1PodReadinessGate> readinessGates = default(IList<V1PodReadinessGate>), string restartPolicy = default(string), string runtimeClassName = default(string), string schedulerName = default(string), V1PodSecurityContext securityContext = default(V1PodSecurityContext), string serviceAccount = default(string), string serviceAccountName = default(string), bool? setHostnameAsFQDN = default(bool?), bool? shareProcessNamespace = default(bool?), string subdomain = default(string), long? terminationGracePeriodSeconds = default(long?), IList<V1Toleration> tolerations = default(IList<V1Toleration>), IList<V1TopologySpreadConstraint> topologySpreadConstraints = default(IList<V1TopologySpreadConstraint>), IList<V1Volume> volumes = default(IList<V1Volume>))
        {
            ActiveDeadlineSeconds = activeDeadlineSeconds;
            Affinity = affinity;
            AutomountServiceAccountToken = automountServiceAccountToken;
            Containers = containers;
            DnsConfig = dnsConfig;
            DnsPolicy = dnsPolicy;
            EnableServiceLinks = enableServiceLinks;
            EphemeralContainers = ephemeralContainers;
            HostAliases = hostAliases;
            HostIPC = hostIPC;
            HostNetwork = hostNetwork;
            HostPID = hostPID;
            Hostname = hostname;
            ImagePullSecrets = imagePullSecrets;
            InitContainers = initContainers;
            NodeName = nodeName;
            NodeSelector = nodeSelector;
            Overhead = overhead;
            PreemptionPolicy = preemptionPolicy;
            Priority = priority;
            PriorityClassName = priorityClassName;
            ReadinessGates = readinessGates;
            RestartPolicy = restartPolicy;
            RuntimeClassName = runtimeClassName;
            SchedulerName = schedulerName;
            SecurityContext = securityContext;
            ServiceAccount = serviceAccount;
            ServiceAccountName = serviceAccountName;
            SetHostnameAsFQDN = setHostnameAsFQDN;
            ShareProcessNamespace = shareProcessNamespace;
            Subdomain = subdomain;
            TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            Tolerations = tolerations;
            TopologySpreadConstraints = topologySpreadConstraints;
            Volumes = volumes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets optional duration in seconds the pod may be active on
        /// the node relative to StartTime before the system will actively try
        /// to mark it failed and kill associated containers. Value must be a
        /// positive integer.
        /// </summary>
        [JsonProperty(PropertyName = "activeDeadlineSeconds")]
        public long? ActiveDeadlineSeconds { get; set; }

        /// <summary>
        /// Gets or sets if specified, the pod's scheduling constraints
        /// </summary>
        [JsonProperty(PropertyName = "affinity")]
        public V1Affinity Affinity { get; set; }

        /// <summary>
        /// Gets or sets automountServiceAccountToken indicates whether a
        /// service account token should be automatically mounted.
        /// </summary>
        [JsonProperty(PropertyName = "automountServiceAccountToken")]
        public bool? AutomountServiceAccountToken { get; set; }

        /// <summary>
        /// Gets or sets list of containers belonging to the pod. Containers
        /// cannot currently be added or removed. There must be at least one
        /// container in a Pod. Cannot be updated.
        /// </summary>
        [JsonProperty(PropertyName = "containers")]
        public IList<V1Container> Containers { get; set; }

        /// <summary>
        /// Gets or sets specifies the DNS parameters of a pod. Parameters
        /// specified here will be merged to the generated DNS configuration
        /// based on DNSPolicy.
        /// </summary>
        [JsonProperty(PropertyName = "dnsConfig")]
        public V1PodDNSConfig DnsConfig { get; set; }

        /// <summary>
        /// Gets or sets set DNS policy for the pod. Defaults to
        /// "ClusterFirst". Valid values are 'ClusterFirstWithHostNet',
        /// 'ClusterFirst', 'Default' or 'None'. DNS parameters given in
        /// DNSConfig will be merged with the policy selected with DNSPolicy.
        /// To have DNS options set along with hostNetwork, you have to specify
        /// DNS policy explicitly to 'ClusterFirstWithHostNet'.
        /// </summary>
        [JsonProperty(PropertyName = "dnsPolicy")]
        public string DnsPolicy { get; set; }

        /// <summary>
        /// Gets or sets enableServiceLinks indicates whether information about
        /// services should be injected into pod's environment variables,
        /// matching the syntax of Docker links. Optional: Defaults to true.
        /// </summary>
        [JsonProperty(PropertyName = "enableServiceLinks")]
        public bool? EnableServiceLinks { get; set; }

        /// <summary>
        /// Gets or sets list of ephemeral containers run in this pod.
        /// Ephemeral containers may be run in an existing pod to perform
        /// user-initiated actions such as debugging. This list cannot be
        /// specified when creating a pod, and it cannot be modified by
        /// updating the pod spec. In order to add an ephemeral container to an
        /// existing pod, use the pod's ephemeralcontainers subresource. This
        /// field is alpha-level and is only honored by servers that enable the
        /// EphemeralContainers feature.
        /// </summary>
        [JsonProperty(PropertyName = "ephemeralContainers")]
        public IList<V1EphemeralContainer> EphemeralContainers { get; set; }

        /// <summary>
        /// Gets or sets hostAliases is an optional list of hosts and IPs that
        /// will be injected into the pod's hosts file if specified. This is
        /// only valid for non-hostNetwork pods.
        /// </summary>
        [JsonProperty(PropertyName = "hostAliases")]
        public IList<V1HostAlias> HostAliases { get; set; }

        /// <summary>
        /// Gets or sets use the host's ipc namespace. Optional: Default to
        /// false.
        /// </summary>
        [JsonProperty(PropertyName = "hostIPC")]
        public bool? HostIPC { get; set; }

        /// <summary>
        /// Gets or sets host networking requested for this pod. Use the host's
        /// network namespace. If this option is set, the ports that will be
        /// used must be specified. Default to false.
        /// </summary>
        [JsonProperty(PropertyName = "hostNetwork")]
        public bool? HostNetwork { get; set; }

        /// <summary>
        /// Gets or sets use the host's pid namespace. Optional: Default to
        /// false.
        /// </summary>
        [JsonProperty(PropertyName = "hostPID")]
        public bool? HostPID { get; set; }

        /// <summary>
        /// Gets or sets specifies the hostname of the Pod If not specified,
        /// the pod's hostname will be set to a system-defined value.
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or sets imagePullSecrets is an optional list of references to
        /// secrets in the same namespace to use for pulling any of the images
        /// used by this PodSpec. If specified, these secrets will be passed to
        /// individual puller implementations for them to use. For example, in
        /// the case of docker, only DockerConfig type secrets are honored.
        /// More info:
        /// https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod
        /// </summary>
        [JsonProperty(PropertyName = "imagePullSecrets")]
        public IList<V1LocalObjectReference> ImagePullSecrets { get; set; }

        /// <summary>
        /// Gets or sets list of initialization containers belonging to the
        /// pod. Init containers are executed in order prior to containers
        /// being started. If any init container fails, the pod is considered
        /// to have failed and is handled according to its restartPolicy. The
        /// name for an init container or normal container must be unique among
        /// all containers. Init containers may not have Lifecycle actions,
        /// Readiness probes, Liveness probes, or Startup probes. The
        /// resourceRequirements of an init container are taken into account
        /// during scheduling by finding the highest request/limit for each
        /// resource type, and then using the max of of that value or the sum
        /// of the normal containers. Limits are applied to init containers in
        /// a similar fashion. Init containers cannot currently be added or
        /// removed. Cannot be updated. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/init-containers/
        /// </summary>
        [JsonProperty(PropertyName = "initContainers")]
        public IList<V1Container> InitContainers { get; set; }

        /// <summary>
        /// Gets or sets nodeName is a request to schedule this pod onto a
        /// specific node. If it is non-empty, the scheduler simply schedules
        /// this pod onto that node, assuming that it fits resource
        /// requirements.
        /// </summary>
        [JsonProperty(PropertyName = "nodeName")]
        public string NodeName { get; set; }

        /// <summary>
        /// Gets or sets nodeSelector is a selector which must be true for the
        /// pod to fit on a node. Selector which must match a node's labels for
        /// the pod to be scheduled on that node. More info:
        /// https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
        /// </summary>
        [JsonProperty(PropertyName = "nodeSelector")]
        public IDictionary<string, string> NodeSelector { get; set; }

        /// <summary>
        /// Gets or sets overhead represents the resource overhead associated
        /// with running a pod for a given RuntimeClass. This field will be
        /// autopopulated at admission time by the RuntimeClass admission
        /// controller. If the RuntimeClass admission controller is enabled,
        /// overhead must not be set in Pod create requests. The RuntimeClass
        /// admission controller will reject Pod create requests which have the
        /// overhead already set. If RuntimeClass is configured and selected in
        /// the PodSpec, Overhead will be set to the value defined in the
        /// corresponding RuntimeClass, otherwise it will remain unset and
        /// treated as zero. More info:
        /// https://git.k8s.io/enhancements/keps/sig-node/20190226-pod-overhead.md
        /// This field is alpha-level as of Kubernetes v1.16, and is only
        /// honored by servers that enable the PodOverhead feature.
        /// </summary>
        [JsonProperty(PropertyName = "overhead")]
        public IDictionary<string, ResourceQuantity> Overhead { get; set; }

        /// <summary>
        /// Gets or sets preemptionPolicy is the Policy for preempting pods
        /// with lower priority. One of Never, PreemptLowerPriority. Defaults
        /// to PreemptLowerPriority if unset. This field is beta-level, gated
        /// by the NonPreemptingPriority feature-gate.
        /// </summary>
        [JsonProperty(PropertyName = "preemptionPolicy")]
        public string PreemptionPolicy { get; set; }

        /// <summary>
        /// Gets or sets the priority value. Various system components use this
        /// field to find the priority of the pod. When Priority Admission
        /// Controller is enabled, it prevents users from setting this field.
        /// The admission controller populates this field from
        /// PriorityClassName. The higher the value, the higher the priority.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets if specified, indicates the pod's priority.
        /// "system-node-critical" and "system-cluster-critical" are two
        /// special keywords which indicate the highest priorities with the
        /// former being the highest priority. Any other name must be defined
        /// by creating a PriorityClass object with that name. If not
        /// specified, the pod priority will be default or zero if there is no
        /// default.
        /// </summary>
        [JsonProperty(PropertyName = "priorityClassName")]
        public string PriorityClassName { get; set; }

        /// <summary>
        /// Gets or sets if specified, all readiness gates will be evaluated
        /// for pod readiness. A pod is ready when all its containers are ready
        /// AND all conditions specified in the readiness gates have status
        /// equal to "True" More info:
        /// https://git.k8s.io/enhancements/keps/sig-network/0007-pod-ready%2B%2B.md
        /// </summary>
        [JsonProperty(PropertyName = "readinessGates")]
        public IList<V1PodReadinessGate> ReadinessGates { get; set; }

        /// <summary>
        /// Gets or sets restart policy for all containers within the pod. One
        /// of Always, OnFailure, Never. Default to Always. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#restart-policy
        /// </summary>
        [JsonProperty(PropertyName = "restartPolicy")]
        public string RestartPolicy { get; set; }

        /// <summary>
        /// Gets or sets runtimeClassName refers to a RuntimeClass object in
        /// the node.k8s.io group, which should be used to run this pod.  If no
        /// RuntimeClass resource matches the named class, the pod will not be
        /// run. If unset or empty, the "legacy" RuntimeClass will be used,
        /// which is an implicit class with an empty definition that uses the
        /// default runtime handler. More info:
        /// https://git.k8s.io/enhancements/keps/sig-node/runtime-class.md This
        /// is a beta feature as of Kubernetes v1.14.
        /// </summary>
        [JsonProperty(PropertyName = "runtimeClassName")]
        public string RuntimeClassName { get; set; }

        /// <summary>
        /// Gets or sets if specified, the pod will be dispatched by specified
        /// scheduler. If not specified, the pod will be dispatched by default
        /// scheduler.
        /// </summary>
        [JsonProperty(PropertyName = "schedulerName")]
        public string SchedulerName { get; set; }

        /// <summary>
        /// Gets or sets securityContext holds pod-level security attributes
        /// and common container settings. Optional: Defaults to empty.  See
        /// type description for default values of each field.
        /// </summary>
        [JsonProperty(PropertyName = "securityContext")]
        public V1PodSecurityContext SecurityContext { get; set; }

        /// <summary>
        /// Gets or sets deprecatedServiceAccount is a depreciated alias for
        /// ServiceAccountName. Deprecated: Use serviceAccountName instead.
        /// </summary>
        [JsonProperty(PropertyName = "serviceAccount")]
        public string ServiceAccount { get; set; }

        /// <summary>
        /// Gets or sets serviceAccountName is the name of the ServiceAccount
        /// to use to run this pod. More info:
        /// https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/
        /// </summary>
        [JsonProperty(PropertyName = "serviceAccountName")]
        public string ServiceAccountName { get; set; }

        /// <summary>
        /// Gets or sets if true the pod's hostname will be configured as the
        /// pod's FQDN, rather than the leaf name (the default). In Linux
        /// containers, this means setting the FQDN in the hostname field of
        /// the kernel (the nodename field of struct utsname). In Windows
        /// containers, this means setting the registry value of hostname for
        /// the registry key
        /// HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters
        /// to FQDN. If a pod does not have FQDN, this has no effect. Default
        /// to false.
        /// </summary>
        [JsonProperty(PropertyName = "setHostnameAsFQDN")]
        public bool? SetHostnameAsFQDN { get; set; }

        /// <summary>
        /// Gets or sets share a single process namespace between all of the
        /// containers in a pod. When this is set containers will be able to
        /// view and signal processes from other containers in the same pod,
        /// and the first process in each container will not be assigned PID 1.
        /// HostPID and ShareProcessNamespace cannot both be set. Optional:
        /// Default to false.
        /// </summary>
        [JsonProperty(PropertyName = "shareProcessNamespace")]
        public bool? ShareProcessNamespace { get; set; }

        /// <summary>
        /// Gets or sets if specified, the fully qualified Pod hostname will be
        /// "&amp;lt;hostname&amp;gt;.&amp;lt;subdomain&amp;gt;.&amp;lt;pod
        /// namespace&amp;gt;.svc.&amp;lt;cluster domain&amp;gt;". If not
        /// specified, the pod will not have a domainname at all.
        /// </summary>
        [JsonProperty(PropertyName = "subdomain")]
        public string Subdomain { get; set; }

        /// <summary>
        /// Gets or sets optional duration in seconds the pod needs to
        /// terminate gracefully. May be decreased in delete request. Value
        /// must be non-negative integer. The value zero indicates delete
        /// immediately. If this value is nil, the default grace period will be
        /// used instead. The grace period is the duration in seconds after the
        /// processes running in the pod are sent a termination signal and the
        /// time when the processes are forcibly halted with a kill signal. Set
        /// this value longer than the expected cleanup time for your process.
        /// Defaults to 30 seconds.
        /// </summary>
        [JsonProperty(PropertyName = "terminationGracePeriodSeconds")]
        public long? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// Gets or sets if specified, the pod's tolerations.
        /// </summary>
        [JsonProperty(PropertyName = "tolerations")]
        public IList<V1Toleration> Tolerations { get; set; }

        /// <summary>
        /// Gets or sets topologySpreadConstraints describes how a group of
        /// pods ought to spread across topology domains. Scheduler will
        /// schedule pods in a way which abides by the constraints. All
        /// topologySpreadConstraints are ANDed.
        /// </summary>
        [JsonProperty(PropertyName = "topologySpreadConstraints")]
        public IList<V1TopologySpreadConstraint> TopologySpreadConstraints { get; set; }

        /// <summary>
        /// Gets or sets list of volumes that can be mounted by containers
        /// belonging to the pod. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes
        /// </summary>
        [JsonProperty(PropertyName = "volumes")]
        public IList<V1Volume> Volumes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Containers == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Containers");
            }
            if (Affinity != null)
            {
                Affinity.Validate();
            }
            if (Containers != null)
            {
                foreach (var element in Containers)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (EphemeralContainers != null)
            {
                foreach (var element1 in EphemeralContainers)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (InitContainers != null)
            {
                foreach (var element2 in InitContainers)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (ReadinessGates != null)
            {
                foreach (var element3 in ReadinessGates)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
            if (SecurityContext != null)
            {
                SecurityContext.Validate();
            }
            if (TopologySpreadConstraints != null)
            {
                foreach (var element4 in TopologySpreadConstraints)
                {
                    if (element4 != null)
                    {
                        element4.Validate();
                    }
                }
            }
            if (Volumes != null)
            {
                foreach (var element5 in Volumes)
                {
                    if (element5 != null)
                    {
                        element5.Validate();
                    }
                }
            }
        }
    }
}
