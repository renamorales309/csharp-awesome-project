﻿namespace simple
{
    using System;
    using System.IO;
    using k8s;

    class PodList
    {
        static void Main(string[] args)
        {
            var k8sClientConfig = new KubernetesClientConfiguration();
            IKubernetes client = new Kubernetes(k8sClientConfig);
            var listTask = client.ListNamespacedPodWithHttpMessagesAsync("default").Result;
            var list = listTask.Body;
            foreach (var item in list.Items) {
                Console.WriteLine(item.Metadata.Name);
            }
        }
    }
}
