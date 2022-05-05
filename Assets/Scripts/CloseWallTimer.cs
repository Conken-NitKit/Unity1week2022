using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseWallTimer : MonoBehaviour
{
    public Text closeWallTimerText;
    public Text displayGoText;
    public float countStartTime;
    int seconds;

    private void FixedUpdate()
    {
        countStartTime -= Time.deltaTime;

        //floatŒ^‚©‚çintŒ^‚É•ÏŠ·
        seconds = (int)countStartTime;

        if (seconds > 0)
        {
            closeWallTimerText.text = seconds.ToString();
        }
        else if(seconds <= 0)
        {
            closeWallTimerText.text = "";
        }
       
    }

}
