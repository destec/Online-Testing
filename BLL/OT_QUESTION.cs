using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using cfs.Model;
namespace cfs.BLL
{
    /// <summary>
    /// OT_QUESTION
    /// </summary>
    public partial class OT_QUESTION
    {
        private readonly cfs.DAL.OT_QUESTION dal = new cfs.DAL.OT_QUESTION();
        public OT_QUESTION()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string QS_ID)
        {
            return dal.Exists(QS_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(cfs.Model.OT_QUESTION model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(cfs.Model.OT_QUESTION model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string QS_ID)
        {

            return dal.Delete(QS_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string QS_IDlist)
        {
            return dal.DeleteList(QS_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public cfs.Model.OT_QUESTION GetModel(string QS_ID)
        {

            return dal.GetModel(QS_ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public cfs.Model.OT_QUESTION GetModelByCache(string QS_ID)
        {

            string CacheKey = "OT_QUESTIONModel-" + QS_ID;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(QS_ID);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (cfs.Model.OT_QUESTION)objModel;
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
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<cfs.Model.OT_QUESTION> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<cfs.Model.OT_QUESTION> DataTableToList(DataTable dt)
        {
            List<cfs.Model.OT_QUESTION> modelList = new List<cfs.Model.OT_QUESTION>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                cfs.Model.OT_QUESTION model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new cfs.Model.OT_QUESTION();
                    if (dt.Rows[n]["QS_ID"] != null && dt.Rows[n]["QS_ID"].ToString() != "")
                    {
                        model.QS_ID = dt.Rows[n]["QS_ID"].ToString();
                    }
                    if (dt.Rows[n]["QS_TYPE"] != null && dt.Rows[n]["QS_TYPE"].ToString() != "")
                    {
                        model.QS_TYPE = dt.Rows[n]["QS_TYPE"].ToString();
                    }
                    if (dt.Rows[n]["QS_EID"] != null && dt.Rows[n]["QS_EID"].ToString() != "")
                    {
                        model.QS_EID = dt.Rows[n]["QS_EID"].ToString();
                    }
                    if (dt.Rows[n]["QS_CONTENT"] != null && dt.Rows[n]["QS_CONTENT"].ToString() != "")
                    {
                        model.QS_CONTENT = dt.Rows[n]["QS_CONTENT"].ToString();
                    }
                    if (dt.Rows[n]["QS_CHOICE_A"] != null && dt.Rows[n]["QS_CHOICE_A"].ToString() != "")
                    {
                        model.QS_CHOICE_A = dt.Rows[n]["QS_CHOICE_A"].ToString();
                    }
                    if (dt.Rows[n]["QS_CHOICE_B"] != null && dt.Rows[n]["QS_CHOICE_B"].ToString() != "")
                    {
                        model.QS_CHOICE_B = dt.Rows[n]["QS_CHOICE_B"].ToString();
                    }
                    if (dt.Rows[n]["QS_CHOICE_C"] != null && dt.Rows[n]["QS_CHOICE_C"].ToString() != "")
                    {
                        model.QS_CHOICE_C = dt.Rows[n]["QS_CHOICE_C"].ToString();
                    }
                    if (dt.Rows[n]["QS_CHOICE_D"] != null && dt.Rows[n]["QS_CHOICE_D"].ToString() != "")
                    {
                        model.QS_CHOICE_D = dt.Rows[n]["QS_CHOICE_D"].ToString();
                    }
                    if (dt.Rows[n]["QS_CHOICE_COR"] != null && dt.Rows[n]["QS_CHOICE_COR"].ToString() != "")
                    {
                        model.QS_CHOICE_COR = int.Parse(dt.Rows[n]["QS_CHOICE_COR"].ToString());
                    }
                    if (dt.Rows[n]["QS_COR_EXPLAINATION"] != null && dt.Rows[n]["QS_COR_EXPLAINATION"].ToString() != "")
                    {
                        model.QS_COR_EXPLAINATION = dt.Rows[n]["QS_COR_EXPLAINATION"].ToString();
                    }
                    if (dt.Rows[n]["QS_DELFLAG"] != null && dt.Rows[n]["QS_DELFLAG"].ToString() != "")
                    {
                        model.QS_DELFLAG = int.Parse(dt.Rows[n]["QS_DELFLAG"].ToString());
                    }
                    if (dt.Rows[n]["QS_HARD"] != null && dt.Rows[n]["QS_HARD"].ToString() != "")
                    {
                        model.QS_HARD = int.Parse(dt.Rows[n]["QS_HARD"].ToString());
                    }
                    if (dt.Rows[n]["QS_CTIME"] != null && dt.Rows[n]["QS_CTIME"].ToString() != "")
                    {
                        model.QS_CTIME = DateTime.Parse(dt.Rows[n]["QS_CTIME"].ToString());
                    }
                    if (dt.Rows[n]["QS_TID"] != null && dt.Rows[n]["QS_TID"].ToString() != "")
                    {
                        model.QS_TID = dt.Rows[n]["QS_TID"].ToString();
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
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
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

