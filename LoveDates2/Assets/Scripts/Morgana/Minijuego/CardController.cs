using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    [SerializeField] Card cardPrefab;
    [SerializeField] Transform gridLayout;
    [SerializeField] Sprite[] sprites;
    private List<Sprite> spritePairs;

    Card firstSelected;
    Card secondSelected;

    public GameObject congratulations;
    int matchCount;
    // Start is called before the first frame update
    void Start()
    {
        PrepareSprites();
        CreateCards();
        congratulations.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSelected(Card card)
    {
        if(card.isSelected == false)
        {
            card.Show();
            if (firstSelected == null)
            {
                firstSelected = card;
                return;
            }
            if (secondSelected == null)
            {
                secondSelected = card;
                StartCoroutine(CheckMatching(firstSelected,secondSelected));
                firstSelected = null;
                secondSelected = null;
            }
        }
    }
    IEnumerator CheckMatching(Card a, Card b)
    {
        yield return new WaitForSeconds(0.3f);
        if(a.iconSprite == b.iconSprite)
        {
            matchCount++;
            if(matchCount>= spritePairs.Count/2)
            {
                congratulations.SetActive(true);
            }
        }
        else
        {
            a.Hide();
            b.Hide();
        }
    }
    private void PrepareSprites()
    {
        spritePairs = new List<Sprite>();
        for(int i = 0; i < sprites.Length; i++)
        {
            spritePairs.Add(sprites[i]);
            spritePairs.Add(sprites[i]);
        }
        ShuffleSprites(spritePairs);
    }

    void CreateCards()
    {
        for(int i = 0; i<spritePairs.Count; i++)
        {
            Card card = Instantiate(cardPrefab, gridLayout);
            card.SetIconSprite(spritePairs[i]);
            card.controller = this;
        }
    }

    void ShuffleSprites(List<Sprite> spriteList)
    {
        for(int i = spriteList.Count -1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);

            Sprite temp = spriteList[i];
            spriteList[i] = spriteList[randomIndex];
            spriteList[randomIndex] = temp;
        }
    }
}
