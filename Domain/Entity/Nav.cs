using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Nav:EntityBase
    {
        #region 基础属性
        /// <summary>
        /// 所属父导航ID
        /// </summary>
        [Display(Name = "所属父导航ID")]
        public int? ParentId { set; get; }
        [ForeignKey("ParentId")]
        public virtual Nav ParentNav { set; get; }

        

        /// <summary>
        /// 所属频道ID
        /// </summary>
        [Display(Name = "所属频道ID")]
        public int? ChannelId
        {
            set;
            get;
        }
        public virtual Channel Channel { set; get; }

        /// <summary>
        /// 调用别名
        /// </summary>
        [Display(Name = "调用别名", Description = "调用别名只允许字母、数字、下划线")]
        [Required]
        [StringLength(50, ErrorMessage = "50字以内")]
        [RegularExpression("^[a-zA-Z][a-zA-Z0-9_ ]+$", ErrorMessage = "调用别名只允许字母、数字、下划线")]
        //[Remote("IsExist", "Navigation", "Admin", AdditionalFields = "Id")]
        public string Alias
        {
            set;
            get;
        }
        /// <summary>
        /// 标题
        /// </summary>
        [Display(Name = "标题", Description = "*导航中文标题，100字符内")]
        [StringLength(100, ErrorMessage = "100字以内")]
        [Required]
        public string Title
        {
            set;
            get;
        }
        /// <summary>
        /// 副标题
        /// </summary>
        [Display(Name = "副标题", Description = "非必填，当导航拥有两个名称时使用")]
        [StringLength(100, ErrorMessage = "100字以内")]
        public string SubTitle
        {
            set;
            get;
        }
        /// <summary>
        /// 图标地址
        /// </summary>
        [Display(Name = "图标")]
        [StringLength(255, ErrorMessage = "255字以内")]
        public string IconUrl
        {
            set;
            get;
        }
        /// <summary>
        /// 链接地址
        /// </summary>
        [Display(Name = "链接地址", Description = "当该导航有子导航时不用填")]
        [StringLength(255, ErrorMessage = "255字以内")]
        public string LinkUrl
        {
            set;
            get;
        }

        /// <summary>
        /// 备注说明
        /// </summary>
        [Display(Name = "备注说明", Description = "非必填，可为空")]
        [StringLength(500, ErrorMessage = "500字以内")]
        public string Remark
        {
            set;
            get;
        }

        /// <summary>
        /// 控制器
        /// </summary>
        [Display(Name = "控制器")]
        [StringLength(50, ErrorMessage = "50字以内")]
        public string Controller { set; get; }

        /// <summary>
        /// 权限资源
        /// </summary>
        [Display(Name = "可访问的Action")]
        [StringLength(500, ErrorMessage = "500字以内")]
        public string Actions
        {
            set;
            get;
        }

        [Display(Name = "系统菜单", Description = "系统菜单不能被删除")]
        public bool IsSys { set; get; }

        #endregion 基础属性


        #region 集合属性
        public virtual ICollection<Nav> SonNavs { set; get; }
        #endregion 集合属性
    }
}
