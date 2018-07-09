using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class goal : MonoBehaviour
{
     finish gameRuleCtrl;
    CountDownTimer gameRule;

    // 衝突した瞬間に呼ばれる
    void OnTriggerEnter(Collider other)
    {
        // GameCtrlクラスを探して、取得する
        gameRuleCtrl = GameObject.FindObjectOfType(typeof(finish)) as finish;
       
        // GameCtrlクラスのGameClearメソッドを呼ぶ
        gameRuleCtrl.GameClear();

        // 衝突してきた物体のGoalメソッドを呼ぶ
   
     
    }
}
