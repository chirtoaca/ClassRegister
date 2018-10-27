using System;
using System.Collections.Generic;
using System.Text;
using ClassRegister.Core.Interfaces;

namespace ClassRegister.Core.Services
{
    public class ExampleService : IExampleService
    {
        public DateTime GetDateTime()
        {
            return DateTime.Now.ToLocalTime();
        }
    }
}
