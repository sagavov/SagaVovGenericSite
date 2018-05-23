using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Extension
{
    public class MaxWordsAttribute : ValidationAttribute
    {
        private readonly int _maxWords;
        protected MaxWordsAttribute(int maxWords) : base("{0} has too many words")
        {
            _maxWords = maxWords;
        }

        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string valueAsString = value.ToString();
                if (valueAsString.Split(' ').Length > _maxWords)
                {
                    return false;
                }
            }
            return true;
        }




    }
}