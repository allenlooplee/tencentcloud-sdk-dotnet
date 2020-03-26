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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HighlightsEditingInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否开启智能集锦。0为关闭，1为开启。其他非0非1值默认为0。
        /// </summary>
        [JsonProperty("Switch")]
        public long? Switch{ get; set; }

        /// <summary>
        /// 额外定制化服务参数。参数为序列化的Json字符串，例如：{"k1":"v1"}。
        /// </summary>
        [JsonProperty("CustomInfo")]
        public string CustomInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "CustomInfo", this.CustomInfo);
        }
    }
}

