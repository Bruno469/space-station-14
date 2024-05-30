using Content.Server.Chat;

namespace Content.Server.Chat.Systems;

public sealed class AnnounceOnSpawnSystem : EntitySystem
{
    [Dependency] private readonly ChatSystem _chat = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<AnnounceOnSpawnComponent, MapInitEvent>(OnInit);
    }

    private void OnInit(EntityUid uid, AnnounceOnSpawnComponent comp, MapInitEvent args)
    {
        var message = Loc.GetString(comp.Message);
<<<<<<< HEAD
        var sender = comp.Sender != null ? Loc.GetString(comp.Sender) : Loc.GetString("chat-manager-sender-announcement");
        _chat.DispatchGlobalAnnouncement(message, sender, playSound: true, comp.Sound, comp.Color);
=======
        var sender = comp.Sender != null ? Loc.GetString(comp.Sender) : "Central Command";
        _chat.DispatchGlobalAnnouncement(message, sender, playSound: true, announcementSound: comp.Sound, colorOverride: comp.Color);
>>>>>>> 5775d4cdef (Merge sunrise build (#2))
    }
}
