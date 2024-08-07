/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Enable Metrics Collection Request Marshaller
    /// </summary>       
    public class EnableMetricsCollectionRequestMarshaller : IMarshaller<IRequest, EnableMetricsCollectionRequest>
    {
        public IRequest Marshall(EnableMetricsCollectionRequest enableMetricsCollectionRequest)
        {
            IRequest request = new DefaultRequest(enableMetricsCollectionRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "EnableMetricsCollection");
            request.Parameters.Add("Version", "2011-01-01");
            if (enableMetricsCollectionRequest != null && enableMetricsCollectionRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(enableMetricsCollectionRequest.AutoScalingGroupName));
            }
            if (enableMetricsCollectionRequest != null)
            {
                List<string> metricsList = enableMetricsCollectionRequest.Metrics;

                int metricsListIndex = 1;
                foreach (string metricsListValue in metricsList)
                { 
                    request.Parameters.Add("Metrics.member." + metricsListIndex, StringUtils.FromString(metricsListValue));
                    metricsListIndex++;
                }
            }
            if (enableMetricsCollectionRequest != null && enableMetricsCollectionRequest.IsSetGranularity())
            {
                request.Parameters.Add("Granularity", StringUtils.FromString(enableMetricsCollectionRequest.Granularity));
            }

            return request;
        }
    }
}
