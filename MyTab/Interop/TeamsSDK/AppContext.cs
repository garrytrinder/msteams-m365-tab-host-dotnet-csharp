using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MyTab.Interop.TeamsSDK;

public class Context
{
    public AppInfo App { get; set; }
    public ChannelInfo Channel { get; set; }
}

public class AppInfo
{
    public AppHostInfo Host { get; set; }
}

public class AppHostInfo
{
    [JsonConverter(typeof(EnumDescriptionConverter<HostName>))]
    public HostName Name { get; set; }
}

/// <summary>
/// https://learn.microsoft.com/en-us/javascript/api/@microsoft/teams-js/hostname?view=msteams-client-js-latest
/// </summary>
public enum HostName
{
    [Description("office")] Office,
    [Description("outlook")] Outlook,
    [Description("outlookWin32")] OutlookWin32,
    [Description("teams")] Teams,
    [Description("teamsModern")] TeamsModern
}

public class ChannelInfo { 
    public string DefaultOneNoteSectionId { get; set; }

    public string DisplayName { get; set; }

    public string Id { get; set; }

    [JsonConverter(typeof(EnumDescriptionConverter<ChannelType>))]
    public ChannelType MembershipType { get; set; }

    public string OwnerGroupId { get; set; }

    public string OwnerTenantId { get; set; }

    public string RelativeUrl { get; set; }
}
