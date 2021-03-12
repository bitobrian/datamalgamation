using Microsoft.Extensions.Logging;
using System;

namespace TheCollector.Services
{
    public class JobService : IJobService
    {
        private readonly ILogger<JobService> _logger;

        public JobService(ILogger<JobService> logger)
        {
            _logger = logger;
        }

        public void RunSuccessfulJob()
        {
            _logger.LogInformation($"{DateTime.Now} - Job ran successfully.");
        }

        public void RunUnsuccessfulJob()
        {
            _logger.LogError($"{DateTime.Now} - Job ran unsuccessfully.");
        }
    }
}
