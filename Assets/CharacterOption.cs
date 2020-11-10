using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "co_optionName", menuName = "ScriptableObjects/Character Option Object", order = 1)]
public class CharacterOption : ScriptableObject
{
    public Sprite displayNameImage;
    public Sprite optionImage;
    public Sprite optionImageExtra;
}
