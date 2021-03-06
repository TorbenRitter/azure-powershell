// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Insights.Legacy.Models;

namespace Microsoft.Azure.Insights.Legacy.Models
{
    /// <summary>
    /// Details about the set of blobs containing data split by time.
    /// </summary>
    public partial class BlobLocation
    {
        private string _blobEndpoint;
        
        /// <summary>
        /// Optional. Gets or sets the blob endpoint.
        /// </summary>
        public string BlobEndpoint
        {
            get { return this._blobEndpoint; }
            set { this._blobEndpoint = value; }
        }
        
        private IList<BlobInfo> _blobInfo;
        
        /// <summary>
        /// Optional. Gets or sets the blob info.
        /// </summary>
        public IList<BlobInfo> BlobInfo
        {
            get { return this._blobInfo; }
            set { this._blobInfo = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the BlobLocation class.
        /// </summary>
        public BlobLocation()
        {
            this.BlobInfo = new LazyList<BlobInfo>();
        }
    }
}
