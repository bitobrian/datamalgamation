namespace TheCollector.Services
{
    public interface IJobService
    {
        public void RunSuccessfulJob();

        public void RunUnsuccessfulJob();
    }
}
