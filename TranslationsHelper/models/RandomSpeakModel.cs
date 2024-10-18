using System.Collections.Generic;
using System.Linq;

namespace TranslationsHelper.models;

public class RandomSpeakModel : Translatable
{
    private readonly List<string> randomTexts;
    
    public RandomSpeakModel(RandomSpeak speaker)
    {
        randomTexts = speaker.m_texts.ToList();
    }
    
    public override List<string> Translate()
    {
        return randomTexts.Select(TranslateTokenToPair).ToList();
    }
}