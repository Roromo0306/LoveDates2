using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField] private Image iconImage;

    public Sprite hiddenIconsprite;
    public Sprite iconSprite;

    public bool isSelected;

    public CardController controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetIconSprite(Sprite sprite)
    {
        iconSprite = sprite;    
    }

    public void Show()
    {
        iconImage.sprite = iconSprite;
        isSelected = true;
    }

    public void Hide()
    {
        iconImage.sprite = hiddenIconsprite;
        isSelected = false;
    }

    public void OnCardClick()
    {
        controller.SetSelected(this);
    }
}
