/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cloudhsm.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyVsmAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源Id
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// UpdateResourceName-修改资源名称,
        /// UpdateSgIds-修改安全组名称,
        /// UpdateNetWork-修改网络,
        /// Default-默认不修改
        /// </summary>
        [JsonProperty("Type")]
        public string[] Type{ get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 安全组Id
        /// </summary>
        [JsonProperty("SgIds")]
        public string[] SgIds{ get; set; }

        /// <summary>
        /// VpcId
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网Id
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamArraySimple(map, prefix + "Type.", this.Type);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamArraySimple(map, prefix + "SgIds.", this.SgIds);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
        }
    }
}

