using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// (LengthかWidth)WallのPrefabどちらかをランダムに呼び出すメソッド
/// </summary>
public class RandomWall : MonoBehaviour
{
   
    [SerializeField] GameObject[] cubePrefabs;
    [SerializeField] int randomNumber;
   
    void FixedUpdate()
    {
        
    }

}
