using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Logging
{
    public interface ILogger
    {
        void Log(DateTime date, string content);
    }
}
