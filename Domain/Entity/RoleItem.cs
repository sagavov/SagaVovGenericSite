using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public class RoleItem:IdBase
    {
        #region 基础属性
        /// <summary>
        /// 角色ID
        /// </summary>
        public int? RoleId
        {
            set;
            get;
        }
        [ForeignKey("RoleId")]
        public virtual Role Role { set; get; }

        /// <summary>
        /// RoleId 和  EmployeeId 只能一个属性有值
        /// </summary>
        public int? EmployeeId { set; get; }
        public virtual Employee Employee { set; get; }

        /// <summary>
        /// 导航调用别名
        /// </summary>
        [StringLength(50)]
        public string NavAlias
        {
            set;
            get;
        }

        /// <summary>
        /// 区域
        /// </summary>
        [Display(Name = "区域")]
        [StringLength(50, ErrorMessage = "50字以内")]
        public string Area { set; get; }

        /// <summary>
        /// 控制器
        /// </summary>
        [Display(Name = "控制器")]
        [StringLength(50, ErrorMessage = "50字以内")]
        public string Controller { set; get; }

        /// <summary>
        /// 可访问的Action
        /// </summary>
        [Display(Name = "可访问的Action")]
        [StringLength(500, ErrorMessage = "500字以内")]
        public string Actions
        {
            set;
            get;
        }

        #endregion 基础属性
    }
}
