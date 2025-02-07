/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLoadBalancer Request Marshaller
    /// </summary>       
    public class CreateLoadBalancerRequestMarshaller : IMarshaller<IRequest, CreateLoadBalancerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLoadBalancerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLoadBalancerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lightsail");
            string target = "Lightsail_20161128.CreateLoadBalancer";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCertificateAlternativeNames())
                {
                    context.Writer.WritePropertyName("certificateAlternativeNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCertificateAlternativeNamesListValue in publicRequest.CertificateAlternativeNames)
                    {
                            context.Writer.Write(publicRequestCertificateAlternativeNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCertificateDomainName())
                {
                    context.Writer.WritePropertyName("certificateDomainName");
                    context.Writer.Write(publicRequest.CertificateDomainName);
                }

                if(publicRequest.IsSetCertificateName())
                {
                    context.Writer.WritePropertyName("certificateName");
                    context.Writer.Write(publicRequest.CertificateName);
                }

                if(publicRequest.IsSetHealthCheckPath())
                {
                    context.Writer.WritePropertyName("healthCheckPath");
                    context.Writer.Write(publicRequest.HealthCheckPath);
                }

                if(publicRequest.IsSetInstancePort())
                {
                    context.Writer.WritePropertyName("instancePort");
                    context.Writer.Write(publicRequest.InstancePort);
                }

                if(publicRequest.IsSetIpAddressType())
                {
                    context.Writer.WritePropertyName("ipAddressType");
                    context.Writer.Write(publicRequest.IpAddressType);
                }

                if(publicRequest.IsSetLoadBalancerName())
                {
                    context.Writer.WritePropertyName("loadBalancerName");
                    context.Writer.Write(publicRequest.LoadBalancerName);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateLoadBalancerRequestMarshaller _instance = new CreateLoadBalancerRequestMarshaller();        

        internal static CreateLoadBalancerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLoadBalancerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}