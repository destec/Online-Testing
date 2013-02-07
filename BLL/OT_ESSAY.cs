using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using cfs.Model;
namespace cfs.BLL
{
	/// <summary>
	/// OT_ESSAY
	/// </summary>
	public partial class OT_ESSAY
	{
		private readonly cfs.DAL.OT_ESSAY dal=new cfs.DAL.OT_ESSAY();
		public OT_ESSAY()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ES_ID)
		{
			return dal.Exists(ES_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(cfs.Model.OT_ESSAY model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(cfs.Model.OT_ESSAY model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ES_ID)
		{
			
			return dal.Delete(ES_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string ES_IDlist )
		{
			return dal.DeleteList(ES_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public cfs.Model.OT_ESSAY GetModel(string ES_ID)
		{
			
			return dal.GetModel(ES_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public cfs.Model.OT_ESSAY GetModelByCache(string ES_ID)
		{
			
			string CacheKey = "OT_ESSAYModel-" + ES_ID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ES_ID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (cfs.Model.OT_ESSAY)objModel;
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
		public List<cfs.Model.OT_ESSAY> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<cfs.Model.OT_ESSAY> DataTableToList(DataTable dt)
		{
			List<cfs.Model.OT_ESSAY> modelList = new List<cfs.Model.OT_ESSAY>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				cfs.Model.OT_ESSAY model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new cfs.Model.OT_ESSAY();
					if(dt.Rows[n]["ES_ID"]!=null && dt.Rows[n]["ES_ID"].ToString()!="")
					{
					model.ES_ID=dt.Rows[n]["ES_ID"].ToString();
					}
					if(dt.Rows[n]["ES_TYPE"]!=null && dt.Rows[n]["ES_TYPE"].ToString()!="")
					{
					model.ES_TYPE=dt.Rows[n]["ES_TYPE"].ToString();
					}
					if(dt.Rows[n]["ES_TITLE"]!=null && dt.Rows[n]["ES_TITLE"].ToString()!="")
					{
					model.ES_TITLE=dt.Rows[n]["ES_TITLE"].ToString();
					}
					if(dt.Rows[n]["ES_CONTENT"]!=null && dt.Rows[n]["ES_CONTENT"].ToString()!="")
					{
					model.ES_CONTENT=dt.Rows[n]["ES_CONTENT"].ToString();
					}
					if(dt.Rows[n]["ES_HARD"]!=null && dt.Rows[n]["ES_HARD"].ToString()!="")
					{
						model.ES_HARD=int.Parse(dt.Rows[n]["ES_HARD"].ToString());
					}
					if(dt.Rows[n]["ES_DELFLAG"]!=null && dt.Rows[n]["ES_DELFLAG"].ToString()!="")
					{
						model.ES_DELFLAG=int.Parse(dt.Rows[n]["ES_DELFLAG"].ToString());
					}
					if(dt.Rows[n]["ES_CTIME"]!=null && dt.Rows[n]["ES_CTIME"].ToString()!="")
					{
						model.ES_CTIME=DateTime.Parse(dt.Rows[n]["ES_CTIME"].ToString());
					}
					if(dt.Rows[n]["ES_TID"]!=null && dt.Rows[n]["ES_TID"].ToString()!="")
					{
					model.ES_TID=dt.Rows[n]["ES_TID"].ToString();
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

