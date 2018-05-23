using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Role:IdBase,ISortBase
    {
        #region 基础属性
        /// <summary>
        /// 角色名称
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name
        {
            set;
            get;
        }

        /// <summary>
        /// 是否系统默认0否1是
        /// </summary>
        public bool IsSys
        {
            set;
            get;
        }

        /// <summary>
        /// 排序数字
        /// </summary>
        [Display(Name = "排序数字", Description = "*数字，越小越向前")]
        public int SortId
        {
            set;
            get;
        }
        #endregion 基础属性

        #region 集合属性
        /// <summary>
        /// 角色包含的可访问项目
        /// </summary>
        public virtual ICollection<RoleItem> Items { set; get; }

        /// <summary>
        /// 角色包含的员工
        /// </summary>
        public virtual ICollection<Employee> Employees { set; get; }
        #endregion 集合属性
    }
}
