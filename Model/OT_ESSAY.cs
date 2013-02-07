using System;
namespace cfs.Model
{
	/// <summary>
	/// OT_ESSAY:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OT_ESSAY
	{
		public OT_ESSAY()
		{}
		#region Model
		private string _es_id;
		private string _es_type;
		private string _es_title;
		private string _es_content;
		private int? _es_hard;
		private int _es_delflag;
		private DateTime _es_ctime;
		private string _es_tid;
		/// <summary>
		/// 
		/// </summary>
		public string ES_ID
		{
			set{ _es_id=value;}
			get{return _es_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ES_TYPE
		{
			set{ _es_type=value;}
			get{return _es_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ES_TITLE
		{
			set{ _es_title=value;}
			get{return _es_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ES_CONTENT
		{
			set{ _es_content=value;}
			get{return _es_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ES_HARD
		{
			set{ _es_hard=value;}
			get{return _es_hard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ES_DELFLAG
		{
			set{ _es_delflag=value;}
			get{return _es_delflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ES_CTIME
		{
			set{ _es_ctime=value;}
			get{return _es_ctime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ES_TID
		{
			set{ _es_tid=value;}
			get{return _es_tid;}
		}
		#endregion Model

	}
}

