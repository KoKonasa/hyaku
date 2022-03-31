using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; //追加

public class Speed : MonoBehaviour
{
    public GameObject textObject;

    public GameObject Coin;
    Rigidbody2D rb;

    void Awake()
    {
        rb = Coin.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Textオブジェクトからコンポーネントを取得する
        Text textObject_text = textObject.GetComponent<Text>();

        //sphereオブジェクトから速さ（速度の大きさ）を取得する
        float vel = rb.velocity.x;
        //float型を文字列に変更する
        int vell = (int)vel;
        string vel_String = vell.ToString();
        //表示する内容を指定する
        textObject_text.text = "Velocity " + vel_String;
    }
}

