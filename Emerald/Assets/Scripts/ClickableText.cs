
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class ClickableText : MonoBehaviour, IPointerClickHandler
{

    [SerializeField] public TMP_Text Acks;
    public GameSceneManager GameSceneManager;
    public NPCDialog NPCDialog;
    public String Sendrep;

    public void OnPointerClick(PointerEventData eventData)
    {

        if (eventData.button == PointerEventData.InputButton.Left)
        {

            int linkIndex = TMP_TextUtilities.FindIntersectingLink(Acks, Input.mousePosition, null);
            if (linkIndex > -1)
            {
                var linkInfo = Acks.textInfo.linkInfo[linkIndex];
                string linkId = linkInfo.GetLinkID();

                if (linkId == "@exit")
                {

                    NPCDialog.gameObject.SetActive(false);
                    return;

                }

                GameSceneManager.NPCtextbutton(linkId);

            }


        }

    }


}
