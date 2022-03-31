
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class HP : MonoBehaviour
{

   
    public GameObject score_object = null; // Textオブジェクト
    GameObject g;
    CoinRun1 gg;
    // 初期化
    void Start()
    {
   
        g = GameObject.Find("Coin");
        gg = g.GetComponent<CoinRun1>();
  
    }

    // 更新
    void Update()
    {     // countTimeに、ゲームが開始してからの秒数を格納
      
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "HP "+gg.hp;

    }
}
