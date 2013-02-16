using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cfs.Model
{
    /// <summary>
    /// JSON:类
    /// </summary>
    public class JSON
    {
        /// <summary>
        /// 状态：200成功； 300失败；301超时
        /// </summary>
        public string statusCode { get; set; }
        /// <summary>
        /// 返回提示信息
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 需要刷新的页面，空则刷新当前页
        /// </summary>
        public string navTabId { get; set; }
        public string rel { get; set; }
        /// <summary>
        ///closeCurrent提交并关闭当前页面，空则不关闭
        /// </summary>
        public string callbackType { get; set; }
        public string forwardUrl { get; set; }
    }
}