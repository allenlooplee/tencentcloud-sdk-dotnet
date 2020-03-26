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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeGameServerSessionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 别名ID
        /// </summary>
        [JsonProperty("AliasId")]
        public string AliasId{ get; set; }

        /// <summary>
        /// 舰队ID
        /// </summary>
        [JsonProperty("FleetId")]
        public string FleetId{ get; set; }

        /// <summary>
        /// 游戏服务器会话ID
        /// </summary>
        [JsonProperty("GameServerSessionId")]
        public string GameServerSessionId{ get; set; }

        /// <summary>
        /// 单次查询记录数上限
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 页偏移，用于查询下一页
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// 游戏服务器会话状态
        /// </summary>
        [JsonProperty("StatusFilter")]
        public string StatusFilter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AliasId", this.AliasId);
            this.SetParamSimple(map, prefix + "FleetId", this.FleetId);
            this.SetParamSimple(map, prefix + "GameServerSessionId", this.GameServerSessionId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamSimple(map, prefix + "StatusFilter", this.StatusFilter);
        }
    }
}

