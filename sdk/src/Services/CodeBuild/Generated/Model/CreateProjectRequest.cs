/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProject operation.
    /// Creates a build project.
    /// </summary>
    public partial class CreateProjectRequest : AmazonCodeBuildRequest
    {
        private ProjectArtifacts _artifacts;
        private bool? _badgeEnabled;
        private ProjectCache _cache;
        private string _description;
        private string _encryptionKey;
        private ProjectEnvironment _environment;
        private List<ProjectFileSystemLocation> _fileSystemLocations = new List<ProjectFileSystemLocation>();
        private LogsConfig _logsConfig;
        private string _name;
        private int? _queuedTimeoutInMinutes;
        private List<ProjectArtifacts> _secondaryArtifacts = new List<ProjectArtifacts>();
        private List<ProjectSource> _secondarySources = new List<ProjectSource>();
        private List<ProjectSourceVersion> _secondarySourceVersions = new List<ProjectSourceVersion>();
        private string _serviceRole;
        private ProjectSource _source;
        private string _sourceVersion;
        private List<Tag> _tags = new List<Tag>();
        private int? _timeoutInMinutes;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property Artifacts. 
        /// <para>
        /// Information about the build output artifacts for the build project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProjectArtifacts Artifacts
        {
            get { return this._artifacts; }
            set { this._artifacts = value; }
        }

        // Check to see if Artifacts property is set
        internal bool IsSetArtifacts()
        {
            return this._artifacts != null;
        }

        /// <summary>
        /// Gets and sets the property BadgeEnabled. 
        /// <para>
        /// Set this to true to generate a publicly accessible URL for your project's build badge.
        /// </para>
        /// </summary>
        public bool BadgeEnabled
        {
            get { return this._badgeEnabled.GetValueOrDefault(); }
            set { this._badgeEnabled = value; }
        }

        // Check to see if BadgeEnabled property is set
        internal bool IsSetBadgeEnabled()
        {
            return this._badgeEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Cache. 
        /// <para>
        /// Stores recently used information so that it can be quickly accessed at a later time.
        /// </para>
        /// </summary>
        public ProjectCache Cache
        {
            get { return this._cache; }
            set { this._cache = value; }
        }

        // Check to see if Cache property is set
        internal bool IsSetCache()
        {
            return this._cache != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description that makes the build project easy to identify.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The AWS Key Management Service (AWS KMS) customer master key (CMK) to be used for
        /// encrypting the build output artifacts.
        /// </para>
        ///  <note> 
        /// <para>
        ///  You can use a cross-account KMS key to encrypt the build output artifacts if your
        /// service role has permission to that key. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You can specify either the Amazon Resource Name (ARN) of the CMK or, if available,
        /// the CMK's alias (using the format <code>alias/<i>alias-name</i> </code>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// Information about the build environment for the build project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProjectEnvironment Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemLocations. 
        /// <para>
        ///  An array of <code>ProjectFileSystemLocation</code> objects for a CodeBuild build
        /// project. A <code>ProjectFileSystemLocation</code> object specifies the <code>identifier</code>,
        /// <code>location</code>, <code>mountOptions</code>, <code>mountPoint</code>, and <code>type</code>
        /// of a file system created using Amazon Elastic File System. 
        /// </para>
        /// </summary>
        public List<ProjectFileSystemLocation> FileSystemLocations
        {
            get { return this._fileSystemLocations; }
            set { this._fileSystemLocations = value; }
        }

        // Check to see if FileSystemLocations property is set
        internal bool IsSetFileSystemLocations()
        {
            return this._fileSystemLocations != null && this._fileSystemLocations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LogsConfig. 
        /// <para>
        ///  Information about logs for the build project. These can be logs in Amazon CloudWatch
        /// Logs, logs uploaded to a specified S3 bucket, or both. 
        /// </para>
        /// </summary>
        public LogsConfig LogsConfig
        {
            get { return this._logsConfig; }
            set { this._logsConfig = value; }
        }

        // Check to see if LogsConfig property is set
        internal bool IsSetLogsConfig()
        {
            return this._logsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the build project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property QueuedTimeoutInMinutes. 
        /// <para>
        ///  The number of minutes a build is allowed to be queued before it times out. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=480)]
        public int QueuedTimeoutInMinutes
        {
            get { return this._queuedTimeoutInMinutes.GetValueOrDefault(); }
            set { this._queuedTimeoutInMinutes = value; }
        }

        // Check to see if QueuedTimeoutInMinutes property is set
        internal bool IsSetQueuedTimeoutInMinutes()
        {
            return this._queuedTimeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecondaryArtifacts. 
        /// <para>
        ///  An array of <code>ProjectArtifacts</code> objects. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public List<ProjectArtifacts> SecondaryArtifacts
        {
            get { return this._secondaryArtifacts; }
            set { this._secondaryArtifacts = value; }
        }

        // Check to see if SecondaryArtifacts property is set
        internal bool IsSetSecondaryArtifacts()
        {
            return this._secondaryArtifacts != null && this._secondaryArtifacts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecondarySources. 
        /// <para>
        ///  An array of <code>ProjectSource</code> objects. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public List<ProjectSource> SecondarySources
        {
            get { return this._secondarySources; }
            set { this._secondarySources = value; }
        }

        // Check to see if SecondarySources property is set
        internal bool IsSetSecondarySources()
        {
            return this._secondarySources != null && this._secondarySources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecondarySourceVersions. 
        /// <para>
        ///  An array of <code>ProjectSourceVersion</code> objects. If <code>secondarySourceVersions</code>
        /// is specified at the build level, then they take precedence over these <code>secondarySourceVersions</code>
        /// (at the project level). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public List<ProjectSourceVersion> SecondarySourceVersions
        {
            get { return this._secondarySourceVersions; }
            set { this._secondarySourceVersions = value; }
        }

        // Check to see if SecondarySourceVersions property is set
        internal bool IsSetSecondarySourceVersions()
        {
            return this._secondarySourceVersions != null && this._secondarySourceVersions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The ARN of the AWS Identity and Access Management (IAM) role that enables AWS CodeBuild
        /// to interact with dependent AWS services on behalf of the AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Information about the build input source code for the build project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProjectSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        ///  A version of the build input to be built for this project. If not specified, the
        /// latest version is used. If specified, it must be one of: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For AWS CodeCommit: the commit ID, branch, or Git tag to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For GitHub: the commit ID, pull request ID, branch name, or tag name that corresponds
        /// to the version of the source code you want to build. If a pull request ID is specified,
        /// it must use the format <code>pr/pull-request-ID</code> (for example <code>pr/25</code>).
        /// If a branch name is specified, the branch's HEAD commit ID is used. If not specified,
        /// the default branch's HEAD commit ID is used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Bitbucket: the commit ID, branch name, or tag name that corresponds to the version
        /// of the source code you want to build. If a branch name is specified, the branch's
        /// HEAD commit ID is used. If not specified, the default branch's HEAD commit ID is used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon Simple Storage Service (Amazon S3): the version ID of the object that represents
        /// the build input ZIP file to use.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If <code>sourceVersion</code> is specified at the build level, then that version
        /// takes precedence over this <code>sourceVersion</code> (at the project level). 
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/sample-source-version.html">Source
        /// Version Sample with CodeBuild</a> in the <i>AWS CodeBuild User Guide</i>. 
        /// </para>
        /// </summary>
        public string SourceVersion
        {
            get { return this._sourceVersion; }
            set { this._sourceVersion = value; }
        }

        // Check to see if SourceVersion property is set
        internal bool IsSetSourceVersion()
        {
            return this._sourceVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags for this build project.
        /// </para>
        ///  
        /// <para>
        /// These tags are available for use by AWS services that support AWS CodeBuild build
        /// project tags.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// How long, in minutes, from 5 to 480 (8 hours), for AWS CodeBuild to wait before it
        /// times out any build that has not been marked as completed. The default is 60 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=480)]
        public int TimeoutInMinutes
        {
            get { return this._timeoutInMinutes.GetValueOrDefault(); }
            set { this._timeoutInMinutes = value; }
        }

        // Check to see if TimeoutInMinutes property is set
        internal bool IsSetTimeoutInMinutes()
        {
            return this._timeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// VpcConfig enables AWS CodeBuild to access resources in an Amazon VPC.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}