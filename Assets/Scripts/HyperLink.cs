using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class HyperLink : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private TextMeshProUGUI hyperText;
    public void OnPointerClick(PointerEventData eventData)
    {
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(hyperText, Input.mousePosition, null);
        if (linkIndex != -1)
        {
            TMP_LinkInfo linkInfo = hyperText.textInfo.linkInfo[linkIndex];
            string linkId = linkInfo.GetLinkID();
            if ( linkId == "https://github.com/KARACb234")
            {
                Application.OpenURL("https://github.com/KARACb234");
            }
        }
    }
}
