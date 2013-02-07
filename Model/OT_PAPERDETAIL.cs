using System;
namespace cfs.Model
{
	/// <summary>
	/// OT_PAPERDETAIL:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OT_PAPERDETAIL
	{
		public OT_PAPERDETAIL()
		{}
		#region Model
		private string _pd_id;
		private string _pd_sid;
		private string _pd_qid;
		private int? _pd_num;
		private decimal? _pd_point;
		/// <summary>
		/// 
		/// </summary>
		public string PD_ID
		{
			set{ _pd_id=value;}
			get{return _pd_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PD_SID
		{
			set{ _pd_sid=value;}
			get{return _pd_sid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PD_QID
		{
			set{ _pd_qid=value;}
			get{return _pd_qid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PD_NUM
		{
			set{ _pd_num=value;}
			get{return _pd_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PD_POINT
		{
			set{ _pd_point=value;}
			get{return _pd_point;}
		}
		#endregion Model

	}
}

