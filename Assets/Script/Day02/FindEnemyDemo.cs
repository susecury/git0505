using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///summery
///
///summery

public class FindEnemyDemo : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUILayout.Button("find the enemy with lowest HP"))
        {
            // find all enemy
            Enemy[] allEnemy = Object.FindObjectsOfType<Enemy>();
            // find the min enemy
            Enemy min = FindEnemyByMinHp(allEnemy);
            // sign the enemy
            min.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (GUILayout.Button("层级未知，查找子物体"))
        {
            var childTF= TransformHelper.GetChild(this.transform,"Cubexx");
            childTF.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        if (GUILayout.Button("暂停游戏"))
            Time.timeScale = 0;

        if (GUILayout.Button("继续游戏"))
            Time.timeScale = 1;
    }



    public Enemy FindEnemyByMinHp(Enemy[] allEnemy)
    {
        // assume the first is the min
        Enemy min = allEnemy[0];
        // 冒泡排序
        for (int i = 0; i < allEnemy.Length; i++)
        {
            if (allEnemy[i].Hp < min.Hp)
                min = allEnemy[i];
        }
        return min;
    }
}
