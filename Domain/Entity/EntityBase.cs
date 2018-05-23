using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class IdBase
    {
        [Key]
        [Display(Name = "标识符")]
        public int Id { set; get; }
    }

    public interface ISortBase
    {
        [Display(Name = "排序数字", Description = "*数字，越小越向前")]
        int SortId { set; get; }
    }

    public interface IStatusBase
    {
        [Display(Name = "是否显示")]
        bool Status { set; get; }
    }



    public interface IOperateBase
    {
        [Display(Name = "添加时间")]
        DateTime CreateTime { set; get; }

        [Display(Name = "添加人Id")]
        int? CreateEmployeeId { set; get; }

        //如果做了日志记录，记录每次变更的状态，也可在此处删除更新人
        [Display(Name = "更新时间")]
        DateTime UpdateTime { set; get; }

        [Display(Name = "更新人Id")]
        int? UpdateEmployeeId { set; get; }


    }

    public class EntityBase: IdBase,IOperateBase, ISortBase, IStatusBase
    {
        [Display(Name = "是否显示")]
        public bool Status { set; get; }

        [Display(Name = "排序数字", Description = "*数字，越小越向前")]
        public int SortId { set; get; }

        [Display(Name = "添加时间")]
        public DateTime CreateTime { set; get; }

        [Display(Name = "添加人Id")]
        public int? CreateEmployeeId { set; get; }

        //如果做了日志记录，记录每次变更的状态，也可在此处删除更新人
        [Display(Name = "更新时间")]
        public DateTime UpdateTime { set; get; }

        [Display(Name = "更新人Id")]
        public int? UpdateEmployeeId { set; get; }
    }
}
