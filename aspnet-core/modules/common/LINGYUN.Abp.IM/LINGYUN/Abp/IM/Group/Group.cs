﻿namespace LINGYUN.Abp.IM.Group
{
    public class Group
    {
        /// <summary>
        /// 群组名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 允许匿名聊天
        /// </summary>
        public bool AllowAnonymous { get; set; }
        /// <summary>
        /// 允许发送消息
        /// </summary>
        public bool AllowSendMessage { get; set; }
        /// <summary>
        /// 最大用户数
        /// </summary>
        public int MaxUserLength { get; set; }
        /// <summary>
        /// 群组用户数
        /// </summary>
        public int GroupUserCount { get; set; }
    }
}
