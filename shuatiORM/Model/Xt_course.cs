/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:30
  Description:    数据表Xt_course对应的业务逻辑层Xt_course
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xt_course_Entity:Xt_course
 * 
************************************************************/
/************************************************************
SQL代码：
select Uuid,Id,CreateTime,ModifyTime,Weix_id,College_id,Name,Major,Active,Is_delete,Is_set_group,Weight_config,Owner,Realname,Start_time,End_time,Is_display_score,Is_display_answer,Teacher_id,Course_code,Courser_caption,Courser_content,Category,Add_method,Student_managers,Student_count,Pass_count,Member_num,Course_time,Browse_author,Category_ids,Category_names,Head_img,Is_file from Xt_course
delete from Xt_course
INSERT INTO Xt_course (Uuid,Id,CreateTime,ModifyTime,Weix_id,College_id,Name,Major,Active,Is_delete,Is_set_group,Weight_config,Owner,Realname,Start_time,End_time,Is_display_score,Is_display_answer,Teacher_id,Course_code,Courser_caption,Courser_content,Category,Add_method,Student_managers,Student_count,Pass_count,Member_num,Course_time,Browse_author,Category_ids,Category_names,Head_img,Is_file)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE Xt_course SET ...
变量赋值代码：
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Id = valObj2.Id;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.Weix_id = valObj2.Weix_id;
        valObj.College_id = valObj2.College_id;
        valObj.Name = valObj2.Name;
        valObj.Major = valObj2.Major;
        valObj.Active = valObj2.Active;
        valObj.Is_delete = valObj2.Is_delete;
        valObj.Is_set_group = valObj2.Is_set_group;
        valObj.Weight_config = valObj2.Weight_config;
        valObj.Owner = valObj2.Owner;
        valObj.Realname = valObj2.Realname;
        valObj.Start_time = valObj2.Start_time;
        valObj.End_time = valObj2.End_time;
        valObj.Is_display_score = valObj2.Is_display_score;
        valObj.Is_display_answer = valObj2.Is_display_answer;
        valObj.Teacher_id = valObj2.Teacher_id;
        valObj.Course_code = valObj2.Course_code;
        valObj.Courser_caption = valObj2.Courser_caption;
        valObj.Courser_content = valObj2.Courser_content;
        valObj.Category = valObj2.Category;
        valObj.Add_method = valObj2.Add_method;
        valObj.Student_managers = valObj2.Student_managers;
        valObj.Student_count = valObj2.Student_count;
        valObj.Pass_count = valObj2.Pass_count;
        valObj.Member_num = valObj2.Member_num;
        valObj.Course_time = valObj2.Course_time;
        valObj.Browse_author = valObj2.Browse_author;
        valObj.Category_ids = valObj2.Category_ids;
        valObj.Category_names = valObj2.Category_names;
        valObj.Head_img = valObj2.Head_img;
        valObj.Is_file = valObj2.Is_file; 
        valObj.Uuid = "";
        valObj.Id = "";
        valObj.CreateTime = "";
        valObj.ModifyTime = "";
        valObj.Weix_id = "";
        valObj.College_id = "";
        valObj.Name = "";
        valObj.Major = "";
        valObj.Active = "";
        valObj.Is_delete = "";
        valObj.Is_set_group = "";
        valObj.Weight_config = "";
        valObj.Owner = "";
        valObj.Realname = "";
        valObj.Start_time = "";
        valObj.End_time = "";
        valObj.Is_display_score = "";
        valObj.Is_display_answer = "";
        valObj.Teacher_id = "";
        valObj.Course_code = "";
        valObj.Courser_caption = "";
        valObj.Courser_content = "";
        valObj.Category = "";
        valObj.Add_method = "";
        valObj.Student_managers = "";
        valObj.Student_count = "";
        valObj.Pass_count = "";
        valObj.Member_num = "";
        valObj.Course_time = "";
        valObj.Browse_author = "";
        valObj.Category_ids = "";
        valObj.Category_names = "";
        valObj.Head_img = "";
        valObj.Is_file = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Id": $("#txt_Id").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "Weix_id": $("#txt_Weix_id").val(),
        "College_id": $("#txt_College_id").val(),
        "Name": $("#txt_Name").val(),
        "Major": $("#txt_Major").val(),
        "Active": $("#txt_Active").val(),
        "Is_delete": $("#txt_Is_delete").val(),
        "Is_set_group": $("#txt_Is_set_group").val(),
        "Weight_config": $("#txt_Weight_config").val(),
        "Owner": $("#txt_Owner").val(),
        "Realname": $("#txt_Realname").val(),
        "Start_time": $("#txt_Start_time").val(),
        "End_time": $("#txt_End_time").val(),
        "Is_display_score": $("#txt_Is_display_score").val(),
        "Is_display_answer": $("#txt_Is_display_answer").val(),
        "Teacher_id": $("#txt_Teacher_id").val(),
        "Course_code": $("#txt_Course_code").val(),
        "Courser_caption": $("#txt_Courser_caption").val(),
        "Courser_content": $("#txt_Courser_content").val(),
        "Category": $("#txt_Category").val(),
        "Add_method": $("#txt_Add_method").val(),
        "Student_managers": $("#txt_Student_managers").val(),
        "Student_count": $("#txt_Student_count").val(),
        "Pass_count": $("#txt_Pass_count").val(),
        "Member_num": $("#txt_Member_num").val(),
        "Course_time": $("#txt_Course_time").val(),
        "Browse_author": $("#txt_Browse_author").val(),
        "Category_ids": $("#txt_Category_ids").val(),
        "Category_names": $("#txt_Category_names").val(),
        "Head_img": $("#txt_Head_img").val(),
        "Is_file": $("#txt_Is_file").val(), 
 * ************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using AgileFrame.Orm.PersistenceLayer.DAL.Base;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Core;
namespace AgileFrame.Orm.PersistenceLayer.Model
{
    /// <summary>
    /// <para>班级表</para>
    /// <para>与Xt_course数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xt_course : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xt_course Factory()
        {
            return new Xt_course();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 课程ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> 修改时间:[CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> 用户id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Weix_id
        {            
            get { return this.Weix_id; }
            set { this.Weix_id = value; }
        }
        
        /// <summary> 学校id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _College_id
        {            
            get { return this.College_id; }
            set { this.College_id = value; }
        }
        
        /// <summary> 名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> 专业,分类:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Major
        {            
            get { return this.Major; }
            set { this.Major = value; }
        }
        
        /// <summary> 活跃度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Active
        {            
            get { return this.Active; }
            set { this.Active = value; }
        }
        
        /// <summary> 是否删除:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_delete
        {            
            get { return this.Is_delete; }
            set { this.Is_delete = value; }
        }
        
        /// <summary> 是否设置群组:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_set_group
        {            
            get { return this.Is_set_group; }
            set { this.Is_set_group = value; }
        }
        
        /// <summary> 权重配置:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Weight_config
        {            
            get { return this.Weight_config; }
            set { this.Weight_config = value; }
        }
        
        /// <summary> 主人:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Owner
        {            
            get { return this.Owner; }
            set { this.Owner = value; }
        }
        
        /// <summary> 真实姓名:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Realname
        {            
            get { return this.Realname; }
            set { this.Realname = value; }
        }
        
        /// <summary> 开始时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Start_time
        {            
            get { return this.Start_time; }
            set { this.Start_time = value; }
        }
        
        /// <summary> 结束时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _End_time
        {            
            get { return this.End_time; }
            set { this.End_time = value; }
        }
        
        /// <summary> 是否显示分数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_display_score
        {            
            get { return this.Is_display_score; }
            set { this.Is_display_score = value; }
        }
        
        /// <summary> 是否显示答案:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_display_answer
        {            
            get { return this.Is_display_answer; }
            set { this.Is_display_answer = value; }
        }
        
        /// <summary> 老师ID:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Teacher_id
        {            
            get { return this.Teacher_id; }
            set { this.Teacher_id = value; }
        }
        
        /// <summary> 课程编码，邀请学生用的:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Course_code
        {            
            get { return this.Course_code; }
            set { this.Course_code = value; }
        }
        
        /// <summary> 课程标题:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Courser_caption
        {            
            get { return this.Courser_caption; }
            set { this.Courser_caption = value; }
        }
        
        /// <summary> 课程介绍:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Courser_content
        {            
            get { return this.Courser_content; }
            set { this.Courser_content = value; }
        }
        
        /// <summary> 课程分类:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Category
        {            
            get { return this.Category; }
            set { this.Category = value; }
        }
        
        /// <summary> 加入方式:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Add_method
        {            
            get { return this.Add_method; }
            set { this.Add_method = value; }
        }
        
        /// <summary> 学生管理员列:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Student_managers
        {            
            get { return this.Student_managers; }
            set { this.Student_managers = value; }
        }
        
        /// <summary> 学生总数:[CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Student_count
        {            
            get { return this.Student_count; }
            set { this.Student_count = value; }
        }
        
        /// <summary> 审核过的学生总数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Pass_count
        {            
            get { return this.Pass_count; }
            set { this.Pass_count = value; }
        }
        
        /// <summary> 成员数量:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Member_num
        {            
            get { return this.Member_num; }
            set { this.Member_num = value; }
        }
        
        /// <summary> 上课时间:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Course_time
        {            
            get { return this.Course_time; }
            set { this.Course_time = value; }
        }
        
        /// <summary> 浏览方式0所有人，1仅成员:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Browse_author
        {            
            get { return this.Browse_author; }
            set { this.Browse_author = value; }
        }
        
        /// <summary> 课程分类（系统带的选择项）:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Category_ids
        {            
            get { return this.Category_ids; }
            set { this.Category_ids = value; }
        }
        
        /// <summary> 课程分类（系统带的选择项）:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Category_names
        {            
            get { return this.Category_names; }
            set { this.Category_names = value; }
        }
        
        /// <summary> 班级封面:[CtrlTypeDic-{SmallText}] Attribute_IsNotNull </summary>
        public string _Head_img
        {            
            get { return this.Head_img; }
            set { this.Head_img = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_file
        {            
            get { return this.Is_file; }
            set { this.Is_file = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 课程ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public Guid Uuid
        {
            get { return this.m_uuid; }
            set //
            {
                if (!uuid_initialized || m_uuid != value)
                {
                    this.m_uuid = value;
                }
                uuid_initialized = true;
            }
        }
        
        /// <summary> Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Id
        {
            get { return this.m_id; }
            set //
            {
                if (!id_initialized || m_id != value)
                {
                    this.m_id = value;
                }
                id_initialized = true;
            }
        }
        
        /// <summary> 创建时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime CreateTime
        {
            get { return this.m_createtime; }
            set //
            {
                if (!createtime_initialized || m_createtime != value)
                {
                    this.m_createtime = value;
                }
                createtime_initialized = true;
            }
        }
        
        /// <summary> 修改时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime ModifyTime
        {
            get { return this.m_modifytime; }
            set //
            {
                if (!modifytime_initialized || m_modifytime != value)
                {
                    this.m_modifytime = value;
                }
                modifytime_initialized = true;
            }
        }
        
        /// <summary> 用户id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Weix_id
        {
            get { return this.m_weix_id; }
            set //
            {
                if (!weix_id_initialized || m_weix_id != value)
                {
                    this.m_weix_id = value;
                }
                weix_id_initialized = true;
            }
        }
        
        /// <summary> 学校id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string College_id
        {
            get { return this.m_college_id; }
            set //
            {
                if (!college_id_initialized || m_college_id != value)
                {
                    this.m_college_id = value;
                }
                college_id_initialized = true;
            }
        }
        
        /// <summary> 名称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Name
        {
            get { return this.m_name; }
            set //
            {
                if (!name_initialized || m_name != value)
                {
                    this.m_name = value;
                }
                name_initialized = true;
            }
        }
        
        /// <summary> 专业,分类:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Major
        {
            get { return this.m_major; }
            set //
            {
                if (!major_initialized || m_major != value)
                {
                    this.m_major = value;
                }
                major_initialized = true;
            }
        }
        
        /// <summary> 活跃度:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Active
        {
            get { return this.m_active; }
            set //
            {
                if (!active_initialized || m_active != value)
                {
                    this.m_active = value;
                }
                active_initialized = true;
            }
        }
        
        /// <summary> 是否删除:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Is_delete
        {
            get { return this.m_is_delete; }
            set //
            {
                if (!is_delete_initialized || m_is_delete != value)
                {
                    this.m_is_delete = value;
                }
                is_delete_initialized = true;
            }
        }
        
        /// <summary> 是否设置群组:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Is_set_group
        {
            get { return this.m_is_set_group; }
            set //
            {
                if (!is_set_group_initialized || m_is_set_group != value)
                {
                    this.m_is_set_group = value;
                }
                is_set_group_initialized = true;
            }
        }
        
        /// <summary> 权重配置:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Weight_config
        {
            get { return this.m_weight_config; }
            set //
            {
                if (!weight_config_initialized || m_weight_config != value)
                {
                    this.m_weight_config = value;
                }
                weight_config_initialized = true;
            }
        }
        
        /// <summary> 主人:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Owner
        {
            get { return this.m_owner; }
            set //
            {
                if (!owner_initialized || m_owner != value)
                {
                    this.m_owner = value;
                }
                owner_initialized = true;
            }
        }
        
        /// <summary> 真实姓名:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Realname
        {
            get { return this.m_realname; }
            set //
            {
                if (!realname_initialized || m_realname != value)
                {
                    this.m_realname = value;
                }
                realname_initialized = true;
            }
        }
        
        /// <summary> 开始时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime Start_time
        {
            get { return this.m_start_time; }
            set //
            {
                if (!start_time_initialized || m_start_time != value)
                {
                    this.m_start_time = value;
                }
                start_time_initialized = true;
            }
        }
        
        /// <summary> 结束时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime End_time
        {
            get { return this.m_end_time; }
            set //
            {
                if (!end_time_initialized || m_end_time != value)
                {
                    this.m_end_time = value;
                }
                end_time_initialized = true;
            }
        }
        
        /// <summary> 是否显示分数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Is_display_score
        {
            get { return this.m_is_display_score; }
            set //
            {
                if (!is_display_score_initialized || m_is_display_score != value)
                {
                    this.m_is_display_score = value;
                }
                is_display_score_initialized = true;
            }
        }
        
        /// <summary> 是否显示答案:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Is_display_answer
        {
            get { return this.m_is_display_answer; }
            set //
            {
                if (!is_display_answer_initialized || m_is_display_answer != value)
                {
                    this.m_is_display_answer = value;
                }
                is_display_answer_initialized = true;
            }
        }
        
        /// <summary> 老师ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Teacher_id
        {
            get { return this.m_teacher_id; }
            set //
            {
                if (!teacher_id_initialized || m_teacher_id != value)
                {
                    this.m_teacher_id = value;
                }
                teacher_id_initialized = true;
            }
        }
        
        /// <summary> 课程编码，邀请学生用的:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Course_code
        {
            get { return this.m_course_code; }
            set //
            {
                if (!course_code_initialized || m_course_code != value)
                {
                    this.m_course_code = value;
                }
                course_code_initialized = true;
            }
        }
        
        /// <summary> 课程标题:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Courser_caption
        {
            get { return this.m_courser_caption; }
            set //
            {
                if (!courser_caption_initialized || m_courser_caption != value)
                {
                    this.m_courser_caption = value;
                }
                courser_caption_initialized = true;
            }
        }
        
        /// <summary> 课程介绍:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Courser_content
        {
            get { return this.m_courser_content; }
            set //
            {
                if (!courser_content_initialized || m_courser_content != value)
                {
                    this.m_courser_content = value;
                }
                courser_content_initialized = true;
            }
        }
        
        /// <summary> 课程分类:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Category
        {
            get { return this.m_category; }
            set //
            {
                if (!category_initialized || m_category != value)
                {
                    this.m_category = value;
                }
                category_initialized = true;
            }
        }
        
        /// <summary> 加入方式:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Add_method
        {
            get { return this.m_add_method; }
            set //
            {
                if (!add_method_initialized || m_add_method != value)
                {
                    this.m_add_method = value;
                }
                add_method_initialized = true;
            }
        }
        
        /// <summary> 学生管理员列:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Student_managers
        {
            get { return this.m_student_managers; }
            set //
            {
                if (!student_managers_initialized || m_student_managers != value)
                {
                    this.m_student_managers = value;
                }
                student_managers_initialized = true;
            }
        }
        
        /// <summary> 学生总数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Student_count
        {
            get { return this.m_student_count; }
            set //
            {
                if (!student_count_initialized || m_student_count != value)
                {
                    this.m_student_count = value;
                }
                student_count_initialized = true;
            }
        }
        
        /// <summary> 审核过的学生总数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Pass_count
        {
            get { return this.m_pass_count; }
            set //
            {
                if (!pass_count_initialized || m_pass_count != value)
                {
                    this.m_pass_count = value;
                }
                pass_count_initialized = true;
            }
        }
        
        /// <summary> 成员数量:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Member_num
        {
            get { return this.m_member_num; }
            set //
            {
                if (!member_num_initialized || m_member_num != value)
                {
                    this.m_member_num = value;
                }
                member_num_initialized = true;
            }
        }
        
        /// <summary> 上课时间:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Course_time
        {
            get { return this.m_course_time; }
            set //
            {
                if (!course_time_initialized || m_course_time != value)
                {
                    this.m_course_time = value;
                }
                course_time_initialized = true;
            }
        }
        
        /// <summary> 浏览方式0所有人，1仅成员:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Browse_author
        {
            get { return this.m_browse_author; }
            set //
            {
                if (!browse_author_initialized || m_browse_author != value)
                {
                    this.m_browse_author = value;
                }
                browse_author_initialized = true;
            }
        }
        
        /// <summary> 课程分类（系统带的选择项）:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Category_ids
        {
            get { return this.m_category_ids; }
            set //
            {
                if (!category_ids_initialized || m_category_ids != value)
                {
                    this.m_category_ids = value;
                }
                category_ids_initialized = true;
            }
        }
        
        /// <summary> 课程分类（系统带的选择项）:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Category_names
        {
            get { return this.m_category_names; }
            set //
            {
                if (!category_names_initialized || m_category_names != value)
                {
                    this.m_category_names = value;
                }
                category_names_initialized = true;
            }
        }
        
        /// <summary> 班级封面:[CtrlTypeDic-{SmallText}]，推荐使用 "_"符号开头 </summary>
        public string Head_img
        {
            get { return this.m_head_img; }
            set //
            {
                if (!head_img_initialized || m_head_img != value)
                {
                    this.m_head_img = value;
                }
                head_img_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Is_file
        {
            get { return this.m_is_file; }
            set //
            {
                if (!is_file_initialized || m_is_file != value)
                {
                    this.m_is_file = value;
                }
                is_file_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>课程ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xt_course].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xt_course].[Id]", typeof(int), 4, default(int));
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xt_course].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>修改时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Xt_course].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>用户id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Weix_id =  new AttributeItem("[Xt_course].[Weix_id]", typeof(string), 36, default(string));
            
            /// <summary>学校id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem College_id =  new AttributeItem("[Xt_course].[College_id]", typeof(string), 36, default(string));
            
            /// <summary>名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[Xt_course].[Name]", typeof(string), 100, default(string));
            
            /// <summary>专业,分类:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Major =  new AttributeItem("[Xt_course].[Major]", typeof(string), 100, default(string));
            
            /// <summary>活跃度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Active =  new AttributeItem("[Xt_course].[Active]", typeof(string), 100, default(string));
            
            /// <summary>是否删除:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_delete =  new AttributeItem("[Xt_course].[Is_delete]", typeof(string), 1, default(string));
            
            /// <summary>是否设置群组:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_set_group =  new AttributeItem("[Xt_course].[Is_set_group]", typeof(string), 1, default(string));
            
            /// <summary>权重配置:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Weight_config =  new AttributeItem("[Xt_course].[Weight_config]", typeof(string), 100, default(string));
            
            /// <summary>主人:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Owner =  new AttributeItem("[Xt_course].[Owner]", typeof(string), 36, default(string));
            
            /// <summary>真实姓名:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Realname =  new AttributeItem("[Xt_course].[Realname]", typeof(string), 100, default(string));
            
            /// <summary>开始时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Start_time =  new AttributeItem("[Xt_course].[Start_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>结束时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem End_time =  new AttributeItem("[Xt_course].[End_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>是否显示分数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_display_score =  new AttributeItem("[Xt_course].[Is_display_score]", typeof(string), 1, default(string));
            
            /// <summary>是否显示答案:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_display_answer =  new AttributeItem("[Xt_course].[Is_display_answer]", typeof(string), 1, default(string));
            
            /// <summary>老师ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teacher_id =  new AttributeItem("[Xt_course].[Teacher_id]", typeof(string), 36, default(string));
            
            /// <summary>课程编码，邀请学生用的:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_code =  new AttributeItem("[Xt_course].[Course_code]", typeof(string), 12, default(string));
            
            /// <summary>课程标题:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Courser_caption =  new AttributeItem("[Xt_course].[Courser_caption]", typeof(string), 200, default(string));
            
            /// <summary>课程介绍:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Courser_content =  new AttributeItem("[Xt_course].[Courser_content]", typeof(string), 500, default(string));
            
            /// <summary>课程分类:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Category =  new AttributeItem("[Xt_course].[Category]", typeof(string), 50, default(string));
            
            /// <summary>加入方式:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Add_method =  new AttributeItem("[Xt_course].[Add_method]", typeof(string), 1, default(string));
            
            /// <summary>学生管理员列:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Student_managers =  new AttributeItem("[Xt_course].[Student_managers]", typeof(string), 1000, default(string));
            
            /// <summary>学生总数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_count =  new AttributeItem("[Xt_course].[Student_count]", typeof(int), 4, default(int));
            
            /// <summary>审核过的学生总数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Pass_count =  new AttributeItem("[Xt_course].[Pass_count]", typeof(int), 4, default(int));
            
            /// <summary>成员数量:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Member_num =  new AttributeItem("[Xt_course].[Member_num]", typeof(int), 4, default(int));
            
            /// <summary>上课时间:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_time =  new AttributeItem("[Xt_course].[Course_time]", typeof(string), 50, default(string));
            
            /// <summary>浏览方式0所有人，1仅成员:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Browse_author =  new AttributeItem("[Xt_course].[Browse_author]", typeof(string), 1, default(string));
            
            /// <summary>课程分类（系统带的选择项）:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Category_ids =  new AttributeItem("[Xt_course].[Category_ids]", typeof(string), 100, default(string));
            
            /// <summary>课程分类（系统带的选择项）:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Category_names =  new AttributeItem("[Xt_course].[Category_names]", typeof(string), 800, default(string));
            
            /// <summary>班级封面:[CtrlTypeDic-{SmallText}]</summary>
            public static AttributeItem Head_img =  new AttributeItem("[Xt_course].[Head_img]", typeof(string), 300, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_file =  new AttributeItem("[Xt_course].[Is_file]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private string m_weix_id;
        /// <summary></summary>
        protected bool weix_id_initialized = false;
        
        private string m_college_id;
        /// <summary></summary>
        protected bool college_id_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_major;
        /// <summary></summary>
        protected bool major_initialized = false;
        
        private string m_active;
        /// <summary></summary>
        protected bool active_initialized = false;
        
        private string m_is_delete;
        /// <summary></summary>
        protected bool is_delete_initialized = false;
        
        private string m_is_set_group;
        /// <summary></summary>
        protected bool is_set_group_initialized = false;
        
        private string m_weight_config;
        /// <summary></summary>
        protected bool weight_config_initialized = false;
        
        private string m_owner;
        /// <summary></summary>
        protected bool owner_initialized = false;
        
        private string m_realname;
        /// <summary></summary>
        protected bool realname_initialized = false;
        
        private DateTime m_start_time;
        /// <summary></summary>
        protected bool start_time_initialized = false;
        
        private DateTime m_end_time;
        /// <summary></summary>
        protected bool end_time_initialized = false;
        
        private string m_is_display_score;
        /// <summary></summary>
        protected bool is_display_score_initialized = false;
        
        private string m_is_display_answer;
        /// <summary></summary>
        protected bool is_display_answer_initialized = false;
        
        private string m_teacher_id;
        /// <summary></summary>
        protected bool teacher_id_initialized = false;
        
        private string m_course_code;
        /// <summary></summary>
        protected bool course_code_initialized = false;
        
        private string m_courser_caption;
        /// <summary></summary>
        protected bool courser_caption_initialized = false;
        
        private string m_courser_content;
        /// <summary></summary>
        protected bool courser_content_initialized = false;
        
        private string m_category;
        /// <summary></summary>
        protected bool category_initialized = false;
        
        private string m_add_method;
        /// <summary></summary>
        protected bool add_method_initialized = false;
        
        private string m_student_managers;
        /// <summary></summary>
        protected bool student_managers_initialized = false;
        
        private int m_student_count;
        /// <summary></summary>
        protected bool student_count_initialized = false;
        
        private int m_pass_count;
        /// <summary></summary>
        protected bool pass_count_initialized = false;
        
        private int m_member_num;
        /// <summary></summary>
        protected bool member_num_initialized = false;
        
        private string m_course_time;
        /// <summary></summary>
        protected bool course_time_initialized = false;
        
        private string m_browse_author;
        /// <summary></summary>
        protected bool browse_author_initialized = false;
        
        private string m_category_ids;
        /// <summary></summary>
        protected bool category_ids_initialized = false;
        
        private string m_category_names;
        /// <summary></summary>
        protected bool category_names_initialized = false;
        
        private string m_head_img;
        /// <summary></summary>
        protected bool head_img_initialized = false;
        
        private string m_is_file;
        /// <summary></summary>
        protected bool is_file_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_course";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.weix_id_initialized = IsLoadAllAttributes;this.college_id_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.major_initialized = IsLoadAllAttributes;this.active_initialized = IsLoadAllAttributes;this.is_delete_initialized = IsLoadAllAttributes;this.is_set_group_initialized = IsLoadAllAttributes;this.weight_config_initialized = IsLoadAllAttributes;this.owner_initialized = IsLoadAllAttributes;this.realname_initialized = IsLoadAllAttributes;this.start_time_initialized = IsLoadAllAttributes;this.end_time_initialized = IsLoadAllAttributes;this.is_display_score_initialized = IsLoadAllAttributes;this.is_display_answer_initialized = IsLoadAllAttributes;this.teacher_id_initialized = IsLoadAllAttributes;this.course_code_initialized = IsLoadAllAttributes;this.courser_caption_initialized = IsLoadAllAttributes;this.courser_content_initialized = IsLoadAllAttributes;this.category_initialized = IsLoadAllAttributes;this.add_method_initialized = IsLoadAllAttributes;this.student_managers_initialized = IsLoadAllAttributes;this.student_count_initialized = IsLoadAllAttributes;this.pass_count_initialized = IsLoadAllAttributes;this.member_num_initialized = IsLoadAllAttributes;this.course_time_initialized = IsLoadAllAttributes;this.browse_author_initialized = IsLoadAllAttributes;this.category_ids_initialized = IsLoadAllAttributes;this.category_names_initialized = IsLoadAllAttributes;this.head_img_initialized = IsLoadAllAttributes;this.is_file_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_course value = new Xt_course();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Weix_id"))
				value.weix_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"College_id"))
				value.college_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Major"))
				value.major_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Active"))
				value.active_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_delete"))
				value.is_delete_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_set_group"))
				value.is_set_group_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Weight_config"))
				value.weight_config_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Owner"))
				value.owner_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Realname"))
				value.realname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Start_time"))
				value.start_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"End_time"))
				value.end_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_display_score"))
				value.is_display_score_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_display_answer"))
				value.is_display_answer_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_id"))
				value.teacher_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_code"))
				value.course_code_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Courser_caption"))
				value.courser_caption_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Courser_content"))
				value.courser_content_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category"))
				value.category_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Add_method"))
				value.add_method_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_managers"))
				value.student_managers_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_count"))
				value.student_count_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pass_count"))
				value.pass_count_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Member_num"))
				value.member_num_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_time"))
				value.course_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Browse_author"))
				value.browse_author_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category_ids"))
				value.category_ids_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category_names"))
				value.category_names_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Head_img"))
				value.head_img_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_file"))
				value.is_file_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xt_course Clone()
        {
            return (Xt_course)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xt_course()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xt_course() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xt_course(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xt_course(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xt_course(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xt_course(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xt_course(Guid uuid1, int id1, DateTime createtime1, DateTime modifytime1, string weix_id1, string college_id1, string name1, string major1, string active1, string is_delete1, string is_set_group1, string weight_config1, string owner1, string realname1, DateTime start_time1, DateTime end_time1, string is_display_score1, string is_display_answer1, string teacher_id1, string course_code1, string courser_caption1, string courser_content1, string category1, string add_method1, string student_managers1, int student_count1, int pass_count1, int member_num1, string course_time1, string browse_author1, string category_ids1, string category_names1, string head_img1, string is_file1)
        {
            
            this.Uuid = uuid1;
            
            this.Id = id1;
            
            this.CreateTime = createtime1;
            
            this.ModifyTime = modifytime1;
            
            this.Weix_id = weix_id1;
            
            this.College_id = college_id1;
            
            this.Name = name1;
            
            this.Major = major1;
            
            this.Active = active1;
            
            this.Is_delete = is_delete1;
            
            this.Is_set_group = is_set_group1;
            
            this.Weight_config = weight_config1;
            
            this.Owner = owner1;
            
            this.Realname = realname1;
            
            this.Start_time = start_time1;
            
            this.End_time = end_time1;
            
            this.Is_display_score = is_display_score1;
            
            this.Is_display_answer = is_display_answer1;
            
            this.Teacher_id = teacher_id1;
            
            this.Course_code = course_code1;
            
            this.Courser_caption = courser_caption1;
            
            this.Courser_content = courser_content1;
            
            this.Category = category1;
            
            this.Add_method = add_method1;
            
            this.Student_managers = student_managers1;
            
            this.Student_count = student_count1;
            
            this.Pass_count = pass_count1;
            
            this.Member_num = member_num1;
            
            this.Course_time = course_time1;
            
            this.Browse_author = browse_author1;
            
            this.Category_ids = category_ids1;
            
            this.Category_names = category_names1;
            
            this.Head_img = head_img1;
            
            this.Is_file = is_file1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xt_course FromIView(IView view)
        {
            return (Xt_course)IView.GetITable(view, "Xt_course");
        }
        /// <summary>获得一个实例  </summary>
        public static Xt_course GetOneInstance()
        {
            Xt_course value = new Xt_course();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xt_course Retrieve()
        {
            BLLTable<Xt_course>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Uuid":
			        return Uuid;
			    			
			    case "Id":
			        return Id;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "Weix_id":
			        return Weix_id;
			    			
			    case "College_id":
			        return College_id;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Major":
			        return Major;
			    			
			    case "Active":
			        return Active;
			    			
			    case "Is_delete":
			        return Is_delete;
			    			
			    case "Is_set_group":
			        return Is_set_group;
			    			
			    case "Weight_config":
			        return Weight_config;
			    			
			    case "Owner":
			        return Owner;
			    			
			    case "Realname":
			        return Realname;
			    			
			    case "Start_time":
			        return Start_time;
			    			
			    case "End_time":
			        return End_time;
			    			
			    case "Is_display_score":
			        return Is_display_score;
			    			
			    case "Is_display_answer":
			        return Is_display_answer;
			    			
			    case "Teacher_id":
			        return Teacher_id;
			    			
			    case "Course_code":
			        return Course_code;
			    			
			    case "Courser_caption":
			        return Courser_caption;
			    			
			    case "Courser_content":
			        return Courser_content;
			    			
			    case "Category":
			        return Category;
			    			
			    case "Add_method":
			        return Add_method;
			    			
			    case "Student_managers":
			        return Student_managers;
			    			
			    case "Student_count":
			        return Student_count;
			    			
			    case "Pass_count":
			        return Pass_count;
			    			
			    case "Member_num":
			        return Member_num;
			    			
			    case "Course_time":
			        return Course_time;
			    			
			    case "Browse_author":
			        return Browse_author;
			    			
			    case "Category_ids":
			        return Category_ids;
			    			
			    case "Category_names":
			        return Category_names;
			    			
			    case "Head_img":
			        return Head_img;
			    			
			    case "Is_file":
			        return Is_file;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Weix_id":
			        this.Weix_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "College_id":
			        this.College_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Major":
			        this.Major = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Active":
			        this.Active = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_delete":
			        this.Is_delete = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_set_group":
			        this.Is_set_group = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Weight_config":
			        this.Weight_config = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Owner":
			        this.Owner = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Realname":
			        this.Realname = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Start_time":
			        this.Start_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "End_time":
			        this.End_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Is_display_score":
			        this.Is_display_score = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_display_answer":
			        this.Is_display_answer = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teacher_id":
			        this.Teacher_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Course_code":
			        this.Course_code = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Courser_caption":
			        this.Courser_caption = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Courser_content":
			        this.Courser_content = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Category":
			        this.Category = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Add_method":
			        this.Add_method = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Student_managers":
			        this.Student_managers = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Student_count":
			        this.Student_count = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Pass_count":
			        this.Pass_count = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Member_num":
			        this.Member_num = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Course_time":
			        this.Course_time = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Browse_author":
			        this.Browse_author = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Category_ids":
			        this.Category_ids = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Category_names":
			        this.Category_names = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Head_img":
			        this.Head_img = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_file":
			        this.Is_file = Convert.ToString(AttributeValue);
                    return true;
			
                default:
                    return base.SetValue(AttributeName, AttributeValue);
			}
        }
        
        /// <summary>通过属性 获取该字段是否已被初始化</summary>
        public override bool GetInitialized(AttributeItem AttributeName)
        {
			switch(AttributeName.FieldName)
			{	
				case "Uuid":
					return uuid_initialized;
				
				case "Id":
					return id_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "Weix_id":
					return weix_id_initialized;
				
				case "College_id":
					return college_id_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Major":
					return major_initialized;
				
				case "Active":
					return active_initialized;
				
				case "Is_delete":
					return is_delete_initialized;
				
				case "Is_set_group":
					return is_set_group_initialized;
				
				case "Weight_config":
					return weight_config_initialized;
				
				case "Owner":
					return owner_initialized;
				
				case "Realname":
					return realname_initialized;
				
				case "Start_time":
					return start_time_initialized;
				
				case "End_time":
					return end_time_initialized;
				
				case "Is_display_score":
					return is_display_score_initialized;
				
				case "Is_display_answer":
					return is_display_answer_initialized;
				
				case "Teacher_id":
					return teacher_id_initialized;
				
				case "Course_code":
					return course_code_initialized;
				
				case "Courser_caption":
					return courser_caption_initialized;
				
				case "Courser_content":
					return courser_content_initialized;
				
				case "Category":
					return category_initialized;
				
				case "Add_method":
					return add_method_initialized;
				
				case "Student_managers":
					return student_managers_initialized;
				
				case "Student_count":
					return student_count_initialized;
				
				case "Pass_count":
					return pass_count_initialized;
				
				case "Member_num":
					return member_num_initialized;
				
				case "Course_time":
					return course_time_initialized;
				
				case "Browse_author":
					return browse_author_initialized;
				
				case "Category_ids":
					return category_ids_initialized;
				
				case "Category_names":
					return category_names_initialized;
				
				case "Head_img":
					return head_img_initialized;
				
				case "Is_file":
					return is_file_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "Weix_id":
					weix_id_initialized = ret;
					return true;
				
				case "College_id":
					college_id_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Major":
					major_initialized = ret;
					return true;
				
				case "Active":
					active_initialized = ret;
					return true;
				
				case "Is_delete":
					is_delete_initialized = ret;
					return true;
				
				case "Is_set_group":
					is_set_group_initialized = ret;
					return true;
				
				case "Weight_config":
					weight_config_initialized = ret;
					return true;
				
				case "Owner":
					owner_initialized = ret;
					return true;
				
				case "Realname":
					realname_initialized = ret;
					return true;
				
				case "Start_time":
					start_time_initialized = ret;
					return true;
				
				case "End_time":
					end_time_initialized = ret;
					return true;
				
				case "Is_display_score":
					is_display_score_initialized = ret;
					return true;
				
				case "Is_display_answer":
					is_display_answer_initialized = ret;
					return true;
				
				case "Teacher_id":
					teacher_id_initialized = ret;
					return true;
				
				case "Course_code":
					course_code_initialized = ret;
					return true;
				
				case "Courser_caption":
					courser_caption_initialized = ret;
					return true;
				
				case "Courser_content":
					courser_content_initialized = ret;
					return true;
				
				case "Category":
					category_initialized = ret;
					return true;
				
				case "Add_method":
					add_method_initialized = ret;
					return true;
				
				case "Student_managers":
					student_managers_initialized = ret;
					return true;
				
				case "Student_count":
					student_count_initialized = ret;
					return true;
				
				case "Pass_count":
					pass_count_initialized = ret;
					return true;
				
				case "Member_num":
					member_num_initialized = ret;
					return true;
				
				case "Course_time":
					course_time_initialized = ret;
					return true;
				
				case "Browse_author":
					browse_author_initialized = ret;
					return true;
				
				case "Category_ids":
					category_ids_initialized = ret;
					return true;
				
				case "Category_names":
					category_names_initialized = ret;
					return true;
				
				case "Head_img":
					head_img_initialized = ret;
					return true;
				
				case "Is_file":
					is_file_initialized = ret;
					return true;
				
                default:
                    return base.SetInitialized(AttributeName, ret);
			}
        }
        #endregion

        #region 获取DataParameter PropertyInfo

        /// <summary>
        /// 获取所有被初始化过的值，获取AttributeItem
        /// 目的为获取 System.Windows.Forms.DataGridViewTextBoxColumn[] 在中间数据层采用了 自定义的 MyDataGridViewTextBoxColumn (空类继承自 DataGridViewTextBoxColumn)
        /// 这里采用了两次遍历的方法，是为了避免拆装过程，使用源代码模式的时候，不会依赖于windows.form.dll。
        /// </summary>
        /// <returns></returns>
        public override AttributeItem[] af_GetAvailableAttributeItem(ref List<object> values)
        {
            List<AttributeItem> parametersList = new List<AttributeItem>();

			
			if (uuid_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (weix_id_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Weix_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Weix_id);
                }
			}
			
			if (college_id_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.College_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(College_id);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (major_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Major;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Major);
                }
			}
			
			if (active_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Active;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Active);
                }
			}
			
			if (is_delete_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Is_delete;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_delete);
                }
			}
			
			if (is_set_group_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Is_set_group;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_set_group);
                }
			}
			
			if (weight_config_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Weight_config;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Weight_config);
                }
			}
			
			if (owner_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Owner;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Owner);
                }
			}
			
			if (realname_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Realname;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Realname);
                }
			}
			
			if (start_time_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Start_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Start_time);
                }
			}
			
			if (end_time_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.End_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(End_time);
                }
			}
			
			if (is_display_score_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Is_display_score;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_display_score);
                }
			}
			
			if (is_display_answer_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Is_display_answer;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_display_answer);
                }
			}
			
			if (teacher_id_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Teacher_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_id);
                }
			}
			
			if (course_code_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Course_code;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_code);
                }
			}
			
			if (courser_caption_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Courser_caption;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Courser_caption);
                }
			}
			
			if (courser_content_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Courser_content;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Courser_content);
                }
			}
			
			if (category_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Category;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category);
                }
			}
			
			if (add_method_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Add_method;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Add_method);
                }
			}
			
			if (student_managers_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Student_managers;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_managers);
                }
			}
			
			if (student_count_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Student_count;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_count);
                }
			}
			
			if (pass_count_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Pass_count;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pass_count);
                }
			}
			
			if (member_num_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Member_num;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Member_num);
                }
			}
			
			if (course_time_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Course_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_time);
                }
			}
			
			if (browse_author_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Browse_author;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Browse_author);
                }
			}
			
			if (category_ids_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Category_ids;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category_ids);
                }
			}
			
			if (category_names_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Category_names;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category_names);
                }
			}
			
			if (head_img_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Head_img;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Head_img);
                }
			}
			
			if (is_file_initialized)
			{
                AttributeItem attr = Xt_course.Attribute.Is_file;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_file);
                }
			}
			
            
			parametersList.AddRange(base.af_GetAvailableAttributeItem(ref values));
            return parametersList.ToArray();
        }
        #endregion                

        #region Json对象
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        [Serializable]
        public class Xt_courseJson
        {
            
            /// <summary>课程ID:[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>Id:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>创建时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>修改时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>用户id:[CtrlTypeDic-{InputString}]</summary>
            public string Weix_id { get; set; }
            
            /// <summary>学校id:[CtrlTypeDic-{InputString}]</summary>
            public string College_id { get; set; }
            
            /// <summary>名称:[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>专业,分类:[CtrlTypeDic-{InputString}]</summary>
            public string Major { get; set; }
            
            /// <summary>活跃度:[CtrlTypeDic-{InputString}]</summary>
            public string Active { get; set; }
            
            /// <summary>是否删除:[CtrlTypeDic-{InputString}]</summary>
            public string Is_delete { get; set; }
            
            /// <summary>是否设置群组:[CtrlTypeDic-{InputString}]</summary>
            public string Is_set_group { get; set; }
            
            /// <summary>权重配置:[CtrlTypeDic-{InputString}]</summary>
            public string Weight_config { get; set; }
            
            /// <summary>主人:[CtrlTypeDic-{InputString}]</summary>
            public string Owner { get; set; }
            
            /// <summary>真实姓名:[CtrlTypeDic-{InputString}]</summary>
            public string Realname { get; set; }
            
            /// <summary>开始时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Start_time { get; set; }
            
            /// <summary>结束时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime End_time { get; set; }
            
            /// <summary>是否显示分数:[CtrlTypeDic-{InputString}]</summary>
            public string Is_display_score { get; set; }
            
            /// <summary>是否显示答案:[CtrlTypeDic-{InputString}]</summary>
            public string Is_display_answer { get; set; }
            
            /// <summary>老师ID:[CtrlTypeDic-{InputString}]</summary>
            public string Teacher_id { get; set; }
            
            /// <summary>课程编码，邀请学生用的:[CtrlTypeDic-{InputString}]</summary>
            public string Course_code { get; set; }
            
            /// <summary>课程标题:[CtrlTypeDic-{InputString}]</summary>
            public string Courser_caption { get; set; }
            
            /// <summary>课程介绍:[CtrlTypeDic-{Text}]</summary>
            public string Courser_content { get; set; }
            
            /// <summary>课程分类:[CtrlTypeDic-{InputString}]</summary>
            public string Category { get; set; }
            
            /// <summary>加入方式:[CtrlTypeDic-{InputString}]</summary>
            public string Add_method { get; set; }
            
            /// <summary>学生管理员列:[CtrlTypeDic-{Text}]</summary>
            public string Student_managers { get; set; }
            
            /// <summary>学生总数:[CtrlTypeDic-{InputString}]</summary>
            public int Student_count { get; set; }
            
            /// <summary>审核过的学生总数:[CtrlTypeDic-{InputString}]</summary>
            public int Pass_count { get; set; }
            
            /// <summary>成员数量:[CtrlTypeDic-{InputString}]</summary>
            public int Member_num { get; set; }
            
            /// <summary>上课时间:[CtrlTypeDic-{InputString}]</summary>
            public string Course_time { get; set; }
            
            /// <summary>浏览方式0所有人，1仅成员:[CtrlTypeDic-{InputString}]</summary>
            public string Browse_author { get; set; }
            
            /// <summary>课程分类（系统带的选择项）:[CtrlTypeDic-{InputString}]</summary>
            public string Category_ids { get; set; }
            
            /// <summary>课程分类（系统带的选择项）:[CtrlTypeDic-{Text}]</summary>
            public string Category_names { get; set; }
            
            /// <summary>班级封面:[CtrlTypeDic-{SmallText}]</summary>
            public string Head_img { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Is_file { get; set; }
        }
        #endregion
    }
}