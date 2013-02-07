using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace cfs.DAL
{
	/// <summary>
	/// 数据访问类:OT_SESSION
	/// </summary>
	public partial class OT_SESSION
	{
		public OT_SESSION()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string SE_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OT_SESSION");
			strSql.Append(" where SE_ID=@SE_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@SE_ID", SqlDbType.VarChar,64)			};
			parameters[0].Value = SE_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(cfs.Model.OT_SESSION model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OT_SESSION(");
			strSql.Append("SE_ID,SE_TID,SE_CTIME,SE_NAME,SE_CONTENT,SE_TTIME,SE_DTIME,SE_DELFLAG)");
			strSql.Append(" values (");
			strSql.Append("@SE_ID,@SE_TID,@SE_CTIME,@SE_NAME,@SE_CONTENT,@SE_TTIME,@SE_DTIME,@SE_DELFLAG)");
			SqlParameter[] parameters = {
					new SqlParameter("@SE_ID", SqlDbType.VarChar,64),
					new SqlParameter("@SE_TID", SqlDbType.VarChar,50),
					new SqlParameter("@SE_CTIME", SqlDbType.DateTime),
					new SqlParameter("@SE_NAME", SqlDbType.NVarChar,500),
					new SqlParameter("@SE_CONTENT", SqlDbType.Text),
					new SqlParameter("@SE_TTIME", SqlDbType.DateTime),
					new SqlParameter("@SE_DTIME", SqlDbType.VarChar,50),
					new SqlParameter("@SE_DELFLAG", SqlDbType.Int,4)};
			parameters[0].Value = model.SE_ID;
			parameters[1].Value = model.SE_TID;
			parameters[2].Value = model.SE_CTIME;
			parameters[3].Value = model.SE_NAME;
			parameters[4].Value = model.SE_CONTENT;
			parameters[5].Value = model.SE_TTIME;
			parameters[6].Value = model.SE_DTIME;
			parameters[7].Value = model.SE_DELFLAG;

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
		public bool Update(cfs.Model.OT_SESSION model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OT_SESSION set ");
			strSql.Append("SE_TID=@SE_TID,");
			strSql.Append("SE_CTIME=@SE_CTIME,");
			strSql.Append("SE_NAME=@SE_NAME,");
			strSql.Append("SE_CONTENT=@SE_CONTENT,");
			strSql.Append("SE_TTIME=@SE_TTIME,");
			strSql.Append("SE_DTIME=@SE_DTIME,");
			strSql.Append("SE_DELFLAG=@SE_DELFLAG");
			strSql.Append(" where SE_ID=@SE_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@SE_TID", SqlDbType.VarChar,50),
					new SqlParameter("@SE_CTIME", SqlDbType.DateTime),
					new SqlParameter("@SE_NAME", SqlDbType.NVarChar,500),
					new SqlParameter("@SE_CONTENT", SqlDbType.Text),
					new SqlParameter("@SE_TTIME", SqlDbType.DateTime),
					new SqlParameter("@SE_DTIME", SqlDbType.VarChar,50),
					new SqlParameter("@SE_DELFLAG", SqlDbType.Int,4),
					new SqlParameter("@SE_ID", SqlDbType.VarChar,64)};
			parameters[0].Value = model.SE_TID;
			parameters[1].Value = model.SE_CTIME;
			parameters[2].Value = model.SE_NAME;
			parameters[3].Value = model.SE_CONTENT;
			parameters[4].Value = model.SE_TTIME;
			parameters[5].Value = model.SE_DTIME;
			parameters[6].Value = model.SE_DELFLAG;
			parameters[7].Value = model.SE_ID;

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
		public bool Delete(string SE_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OT_SESSION ");
			strSql.Append(" where SE_ID=@SE_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@SE_ID", SqlDbType.VarChar,64)			};
			parameters[0].Value = SE_ID;

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
		public bool DeleteList(string SE_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OT_SESSION ");
			strSql.Append(" where SE_ID in ("+SE_IDlist + ")  ");
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
		public cfs.Model.OT_SESSION GetModel(string SE_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SE_ID,SE_TID,SE_CTIME,SE_NAME,SE_CONTENT,SE_TTIME,SE_DTIME,SE_DELFLAG from OT_SESSION ");
			strSql.Append(" where SE_ID=@SE_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@SE_ID", SqlDbType.VarChar,64)			};
			parameters[0].Value = SE_ID;

			cfs.Model.OT_SESSION model=new cfs.Model.OT_SESSION();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["SE_ID"]!=null && ds.Tables[0].Rows[0]["SE_ID"].ToString()!="")
				{
					model.SE_ID=ds.Tables[0].Rows[0]["SE_ID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SE_TID"]!=null && ds.Tables[0].Rows[0]["SE_TID"].ToString()!="")
				{
					model.SE_TID=ds.Tables[0].Rows[0]["SE_TID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SE_CTIME"]!=null && ds.Tables[0].Rows[0]["SE_CTIME"].ToString()!="")
				{
					model.SE_CTIME=DateTime.Parse(ds.Tables[0].Rows[0]["SE_CTIME"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SE_NAME"]!=null && ds.Tables[0].Rows[0]["SE_NAME"].ToString()!="")
				{
					model.SE_NAME=ds.Tables[0].Rows[0]["SE_NAME"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SE_CONTENT"]!=null && ds.Tables[0].Rows[0]["SE_CONTENT"].ToString()!="")
				{
					model.SE_CONTENT=ds.Tables[0].Rows[0]["SE_CONTENT"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SE_TTIME"]!=null && ds.Tables[0].Rows[0]["SE_TTIME"].ToString()!="")
				{
					model.SE_TTIME=DateTime.Parse(ds.Tables[0].Rows[0]["SE_TTIME"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SE_DTIME"]!=null && ds.Tables[0].Rows[0]["SE_DTIME"].ToString()!="")
				{
					model.SE_DTIME=ds.Tables[0].Rows[0]["SE_DTIME"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SE_DELFLAG"]!=null && ds.Tables[0].Rows[0]["SE_DELFLAG"].ToString()!="")
				{
					model.SE_DELFLAG=int.Parse(ds.Tables[0].Rows[0]["SE_DELFLAG"].ToString());
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
			strSql.Append("select SE_ID,SE_TID,SE_CTIME,SE_NAME,SE_CONTENT,SE_TTIME,SE_DTIME,SE_DELFLAG ");
			strSql.Append(" FROM OT_SESSION ");
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
			strSql.Append(" SE_ID,SE_TID,SE_CTIME,SE_NAME,SE_CONTENT,SE_TTIME,SE_DTIME,SE_DELFLAG ");
			strSql.Append(" FROM OT_SESSION ");
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
			strSql.Append("select count(1) FROM OT_SESSION ");
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
				strSql.Append("order by T.SE_ID desc");
			}
			strSql.Append(")AS Row, T.*  from OT_SESSION T ");
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
			parameters[0].Value = "OT_SESSION";
			parameters[1].Value = "SE_ID";
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

