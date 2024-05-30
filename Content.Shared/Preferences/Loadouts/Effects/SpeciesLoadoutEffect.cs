using System.Diagnostics.CodeAnalysis;
using Content.Shared.Humanoid.Prototypes;
using Robust.Shared.Player;
using Robust.Shared.Prototypes;
using Robust.Shared.Utility;

namespace Content.Shared.Preferences.Loadouts.Effects;

public sealed partial class SpeciesLoadoutEffect : LoadoutEffect
{
    [DataField(required: true)]
    public List<ProtoId<SpeciesPrototype>> Species = new();

<<<<<<< HEAD
    public override bool Validate(HumanoidCharacterProfile profile, RoleLoadout loadout, ICommonSession? session, IDependencyCollection collection,
=======
    public override bool Validate(HumanoidCharacterProfile profile, RoleLoadout loadout, LoadoutPrototype proto, ICommonSession session, IDependencyCollection collection, // Sunrise-Sponsors
>>>>>>> 5775d4cdef (Merge sunrise build (#2))
        [NotNullWhen(false)] out FormattedMessage? reason)
    {
        if (Species.Contains(profile.Species))
        {
            reason = null;
            return true;
        }

        reason = FormattedMessage.FromUnformatted(Loc.GetString("loadout-group-species-restriction"));
        return false;
    }
}
