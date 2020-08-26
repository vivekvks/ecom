using System.Collections.Generic;

namespace Ecom.Models.Response
{
    public class Response<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public List<string> Errors { get; set; } = new List<string>();
    }
}
