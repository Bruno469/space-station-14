using Robust.Shared.Audio;
using Robust.Shared.GameStates;

namespace Content.Shared.Standing;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class StandingStateComponent : Component
{
<<<<<<< HEAD
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField]
    public SoundSpecifier DownSound { get; private set; } = new SoundCollectionSpecifier("BodyFall");

    // WD EDIT START
    [DataField, AutoNetworkedField]
    public StandingState CurrentState { get; set; } = StandingState.Standing;
    // WD EDIT END
=======
    [DataField]
    public SoundSpecifier DownSound { get; private set; } = new SoundCollectionSpecifier("BodyFall");

    [DataField, AutoNetworkedField]
    public StandingState CurrentState { get; set; } = StandingState.Standing;
>>>>>>> 40568a243c (lay down + scope (#476))

    [DataField, AutoNetworkedField]
    public bool Standing { get; set; } = true;

    /// <summary>
    ///     List of fixtures that had their collision mask changed when the entity was downed.
    ///     Required for re-adding the collision mask.
    /// </summary>
    [DataField, AutoNetworkedField]
    public List<string> ChangedFixtures = new();
<<<<<<< HEAD
=======
}

public enum StandingState
{
    Lying,
    GettingUp,
    Standing,
>>>>>>> 40568a243c (lay down + scope (#476))
}
// WD EDIT START
public enum StandingState
{
    Lying,
    GettingUp,
    Standing,
}
// WD EDIT END
