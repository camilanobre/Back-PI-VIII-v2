using System;

namespace back_piviii.BLL.Exceptions
{
    public class  NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }

}