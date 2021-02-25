using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        //params ile göderilen iş kurallarından başarısız olanı business a logic döndürür
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)//kurala uymayanı döndür
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
