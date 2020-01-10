using worksln.Application.Common.Interfaces;
using System;

namespace worksln.WebUI.IntegrationTests
{
    public class TestDateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
