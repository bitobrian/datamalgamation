using Quartz;
using System.Threading.Tasks;
using TheCollector.Services;

namespace TheCollector.Jobs
{
    [DisallowConcurrentExecution]
    public class ExampleJob : IJob
    {
        private readonly IJobService _jobService;

        public ExampleJob(IJobService jobService)
        {
            _jobService = jobService;
        }

        public Task Execute(IJobExecutionContext context)
        {
            _jobService.RunSuccessfulJob();

            _jobService.RunUnsuccessfulJob();

            return Task.CompletedTask;
        }
    }
}
