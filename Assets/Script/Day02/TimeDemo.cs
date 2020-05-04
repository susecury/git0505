using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///summery
///
///summery

public class TimeDemo : MonoBehaviour
{
    public float show_time;                //游戏时间，可以被 time scale 暂停
    public float show_unscaled_time;            //实际游戏运行时间
    public float show_realtimeSinceStartup;   //实际游戏运行时间
    public float show_unscaledDeltaTime;  //即使暂停了也大约 0.01秒一次
    public float speed;

    public void Update()
    {
       show_time = Time.time;
       show_unscaledDeltaTime = Time.unscaledDeltaTime;
       speed = 10;
       // 让时间恒定
        this.transform.Rotate(0, speed * Time.deltaTime, 0);

    //    // 暂停后，该物体的刷新不受影响
        this.transform.Rotate(speed * Time.unscaledDeltaTime,0 , 0);
        //
    }
}
