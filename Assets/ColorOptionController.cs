using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ColorOptionController : MonoBehaviour
{
    public List<Color> colorOptions;
    public List<Button> colorButtons;
    public GameObject imageGameObject;
    public int defaultIdx = 1;
    // maybe i need a list of buttons too :( 

    public void Start()
    {
        if (colorOptions.Count != colorButtons.Count)
        {
            Debug.LogError("Color Option Controller has mismatched number of color options/buttons!");
            return;
        }

        for (int i = 0; i < colorButtons.Count; ++i)
        {
            var idx = i;
            colorButtons[i].onClick.AddListener(delegate { ChangeColor(idx); });
        }

        colorButtons[defaultIdx].interactable = false;
    }

    private void ChangeColor(int idx)
    {
        // n.b. the image is set dynamically at runtime!
        imageGameObject.GetComponent<Image>().color = colorOptions[idx];

        // keep the last clicked button 'selected' by disabling it
        foreach (Button button in colorButtons)
            button.interactable = true;
        colorButtons[idx].interactable = false;
    }

}
