using System;
namespace cfs.Model
{
    /// <summary>
    /// OT_QUESTION:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class OT_QUESTION
    {
        public OT_QUESTION()
        { }
        #region Model
        private string _qs_id;
        private string _qs_type;
        private string _qs_eid;
        private string _qs_content;
        private string _qs_choice_a;
        private string _qs_choice_b;
        private string _qs_choice_c;
        private string _qs_choice_d;
        private int? _qs_choice_cor;
        private string _qs_cor_explaination;
        private int _qs_delflag;
        private int? _qs_hard;
        private DateTime _qs_ctime;
        private string _qs_tid;
        /// <summary>
        /// 
        /// </summary>
        public string QS_ID
        {
            set { _qs_id = value; }
            get { return _qs_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QS_TYPE
        {
            set { _qs_type = value; }
            get { return _qs_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QS_EID
        {
            set { _qs_eid = value; }
            get { return _qs_eid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QS_CONTENT
        {
            set { _qs_content = value; }
            get { return _qs_content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QS_CHOICE_A
        {
            set { _qs_choice_a = value; }
            get { return _qs_choice_a; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QS_CHOICE_B
        {
            set { _qs_choice_b = value; }
            get { return _qs_choice_b; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QS_CHOICE_C
        {
            set { _qs_choice_c = value; }
            get { return _qs_choice_c; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QS_CHOICE_D
        {
            set { _qs_choice_d = value; }
            get { return _qs_choice_d; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? QS_CHOICE_COR
        {
            set { _qs_choice_cor = value; }
            get { return _qs_choice_cor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QS_COR_EXPLAINATION
        {
            set { _qs_cor_explaination = value; }
            get { return _qs_cor_explaination; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int QS_DELFLAG
        {
            set { _qs_delflag = value; }
            get { return _qs_delflag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? QS_HARD
        {
            set { _qs_hard = value; }
            get { return _qs_hard; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime QS_CTIME
        {
            set { _qs_ctime = value; }
            get { return _qs_ctime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QS_TID
        {
            set { _qs_tid = value; }
            get { return _qs_tid; }
        }
        #endregion Model

    }
}

