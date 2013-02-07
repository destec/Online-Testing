using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace cfs.DAL
{
    /// <summary>
    /// 数据访问类:OT_QUESTION
    /// </summary>
    public partial class OT_QUESTION
    {
        public OT_QUESTION()
        { }
        #region  Method

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string QS_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from OT_QUESTION");
            strSql.Append(" where QS_ID=@QS_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@QS_ID", SqlDbType.VarChar,64)			};
            parameters[0].Value = QS_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(cfs.Model.OT_QUESTION model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into OT_QUESTION(");
            strSql.Append("QS_ID,QS_TYPE,QS_EID,QS_CONTENT,QS_CHOICE_A,QS_CHOICE_B,QS_CHOICE_C,QS_CHOICE_D,QS_CHOICE_COR,QS_COR_EXPLAINATION,QS_DELFLAG,QS_HARD,QS_CTIME,QS_TID)");
            strSql.Append(" values (");
            strSql.Append("@QS_ID,@QS_TYPE,@QS_EID,@QS_CONTENT,@QS_CHOICE_A,@QS_CHOICE_B,@QS_CHOICE_C,@QS_CHOICE_D,@QS_CHOICE_COR,@QS_COR_EXPLAINATION,@QS_DELFLAG,@QS_HARD,@QS_CTIME,@QS_TID)");
            SqlParameter[] parameters = {
					new SqlParameter("@QS_ID", SqlDbType.VarChar,64),
					new SqlParameter("@QS_TYPE", SqlDbType.VarChar,50),
					new SqlParameter("@QS_EID", SqlDbType.VarChar,64),
					new SqlParameter("@QS_CONTENT", SqlDbType.Text),
					new SqlParameter("@QS_CHOICE_A", SqlDbType.Text),
					new SqlParameter("@QS_CHOICE_B", SqlDbType.Text),
					new SqlParameter("@QS_CHOICE_C", SqlDbType.Text),
					new SqlParameter("@QS_CHOICE_D", SqlDbType.Text),
					new SqlParameter("@QS_CHOICE_COR", SqlDbType.Int,4),
					new SqlParameter("@QS_COR_EXPLAINATION", SqlDbType.NVarChar,1000),
					new SqlParameter("@QS_DELFLAG", SqlDbType.Int,4),
					new SqlParameter("@QS_HARD", SqlDbType.Int,4),
					new SqlParameter("@QS_CTIME", SqlDbType.DateTime),
					new SqlParameter("@QS_TID", SqlDbType.VarChar,50)};
            parameters[0].Value = model.QS_ID;
            parameters[1].Value = model.QS_TYPE;
            parameters[2].Value = model.QS_EID;
            parameters[3].Value = model.QS_CONTENT;
            parameters[4].Value = model.QS_CHOICE_A;
            parameters[5].Value = model.QS_CHOICE_B;
            parameters[6].Value = model.QS_CHOICE_C;
            parameters[7].Value = model.QS_CHOICE_D;
            parameters[8].Value = model.QS_CHOICE_COR;
            parameters[9].Value = model.QS_COR_EXPLAINATION;
            parameters[10].Value = model.QS_DELFLAG;
            parameters[11].Value = model.QS_HARD;
            parameters[12].Value = model.QS_CTIME;
            parameters[13].Value = model.QS_TID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(cfs.Model.OT_QUESTION model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update OT_QUESTION set ");
            strSql.Append("QS_TYPE=@QS_TYPE,");
            strSql.Append("QS_EID=@QS_EID,");
            strSql.Append("QS_CONTENT=@QS_CONTENT,");
            strSql.Append("QS_CHOICE_A=@QS_CHOICE_A,");
            strSql.Append("QS_CHOICE_B=@QS_CHOICE_B,");
            strSql.Append("QS_CHOICE_C=@QS_CHOICE_C,");
            strSql.Append("QS_CHOICE_D=@QS_CHOICE_D,");
            strSql.Append("QS_CHOICE_COR=@QS_CHOICE_COR,");
            strSql.Append("QS_COR_EXPLAINATION=@QS_COR_EXPLAINATION,");
            strSql.Append("QS_DELFLAG=@QS_DELFLAG,");
            strSql.Append("QS_HARD=@QS_HARD,");
            strSql.Append("QS_CTIME=@QS_CTIME,");
            strSql.Append("QS_TID=@QS_TID");
            strSql.Append(" where QS_ID=@QS_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@QS_TYPE", SqlDbType.VarChar,50),
					new SqlParameter("@QS_EID", SqlDbType.VarChar,64),
					new SqlParameter("@QS_CONTENT", SqlDbType.Text),
					new SqlParameter("@QS_CHOICE_A", SqlDbType.Text),
					new SqlParameter("@QS_CHOICE_B", SqlDbType.Text),
					new SqlParameter("@QS_CHOICE_C", SqlDbType.Text),
					new SqlParameter("@QS_CHOICE_D", SqlDbType.Text),
					new SqlParameter("@QS_CHOICE_COR", SqlDbType.Int,4),
					new SqlParameter("@QS_COR_EXPLAINATION", SqlDbType.NVarChar,1000),
					new SqlParameter("@QS_DELFLAG", SqlDbType.Int,4),
					new SqlParameter("@QS_HARD", SqlDbType.Int,4),
					new SqlParameter("@QS_CTIME", SqlDbType.DateTime),
					new SqlParameter("@QS_TID", SqlDbType.VarChar,50),
					new SqlParameter("@QS_ID", SqlDbType.VarChar,64)};
            parameters[0].Value = model.QS_TYPE;
            parameters[1].Value = model.QS_EID;
            parameters[2].Value = model.QS_CONTENT;
            parameters[3].Value = model.QS_CHOICE_A;
            parameters[4].Value = model.QS_CHOICE_B;
            parameters[5].Value = model.QS_CHOICE_C;
            parameters[6].Value = model.QS_CHOICE_D;
            parameters[7].Value = model.QS_CHOICE_COR;
            parameters[8].Value = model.QS_COR_EXPLAINATION;
            parameters[9].Value = model.QS_DELFLAG;
            parameters[10].Value = model.QS_HARD;
            parameters[11].Value = model.QS_CTIME;
            parameters[12].Value = model.QS_TID;
            parameters[13].Value = model.QS_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string QS_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from OT_QUESTION ");
            strSql.Append(" where QS_ID=@QS_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@QS_ID", SqlDbType.VarChar,64)			};
            parameters[0].Value = QS_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string QS_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from OT_QUESTION ");
            strSql.Append(" where QS_ID in (" + QS_IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public cfs.Model.OT_QUESTION GetModel(string QS_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 QS_ID,QS_TYPE,QS_EID,QS_CONTENT,QS_CHOICE_A,QS_CHOICE_B,QS_CHOICE_C,QS_CHOICE_D,QS_CHOICE_COR,QS_COR_EXPLAINATION,QS_DELFLAG,QS_HARD,QS_CTIME,QS_TID from OT_QUESTION ");
            strSql.Append(" where QS_ID=@QS_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@QS_ID", SqlDbType.VarChar,64)			};
            parameters[0].Value = QS_ID;

            cfs.Model.OT_QUESTION model = new cfs.Model.OT_QUESTION();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["QS_ID"] != null && ds.Tables[0].Rows[0]["QS_ID"].ToString() != "")
                {
                    model.QS_ID = ds.Tables[0].Rows[0]["QS_ID"].ToString();
                }
                if (ds.Tables[0].Rows[0]["QS_TYPE"] != null && ds.Tables[0].Rows[0]["QS_TYPE"].ToString() != "")
                {
                    model.QS_TYPE = ds.Tables[0].Rows[0]["QS_TYPE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["QS_EID"] != null && ds.Tables[0].Rows[0]["QS_EID"].ToString() != "")
                {
                    model.QS_EID = ds.Tables[0].Rows[0]["QS_EID"].ToString();
                }
                if (ds.Tables[0].Rows[0]["QS_CONTENT"] != null && ds.Tables[0].Rows[0]["QS_CONTENT"].ToString() != "")
                {
                    model.QS_CONTENT = ds.Tables[0].Rows[0]["QS_CONTENT"].ToString();
                }
                if (ds.Tables[0].Rows[0]["QS_CHOICE_A"] != null && ds.Tables[0].Rows[0]["QS_CHOICE_A"].ToString() != "")
                {
                    model.QS_CHOICE_A = ds.Tables[0].Rows[0]["QS_CHOICE_A"].ToString();
                }
                if (ds.Tables[0].Rows[0]["QS_CHOICE_B"] != null && ds.Tables[0].Rows[0]["QS_CHOICE_B"].ToString() != "")
                {
                    model.QS_CHOICE_B = ds.Tables[0].Rows[0]["QS_CHOICE_B"].ToString();
                }
                if (ds.Tables[0].Rows[0]["QS_CHOICE_C"] != null && ds.Tables[0].Rows[0]["QS_CHOICE_C"].ToString() != "")
                {
                    model.QS_CHOICE_C = ds.Tables[0].Rows[0]["QS_CHOICE_C"].ToString();
                }
                if (ds.Tables[0].Rows[0]["QS_CHOICE_D"] != null && ds.Tables[0].Rows[0]["QS_CHOICE_D"].ToString() != "")
                {
                    model.QS_CHOICE_D = ds.Tables[0].Rows[0]["QS_CHOICE_D"].ToString();
                }
                if (ds.Tables[0].Rows[0]["QS_CHOICE_COR"] != null && ds.Tables[0].Rows[0]["QS_CHOICE_COR"].ToString() != "")
                {
                    model.QS_CHOICE_COR = int.Parse(ds.Tables[0].Rows[0]["QS_CHOICE_COR"].ToString());
                }
                if (ds.Tables[0].Rows[0]["QS_COR_EXPLAINATION"] != null && ds.Tables[0].Rows[0]["QS_COR_EXPLAINATION"].ToString() != "")
                {
                    model.QS_COR_EXPLAINATION = ds.Tables[0].Rows[0]["QS_COR_EXPLAINATION"].ToString();
                }
                if (ds.Tables[0].Rows[0]["QS_DELFLAG"] != null && ds.Tables[0].Rows[0]["QS_DELFLAG"].ToString() != "")
                {
                    model.QS_DELFLAG = int.Parse(ds.Tables[0].Rows[0]["QS_DELFLAG"].ToString());
                }
                if (ds.Tables[0].Rows[0]["QS_HARD"] != null && ds.Tables[0].Rows[0]["QS_HARD"].ToString() != "")
                {
                    model.QS_HARD = int.Parse(ds.Tables[0].Rows[0]["QS_HARD"].ToString());
                }
                if (ds.Tables[0].Rows[0]["QS_CTIME"] != null && ds.Tables[0].Rows[0]["QS_CTIME"].ToString() != "")
                {
                    model.QS_CTIME = DateTime.Parse(ds.Tables[0].Rows[0]["QS_CTIME"].ToString());
                }
                if (ds.Tables[0].Rows[0]["QS_TID"] != null && ds.Tables[0].Rows[0]["QS_TID"].ToString() != "")
                {
                    model.QS_TID = ds.Tables[0].Rows[0]["QS_TID"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select QS_ID,QS_TYPE,QS_EID,QS_CONTENT,QS_CHOICE_A,QS_CHOICE_B,QS_CHOICE_C,QS_CHOICE_D,QS_CHOICE_COR,QS_COR_EXPLAINATION,QS_DELFLAG,QS_HARD,QS_CTIME,QS_TID ");
            strSql.Append(" FROM OT_QUESTION ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" QS_ID,QS_TYPE,QS_EID,QS_CONTENT,QS_CHOICE_A,QS_CHOICE_B,QS_CHOICE_C,QS_CHOICE_D,QS_CHOICE_COR,QS_COR_EXPLAINATION,QS_DELFLAG,QS_HARD,QS_CTIME,QS_TID ");
            strSql.Append(" FROM OT_QUESTION ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM OT_QUESTION ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.QS_ID desc");
            }
            strSql.Append(")AS Row, T.*  from OT_QUESTION T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "OT_QUESTION";
            parameters[1].Value = "QS_ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  Method
    }
}

