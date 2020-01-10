using worksln.Application.Common.Interfaces;
using System;

namespace worksln.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
