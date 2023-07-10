using CommunityToolkit.Mvvm.Messaging.Messages;

namespace LogTest.Mobile.Messengers;

internal class NetworkLengthMessage : ValueChangedMessage<int>
{
    public NetworkLengthMessage(int value) : base(value)
    {
    }
}
