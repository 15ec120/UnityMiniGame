using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDelete : MonoBehaviour {

    //Hierarchyからカラーをセット
    [SerializeField] Color[] Colors;

    Renderer Renderer;
    int CurrentColorIdx;

    void Awake()
    {
        //何度も呼ぶAPIはキャッシュしておくといいです。
        Renderer = GetComponent<Renderer>();
        //始めのカラーを表示
        ChangeMaterialColor();
    }

    void OnCollisionEnter(Collision collision)
    { 
        GameObject obj = GameObject.Find("JamaWall");
        Destroy(obj, 2.0f);
        ChangeMaterialColor();
    }
    void ChangeMaterialColor()
    {
        Renderer.material.color = Colors[CurrentColorIdx];
        CurrentColorIdx++;
        if (CurrentColorIdx >= Colors.Length) CurrentColorIdx = 1;
    }
}
