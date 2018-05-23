using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Site:EntityBase
    {
        [Display(Name = "标题")]
        [StringLength(100)]
        [Required]
        public string Title
        {
            set;
            get;
        }

        [Display(Name = "绑定域名")]
        [StringLength(255)]
        public string Domain
        {
            set;
            get;
        }

        /// <summary>
        /// 频道名称
        /// </summary>
        [StringLength(50, ErrorMessage = "×50字符以内")]
        [RegularExpression("^[a-zA-Z0-9-_]{2,50}$")]
        //[Remote("NotExist", "ChannelSite", "Admin", AdditionalFields = "Id", ErrorMessage = "该调用名称已存在")]
        [Required]
        public string Alias
        {
            set;
            get;
        }

        [Display(Name = "网站名称")]
        [StringLength(255)]
        [Required]
        public string SiteName
        {
            set;
            get;
        }

        [Display(Name = "Logo")]
        [StringLength(255)]
        public string Logo
        {
            set;
            get;
        }

        [Display(Name = "公司名称")]
        [StringLength(255)]
        public string Company
        {
            set;
            get;
        }
        [Display(Name = "通讯地址")]
        [StringLength(255)]
        public string Address
        {
            set;
            get;
        }
        [Display(Name = "联系电话")]
        [StringLength(30)]
        public string Tel
        {
            set;
            get;
        }
        [Display(Name = "传真号码")]
        [StringLength(30)]
        public string Fax
        {
            set;
            get;
        }
        [Display(Name = "电子邮箱")]
        [StringLength(50)]
        public string Email
        {
            set;
            get;
        }
        [Display(Name = "备案号")]
        [StringLength(100)]
        public string Crod
        {
            set;
            get;
        }
        [Display(Name = "版权信息")]
        public string Copyright
        {
            set;
            get;
        }
        [Display(Name = "SEO标题")]
        [StringLength(255)]
        public string SeoTitle
        {
            set;
            get;
        }
        [Display(Name = "SEO关键字")]
        [StringLength(255)]
        public string SeoKeyword
        {
            set;
            get;
        }
        [Display(Name = "SEO描述")]
        [StringLength(500)]
        public string SeoDescription
        {
            set;
            get;
        }
        /// <summary>
        /// 是否默认
        /// </summary>
        public bool IsDefault
        {
            set;
            get;
        }
        /// <summary>
        /// 排序数字
        /// </summary>
        public int SortId
        {
            set;
            get;
        }
    }
}
