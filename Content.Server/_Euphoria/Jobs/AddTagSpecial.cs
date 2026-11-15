using Content.Shared.Roles;
using Content.Shared.Tag;
using Robust.Shared.Prototypes;

namespace Content.Server.Jobs;

public sealed partial class AddTagSpecial : JobSpecial
{

    [DataField(required: true)]
    public ProtoId<TagPrototype> Tag;

    public override void AfterEquip(EntityUid mob)
    {
        var entMan = IoCManager.Resolve<IEntityManager>();
        entMan.System<TagSystem>().AddTag(mob,Tag);
    }
}
