using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestEngine
{
    public interface IRestEngine
    {
        Task<string> Request(string url);
    }
}


