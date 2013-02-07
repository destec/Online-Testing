using System;
namespace cfs.Model
{
	/// <summary>
	/// OT_SESSION:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OT_SESSION
	{
		public OT_SESSION()
		{}
		#region Model
		private string _se_id;
		private string _se_tid;
		private DateTime _se_ctime;
		private string _se_name;
		private string _se_content;
		private DateTime? _se_ttime;
		private string _se_dtime;
		private int _se_delflag;
		/// <summary>
		/// 
		/// </summary>
		public string SE_ID
		{
			set{ _se_id=value;}
			get{return _se_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SE_TID
		{
			set{ _se_tid=value;}
			get{return _se_tid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime SE_CTIME
		{
			set{ _se_ctime=value;}
			get{return _se_ctime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SE_NAME
		{
			set{ _se_name=value;}
			get{return _se_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SE_CONTENT
		{
			set{ _se_content=value;}
			get{return _se_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SE_TTIME
		{
			set{ _se_ttime=value;}
			get{return _se_ttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SE_DTIME
		{
			set{ _se_dtime=value;}
			get{return _se_dtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SE_DELFLAG
		{
			set{ _se_delflag=value;}
			get{return _se_delflag;}
		}
		#endregion Model

	}
}

