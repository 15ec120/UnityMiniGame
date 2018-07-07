using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    int score = 0;
    public UnityEngine.UI.Text scoreLabel;

    private void OnTriggerEnter(Collider hit){
        //Cubeに触れると100点追加
        if (hit.CompareTag("Cube"))
        {
            score += 100;
        }

        //Capsuleに触れると50点追加
        else if (hit.CompareTag("Capsule"))
        {
            score += 50;
        }
    }

    public void Update(){
        scoreLabel.text = "Score:" + score.ToString();
    }
}
