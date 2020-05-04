using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///summery
///
///summery

public class CountdownTimer : MonoBehaviour
{
    //需求1秒修改一次text文本
    //1,查找组件引用
    //2,定义变量：秒
    //3，秒->  02:00格式
    //4,修改文本
    //5，如何每秒修改一次

    private Text txtTimer;
    public int second = 120;
    private int markedTime;

    private void Start()
    {
        txtTimer = this.GetComponent<Text>();
        markedTime = 0;
    }

    private void Update()
    {
        if (Time.realtimeSinceStartup - markedTime > 1)
        {
            markedTime = (int) Time.realtimeSinceStartup;
            second--;
        }       
        txtTimer.text = string.Format("{0:d2}:{1:d2}", second / 60, second % 60);

        if (second < 10)
            txtTimer.color = Color.red;
        if (second < 0)
            second = 0;
    }

    private void OnGUI()
    {
        if (GUILayout.Button("定时器2分钟"))
            second = 120;
    }


}
