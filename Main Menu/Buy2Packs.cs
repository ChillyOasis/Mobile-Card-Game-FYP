using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy2Packs : MonoBehaviour
{
    public Text packNumInMain;
    public Text packNumInOpenPack;

    public void ButtonClicked()
    {
        ExpScript.packs += 2;

        packNumInMain.text = ExpScript.packs.ToString();
        packNumInOpenPack.text = ExpScript.packs.ToString();
    }
}
