using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using cfs.Model;
namespace cfs.BLL
{
	/// <summary>
	/// OT_PAPERDETAIL
	/// </summary>
	public partial class OT_PAPERDETAIL
	{
		private readonly cfs.DAL.OT_PAPERDETAIL dal=new cfs.DAL.OT_PAPERDETAIL();
		public OT_PAPERDETAIL()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string PD_ID)
		{
			return dal.Exists(PD_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(cfs.Model.OT_PAPERDETAIL model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(cfs.Model.OT_PAPERDETAIL model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string PD_ID)
		{
			
			return dal.Delete(PD_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string PD_IDlist )
		{
			return dal.DeleteList(PD_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public cfs.Model.OT_PAPERDETAIL GetModel(string PD_ID)
		{
			
			return dal.GetModel(PD_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public cfs.Model.OT_PAPERDETAIL GetModelByCache(string PD_ID)
		{
			
			string CacheKey = "OT_PAPERDETAILModel-" + PD_ID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(PD_ID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (cfs.Model.OT_PAPERDETAIL)objModel;
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
		public List<cfs.Model.OT_PAPERDETAIL> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<cfs.Model.OT_PAPERDETAIL> DataTableToList(DataTable dt)
		{
			List<cfs.Model.OT_PAPERDETAIL> modelList = new List<cfs.Model.OT_PAPERDETAIL>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				cfs.Model.OT_PAPERDETAIL model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new cfs.Model.OT_PAPERDETAIL();
					if(dt.Rows[n]["PD_ID"]!=null && dt.Rows[n]["PD_ID"].ToString()!="")
					{
					model.PD_ID=dt.Rows[n]["PD_ID"].ToString();
					}
					if(dt.Rows[n]["PD_SID"]!=null && dt.Rows[n]["PD_SID"].ToString()!="")
					{
					model.PD_SID=dt.Rows[n]["PD_SID"].ToString();
					}
					if(dt.Rows[n]["PD_QID"]!=null && dt.Rows[n]["PD_QID"].ToString()!="")
					{
					model.PD_QID=dt.Rows[n]["PD_QID"].ToString();
					}
					if(dt.Rows[n]["PD_NUM"]!=null && dt.Rows[n]["PD_NUM"].ToString()!="")
					{
						model.PD_NUM=int.Parse(dt.Rows[n]["PD_NUM"].ToString());
					}
					if(dt.Rows[n]["PD_POINT"]!=null && dt.Rows[n]["PD_POINT"].ToString()!="")
					{
						model.PD_POINT=decimal.Parse(dt.Rows[n]["PD_POINT"].ToString());
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

