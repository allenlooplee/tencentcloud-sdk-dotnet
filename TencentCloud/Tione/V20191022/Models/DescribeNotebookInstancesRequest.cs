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

namespace TencentCloud.Tione.V20191022.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNotebookInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 限制数目
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// 排序方式
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }

        /// <summary>
        /// 创建时间晚于
        /// </summary>
        [JsonProperty("CreationTimeAfter")]
        public string CreationTimeAfter{ get; set; }

        /// <summary>
        /// 创建时间早于
        /// </summary>
        [JsonProperty("CreationTimeBefore")]
        public string CreationTimeBefore{ get; set; }

        /// <summary>
        /// 最近修改时间晚于
        /// </summary>
        [JsonProperty("LastModifiedTimeAfter")]
        public string LastModifiedTimeAfter{ get; set; }

        /// <summary>
        /// 最近修改时间早于
        /// </summary>
        [JsonProperty("LastModifiedTimeBefore")]
        public string LastModifiedTimeBefore{ get; set; }

        /// <summary>
        /// 根据名称过滤
        /// </summary>
        [JsonProperty("NameContains")]
        public string NameContains{ get; set; }

        /// <summary>
        /// 根据状态过滤
        /// </summary>
        [JsonProperty("StatusEquals")]
        public string StatusEquals{ get; set; }

        /// <summary>
        /// 最大返回个数
        /// </summary>
        [JsonProperty("MaxResults")]
        public ulong? MaxResults{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
            this.SetParamSimple(map, prefix + "CreationTimeAfter", this.CreationTimeAfter);
            this.SetParamSimple(map, prefix + "CreationTimeBefore", this.CreationTimeBefore);
            this.SetParamSimple(map, prefix + "LastModifiedTimeAfter", this.LastModifiedTimeAfter);
            this.SetParamSimple(map, prefix + "LastModifiedTimeBefore", this.LastModifiedTimeBefore);
            this.SetParamSimple(map, prefix + "NameContains", this.NameContains);
            this.SetParamSimple(map, prefix + "StatusEquals", this.StatusEquals);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
        }
    }
}

