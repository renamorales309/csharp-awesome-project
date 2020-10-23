using AutoMapper;
using k8s.Models;

namespace k8s.Versioning
{
    public static partial class VersionConverter
    {
        private static void AutoConfigurations(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Admissionregistrationv1beta1ServiceReference, Admissionregistrationv1ServiceReference>().ReverseMap();
            cfg.CreateMap<Admissionregistrationv1beta1WebhookClientConfig, Admissionregistrationv1WebhookClientConfig>().ReverseMap();
            cfg.CreateMap<V1AggregationRule, V1alpha1AggregationRule>().ReverseMap();
            cfg.CreateMap<V1AggregationRule, V1beta1AggregationRule>().ReverseMap();
            cfg.CreateMap<V1alpha1AggregationRule, V1beta1AggregationRule>().ReverseMap();
            cfg.CreateMap<Apiextensionsv1beta1ServiceReference, Apiextensionsv1ServiceReference>().ReverseMap();
            cfg.CreateMap<Apiextensionsv1beta1WebhookClientConfig, Apiextensionsv1WebhookClientConfig>().ReverseMap();
            cfg.CreateMap<Apiregistrationv1beta1ServiceReference, Apiregistrationv1ServiceReference>().ReverseMap();
            cfg.CreateMap<V1APIService, V1beta1APIService>().ReverseMap();
            cfg.CreateMap<V1APIServiceCondition, V1beta1APIServiceCondition>().ReverseMap();
            cfg.CreateMap<V1APIServiceList, V1beta1APIServiceList>().ReverseMap();
            cfg.CreateMap<V1APIServiceSpec, V1beta1APIServiceSpec>().ReverseMap();
            cfg.CreateMap<V1APIServiceStatus, V1beta1APIServiceStatus>().ReverseMap();
            cfg.CreateMap<V1alpha1ClusterRole, V1beta1ClusterRole>().ReverseMap();
            cfg.CreateMap<V1alpha1ClusterRole, V1ClusterRole>().ReverseMap();
            cfg.CreateMap<V1beta1ClusterRole, V1ClusterRole>().ReverseMap();
            cfg.CreateMap<V1alpha1ClusterRoleBinding, V1beta1ClusterRoleBinding>().ReverseMap();
            cfg.CreateMap<V1alpha1ClusterRoleBinding, V1ClusterRoleBinding>().ReverseMap();
            cfg.CreateMap<V1beta1ClusterRoleBinding, V1ClusterRoleBinding>().ReverseMap();
            cfg.CreateMap<V1alpha1ClusterRoleBindingList, V1beta1ClusterRoleBindingList>().ReverseMap();
            cfg.CreateMap<V1alpha1ClusterRoleBindingList, V1ClusterRoleBindingList>().ReverseMap();
            cfg.CreateMap<V1beta1ClusterRoleBindingList, V1ClusterRoleBindingList>().ReverseMap();
            cfg.CreateMap<V1alpha1ClusterRoleList, V1beta1ClusterRoleList>().ReverseMap();
            cfg.CreateMap<V1alpha1ClusterRoleList, V1ClusterRoleList>().ReverseMap();
            cfg.CreateMap<V1beta1ClusterRoleList, V1ClusterRoleList>().ReverseMap();
            cfg.CreateMap<V1beta1CronJob, V2alpha1CronJob>().ReverseMap();
            cfg.CreateMap<V1beta1CronJobList, V2alpha1CronJobList>().ReverseMap();
            cfg.CreateMap<V1beta1CronJobSpec, V2alpha1CronJobSpec>().ReverseMap();
            cfg.CreateMap<V1beta1CronJobStatus, V2alpha1CronJobStatus>().ReverseMap();
            cfg.CreateMap<V1CrossVersionObjectReference, V2beta1CrossVersionObjectReference>().ReverseMap();
            cfg.CreateMap<V1CrossVersionObjectReference, V2beta2CrossVersionObjectReference>().ReverseMap();
            cfg.CreateMap<V2beta1CrossVersionObjectReference, V2beta2CrossVersionObjectReference>().ReverseMap();
            cfg.CreateMap<V1beta1CSIDriver, V1CSIDriver>().ReverseMap();
            cfg.CreateMap<V1beta1CSIDriverList, V1CSIDriverList>().ReverseMap();
            cfg.CreateMap<V1beta1CSIDriverSpec, V1CSIDriverSpec>().ReverseMap();
            cfg.CreateMap<V1beta1CSINode, V1CSINode>().ReverseMap();
            cfg.CreateMap<V1beta1CSINodeDriver, V1CSINodeDriver>().ReverseMap();
            cfg.CreateMap<V1beta1CSINodeList, V1CSINodeList>().ReverseMap();
            cfg.CreateMap<V1beta1CSINodeSpec, V1CSINodeSpec>().ReverseMap();
            cfg.CreateMap<V1beta1CustomResourceColumnDefinition, V1CustomResourceColumnDefinition>().ReverseMap();
            cfg.CreateMap<V1beta1CustomResourceConversion, V1CustomResourceConversion>().ReverseMap();
            cfg.CreateMap<V1beta1CustomResourceDefinition, V1CustomResourceDefinition>().ReverseMap();
            cfg.CreateMap<V1beta1CustomResourceDefinitionCondition, V1CustomResourceDefinitionCondition>().ReverseMap();
            cfg.CreateMap<V1beta1CustomResourceDefinitionList, V1CustomResourceDefinitionList>().ReverseMap();
            cfg.CreateMap<V1beta1CustomResourceDefinitionNames, V1CustomResourceDefinitionNames>().ReverseMap();
            cfg.CreateMap<V1beta1CustomResourceDefinitionSpec, V1CustomResourceDefinitionSpec>().ReverseMap();
            cfg.CreateMap<V1beta1CustomResourceDefinitionStatus, V1CustomResourceDefinitionStatus>().ReverseMap();
            cfg.CreateMap<V1beta1CustomResourceDefinitionVersion, V1CustomResourceDefinitionVersion>().ReverseMap();
            cfg.CreateMap<V1beta1CustomResourceSubresources, V1CustomResourceSubresources>().ReverseMap();
            cfg.CreateMap<V1beta1CustomResourceSubresourceScale, V1CustomResourceSubresourceScale>().ReverseMap();
            cfg.CreateMap<V1beta1CustomResourceValidation, V1CustomResourceValidation>().ReverseMap();
            cfg.CreateMap<V1beta1EndpointPort, V1EndpointPort>().ReverseMap();
            cfg.CreateMap<V1beta1Event, V1Event>().ReverseMap();
            cfg.CreateMap<V1beta1EventList, V1EventList>().ReverseMap();
            cfg.CreateMap<V1beta1EventSeries, V1EventSeries>().ReverseMap();
            cfg.CreateMap<V1beta1ExternalDocumentation, V1ExternalDocumentation>().ReverseMap();
            cfg.CreateMap<V1HorizontalPodAutoscaler, V2beta1HorizontalPodAutoscaler>().ReverseMap();
            cfg.CreateMap<V1HorizontalPodAutoscaler, V2beta2HorizontalPodAutoscaler>().ReverseMap();
            cfg.CreateMap<V2beta1HorizontalPodAutoscaler, V2beta2HorizontalPodAutoscaler>().ReverseMap();
            cfg.CreateMap<V2beta1HorizontalPodAutoscalerCondition, V2beta2HorizontalPodAutoscalerCondition>().ReverseMap();
            cfg.CreateMap<V1HorizontalPodAutoscalerList, V2beta1HorizontalPodAutoscalerList>().ReverseMap();
            cfg.CreateMap<V1HorizontalPodAutoscalerList, V2beta2HorizontalPodAutoscalerList>().ReverseMap();
            cfg.CreateMap<V2beta1HorizontalPodAutoscalerList, V2beta2HorizontalPodAutoscalerList>().ReverseMap();
            cfg.CreateMap<V2beta1HorizontalPodAutoscalerStatus, V2beta2HorizontalPodAutoscalerStatus>().ReverseMap();
            cfg.CreateMap<V1beta1JobTemplateSpec, V2alpha1JobTemplateSpec>().ReverseMap();
            cfg.CreateMap<V1beta1JSONSchemaProps, V1JSONSchemaProps>().ReverseMap();
            cfg.CreateMap<V1beta1Lease, V1Lease>().ReverseMap();
            cfg.CreateMap<V1beta1LeaseList, V1LeaseList>().ReverseMap();
            cfg.CreateMap<V1beta1LeaseSpec, V1LeaseSpec>().ReverseMap();
            cfg.CreateMap<V1beta1LocalSubjectAccessReview, V1LocalSubjectAccessReview>().ReverseMap();
            cfg.CreateMap<V2beta1MetricSpec, V2beta2MetricSpec>().ReverseMap();
            cfg.CreateMap<V2beta1MetricStatus, V2beta2MetricStatus>().ReverseMap();
            cfg.CreateMap<V1beta1MutatingWebhook, V1MutatingWebhook>().ReverseMap();
            cfg.CreateMap<V1beta1MutatingWebhookConfiguration, V1MutatingWebhookConfiguration>().ReverseMap();
            cfg.CreateMap<V1beta1MutatingWebhookConfigurationList, V1MutatingWebhookConfigurationList>().ReverseMap();
            cfg.CreateMap<V1beta1NonResourceAttributes, V1NonResourceAttributes>().ReverseMap();
            cfg.CreateMap<V1beta1NonResourceRule, V1NonResourceRule>().ReverseMap();
            cfg.CreateMap<V1alpha1Overhead, V1beta1Overhead>().ReverseMap();
            cfg.CreateMap<V1alpha1PolicyRule, V1beta1PolicyRule>().ReverseMap();
            cfg.CreateMap<V1alpha1PolicyRule, V1PolicyRule>().ReverseMap();
            cfg.CreateMap<V1beta1PolicyRule, V1PolicyRule>().ReverseMap();
            cfg.CreateMap<V1alpha1PriorityClass, V1beta1PriorityClass>().ReverseMap();
            cfg.CreateMap<V1alpha1PriorityClass, V1PriorityClass>().ReverseMap();
            cfg.CreateMap<V1beta1PriorityClass, V1PriorityClass>().ReverseMap();
            cfg.CreateMap<V1alpha1PriorityClassList, V1beta1PriorityClassList>().ReverseMap();
            cfg.CreateMap<V1alpha1PriorityClassList, V1PriorityClassList>().ReverseMap();
            cfg.CreateMap<V1beta1PriorityClassList, V1PriorityClassList>().ReverseMap();
            cfg.CreateMap<V1beta1ResourceAttributes, V1ResourceAttributes>().ReverseMap();
            cfg.CreateMap<V1beta1ResourceRule, V1ResourceRule>().ReverseMap();
            cfg.CreateMap<V1alpha1Role, V1beta1Role>().ReverseMap();
            cfg.CreateMap<V1alpha1Role, V1Role>().ReverseMap();
            cfg.CreateMap<V1beta1Role, V1Role>().ReverseMap();
            cfg.CreateMap<V1alpha1RoleBinding, V1beta1RoleBinding>().ReverseMap();
            cfg.CreateMap<V1alpha1RoleBinding, V1RoleBinding>().ReverseMap();
            cfg.CreateMap<V1beta1RoleBinding, V1RoleBinding>().ReverseMap();
            cfg.CreateMap<V1alpha1RoleBindingList, V1beta1RoleBindingList>().ReverseMap();
            cfg.CreateMap<V1alpha1RoleBindingList, V1RoleBindingList>().ReverseMap();
            cfg.CreateMap<V1beta1RoleBindingList, V1RoleBindingList>().ReverseMap();
            cfg.CreateMap<V1alpha1RoleList, V1beta1RoleList>().ReverseMap();
            cfg.CreateMap<V1alpha1RoleList, V1RoleList>().ReverseMap();
            cfg.CreateMap<V1beta1RoleList, V1RoleList>().ReverseMap();
            cfg.CreateMap<V1alpha1RoleRef, V1beta1RoleRef>().ReverseMap();
            cfg.CreateMap<V1alpha1RoleRef, V1RoleRef>().ReverseMap();
            cfg.CreateMap<V1beta1RoleRef, V1RoleRef>().ReverseMap();
            cfg.CreateMap<V1beta1RuleWithOperations, V1RuleWithOperations>().ReverseMap();
            cfg.CreateMap<V1alpha1RuntimeClassList, V1beta1RuntimeClassList>().ReverseMap();
            cfg.CreateMap<V1alpha1Scheduling, V1beta1Scheduling>().ReverseMap();
            cfg.CreateMap<V1beta1SelfSubjectAccessReview, V1SelfSubjectAccessReview>().ReverseMap();
            cfg.CreateMap<V1beta1SelfSubjectAccessReviewSpec, V1SelfSubjectAccessReviewSpec>().ReverseMap();
            cfg.CreateMap<V1beta1SelfSubjectRulesReview, V1SelfSubjectRulesReview>().ReverseMap();
            cfg.CreateMap<V1beta1SelfSubjectRulesReviewSpec, V1SelfSubjectRulesReviewSpec>().ReverseMap();
            cfg.CreateMap<V1beta1StorageClass, V1StorageClass>().ReverseMap();
            cfg.CreateMap<V1beta1StorageClassList, V1StorageClassList>().ReverseMap();
            cfg.CreateMap<V1beta1Subject, V1Subject>().ReverseMap();
            cfg.CreateMap<V1beta1SubjectAccessReview, V1SubjectAccessReview>().ReverseMap();
            cfg.CreateMap<V1beta1SubjectAccessReviewSpec, V1SubjectAccessReviewSpec>().ReverseMap();
            cfg.CreateMap<V1beta1SubjectAccessReviewStatus, V1SubjectAccessReviewStatus>().ReverseMap();
            cfg.CreateMap<V1beta1SubjectRulesReviewStatus, V1SubjectRulesReviewStatus>().ReverseMap();
            cfg.CreateMap<V1beta1TokenReview, V1TokenReview>().ReverseMap();
            cfg.CreateMap<V1beta1TokenReviewSpec, V1TokenReviewSpec>().ReverseMap();
            cfg.CreateMap<V1beta1TokenReviewStatus, V1TokenReviewStatus>().ReverseMap();
            cfg.CreateMap<V1beta1UserInfo, V1UserInfo>().ReverseMap();
            cfg.CreateMap<V1beta1ValidatingWebhook, V1ValidatingWebhook>().ReverseMap();
            cfg.CreateMap<V1beta1ValidatingWebhookConfiguration, V1ValidatingWebhookConfiguration>().ReverseMap();
            cfg.CreateMap<V1beta1ValidatingWebhookConfigurationList, V1ValidatingWebhookConfigurationList>().ReverseMap();
            cfg.CreateMap<V1alpha1VolumeAttachment, V1beta1VolumeAttachment>().ReverseMap();
            cfg.CreateMap<V1alpha1VolumeAttachment, V1VolumeAttachment>().ReverseMap();
            cfg.CreateMap<V1beta1VolumeAttachment, V1VolumeAttachment>().ReverseMap();
            cfg.CreateMap<V1alpha1VolumeAttachmentList, V1beta1VolumeAttachmentList>().ReverseMap();
            cfg.CreateMap<V1alpha1VolumeAttachmentList, V1VolumeAttachmentList>().ReverseMap();
            cfg.CreateMap<V1beta1VolumeAttachmentList, V1VolumeAttachmentList>().ReverseMap();
            cfg.CreateMap<V1alpha1VolumeAttachmentSource, V1beta1VolumeAttachmentSource>().ReverseMap();
            cfg.CreateMap<V1alpha1VolumeAttachmentSource, V1VolumeAttachmentSource>().ReverseMap();
            cfg.CreateMap<V1beta1VolumeAttachmentSource, V1VolumeAttachmentSource>().ReverseMap();
            cfg.CreateMap<V1alpha1VolumeAttachmentSpec, V1beta1VolumeAttachmentSpec>().ReverseMap();
            cfg.CreateMap<V1alpha1VolumeAttachmentSpec, V1VolumeAttachmentSpec>().ReverseMap();
            cfg.CreateMap<V1beta1VolumeAttachmentSpec, V1VolumeAttachmentSpec>().ReverseMap();
            cfg.CreateMap<V1alpha1VolumeAttachmentStatus, V1beta1VolumeAttachmentStatus>().ReverseMap();
            cfg.CreateMap<V1alpha1VolumeAttachmentStatus, V1VolumeAttachmentStatus>().ReverseMap();
            cfg.CreateMap<V1beta1VolumeAttachmentStatus, V1VolumeAttachmentStatus>().ReverseMap();
            cfg.CreateMap<V1alpha1VolumeError, V1beta1VolumeError>().ReverseMap();
            cfg.CreateMap<V1alpha1VolumeError, V1VolumeError>().ReverseMap();
            cfg.CreateMap<V1beta1VolumeError, V1VolumeError>().ReverseMap();
            cfg.CreateMap<V1beta1VolumeNodeResources, V1VolumeNodeResources>().ReverseMap();
        }
    }
}
