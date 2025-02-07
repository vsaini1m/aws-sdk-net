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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PI.Model
{
    /// <summary>
    /// A logical grouping of Performance Insights metrics for a related subject area. For
    /// example, the <code>db.sql</code> dimension group consists of the following dimensions:
    /// <code>db.sql.id</code>, <code>db.sql.db_id</code>, <code>db.sql.statement</code>,
    /// and <code>db.sql.tokenized_id</code>.
    /// 
    ///  <note> 
    /// <para>
    /// Each response element returns a maximum of 500 bytes. For larger elements, such as
    /// SQL statements, only the first 500 bytes are returned.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DimensionGroup
    {
        private List<string> _dimensions = new List<string>();
        private string _group;
        private int? _limit;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// A list of specific dimensions from a dimension group. If this parameter is not present,
        /// then it signifies that all of the dimensions in the group were requested, or are present
        /// in the response.
        /// </para>
        ///  
        /// <para>
        /// Valid values for elements in the <code>Dimensions</code> array are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>db.application.name</code> - The name of the application that is connected
        /// to the database (only Aurora PostgreSQL and RDS PostgreSQL)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.host.id</code> - The host ID of the connected client (all engines)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.host.name</code> - The host name of the connected client (all engines)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.name</code> - The name of the database to which the client is connected
        /// (only Aurora PostgreSQL, Amazon RDS PostgreSQL, Aurora MySQL, Amazon RDS MySQL, and
        /// MariaDB)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.session_type.name</code> - The type of the current session (only Aurora
        /// PostgreSQL and RDS PostgreSQL)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.sql.id</code> - The SQL ID generated by Performance Insights (all engines)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.sql.db_id</code> - The SQL ID generated by the database (all engines)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.sql.statement</code> - The SQL text that is being executed (all engines)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.sql.tokenized_id</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.sql_tokenized.id</code> - The SQL digest ID generated by Performance Insights
        /// (all engines)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.sql_tokenized.db_id</code> - SQL digest ID generated by the database (all
        /// engines)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.sql_tokenized.statement</code> - The SQL digest text (all engines)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.user.id</code> - The ID of the user logged in to the database (all engines)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.user.name</code> - The name of the user logged in to the database (all engines)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.wait_event.name</code> - The event for which the backend is waiting (all
        /// engines)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.wait_event.type</code> - The type of event for which the backend is waiting
        /// (all engines)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.wait_event_type.name</code> - The name of the event type for which the backend
        /// is waiting (all engines)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && this._dimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name of the dimension group. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>db</code> - The name of the database to which the client is connected (only
        /// Aurora PostgreSQL, Amazon RDS PostgreSQL, Aurora MySQL, Amazon RDS MySQL, and MariaDB)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.application</code> - The name of the application that is connected to the
        /// database (only Aurora PostgreSQL and RDS PostgreSQL)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.host</code> - The host name of the connected client (all engines)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.session_type</code> - The type of the current session (only Aurora PostgreSQL
        /// and RDS PostgreSQL)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.sql</code> - The SQL that is currently executing (all engines)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.sql_tokenized</code> - The SQL digest (all engines)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.wait_event</code> - The event for which the database backend is waiting
        /// (all engines)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.wait_event_type</code> - The type of event for which the database backend
        /// is waiting (all engines)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.user</code> - The user logged in to the database (all engines)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items to fetch for this dimension group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

    }
}