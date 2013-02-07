using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cfs.Web.cfsadmin.QuestionManagement
{
    public partial class DepthReading : System.Web.UI.Page
    {
        #region 字段与属性
        /// <summary>
        /// 每页显示的条数
        /// </summary>
        private int numPerPage;
        /// <summary>
        /// 每页显示的条数
        /// </summary>
        public int NumPerPage
        {
            get
            {
                return numPerPage;
            }
            set { numPerPage = value; }
        }
        /// <summary>
        /// 页数导航的个数
        /// </summary>
        private int pageNumShown = 10;
        /// <summary>
        /// 页数导航的个数
        /// </summary>
        public int PageNumShown
        {
            get { return pageNumShown; }
            set { pageNumShown = value; }
        }
        /// <summary>
        /// 当前显示条数
        /// </summary>
        private int pageNum;
        /// <summary>
        /// 当前显示的页数
        /// </summary>
        public int PageNum
        {
            get
            {
                return pageNum;
            }
            set { pageNum = value; }
        }
        /// <summary>
        /// 总条数
        /// </summary>
        private int totalCount;
        /// <summary>
        /// 总条数
        /// </summary>
        public int TotalCount
        {
            get { return totalCount; }
            set { totalCount = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int temp = Convert.ToInt32(Request.Form["numPerPage"]);
                numPerPage = temp == 0 ? 15 : temp;
                temp = Convert.ToInt32(Request.Form["pageNum"]);
                pageNum = temp == 0 ? 1 : temp;

                //BindData(numPerPage, pageNum);
            }
        }
    }
}