using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WallManager : MonoBehaviour
{
    [SerializeField] WallAnimation wallAnimation;

    void Stare()
    {
        
    }

    void FixedUpdate()
    {
        wallAnimation.widthWallMove();
    }

}
