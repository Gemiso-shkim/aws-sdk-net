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
    /// An email composed of a subject, a text part and a html part.
    /// </summary>
    public partial class SimpleEmail
    {
        private SimpleEmailPart _htmlPart;
        private SimpleEmailPart _subject;
        private SimpleEmailPart _textPart;

        /// <summary>
        /// Gets and sets the property HtmlPart. The content of the message, in HTML format. Use
        /// this for email clients that can process HTML. You can include clickable links, formatted
        /// text, and much more in an HTML message.
        /// </summary>
        public SimpleEmailPart HtmlPart
        {
            get { return this._htmlPart; }
            set { this._htmlPart = value; }
        }

        // Check to see if HtmlPart property is set
        internal bool IsSetHtmlPart()
        {
            return this._htmlPart != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. The subject of the message: A short summary of
        /// the content, which will appear in the recipient's inbox.
        /// </summary>
        public SimpleEmailPart Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

        /// <summary>
        /// Gets and sets the property TextPart. The content of the message, in text format. Use
        /// this for text-based email clients, or clients on high-latency networks (such as mobile
        /// devices).
        /// </summary>
        public SimpleEmailPart TextPart
        {
            get { return this._textPart; }
            set { this._textPart = value; }
        }

        // Check to see if TextPart property is set
        internal bool IsSetTextPart()
        {
            return this._textPart != null;
        }

    }
}