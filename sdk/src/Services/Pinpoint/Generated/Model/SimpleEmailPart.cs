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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Textual email data, plus an optional character set specification.
    /// </summary>
    public partial class SimpleEmailPart
    {
        private string _charset;
        private string _data;

        /// <summary>
        /// Gets and sets the property Charset. The character set of the content.
        /// </summary>
        public string Charset
        {
            get { return this._charset; }
            set { this._charset = value; }
        }

        // Check to see if Charset property is set
        internal bool IsSetCharset()
        {
            return this._charset != null;
        }

        /// <summary>
        /// Gets and sets the property Data. The textual data of the content.
        /// </summary>
        public string Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

    }
}