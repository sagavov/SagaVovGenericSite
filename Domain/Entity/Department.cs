using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Department:EntityBase
    {
        #region 基础属性

        [StringLength(10, ErrorMessage = "部门编号10个字符以内")]
        [Display(Name = "部门编号")]
        [Required]
        public string NO { set; get; }

        [Display(Name = "部门名称")]
        [StringLength(50, ErrorMessage = "部门名称50个字符以内")]
        public string Name { set; get; }

        [Display(Name = "父部门编号")]
        public int? ParentId { set; get; }

        [Display(Name = "部门")]
        [ForeignKey("ParentId")]
        public virtual Department ParentDepartment { set; get; }
       

        /// <summary>
        /// 是否结算单元
        /// </summary>
        [Display(Name = "是否结算单元", Description = "如是经理权限可查看最上级的结算单元下的数据")]
        public bool IsCostUnit
        {
            set;
            get;
        }

        /// <summary>
        /// 是否系统部门
        /// </summary>
        [Display(Name = "是否系统部门", Description = "如系统部门不能删除")]
        public bool IsSys
        {
            set;
            get;

        }

        #endregion 普通属性


        #region 集合属性
        public virtual ICollection<Department> SonDepartments { set; get; }
        #endregion 集合属性
    }
}
