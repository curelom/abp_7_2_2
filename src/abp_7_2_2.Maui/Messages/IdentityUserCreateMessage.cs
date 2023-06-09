using CommunityToolkit.Mvvm.Messaging.Messages;
using Volo.Abp.Identity;

namespace abp_7_2_2.Maui.Messages;
public class IdentityUserCreateMessage : ValueChangedMessage<IdentityUserCreateDto>
{
    public IdentityUserCreateMessage(IdentityUserCreateDto value) : base(value)
    {
    }
}
