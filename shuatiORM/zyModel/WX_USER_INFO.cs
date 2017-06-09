using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;


	/// <summary>
	/// 类WX_USER_INFO。
	/// </summary>
	[Serializable]
	public partial class WX_USER_INFO
	{
		public WX_USER_INFO()
		{}
		#region Model
		private int _id;
		private string _open_id;
		private string _user_code;
		private string _nick_name;
		private int? _sex;
		private string _city;
		private string _country;
		private string _head_img_url;
		private int? _subscribe;
		private string _subscribe_time;
		private string _remark;
		private int? _groupid;
		private string _user_phone;
		private string _PROVINCE;
		private string _LANGUAGE;
		private string _rmrk3;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPEN_ID
		{
			set{ _open_id=value;}
			get{return _open_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USER_CODE
		{
			set{ _user_code=value;}
			get{return _user_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NICK_NAME
		{
			set{ _nick_name=value;}
			get{return _nick_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SEX
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CITY
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COUNTRY
		{
			set{ _country=value;}
			get{return _country;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HEAD_IMG_URL
		{
			set{ _head_img_url=value;}
			get{return _head_img_url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SUBSCRIBE
		{
			set{ _subscribe=value;}
			get{return _subscribe;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUBSCRIBE_TIME
		{
			set{ _subscribe_time=value;}
			get{return _subscribe_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GROUPID
		{
			set{ _groupid=value;}
			get{return _groupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USER_PHONE
		{
			set{ _user_phone=value;}
			get{return _user_phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PROVINCE
		{
			set{ _PROVINCE=value;}
			get{return _PROVINCE;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LANGUAGE
		{
			set{ _LANGUAGE=value;}
			get{return _LANGUAGE;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RMRK3
		{
			set{ _rmrk3=value;}
			get{return _rmrk3;}
		}
		#endregion Model


		#region  Method


        public int AddUser(WX_USER_INFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [WX_USER_INFO] (");
            strSql.Append("OPEN_ID,USER_CODE,NICK_NAME,SEX,CITY,COUNTRY,HEAD_IMG_URL,SUBSCRIBE,SUBSCRIBE_TIME,REMARK,GROUPID,USER_PHONE,PROVINCE,LANGUAGE,RMRK3)");
            strSql.Append(" values (");
            strSql.Append("@OPEN_ID,@USER_CODE,@NICK_NAME,@SEX,@CITY,@COUNTRY,@HEAD_IMG_URL,@SUBSCRIBE,@SUBSCRIBE_TIME,@REMARK,@GROUPID,@USER_PHONE,@PROVINCE,@LANGUAGE,@RMRK3)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@OPEN_ID", SqlDbType.VarChar,32),
					new SqlParameter("@USER_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@NICK_NAME", SqlDbType.VarChar,32),
					new SqlParameter("@SEX", SqlDbType.Int,4),
					new SqlParameter("@CITY", SqlDbType.VarChar,32),
					new SqlParameter("@COUNTRY", SqlDbType.VarChar,32),
					new SqlParameter("@HEAD_IMG_URL", SqlDbType.VarChar,-1),
					new SqlParameter("@SUBSCRIBE", SqlDbType.Int,4),
					new SqlParameter("@SUBSCRIBE_TIME", SqlDbType.VarChar,32),
					new SqlParameter("@REMARK", SqlDbType.VarChar,32),
					new SqlParameter("@GROUPID", SqlDbType.Int,4),
					new SqlParameter("@USER_PHONE", SqlDbType.VarChar,32),
					new SqlParameter("@PROVINCE", SqlDbType.VarChar,128),
					new SqlParameter("@LANGUAGE", SqlDbType.VarChar,128),
					new SqlParameter("@RMRK3", SqlDbType.VarChar,128)};
            parameters[0].Value = OPEN_ID;
            parameters[1].Value = USER_CODE;
            parameters[2].Value = NICK_NAME;
            parameters[3].Value = SEX;
            parameters[4].Value = CITY;
            parameters[5].Value = COUNTRY;
            parameters[6].Value = HEAD_IMG_URL;
            parameters[7].Value = SUBSCRIBE;
            parameters[8].Value = SUBSCRIBE_TIME;
            parameters[9].Value = REMARK;
            parameters[10].Value = GROUPID;
            parameters[11].Value = USER_PHONE;
            parameters[12].Value = PROVINCE;
            parameters[13].Value = LANGUAGE;
            parameters[14].Value = RMRK3;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
		/// 得到一个对象实体
		/// </summary>
		public WX_USER_INFO(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,OPEN_ID,USER_CODE,NICK_NAME,SEX,CITY,COUNTRY,HEAD_IMG_URL,SUBSCRIBE,SUBSCRIBE_TIME,REMARK,GROUPID,USER_PHONE,PROVINCE,LANGUAGE,RMRK3 ");
			strSql.Append(" FROM [WX_USER_INFO] ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					this.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OPEN_ID"]!=null)
				{
					this.OPEN_ID=ds.Tables[0].Rows[0]["OPEN_ID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["USER_CODE"]!=null)
				{
					this.USER_CODE=ds.Tables[0].Rows[0]["USER_CODE"].ToString();
				}
				if(ds.Tables[0].Rows[0]["NICK_NAME"]!=null)
				{
					this.NICK_NAME=ds.Tables[0].Rows[0]["NICK_NAME"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SEX"]!=null && ds.Tables[0].Rows[0]["SEX"].ToString()!="")
				{
					this.SEX=int.Parse(ds.Tables[0].Rows[0]["SEX"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CITY"]!=null)
				{
					this.CITY=ds.Tables[0].Rows[0]["CITY"].ToString();
				}
				if(ds.Tables[0].Rows[0]["COUNTRY"]!=null)
				{
					this.COUNTRY=ds.Tables[0].Rows[0]["COUNTRY"].ToString();
				}
				if(ds.Tables[0].Rows[0]["HEAD_IMG_URL"]!=null)
				{
					this.HEAD_IMG_URL=ds.Tables[0].Rows[0]["HEAD_IMG_URL"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SUBSCRIBE"]!=null && ds.Tables[0].Rows[0]["SUBSCRIBE"].ToString()!="")
				{
					this.SUBSCRIBE=int.Parse(ds.Tables[0].Rows[0]["SUBSCRIBE"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SUBSCRIBE_TIME"]!=null)
				{
					this.SUBSCRIBE_TIME=ds.Tables[0].Rows[0]["SUBSCRIBE_TIME"].ToString();
				}
				if(ds.Tables[0].Rows[0]["REMARK"]!=null)
				{
					this.REMARK=ds.Tables[0].Rows[0]["REMARK"].ToString();
				}
				if(ds.Tables[0].Rows[0]["GROUPID"]!=null && ds.Tables[0].Rows[0]["GROUPID"].ToString()!="")
				{
					this.GROUPID=int.Parse(ds.Tables[0].Rows[0]["GROUPID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["USER_PHONE"]!=null)
				{
					this.USER_PHONE=ds.Tables[0].Rows[0]["USER_PHONE"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PROVINCE"]!=null)
				{
					this.PROVINCE=ds.Tables[0].Rows[0]["PROVINCE"].ToString();
				}
				if(ds.Tables[0].Rows[0]["LANGUAGE"]!=null)
				{
					this.LANGUAGE=ds.Tables[0].Rows[0]["LANGUAGE"].ToString();
				}
				if(ds.Tables[0].Rows[0]["RMRK3"]!=null)
				{
					this.RMRK3=ds.Tables[0].Rows[0]["RMRK3"].ToString();
				}
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "WX_USER_INFO"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [WX_USER_INFO]");
			strSql.Append(" where ID=@ID ");

			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        public bool ExistsUser(string OPEN_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [WX_USER_INFO]");
            strSql.Append(" where OPEN_ID=@OPEN_ID ");

            SqlParameter[] parameters = {
					new SqlParameter("@OPEN_ID", SqlDbType.VarChar,32)};
            parameters[0].Value = OPEN_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [WX_USER_INFO] (");
			strSql.Append("OPEN_ID,USER_CODE,NICK_NAME,SEX,CITY,COUNTRY,HEAD_IMG_URL,SUBSCRIBE,SUBSCRIBE_TIME,REMARK,GROUPID,USER_PHONE,PROVINCE,LANGUAGE,RMRK3)");
			strSql.Append(" values (");
			strSql.Append("@OPEN_ID,@USER_CODE,@NICK_NAME,@SEX,@CITY,@COUNTRY,@HEAD_IMG_URL,@SUBSCRIBE,@SUBSCRIBE_TIME,@REMARK,@GROUPID,@USER_PHONE,@PROVINCE,@LANGUAGE,@RMRK3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@OPEN_ID", SqlDbType.VarChar,32),
					new SqlParameter("@USER_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@NICK_NAME", SqlDbType.VarChar,32),
					new SqlParameter("@SEX", SqlDbType.Int,4),
					new SqlParameter("@CITY", SqlDbType.VarChar,32),
					new SqlParameter("@COUNTRY", SqlDbType.VarChar,32),
					new SqlParameter("@HEAD_IMG_URL", SqlDbType.VarChar,-1),
					new SqlParameter("@SUBSCRIBE", SqlDbType.Int,4),
					new SqlParameter("@SUBSCRIBE_TIME", SqlDbType.VarChar,32),
					new SqlParameter("@REMARK", SqlDbType.VarChar,32),
					new SqlParameter("@GROUPID", SqlDbType.Int,4),
					new SqlParameter("@USER_PHONE", SqlDbType.VarChar,32),
					new SqlParameter("@PROVINCE", SqlDbType.VarChar,128),
					new SqlParameter("@LANGUAGE", SqlDbType.VarChar,128),
					new SqlParameter("@RMRK3", SqlDbType.VarChar,128)};
			parameters[0].Value = OPEN_ID;
			parameters[1].Value = USER_CODE;
			parameters[2].Value = NICK_NAME;
			parameters[3].Value = SEX;
			parameters[4].Value = CITY;
			parameters[5].Value = COUNTRY;
			parameters[6].Value = HEAD_IMG_URL;
			parameters[7].Value = SUBSCRIBE;
			parameters[8].Value = SUBSCRIBE_TIME;
			parameters[9].Value = REMARK;
			parameters[10].Value = GROUPID;
			parameters[11].Value = USER_PHONE;
			parameters[12].Value = PROVINCE;
			parameters[13].Value = LANGUAGE;
			parameters[14].Value = RMRK3;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [WX_USER_INFO] set ");
			strSql.Append("OPEN_ID=@OPEN_ID,");
			strSql.Append("USER_CODE=@USER_CODE,");
			strSql.Append("NICK_NAME=@NICK_NAME,");
			strSql.Append("SEX=@SEX,");
			strSql.Append("CITY=@CITY,");
			strSql.Append("COUNTRY=@COUNTRY,");
			strSql.Append("HEAD_IMG_URL=@HEAD_IMG_URL,");
			strSql.Append("SUBSCRIBE=@SUBSCRIBE,");
			strSql.Append("SUBSCRIBE_TIME=@SUBSCRIBE_TIME,");
			strSql.Append("REMARK=@REMARK,");
			strSql.Append("GROUPID=@GROUPID,");
			strSql.Append("USER_PHONE=@USER_PHONE,");
			strSql.Append("PROVINCE=@PROVINCE,");
			strSql.Append("LANGUAGE=@LANGUAGE,");
			strSql.Append("RMRK3=@RMRK3");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OPEN_ID", SqlDbType.VarChar,32),
					new SqlParameter("@USER_CODE", SqlDbType.VarChar,32),
					new SqlParameter("@NICK_NAME", SqlDbType.VarChar,32),
					new SqlParameter("@SEX", SqlDbType.Int,4),
					new SqlParameter("@CITY", SqlDbType.VarChar,32),
					new SqlParameter("@COUNTRY", SqlDbType.VarChar,32),
					new SqlParameter("@HEAD_IMG_URL", SqlDbType.VarChar,-1),
					new SqlParameter("@SUBSCRIBE", SqlDbType.Int,4),
					new SqlParameter("@SUBSCRIBE_TIME", SqlDbType.VarChar,32),
					new SqlParameter("@REMARK", SqlDbType.VarChar,32),
					new SqlParameter("@GROUPID", SqlDbType.Int,4),
					new SqlParameter("@USER_PHONE", SqlDbType.VarChar,32),
					new SqlParameter("@PROVINCE", SqlDbType.VarChar,128),
					new SqlParameter("@LANGUAGE", SqlDbType.VarChar,128),
					new SqlParameter("@RMRK3", SqlDbType.VarChar,128),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = OPEN_ID;
			parameters[1].Value = USER_CODE;
			parameters[2].Value = NICK_NAME;
			parameters[3].Value = SEX;
			parameters[4].Value = CITY;
			parameters[5].Value = COUNTRY;
			parameters[6].Value = HEAD_IMG_URL;
			parameters[7].Value = SUBSCRIBE;
			parameters[8].Value = SUBSCRIBE_TIME;
			parameters[9].Value = REMARK;
			parameters[10].Value = GROUPID;
			parameters[11].Value = USER_PHONE;
			parameters[12].Value = PROVINCE;
			parameters[13].Value = LANGUAGE;
			parameters[14].Value = RMRK3;
			parameters[15].Value = ID;

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
		public bool Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from [WX_USER_INFO] ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

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
		/// 得到一个对象实体
		/// </summary>
		public void GetModel(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,OPEN_ID,USER_CODE,NICK_NAME,SEX,CITY,COUNTRY,HEAD_IMG_URL,SUBSCRIBE,SUBSCRIBE_TIME,REMARK,GROUPID,USER_PHONE,PROVINCE,LANGUAGE,RMRK3 ");
			strSql.Append(" FROM [WX_USER_INFO] ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					this.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OPEN_ID"]!=null )
				{
					this.OPEN_ID=ds.Tables[0].Rows[0]["OPEN_ID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["USER_CODE"]!=null )
				{
					this.USER_CODE=ds.Tables[0].Rows[0]["USER_CODE"].ToString();
				}
				if(ds.Tables[0].Rows[0]["NICK_NAME"]!=null )
				{
					this.NICK_NAME=ds.Tables[0].Rows[0]["NICK_NAME"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SEX"]!=null && ds.Tables[0].Rows[0]["SEX"].ToString()!="")
				{
					this.SEX=int.Parse(ds.Tables[0].Rows[0]["SEX"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CITY"]!=null )
				{
					this.CITY=ds.Tables[0].Rows[0]["CITY"].ToString();
				}
				if(ds.Tables[0].Rows[0]["COUNTRY"]!=null )
				{
					this.COUNTRY=ds.Tables[0].Rows[0]["COUNTRY"].ToString();
				}
				if(ds.Tables[0].Rows[0]["HEAD_IMG_URL"]!=null )
				{
					this.HEAD_IMG_URL=ds.Tables[0].Rows[0]["HEAD_IMG_URL"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SUBSCRIBE"]!=null && ds.Tables[0].Rows[0]["SUBSCRIBE"].ToString()!="")
				{
					this.SUBSCRIBE=int.Parse(ds.Tables[0].Rows[0]["SUBSCRIBE"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SUBSCRIBE_TIME"]!=null )
				{
					this.SUBSCRIBE_TIME=ds.Tables[0].Rows[0]["SUBSCRIBE_TIME"].ToString();
				}
				if(ds.Tables[0].Rows[0]["REMARK"]!=null )
				{
					this.REMARK=ds.Tables[0].Rows[0]["REMARK"].ToString();
				}
				if(ds.Tables[0].Rows[0]["GROUPID"]!=null && ds.Tables[0].Rows[0]["GROUPID"].ToString()!="")
				{
					this.GROUPID=int.Parse(ds.Tables[0].Rows[0]["GROUPID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["USER_PHONE"]!=null )
				{
					this.USER_PHONE=ds.Tables[0].Rows[0]["USER_PHONE"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PROVINCE"]!=null )
				{
					this.PROVINCE=ds.Tables[0].Rows[0]["PROVINCE"].ToString();
				}
				if(ds.Tables[0].Rows[0]["LANGUAGE"]!=null )
				{
					this.LANGUAGE=ds.Tables[0].Rows[0]["LANGUAGE"].ToString();
				}
				if(ds.Tables[0].Rows[0]["RMRK3"]!=null )
				{
					this.RMRK3=ds.Tables[0].Rows[0]["RMRK3"].ToString();
				}
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM [WX_USER_INFO] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method

        
    }


