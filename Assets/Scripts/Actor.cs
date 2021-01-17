using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{

    public Sprite[] emotionSprites;
    //contain sprites for character emotions
    SpriteRenderer spriteRender;

    public int ID; //Tells if character is on left or right - Left = 0, Right = 1

    public enum CharacterEmotions
    {
        neutral, happy, sad, angry //also use as order for array for easy read
    }
    // Character emotion images
    public CharacterEmotions myState;
    [SerializeField]
    void Awake()
    {
        myState = CharacterEmotions.neutral;
        // Default to neutral
        spriteRender = GetComponent<SpriteRenderer>();
    }

    // Change emotion
    public void ChangeState(string emotionName)
    {
        StartCoroutine(emotionName + "State");
    }

    IEnumerator SadState()
    {
        spriteRender.sprite = emotionSprites[2];
        myState = CharacterEmotions.sad;
        yield return null;
    }

    IEnumerator AngryState()
    {
        spriteRender.sprite = emotionSprites[3];
        myState = CharacterEmotions.angry;
        yield return null;
    }

    IEnumerator HappyState()
    {
        spriteRender.sprite = emotionSprites[1];
        myState = CharacterEmotions.happy;
        yield return null;
    }

    IEnumerator NeutralState()
    {
        spriteRender.sprite = emotionSprites[0];
        myState = CharacterEmotions.neutral;
        yield return null;
    }
}
