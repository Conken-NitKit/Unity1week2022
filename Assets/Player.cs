using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

///<summary>
///プレイヤーの動きの処理
///</summary>
public class Player : MonoBehaviour
{
    private const float defaultXPosition = 0;
    private const float defaultYPosition = 0;
    private const float rightXPositon = 2f;
    private const float leftXPosition = -2f;
    private const float upYPosition = 2.5f;
    private const float downYPosition = -2.5f;
    private const float moveTime = 0.01f;
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
            this.transform.DOMove(new Vector2(rightXPositon,defaultYPosition),moveTime);
            pushOtherKey = true;
            pushRightArrowKey = true;
        }

        if(Input.GetKey(KeyCode.LeftArrow) && pushOtherKey == false)
        {
            this.transform.DOMove(new Vector2(leftXPosition,defaultYPosition),moveTime);
            pushOtherKey = true;
            pushLeftArrowKey = true;
        }

        if(Input.GetKey(KeyCode.UpArrow) && pushOtherKey == false)
        {
            this.transform.DOMove(new Vector2(defaultXPosition,upYPosition),moveTime);
            pushOtherKey = true;
            pushUpArrowKey = true;
        }

        if(Input.GetKey(KeyCode.DownArrow) && pushOtherKey == false)
        {
            this.transform.DOMove(new Vector2(defaultXPosition,downYPosition),moveTime);
            pushOtherKey = true;
            pushDownArrowKey = true;
        }

        if((Input.GetKeyUp(KeyCode.RightArrow) && pushRightArrowKey == true) || (Input.GetKeyUp(KeyCode.LeftArrow) && pushLeftArrowKey == true) || (Input.GetKeyUp(KeyCode.UpArrow) && pushUpArrowKey == true) || (Input.GetKeyUp(KeyCode.DownArrow) && pushDownArrowKey == true))
        {
            this.transform.DOMove(new Vector2(defaultXPosition,defaultYPosition),moveTime);
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
