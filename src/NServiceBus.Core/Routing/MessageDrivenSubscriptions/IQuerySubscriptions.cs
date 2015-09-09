namespace NServiceBus.Unicast.Subscriptions.MessageDrivenSubscriptions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Allows to query for subscriptions.
    /// </summary>
    public interface IQuerySubscriptions
    {
        /// <summary>
        /// Returns a list of addresses of subscribers that previously requested to be notified
        /// of messages of the given message types.
        /// </summary>
        Task<IEnumerable<string>> GetSubscriberAddressesForMessage(IEnumerable<MessageType> messageTypes);
    }
}