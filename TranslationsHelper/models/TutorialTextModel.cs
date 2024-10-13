using System.Collections.Generic;
using JetBrains.Annotations;

namespace TranslationsHelper.models;

public class TutorialTextModel : Translatable
{
    public TutorialTextModel(RuneStone original)
    {
        TextToken = original.m_text;
        TopicToken = original.m_topic;
        LabelToken = original.m_label;
    }

    public TutorialTextModel(Raven.RavenText original)
    {
        TextToken = original.m_text;
        TopicToken = original.m_topic;
        LabelToken = original.m_label;
    }

    [UsedImplicitly] public readonly string TextToken;
    [UsedImplicitly] public readonly string TopicToken;
    [UsedImplicitly] public readonly string LabelToken;

    public override List<string> Translate()
    {
        List<string> translations = new();
        translations.AddRange(new List<string>
        {
            TranslateTokenToPair(TextToken),
            TranslateTokenToPair(TopicToken),
            TranslateTokenToPair(LabelToken)
        });
        return translations;
    }
}