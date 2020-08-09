using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Web.Response
{
    public class Response<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public List<string> Errors { get; set; } = new List<string>();
    }
}
