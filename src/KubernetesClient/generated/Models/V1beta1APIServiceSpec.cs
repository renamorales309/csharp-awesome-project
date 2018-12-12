// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// APIServiceSpec contains information for locating and communicating with
    /// a server. Only https is supported, though you are able to disable
    /// certificate verification.
    /// </summary>
    public partial class V1beta1APIServiceSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1APIServiceSpec class.
        /// </summary>
        public V1beta1APIServiceSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1APIServiceSpec class.
        /// </summary>
        /// <param name="groupPriorityMinimum">GroupPriorityMininum is the
        /// priority this group should have at least. Higher priority means
        /// that the group is preferred by clients over lower priority ones.
        /// Note that other versions of this group might specify even higher
        /// GroupPriorityMininum values such that the whole group gets a higher
        /// priority. The primary sort is based on GroupPriorityMinimum,
        /// ordered highest number to lowest (20 before 10). The secondary sort
        /// is based on the alphabetical comparison of the name of the object.
        /// (v1.bar before v1.foo) We'd recommend something like: *.k8s.io
        /// (except extensions) at 18000 and PaaSes (OpenShift, Deis) are
        /// recommended to be in the 2000s</param>
        /// <param name="service">Service is a reference to the service for
        /// this API server.  It must communicate on port 443 If the Service is
        /// nil, that means the handling for the API groupversion is handled
        /// locally on this server. The call will simply delegate to the normal
        /// handler chain to be fulfilled.</param>
        /// <param name="versionPriority">VersionPriority controls the ordering
        /// of this API version inside of its group.  Must be greater than
        /// zero. The primary sort is based on VersionPriority, ordered highest
        /// to lowest (20 before 10). Since it's inside of a group, the number
        /// can be small, probably in the 10s. In case of equal version
        /// priorities, the version string will be used to compute the order
        /// inside a group. If the version string is "kube-like", it will sort
        /// above non "kube-like" version strings, which are ordered
        /// lexicographically. "Kube-like" versions start with a "v", then are
        /// followed by a number (the major version), then optionally the
        /// string "alpha" or "beta" and another number (the minor version).
        /// These are sorted first by GA &gt; beta &gt; alpha (where GA is a
        /// version with no suffix such as beta or alpha), and then by
        /// comparing major version, then minor version. An example sorted list
        /// of versions: v10, v2, v1, v11beta2, v10beta3, v3beta1, v12alpha1,
        /// v11alpha2, foo1, foo10.</param>
        /// <param name="caBundle">CABundle is a PEM encoded CA bundle which
        /// will be used to validate an API server's serving certificate. If
        /// unspecified, system trust roots on the apiserver are used.</param>
        /// <param name="group">Group is the API group name this server
        /// hosts</param>
        /// <param name="insecureSkipTLSVerify">InsecureSkipTLSVerify disables
        /// TLS certificate verification when communicating with this server.
        /// This is strongly discouraged.  You should use the CABundle
        /// instead.</param>
        /// <param name="version">Version is the API version this server hosts.
        /// For example, "v1"</param>
        public V1beta1APIServiceSpec(int groupPriorityMinimum, Apiregistrationv1beta1ServiceReference service, int versionPriority, byte[] caBundle = default(byte[]), string group = default(string), bool? insecureSkipTLSVerify = default(bool?), string version = default(string))
        {
            CaBundle = caBundle;
            Group = group;
            GroupPriorityMinimum = groupPriorityMinimum;
            InsecureSkipTLSVerify = insecureSkipTLSVerify;
            Service = service;
            Version = version;
            VersionPriority = versionPriority;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets cABundle is a PEM encoded CA bundle which will be used
        /// to validate an API server's serving certificate. If unspecified,
        /// system trust roots on the apiserver are used.
        /// </summary>
        [JsonProperty(PropertyName = "caBundle")]
        public byte[] CaBundle { get; set; }

        /// <summary>
        /// Gets or sets group is the API group name this server hosts
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets groupPriorityMininum is the priority this group should
        /// have at least. Higher priority means that the group is preferred by
        /// clients over lower priority ones. Note that other versions of this
        /// group might specify even higher GroupPriorityMininum values such
        /// that the whole group gets a higher priority. The primary sort is
        /// based on GroupPriorityMinimum, ordered highest number to lowest (20
        /// before 10). The secondary sort is based on the alphabetical
        /// comparison of the name of the object.  (v1.bar before v1.foo) We'd
        /// recommend something like: *.k8s.io (except extensions) at 18000 and
        /// PaaSes (OpenShift, Deis) are recommended to be in the 2000s
        /// </summary>
        [JsonProperty(PropertyName = "groupPriorityMinimum")]
        public int GroupPriorityMinimum { get; set; }

        /// <summary>
        /// Gets or sets insecureSkipTLSVerify disables TLS certificate
        /// verification when communicating with this server. This is strongly
        /// discouraged.  You should use the CABundle instead.
        /// </summary>
        [JsonProperty(PropertyName = "insecureSkipTLSVerify")]
        public bool? InsecureSkipTLSVerify { get; set; }

        /// <summary>
        /// Gets or sets service is a reference to the service for this API
        /// server.  It must communicate on port 443 If the Service is nil,
        /// that means the handling for the API groupversion is handled locally
        /// on this server. The call will simply delegate to the normal handler
        /// chain to be fulfilled.
        /// </summary>
        [JsonProperty(PropertyName = "service")]
        public Apiregistrationv1beta1ServiceReference Service { get; set; }

        /// <summary>
        /// Gets or sets version is the API version this server hosts.  For
        /// example, "v1"
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets versionPriority controls the ordering of this API
        /// version inside of its group.  Must be greater than zero. The
        /// primary sort is based on VersionPriority, ordered highest to lowest
        /// (20 before 10). Since it's inside of a group, the number can be
        /// small, probably in the 10s. In case of equal version priorities,
        /// the version string will be used to compute the order inside a
        /// group. If the version string is "kube-like", it will sort above non
        /// "kube-like" version strings, which are ordered lexicographically.
        /// "Kube-like" versions start with a "v", then are followed by a
        /// number (the major version), then optionally the string "alpha" or
        /// "beta" and another number (the minor version). These are sorted
        /// first by GA &amp;gt; beta &amp;gt; alpha (where GA is a version
        /// with no suffix such as beta or alpha), and then by comparing major
        /// version, then minor version. An example sorted list of versions:
        /// v10, v2, v1, v11beta2, v10beta3, v3beta1, v12alpha1, v11alpha2,
        /// foo1, foo10.
        /// </summary>
        [JsonProperty(PropertyName = "versionPriority")]
        public int VersionPriority { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Service == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Service");
            }
        }
    }
}
