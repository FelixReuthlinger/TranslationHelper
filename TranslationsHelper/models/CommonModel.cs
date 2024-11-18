using System.Collections.Generic;
using JetBrains.Annotations;
using Jotunn;

namespace TranslationsHelper.models;

public class CommonModel : NameModel
{
    public CommonModel(ItemDrop fromItemDrop) : base(fromItemDrop.name, fromItemDrop.m_itemData.m_shared.m_name)
    {
        TranslationDescriptionToken = fromItemDrop.m_itemData.m_shared.m_description;
        var guidePoint = fromItemDrop.gameObject.GetComponentInChildren<GuidePoint>();
        if (guidePoint != null)
        {
            Logger.LogInfo($"GuidePoint {guidePoint.name} found in {fromItemDrop.name}");
            Tutorial = new TutorialTextModel(guidePoint.m_text);
        }
    }

    public CommonModel(Piece fromPiece) : base(fromPiece.name, fromPiece.m_name)
    {
        TranslationDescriptionToken = fromPiece.m_description;
        var guidePoint = fromPiece.gameObject.GetComponentInChildren<GuidePoint>();
        if (guidePoint != null)
        {
            Logger.LogInfo($"GuidePoint {guidePoint.name} found in {fromPiece.name}");
            Tutorial = new TutorialTextModel(guidePoint.m_text);
        }
    }

    [UsedImplicitly] public readonly string TranslationDescriptionToken;
    [UsedImplicitly] public readonly TutorialTextModel? Tutorial;

    public override List<string> Translate()
    {
        var result = new List<string>
        {
            TranslateTokenToPair(TranslationNameToken),
            TranslateTokenToPair(TranslationDescriptionToken),
        };
        if (Tutorial != null) result.AddRange(Tutorial.Translate());
        return result;
    }
}