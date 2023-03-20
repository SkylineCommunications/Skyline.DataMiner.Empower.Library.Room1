using System.Threading.Tasks;

namespace Skyline.DataMiner.Empower.Library.Room1
{
    /// <summary>
    ///  Allows dispatching of an order to be sent over HTTPS to DataMiner.
    /// </summary>
    public interface IOrder
    {
        /// <summary>
        /// Dispatches this job and waits on result.
        /// REQUIRED - A user secret holding the GUID to log to DataMiner is required.
        /// Run the commands on every server you want to provide access: 
        /// dotnet tool install --global Skyline.DataMiner.CICD.Tools.WinEncryptedKeys
        /// WinEncryptedKeys --name SLC_EXTERNAL_DISPATCHER_KEY --value MYGUID
        /// </summary>
        /// <param name="user">The user dispatching the job.</param>
        /// <returns>True if the dispatch was successful, False if logging failed.</returns>
        bool Dispatch(string user);

        /// <summary>
        /// Dispatches this job without waiting on a result.
        /// Run the commands on every server you want to provide access: 
        /// dotnet tool install --global Skyline.DataMiner.CICD.Tools.WinEncryptedKeys
        /// WinEncryptedKeys --name SLC_EXTERNAL_DISPATCHER_KEY --value MYGUID
        /// </summary>
        /// <param name="user">The user dispatching the job.</param>
        /// <returns>True if the dispatch was successful, False if logging failed.</returns>
        Task<bool> DispatchAsync(string user);
    }
}