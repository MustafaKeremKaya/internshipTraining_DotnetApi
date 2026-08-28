using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        /*params:: allows you to pass a variable number of arguments to a method.
        In this case, it allows you to pass multiple IResult objects to the Run method.*/
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (logic != null)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
