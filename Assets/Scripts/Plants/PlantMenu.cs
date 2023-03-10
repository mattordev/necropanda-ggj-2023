using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlantMenu : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Image image;

    Plant plant;

    public void SetupMenu(Plant plant)
    {
        this.plant = plant;
        text.text = plant.plantName  + "( x " + plant.numberOfPlants + ")";
        image.sprite = plant.sprite;
    }

    public void ButtonPressed()
    {
        MouseSelect.instance.canClick = false;
        MouseSelect.instance.GetBuildMenu().SetOpen(plant);
    }
}
