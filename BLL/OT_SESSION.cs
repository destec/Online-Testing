using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using cfs.Model;
namespace cfs.BLL
{
	/// <summary>
	/// OT_SESSION
	/// </summary>
	public partial class OT_SESSION
	{
		private readonly cfs.DAL.OT_SESSION dal=new cfs.DAL.OT_SESSION();
		public OT_SESSION()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string SE_ID)
		{
			return dal.Exists(SE_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(cfs.Model.OT_SESSION model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(cfs.Model.OT_SESSION model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string SE_ID)
		{
			
			return dal.Delete(SE_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string SE_IDlist )
		{
			return dal.DeleteList(SE_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public cfs.Model.OT_SESSION GetModel(string SE_ID)
		{
			
			return dal.GetModel(SE_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public cfs.Model.OT_SESSION GetModelByCache(string SE_ID)
		{
			
			string CacheKey = "OT_SESSIONModel-" + SE_ID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(SE_ID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (cfs.Model.OT_SESSION)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<cfs.Model.OT_SESSION> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<cfs.Model.OT_SESSION> DataTableToList(DataTable dt)
		{
			List<cfs.Model.OT_SESSION> modelList = new List<cfs.Model.OT_SESSION>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				cfs.Model.OT_SESSION model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new cfs.Model.OT_SESSION();
					if(dt.Rows[n]["SE_ID"]!=null && dt.Rows[n]["SE_ID"].ToString()!="")
					{
					model.SE_ID=dt.Rows[n]["SE_ID"].ToString();
					}
					if(dt.Rows[n]["SE_TID"]!=null && dt.Rows[n]["SE_TID"].ToString()!="")
					{
					model.SE_TID=dt.Rows[n]["SE_TID"].ToString();
					}
					if(dt.Rows[n]["SE_CTIME"]!=null && dt.Rows[n]["SE_CTIME"].ToString()!="")
					{
						model.SE_CTIME=DateTime.Parse(dt.Rows[n]["SE_CTIME"].ToString());
					}
					if(dt.Rows[n]["SE_NAME"]!=null && dt.Rows[n]["SE_NAME"].ToString()!="")
					{
					model.SE_NAME=dt.Rows[n]["SE_NAME"].ToString();
					}
					if(dt.Rows[n]["SE_CONTENT"]!=null && dt.Rows[n]["SE_CONTENT"].ToString()!="")
					{
					model.SE_CONTENT=dt.Rows[n]["SE_CONTENT"].ToString();
					}
					if(dt.Rows[n]["SE_TTIME"]!=null && dt.Rows[n]["SE_TTIME"].ToString()!="")
					{
						model.SE_TTIME=DateTime.Parse(dt.Rows[n]["SE_TTIME"].ToString());
					}
					if(dt.Rows[n]["SE_DTIME"]!=null && dt.Rows[n]["SE_DTIME"].ToString()!="")
					{
					model.SE_DTIME=dt.Rows[n]["SE_DTIME"].ToString();
					}
					if(dt.Rows[n]["SE_DELFLAG"]!=null && dt.Rows[n]["SE_DELFLAG"].ToString()!="")
					{
						model.SE_DELFLAG=int.Parse(dt.Rows[n]["SE_DELFLAG"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

