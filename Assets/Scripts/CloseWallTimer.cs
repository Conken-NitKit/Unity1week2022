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
    [SerializeField] Text displayGoText; //変数困る
    [SerializeField] float countStartTime;
    int waitingSeconds;

    private void FixedUpdate()
    {
        countStartTime -= Time.deltaTime;

        //float型からint型に変換
        waitingSeconds = (int)countStartTime;

        if (waitingSeconds > 0)
        {
            wallCloseTimerText.text = waitingSeconds.ToString();
        }
        else if (waitingSeconds <= 0)
        {
            wallCloseTimerText.text = "";
        }
    }

}
