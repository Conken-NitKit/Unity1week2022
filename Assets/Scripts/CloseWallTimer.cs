using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Wallが動き始めるまでのwait時間をカウントするメソッド
/// </summary>
public class CloseWallTimer : MonoBehaviour
{
    [SerializeField] Text wallCloseTimerText;
    [SerializeField] Text displayGoText; //GoTextを表示する
    [SerializeField] float countStartTime;
    float waitingSeconds;

    private void FixedUpdate()
    {
        countStartTime -= Time.deltaTime;

        if (countStartTime > 0)
        {
            wallCloseTimerText.text = countStartTime.ToString("F0");
        }
        else if (countStartTime <= 0)
        {
            wallCloseTimerText.text = "";
        }
    }

}
