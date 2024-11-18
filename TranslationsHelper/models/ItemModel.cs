using System.Collections.Generic;
using JetBrains.Annotations;

namespace TranslationsHelper.models;

public class ItemModel : NameModel
{
    [UsedImplicitly] public readonly string SetName;
    [UsedImplicitly] public readonly StatusEffectModel? ItemStatusEffect;

    public ItemModel(ItemDrop fromItemDrop) : base(fromItemDrop.name, fromItemDrop.m_itemData.m_shared.m_name)
    {
        SetName = fromItemDrop.m_itemData.m_shared.m_setName;
        if (fromItemDrop.m_itemData.m_shared.m_equipStatusEffect)
            ItemStatusEffect = new StatusEffectModel(fromItemDrop.m_itemData.m_shared.m_equipStatusEffect);
    }

    public override List<string> Translate()
    {
        var result = base.Translate();
        if (ItemStatusEffect != null) result.AddRange(ItemStatusEffect.Translate());
        return result;
    }
}