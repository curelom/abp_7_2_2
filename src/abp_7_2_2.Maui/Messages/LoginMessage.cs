using CommunityToolkit.Mvvm.Messaging.Messages;

namespace abp_7_2_2.Maui.Messages;
public class LoginMessage : ValueChangedMessage<bool?>
{
    public LoginMessage(bool? value = null) : base(value)
    {
    }
}
