namespace JDI.Light.Core.Interfaces.Utils
{
    public interface IKillDriver
    {
        string[] ProcessToKill { get; set; }
        void KillAllRunningDrivers();
    }
}
