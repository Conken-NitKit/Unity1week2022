using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Wall�������n�߂�܂ł�wait���Ԃ��J�E���g���郁�\�b�h
/// </summary>
public class CloseWallTimer : MonoBehaviour
{
    [SerializeField] Text wallCloseTimerText;
    [SerializeField] Text displayGoText; //�ϐ�����
    [SerializeField] float countStartTime;
    int waitingSeconds;

    private void FixedUpdate()
    {
        countStartTime -= Time.deltaTime;

        //float�^����int�^�ɕϊ�
        waitingSeconds = (int)countStartTime;

        if (waitingSeconds > 0)
        {
            wallCloseTimerText.text = waitingSeconds.ToString();
        }
        else if(waitingSeconds <= 0)
        {
            wallCloseTimerText.text = "";
        }
       
    }

}
