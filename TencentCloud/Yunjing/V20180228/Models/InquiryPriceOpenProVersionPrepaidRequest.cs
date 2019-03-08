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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquiryPriceOpenProVersionPrepaidRequest : AbstractModel
    {
        
        /// <summary>
        /// 预付费模式(包年包月)参数设置。
        /// </summary>
        [JsonProperty("ChargePrepaid")]
        public ChargePrepaid ChargePrepaid{ get; set; }

        /// <summary>
        /// 需要开通专业版机器列表数组。
        /// </summary>
        [JsonProperty("Machines")]
        public ProVersionMachine[] Machines{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ChargePrepaid.", this.ChargePrepaid);
            this.SetParamArrayObj(map, prefix + "Machines.", this.Machines);
        }
    }
}
