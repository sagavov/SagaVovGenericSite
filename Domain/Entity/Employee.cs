using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Domain.Entity
{
    public class Employee : EntityBase
    {

        #region 基础属性
        [Display(Name = "用户名")]
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "2-20字符以内")]
        [RegularExpression("^[a-zA-Z][a-zA-Z0-9_]*$", ErrorMessage = "字母开头的任意字母数字的和下划线的组合")]
        [Remote("IsExist", "Employee", "Admin")]
        public string Username
        {
            set;
            get;
        }

        /// <summary>
        /// 登录密码
        /// </summary>
        [Display(Name = "密码")]
        [Required]
        [StringLength(32, ErrorMessage = "32字符以内")]
        public string Password
        {
            set;
            get;
        }


        /// <summary>
        /// 6位随机字符串,加密用到
        /// </summary>
        [Display(Name = "随机码")]
        [Required]
        [StringLength(6, ErrorMessage = "×6字符以内")]
        public string Salt
        {
            set;
            get;
        }
        /// <summary>
        /// 用户姓名
        /// </summary>
        [Required]
        [StringLength(20, ErrorMessage = "20字符以内")]
        [Display(Name = "用户姓名")]
        public string RealName
        {
            set;
            get;
        }

        /// <summary>
        /// 部门编号
        /// </summary>
        [Display(Name = "部门编号")]
        [Required(ErrorMessage = "部门必选")]
        public int DepartmentId { set; get; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { set; get; }


        /// <summary>
        /// 直线
        /// </summary>
        [StringLength(20, ErrorMessage = "20字符以内")]
        [Display(Name = "直线")]
        public string Tel
        {
            set;
            get;
        }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "100字符以内")]
        [Display(Name = "电子邮箱")]
        public string Email
        {
            set;
            get;
        }

        /// <summary>
        ///性别
        /// </summary>
        [Display(Name = "性别")]
        public byte? Gender
        { set; get; }


        /// <summary>
        ///手机号码
        /// </summary>
        [Display(Name = "手机号码")]
        [StringLength(11, ErrorMessage = "11字符以内")]
        public string CellPhone
        { set; get; }


        

        /// <summary>
        /// 数据权限 enum DataAuthority
        /// </summary>
        [Display(Name = "数据权限范围")]
        [Required(ErrorMessage = "数据权限范围是必须的")]
        public byte DataAuthority { set; get; }


        [Display(Name = "登陆后强制修改密码")]
        public bool NeedChangePassword { set; get; }

        #endregion 基础属性


        #region 集合属性

        /// <summary>
        /// 用户的角色集合
        /// </summary>
        //public virtual ICollection<Role> Roles { set; get; }

        /// <summary>
        /// 除了角色权限意外的权限
        /// </summary>
        //public virtual ICollection<Authority> Authoritys { set; get; }


        /// <summary>
        /// 结算人员或业保中心人员所负责的结算或出票部门。如设置此项目。该人员只对此处设置的部门有权限
        /// </summary>
        //[Display(Name = "负责部门")]
        //public string ResponseDepartmentIds { set; get; }

        #endregion 集合属性
    }
}
