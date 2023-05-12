using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelInGame : MonoBehaviour
{


    public Slider sliderInnovation;

    public void UpdatePlayerValues ()
    {
        sliderInnovation.value = Main.instance.player.innovation;

    }
}
