using Content.Shared._DV.Traits.Effects;
using Content.Shared.Tag;
using Robust.Shared.Prototypes;

namespace Content.Shared._Euphoria.Traits.Effects;

public sealed partial class RemTagTraitEffect : BaseTraitEffect
{
    [DataField(required: true)]
    public ProtoId<TagPrototype> TagToRem = new();

    public override void Apply(TraitEffectContext ctx)
    {
        ctx.EntMan.System<TagSystem>().RemoveTag(ctx.Player, TagToRem);
    }
}
