using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public int points;
    public int HitsToBreak;
    public Sprite HitSprite;

    public void BreakBrick()
    {
        HitsToBreak--;
        GetComponent<SpriteRenderer>().sprite = HitSprite;

    }
}
