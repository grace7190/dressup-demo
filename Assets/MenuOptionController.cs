using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuOptionController : MonoBehaviour
{
    public List<CharacterOption> charOptions;
    public int selectedIdx = 0;
    public GameObject charOptionText;
    public GameObject charOptionSprite;
    [SerializeField] private GameObject charSpriteExtra = null;
    //public GameObject charSpriteExtra;
    public Button prevButton;
    public Button nextButton;
    public Sprite nullSprite; 
    
    private void Start()
    {
        SetSprites();
        SetButtonsInteractable();
    }

    public void SelectPrev()
    {
        if (selectedIdx > 0)
        {
            selectedIdx--;
            SetSprites();
        }
        SetButtonsInteractable();
    }

    public void SelectNext()
    {
        if (selectedIdx < charOptions.Count)
        {
            selectedIdx++;
            SetSprites();
        }
        SetButtonsInteractable();
    }

    private void SetButtonsInteractable()
    {
        prevButton.interactable = selectedIdx != 0;
        nextButton.interactable = selectedIdx != charOptions.Count - 1;
    }

    private void SetSprites()
    {
        charOptionText.GetComponent<Image>().sprite = charOptions[selectedIdx].displayNameImage;
        charOptionSprite.GetComponent<Image>().sprite = charOptions[selectedIdx].optionImage;
        if (charSpriteExtra != null)
        {
            if (charOptions[selectedIdx].optionImageExtra != null)
                charSpriteExtra.GetComponent<Image>().sprite = charOptions[selectedIdx].optionImageExtra;
            else
                charSpriteExtra.GetComponent<Image>().sprite = nullSprite;
        }
    }
}
