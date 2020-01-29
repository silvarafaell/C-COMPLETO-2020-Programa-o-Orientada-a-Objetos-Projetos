using System;


namespace SalesWebMvc.Services.Exception
{
    public class NotFoundException : ApplicationException //herdar do aplicationException
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
