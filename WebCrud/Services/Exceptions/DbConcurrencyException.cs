using System;

namespace WebCrud.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message): base(message)
        {

        }
    }
}
