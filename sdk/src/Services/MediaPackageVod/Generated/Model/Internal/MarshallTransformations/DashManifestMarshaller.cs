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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackageVod.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaPackageVod.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DashManifest Marshaller
    /// </summary>
    public class DashManifestMarshaller : IRequestMarshaller<DashManifest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DashManifest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetManifestLayout())
            {
                context.Writer.WritePropertyName("manifestLayout");
                context.Writer.Write(requestObject.ManifestLayout);
            }

            if(requestObject.IsSetManifestName())
            {
                context.Writer.WritePropertyName("manifestName");
                context.Writer.Write(requestObject.ManifestName);
            }

            if(requestObject.IsSetMinBufferTimeSeconds())
            {
                context.Writer.WritePropertyName("minBufferTimeSeconds");
                context.Writer.Write(requestObject.MinBufferTimeSeconds);
            }

            if(requestObject.IsSetProfile())
            {
                context.Writer.WritePropertyName("profile");
                context.Writer.Write(requestObject.Profile);
            }

            if(requestObject.IsSetStreamSelection())
            {
                context.Writer.WritePropertyName("streamSelection");
                context.Writer.WriteObjectStart();

                var marshaller = StreamSelectionMarshaller.Instance;
                marshaller.Marshall(requestObject.StreamSelection, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DashManifestMarshaller Instance = new DashManifestMarshaller();

    }
}