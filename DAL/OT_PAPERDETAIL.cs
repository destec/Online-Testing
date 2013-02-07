using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace cfs.DAL
{
	/// <summary>
	/// 数据访问类:OT_PAPERDETAIL
	/// </summary>
	public partial class OT_PAPERDETAIL
	{
		public OT_PAPERDETAIL()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string PD_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OT_PAPERDETAIL");
			strSql.Append(" where PD_ID=@PD_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PD_ID", SqlDbType.VarChar,64)			};
			parameters[0].Value = PD_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(cfs.Model.OT_PAPERDETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OT_PAPERDETAIL(");
			strSql.Append("PD_ID,PD_SID,PD_QID,PD_NUM,PD_POINT)");
			strSql.Append(" values (");
			strSql.Append("@PD_ID,@PD_SID,@PD_QID,@PD_NUM,@PD_POINT)");
			SqlParameter[] parameters = {
					new SqlParameter("@PD_ID", SqlDbType.VarChar,64),
					new SqlParameter("@PD_SID", SqlDbType.VarChar,64),
					new SqlParameter("@PD_QID", SqlDbType.VarChar,64),
					new SqlParameter("@PD_NUM", SqlDbType.Int,4),
					new SqlParameter("@PD_POINT", SqlDbType.Decimal,9)};
			parameters[0].Value = model.PD_ID;
			parameters[1].Value = model.PD_SID;
			parameters[2].Value = model.PD_QID;
			parameters[3].Value = model.PD_NUM;
			parameters[4].Value = model.PD_POINT;

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
		public bool Update(cfs.Model.OT_PAPERDETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OT_PAPERDETAIL set ");
			strSql.Append("PD_SID=@PD_SID,");
			strSql.Append("PD_QID=@PD_QID,");
			strSql.Append("PD_NUM=@PD_NUM,");
			strSql.Append("PD_POINT=@PD_POINT");
			strSql.Append(" where PD_ID=@PD_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PD_SID", SqlDbType.VarChar,64),
					new SqlParameter("@PD_QID", SqlDbType.VarChar,64),
					new SqlParameter("@PD_NUM", SqlDbType.Int,4),
					new SqlParameter("@PD_POINT", SqlDbType.Decimal,9),
					new SqlParameter("@PD_ID", SqlDbType.VarChar,64)};
			parameters[0].Value = model.PD_SID;
			parameters[1].Value = model.PD_QID;
			parameters[2].Value = model.PD_NUM;
			parameters[3].Value = model.PD_POINT;
			parameters[4].Value = model.PD_ID;

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
		public bool Delete(string PD_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OT_PAPERDETAIL ");
			strSql.Append(" where PD_ID=@PD_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PD_ID", SqlDbType.VarChar,64)			};
			parameters[0].Value = PD_ID;

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
		public bool DeleteList(string PD_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OT_PAPERDETAIL ");
			strSql.Append(" where PD_ID in ("+PD_IDlist + ")  ");
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
		public cfs.Model.OT_PAPERDETAIL GetModel(string PD_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 PD_ID,PD_SID,PD_QID,PD_NUM,PD_POINT from OT_PAPERDETAIL ");
			strSql.Append(" where PD_ID=@PD_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PD_ID", SqlDbType.VarChar,64)			};
			parameters[0].Value = PD_ID;

			cfs.Model.OT_PAPERDETAIL model=new cfs.Model.OT_PAPERDETAIL();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["PD_ID"]!=null && ds.Tables[0].Rows[0]["PD_ID"].ToString()!="")
				{
					model.PD_ID=ds.Tables[0].Rows[0]["PD_ID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PD_SID"]!=null && ds.Tables[0].Rows[0]["PD_SID"].ToString()!="")
				{
					model.PD_SID=ds.Tables[0].Rows[0]["PD_SID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PD_QID"]!=null && ds.Tables[0].Rows[0]["PD_QID"].ToString()!="")
				{
					model.PD_QID=ds.Tables[0].Rows[0]["PD_QID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PD_NUM"]!=null && ds.Tables[0].Rows[0]["PD_NUM"].ToString()!="")
				{
					model.PD_NUM=int.Parse(ds.Tables[0].Rows[0]["PD_NUM"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PD_POINT"]!=null && ds.Tables[0].Rows[0]["PD_POINT"].ToString()!="")
				{
					model.PD_POINT=decimal.Parse(ds.Tables[0].Rows[0]["PD_POINT"].ToString());
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
			strSql.Append("select PD_ID,PD_SID,PD_QID,PD_NUM,PD_POINT ");
			strSql.Append(" FROM OT_PAPERDETAIL ");
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
			strSql.Append(" PD_ID,PD_SID,PD_QID,PD_NUM,PD_POINT ");
			strSql.Append(" FROM OT_PAPERDETAIL ");
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
			strSql.Append("select count(1) FROM OT_PAPERDETAIL ");
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
				strSql.Append("order by T.PD_ID desc");
			}
			strSql.Append(")AS Row, T.*  from OT_PAPERDETAIL T ");
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
			parameters[0].Value = "OT_PAPERDETAIL";
			parameters[1].Value = "PD_ID";
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

