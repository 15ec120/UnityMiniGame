using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    // ゲームオーバーフラグ

    public GameObject winnerLabelObject;

    public bool gameOver = false;
    // ゲームクリア
    public bool gameClear = false;
    //
    public float sceneDelay = 10.0f;

    void Update()
    {
        // ゲーム終了条件成立後、シーン遷移
        if (gameClear)
        {

            winnerLabelObject.SetActive(true);

            sceneDelay -= Time.deltaTime;
            if (sceneDelay <= 0.0f)
            {
                SceneManager.LoadScene("red");
            }
            return;
        }
       

    }

    // ゲームオーバー
   

    // ゲームクリア
    // Goalオブジェクトからイベントメッセージとして
    // 呼び出してもらうためのメソッド
    public void GameClear()
    {
        gameClear = true;
    }
}