using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

///<summary>
///プレイヤーの動きのクラス
///</summary>
public class Player : MonoBehaviour
{
    [SerializeField]
    AudioClip soundMove;
    [SerializeField]
    AudioSource audioSource;

    [SerializeField]
    SpriteRenderer spriteRenderer;

    [SerializeField]
    Sprite leftWardSprite;
    [SerializeField]
    Sprite rightWardSprite;
    [SerializeField]
    Sprite upWardSprite;
    [SerializeField]
    Sprite downWardSprite;


    private const float DefaultXPosition = 0;
    private const float DefaultYPosition = 0;
    private const float RightXPositon = 2f;
    private const float LeftXPosition = -2f;
    private const float UpYPosition = 2.5f;
    private const float DownYPosition = -2.5f;
    private const float MoveSeconds = 0.01f;

    private bool pushOtherKey = false;
    private bool pushRightArrowKey = false;
    private bool pushLeftArrowKey = false;
    private bool pushUpArrowKey = false;
    private bool pushDownArrowKey = false;


    void Update()
    {
        MovePlayer();
    }
    
    ///<summary>
    ///矢印キーの方向に移動するメソッド
    ///</summary>
    void MovePlayer()
    {
        if(Input.GetKey(KeyCode.RightArrow) && pushOtherKey == false)
        {
            spriteRenderer.sprite = rightWardSprite;
            this.transform.DOMove(new Vector2(RightXPositon,DefaultYPosition),MoveSeconds);
            pushOtherKey = true;
            pushRightArrowKey = true;
            audioSource.PlayOneShot(soundMove);
        }

        if(Input.GetKey(KeyCode.LeftArrow) && pushOtherKey == false)
        {
            spriteRenderer.sprite = leftWardSprite;
            this.transform.DOMove(new Vector2(LeftXPosition,DefaultYPosition),MoveSeconds);
            pushOtherKey = true;
            pushLeftArrowKey = true;
            audioSource.PlayOneShot(soundMove);
        }

        if(Input.GetKey(KeyCode.UpArrow) && pushOtherKey == false)
        {
            spriteRenderer.sprite = upWardSprite;
            this.transform.DOMove(new Vector2(DefaultXPosition,UpYPosition),MoveSeconds);
            pushOtherKey = true;
            pushUpArrowKey = true;
            audioSource.PlayOneShot(soundMove);
        }

        if(Input.GetKey(KeyCode.DownArrow) && pushOtherKey == false)
        {
            this.transform.DOMove(new Vector2(DefaultXPosition,DownYPosition),MoveSeconds);
            pushOtherKey = true;
            pushDownArrowKey = true;
            audioSource.PlayOneShot(soundMove);
        }

        if((Input.GetKeyUp(KeyCode.RightArrow) && pushRightArrowKey == true) || (Input.GetKeyUp(KeyCode.LeftArrow) && pushLeftArrowKey == true) || (Input.GetKeyUp(KeyCode.UpArrow) && pushUpArrowKey == true) || (Input.GetKeyUp(KeyCode.DownArrow) && pushDownArrowKey == true))
        {
            spriteRenderer.sprite = downWardSprite;
            this.transform.DOMove(new Vector2(DefaultXPosition,DefaultYPosition),MoveSeconds);
            pushOtherKey = false;
            if(pushRightArrowKey == true)
            {
                pushRightArrowKey = false;
            }
            if(pushLeftArrowKey == true)
            {
                pushLeftArrowKey = false;
            }
            if(pushUpArrowKey == true)
            {
                pushUpArrowKey = false;
            }
            if(pushDownArrowKey == true)
            {
                pushDownArrowKey =false;
            }
        }
    }
}
