using CommunityToolkit.Mvvm.Messaging.Messages;

namespace abp_7_2_2.Maui.Messages;
public class LogoutMessage : ValueChangedMessage<bool?>
{
    public LogoutMessage(bool? value = null) : base(value)
    {
    }
}