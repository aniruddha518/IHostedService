namespace BackgroundTaskDemo
{
    public interface IWorker
    {
        Task Dowork(CancellationToken cancellationToken);
    }
}