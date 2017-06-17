// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// AzureDisk represents an Azure Data Disk mount on the host and bind
    /// mount to the pod.
    /// </summary>
    public partial class V1AzureDiskVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the V1AzureDiskVolumeSource class.
        /// </summary>
        public V1AzureDiskVolumeSource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1AzureDiskVolumeSource class.
        /// </summary>
        /// <param name="diskName">The Name of the data disk in the blob
        /// storage</param>
        /// <param name="diskURI">The URI the data disk in the blob
        /// storage</param>
        /// <param name="cachingMode">Host Caching mode: None, Read Only, Read
        /// Write.</param>
        /// <param name="fsType">Filesystem type to mount. Must be a filesystem
        /// type supported by the host operating system. Ex. "ext4", "xfs",
        /// "ntfs". Implicitly inferred to be "ext4" if unspecified.</param>
        /// <param name="readOnlyProperty">Defaults to false (read/write).
        /// ReadOnly here will force the ReadOnly setting in
        /// VolumeMounts.</param>
        public V1AzureDiskVolumeSource(string diskName, string diskURI, string cachingMode = default(string), string fsType = default(string), bool? readOnlyProperty = default(bool?))
        {
            CachingMode = cachingMode;
            DiskName = diskName;
            DiskURI = diskURI;
            FsType = fsType;
            ReadOnlyProperty = readOnlyProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets host Caching mode: None, Read Only, Read Write.
        /// </summary>
        [JsonProperty(PropertyName = "cachingMode")]
        public string CachingMode { get; set; }

        /// <summary>
        /// Gets or sets the Name of the data disk in the blob storage
        /// </summary>
        [JsonProperty(PropertyName = "diskName")]
        public string DiskName { get; set; }

        /// <summary>
        /// Gets or sets the URI the data disk in the blob storage
        /// </summary>
        [JsonProperty(PropertyName = "diskURI")]
        public string DiskURI { get; set; }

        /// <summary>
        /// Gets or sets filesystem type to mount. Must be a filesystem type
        /// supported by the host operating system. Ex. "ext4", "xfs", "ntfs".
        /// Implicitly inferred to be "ext4" if unspecified.
        /// </summary>
        [JsonProperty(PropertyName = "fsType")]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or sets defaults to false (read/write). ReadOnly here will
        /// force the ReadOnly setting in VolumeMounts.
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DiskName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DiskName");
            }
            if (DiskURI == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DiskURI");
            }
        }
    }
}
