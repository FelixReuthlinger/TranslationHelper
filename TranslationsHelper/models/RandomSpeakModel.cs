using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace TranslationsHelper.models;

public class RandomSpeakModel : Translatable
{
    [UsedImplicitly] public readonly List<string> RandomTexts;
    [UsedImplicitly] public readonly string Topic;

    public RandomSpeakModel(RandomSpeak speaker)
    {
        Topic = speaker.m_topic;
        RandomTexts = speaker.m_texts.ToList();
    }

    public override List<string> Translate()
    {
        List<string> translatedTexts = RandomTexts.Select(TranslateTokenToPair).ToList();
        translatedTexts.Add(TranslateTokenToPair(Topic));
        return translatedTexts;
    }
}