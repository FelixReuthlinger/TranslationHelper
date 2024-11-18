using System.Collections.Generic;
using JetBrains.Annotations;
using Jotunn;

namespace TranslationsHelper.models;

public class ItemModel : NameModel
{
    [UsedImplicitly] public readonly StatusEffectModel? ItemStatusEffect;

    public ItemModel(ItemDrop fromItemDrop) : base(fromItemDrop.name, fromItemDrop.m_itemData.m_shared.m_name)
    {
        if (fromItemDrop.m_itemData.m_shared.m_equipStatusEffect != null)
            ItemStatusEffect = new StatusEffectModel(fromItemDrop.m_itemData.m_shared.m_equipStatusEffect);
    }

    public override List<string> Translate()
    {
        var result = base.Translate();
        if (ItemStatusEffect != null) result.AddRange(ItemStatusEffect.Translate());
        return result;
    }
}