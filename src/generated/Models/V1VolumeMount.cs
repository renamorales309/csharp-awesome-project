// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// VolumeMount describes a mounting of a Volume within a container.
    /// </summary>
    public partial class V1VolumeMount
    {
        /// <summary>
        /// Initializes a new instance of the V1VolumeMount class.
        /// </summary>
        public V1VolumeMount()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1VolumeMount class.
        /// </summary>
        /// <param name="mountPath">Path within the container at which the
        /// volume should be mounted.  Must not contain ':'.</param>
        /// <param name="name">This must match the Name of a Volume.</param>
        /// <param name="readOnlyProperty">Mounted read-only if true,
        /// read-write otherwise (false or unspecified). Defaults to
        /// false.</param>
        /// <param name="subPath">Path within the volume from which the
        /// container's volume should be mounted. Defaults to "" (volume's
        /// root).</param>
        public V1VolumeMount(string mountPath, string name, bool? readOnlyProperty = default(bool?), string subPath = default(string))
        {
            MountPath = mountPath;
            Name = name;
            ReadOnlyProperty = readOnlyProperty;
            SubPath = subPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets path within the container at which the volume should
        /// be mounted.  Must not contain ':'.
        /// </summary>
        [JsonProperty(PropertyName = "mountPath")]
        public string MountPath { get; set; }

        /// <summary>
        /// Gets or sets this must match the Name of a Volume.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets mounted read-only if true, read-write otherwise (false
        /// or unspecified). Defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Gets or sets path within the volume from which the container's
        /// volume should be mounted. Defaults to "" (volume's root).
        /// </summary>
        [JsonProperty(PropertyName = "subPath")]
        public string SubPath { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MountPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MountPath");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
