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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 实例状态。取值范围：
        /// <li>1：申请中</li>
        /// <li>2：运行中</li>
        /// <li>3：受限运行中 (主备切换中)</li>
        /// <li>4：已隔离</li>
        /// <li>5：回收中</li>
        /// <li>6：已回收</li>
        /// <li>7：任务执行中 (实例做备份、回档等操作)</li>
        /// <li>8：已下线</li>
        /// <li>9：实例扩容中</li>
        /// <li>10：实例迁移中</li>
        /// <li>11：只读</li>
        /// <li>12：重启中</li>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 分页返回，页编号，默认值为第0页
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页返回，每页返回的数目，取值为1-100，默认值为100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 一个或者多个实例ID。实例ID，格式如：mssql-si2823jyl
        /// </summary>
        [JsonProperty("InstanceIdSet")]
        public string[] InstanceIdSet{ get; set; }

        /// <summary>
        /// 付费类型检索 1-包年包月，0-按量计费
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 实例所属VPC的唯一字符串ID，格式如：vpc-xxx，传空字符串(“”)则按照基础网络筛选。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 实例所属子网的唯一字符串ID，格式如： subnet-xxx，传空字符串(“”)则按照基础网络筛选。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "InstanceIdSet.", this.InstanceIdSet);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
        }
    }
}

