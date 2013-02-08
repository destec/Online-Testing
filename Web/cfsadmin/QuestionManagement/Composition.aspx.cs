using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

namespace cfs.Web.cfsadmin.QuestionManagement
{
    public partial class Composition : System.Web.UI.Page
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

                BindData(numPerPage, pageNum);
            }
        }
        private void BindData(int numPerPage, int pageNum)
        {
            cfs.BLL.OT_ESSAY bll = new cfs.BLL.OT_ESSAY();
            StringBuilder sb = new StringBuilder();
            DataSet ds = new DataSet();
            //根据Session值查表
            string sqlwhere = "ES_TYPE = 5 AND ES_DELFLAG = 0";
            TotalCount = bll.GetRecordCount(sqlwhere);
            ds = bll.GetListByPage(sqlwhere, "ES_ID DESC", (pageNum - 1) * numPerPage + 1, pageNum * numPerPage);
            sb.Append("<table class=\"table\" width=\"80%\" layouth=\"74\"><thead><tr align='center'><th>题目编号</th><th width='15%'>作文题目</th><th width=\"50%\">题目叙述</th><th width='5%'>难易度</th><th width='10%'>创建教师</th></tr></thead>");
            sb.Append("<tbody>");
            if (ds.Tables[0].Rows.Count != 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    sb.Append("<tr target='esid' rel='" + ds.Tables[0].Rows[i]["ES_ID"] + "' align='center'>");
                    sb.Append("<td>");
                    sb.Append(ds.Tables[0].Rows[i]["ES_ID"]);
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append(ds.Tables[0].Rows[i]["ES_TITLE"]);
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append(ds.Tables[0].Rows[i]["ES_CONTENT"]);
                    sb.Append("</td>");
                    sb.Append("<td>");
                    sb.Append(ds.Tables[0].Rows[i]["ES_HARD"]);
                    sb.Append("</td>");
                    //显示用户分组，根据Session的值更改
                    sb.Append("<td>");
                    sb.Append(ds.Tables[0].Rows[i]["ES_TID"]);
                    sb.Append("</td>");
                    sb.Append("</tr>");
                }
            }
            sb.Append("</tbody></table>");
            MainTable.InnerHtml = sb.ToString();
        }
    }
}