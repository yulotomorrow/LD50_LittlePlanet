using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public struct DialogInfo 
{
    public string dialogText;
    public int indexNPC;
    public int indexIcon;
    public int isScripted;

    public DialogInfo(string dText, int NPC, int icon, int scripted) 
    {
        dialogText = dText;
        indexNPC = NPC;
        indexIcon = icon;
        isScripted = scripted;
    }
}
