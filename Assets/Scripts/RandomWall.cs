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
        if (Input.GetKey(KeyCode.Return))
    
        {
            /*randomNumber = Random.Range(0, cubePrefabs.Length);
            Instantiate(cubePrefabs[randomNumber], new Vector3(-10, 0, 0), Quaternion.identity);
            //X座標-10にランダム出現、向きの設定は無し
            */

        }
    }

}
