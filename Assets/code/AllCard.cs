using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllCard : MonoBehaviour
{
   public List<card>cards;
  public List<card> Allcard = new List<card>();
    public List<card> cardInHand = new List<card>();
    private void Start()
    {
        while (Allcard.Count < 30)
        {
            Allcard.Add(cards[Random.Range(0,cards.Count)]);
        }    
       for (int i = 0; i <= 4; i++) 
        {
            cardInHand.Add(Allcard[i]);
            var p = Instantiate(cardInHand[i]);
        }    

    }



}
