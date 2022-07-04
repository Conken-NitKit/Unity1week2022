using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 4つのWallのPrefabどれかをランダムに呼び出すメソッド
/// </summary>
public class RandomWall : MonoBehaviour
{
   
    [SerializeField] GameObject[] wallPrefabs;
    [SerializeField] int randomNumber;
   
    void FixedUpdate()
    {
        
    }

}
