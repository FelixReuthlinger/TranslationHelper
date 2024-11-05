using System.Collections.Generic;
using JetBrains.Annotations;

namespace TranslationsHelper.models;

public class StatusEffectModel: NameModel
{
    [UsedImplicitly] public readonly string ToolTipToken;
    [UsedImplicitly] public readonly string RepeatMessage;
    [UsedImplicitly] public readonly string StartMessage;
    [UsedImplicitly] public readonly string StopMessage;
    
    public StatusEffectModel(StatusEffect statusEffect): base(statusEffect.name, statusEffect.m_name)
    {
        ToolTipToken = statusEffect.m_tooltip;
        RepeatMessage = statusEffect.m_repeatMessage;
        StartMessage = statusEffect.m_startMessage;
        StopMessage = statusEffect.m_stopMessage;
    }

    public override List<string> Translate()
    {
        List<string> toolTipTranslations = base.Translate();
        toolTipTranslations.AddRange(new List<string>
        {
            TranslateTokenToPair(ToolTipToken),
            TranslateTokenToPair(RepeatMessage),
            TranslateTokenToPair(StartMessage),
            TranslateTokenToPair(StopMessage)
        });
        return toolTipTranslations;
    }
}