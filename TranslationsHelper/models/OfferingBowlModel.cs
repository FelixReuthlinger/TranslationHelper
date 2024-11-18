using System.Collections.Generic;
using JetBrains.Annotations;

namespace TranslationsHelper.models;

public class OfferingBowlModel : NameModel
{
    public OfferingBowlModel(OfferingBowl original) : base(internalName: original.name, nameToken: original.m_name)
    {
        UseItemTextToken = original.m_useItemText;
        UsedAltarTextToken = original.m_usedAltarText;
        CannotOfferToken = original.m_cantOfferText;
        WrongOfferToken = original.m_wrongOfferText;
        IncompleteOfferingToken = original.m_incompleteOfferText;
    }

    [UsedImplicitly] public readonly string UseItemTextToken;
    [UsedImplicitly] public readonly string UsedAltarTextToken;
    [UsedImplicitly] public readonly string CannotOfferToken;
    [UsedImplicitly] public readonly string WrongOfferToken;
    [UsedImplicitly] public readonly string IncompleteOfferingToken;

    public override List<string> Translate()
    {
        var translations = base.Translate();
        translations.Add(TranslateTokenToPair(UseItemTextToken));
        translations.Add(TranslateTokenToPair(UsedAltarTextToken));
        translations.Add(TranslateTokenToPair(CannotOfferToken));
        translations.Add(TranslateTokenToPair(WrongOfferToken));
        translations.Add(TranslateTokenToPair(IncompleteOfferingToken));
        return translations;
    }
}