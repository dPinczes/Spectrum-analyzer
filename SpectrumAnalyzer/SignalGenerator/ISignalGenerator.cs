namespace SignalGenerator
{
    public interface ISignalGenerator
    {
        void Start();
        void Stop();
        bool GetStatus();
    }
}