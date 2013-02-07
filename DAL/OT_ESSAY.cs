using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace cfs.DAL
{
	/// <summary>
	/// 数据访问类:OT_ESSAY
	/// </summary>
	public partial class OT_ESSAY
	{
		public OT_ESSAY()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ES_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OT_ESSAY");
			strSql.Append(" where ES_ID=@ES_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ES_ID", SqlDbType.VarChar,64)			};
			parameters[0].Value = ES_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(cfs.Model.OT_ESSAY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OT_ESSAY(");
			strSql.Append("ES_ID,ES_TYPE,ES_TITLE,ES_CONTENT,ES_HARD,ES_DELFLAG,ES_CTIME,ES_TID)");
			strSql.Append(" values (");
			strSql.Append("@ES_ID,@ES_TYPE,@ES_TITLE,@ES_CONTENT,@ES_HARD,@ES_DELFLAG,@ES_CTIME,@ES_TID)");
			SqlParameter[] parameters = {
					new SqlParameter("@ES_ID", SqlDbType.VarChar,64),
					new SqlParameter("@ES_TYPE", SqlDbType.VarChar,50),
					new SqlParameter("@ES_TITLE", SqlDbType.Text),
					new SqlParameter("@ES_CONTENT", SqlDbType.Text),
					new SqlParameter("@ES_HARD", SqlDbType.Int,4),
					new SqlParameter("@ES_DELFLAG", SqlDbType.Int,4),
					new SqlParameter("@ES_CTIME", SqlDbType.DateTime),
					new SqlParameter("@ES_TID", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ES_ID;
			parameters[1].Value = model.ES_TYPE;
			parameters[2].Value = model.ES_TITLE;
			parameters[3].Value = model.ES_CONTENT;
			parameters[4].Value = model.ES_HARD;
			parameters[5].Value = model.ES_DELFLAG;
			parameters[6].Value = model.ES_CTIME;
			parameters[7].Value = model.ES_TID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(cfs.Model.OT_ESSAY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OT_ESSAY set ");
			strSql.Append("ES_TYPE=@ES_TYPE,");
			strSql.Append("ES_TITLE=@ES_TITLE,");
			strSql.Append("ES_CONTENT=@ES_CONTENT,");
			strSql.Append("ES_HARD=@ES_HARD,");
			strSql.Append("ES_DELFLAG=@ES_DELFLAG,");
			strSql.Append("ES_CTIME=@ES_CTIME,");
			strSql.Append("ES_TID=@ES_TID");
			strSql.Append(" where ES_ID=@ES_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ES_TYPE", SqlDbType.VarChar,50),
					new SqlParameter("@ES_TITLE", SqlDbType.Text),
					new SqlParameter("@ES_CONTENT", SqlDbType.Text),
					new SqlParameter("@ES_HARD", SqlDbType.Int,4),
					new SqlParameter("@ES_DELFLAG", SqlDbType.Int,4),
					new SqlParameter("@ES_CTIME", SqlDbType.DateTime),
					new SqlParameter("@ES_TID", SqlDbType.VarChar,50),
					new SqlParameter("@ES_ID", SqlDbType.VarChar,64)};
			parameters[0].Value = model.ES_TYPE;
			parameters[1].Value = model.ES_TITLE;
			parameters[2].Value = model.ES_CONTENT;
			parameters[3].Value = model.ES_HARD;
			parameters[4].Value = model.ES_DELFLAG;
			parameters[5].Value = model.ES_CTIME;
			parameters[6].Value = model.ES_TID;
			parameters[7].Value = model.ES_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(string ES_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OT_ESSAY ");
			strSql.Append(" where ES_ID=@ES_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ES_ID", SqlDbType.VarChar,64)			};
			parameters[0].Value = ES_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string ES_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OT_ESSAY ");
			strSql.Append(" where ES_ID in ("+ES_IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public cfs.Model.OT_ESSAY GetModel(string ES_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ES_ID,ES_TYPE,ES_TITLE,ES_CONTENT,ES_HARD,ES_DELFLAG,ES_CTIME,ES_TID from OT_ESSAY ");
			strSql.Append(" where ES_ID=@ES_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ES_ID", SqlDbType.VarChar,64)			};
			parameters[0].Value = ES_ID;

			cfs.Model.OT_ESSAY model=new cfs.Model.OT_ESSAY();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ES_ID"]!=null && ds.Tables[0].Rows[0]["ES_ID"].ToString()!="")
				{
					model.ES_ID=ds.Tables[0].Rows[0]["ES_ID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ES_TYPE"]!=null && ds.Tables[0].Rows[0]["ES_TYPE"].ToString()!="")
				{
					model.ES_TYPE=ds.Tables[0].Rows[0]["ES_TYPE"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ES_TITLE"]!=null && ds.Tables[0].Rows[0]["ES_TITLE"].ToString()!="")
				{
					model.ES_TITLE=ds.Tables[0].Rows[0]["ES_TITLE"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ES_CONTENT"]!=null && ds.Tables[0].Rows[0]["ES_CONTENT"].ToString()!="")
				{
					model.ES_CONTENT=ds.Tables[0].Rows[0]["ES_CONTENT"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ES_HARD"]!=null && ds.Tables[0].Rows[0]["ES_HARD"].ToString()!="")
				{
					model.ES_HARD=int.Parse(ds.Tables[0].Rows[0]["ES_HARD"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ES_DELFLAG"]!=null && ds.Tables[0].Rows[0]["ES_DELFLAG"].ToString()!="")
				{
					model.ES_DELFLAG=int.Parse(ds.Tables[0].Rows[0]["ES_DELFLAG"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ES_CTIME"]!=null && ds.Tables[0].Rows[0]["ES_CTIME"].ToString()!="")
				{
					model.ES_CTIME=DateTime.Parse(ds.Tables[0].Rows[0]["ES_CTIME"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ES_TID"]!=null && ds.Tables[0].Rows[0]["ES_TID"].ToString()!="")
				{
					model.ES_TID=ds.Tables[0].Rows[0]["ES_TID"].ToString();
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ES_ID,ES_TYPE,ES_TITLE,ES_CONTENT,ES_HARD,ES_DELFLAG,ES_CTIME,ES_TID ");
			strSql.Append(" FROM OT_ESSAY ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ES_ID,ES_TYPE,ES_TITLE,ES_CONTENT,ES_HARD,ES_DELFLAG,ES_CTIME,ES_TID ");
			strSql.Append(" FROM OT_ESSAY ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM OT_ESSAY ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ES_ID desc");
			}
			strSql.Append(")AS Row, T.*  from OT_ESSAY T ");
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
			parameters[0].Value = "OT_ESSAY";
			parameters[1].Value = "ES_ID";
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

