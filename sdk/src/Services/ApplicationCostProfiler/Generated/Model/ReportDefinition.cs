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
 * Do not modify this file. This file is generated from the applicationcostprofiler-2020-09-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationCostProfiler.Model
{
    /// <summary>
    /// The configuration of a report in AWS Application Cost Profiler.
    /// </summary>
    public partial class ReportDefinition
    {
        private DateTime? _createdAt;
        private S3Location _destinations3Location;
        private Format _format;
        private DateTime? _lastUpdatedAt;
        private string _reportDescription;
        private ReportFrequency _reportFrequency;
        private string _reportId;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp (milliseconds) when this report definition was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationS3Location. 
        /// <para>
        /// The location in Amazon Simple Storage Service (Amazon S3) the reports should be saved
        /// to.
        /// </para>
        /// </summary>
        public S3Location DestinationS3Location
        {
            get { return this._destinations3Location; }
            set { this._destinations3Location = value; }
        }

        // Check to see if DestinationS3Location property is set
        internal bool IsSetDestinationS3Location()
        {
            return this._destinations3Location != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format used for the generated reports.
        /// </para>
        /// </summary>
        public Format Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// Timestamp (milliseconds) when this report definition was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportDescription. 
        /// <para>
        /// Description of the report
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ReportDescription
        {
            get { return this._reportDescription; }
            set { this._reportDescription = value; }
        }

        // Check to see if ReportDescription property is set
        internal bool IsSetReportDescription()
        {
            return this._reportDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ReportFrequency. 
        /// <para>
        /// The cadence at which the report is generated.
        /// </para>
        /// </summary>
        public ReportFrequency ReportFrequency
        {
            get { return this._reportFrequency; }
            set { this._reportFrequency = value; }
        }

        // Check to see if ReportFrequency property is set
        internal bool IsSetReportFrequency()
        {
            return this._reportFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// The ID of the report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ReportId
        {
            get { return this._reportId; }
            set { this._reportId = value; }
        }

        // Check to see if ReportId property is set
        internal bool IsSetReportId()
        {
            return this._reportId != null;
        }

    }
}