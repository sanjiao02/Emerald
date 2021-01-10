using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCDialog : MonoBehaviour
{
    [HideInInspector]
    public List<string> Lines;    
    public TMP_Text Name, Text;

    public void NewText(string name, List<string> lines)
    {
        Lines = lines;
        Text.text = string.Empty;
        Name.text = name;

        for (int i = 0; i < Lines.Count; i++)
        {
            Text.text += Lines[i] + "\n";
        }
    }
}
