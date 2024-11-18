using System.Collections.Generic;
using JetBrains.Annotations;
using Jotunn;

namespace TranslationsHelper.models;

public class ItemModel : CommonModel
{
    [UsedImplicitly] public readonly StatusEffectModel? ItemStatusEffect;

    public ItemModel(ItemDrop fromItemDrop) : base(fromItemDrop)
    {
        var equipEffect = fromItemDrop.m_itemData.m_shared.m_equipStatusEffect;
        if (equipEffect != null)
        {
            Logger.LogInfo($"Equip status effect {equipEffect.name} found in {fromItemDrop.name}");
            ItemStatusEffect = new StatusEffectModel(fromItemDrop.m_itemData.m_shared.m_equipStatusEffect);
        }
    }

    public override List<string> Translate()
    {
        var result = base.Translate();
        if (ItemStatusEffect != null) result.AddRange(ItemStatusEffect.Translate());
        return result;
    }
}