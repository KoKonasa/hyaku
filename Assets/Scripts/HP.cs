
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class HP : MonoBehaviour
{

   
    public GameObject score_object = null; // Text�I�u�W�F�N�g
    GameObject g;
    CoinRun1 gg;
    // ������
    void Start()
    {
   
        g = GameObject.Find("Coin");
        gg = g.GetComponent<CoinRun1>();
  
    }

    // �X�V
    void Update()
    {     // countTime�ɁA�Q�[�����J�n���Ă���̕b�����i�[
      
        // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text score_text = score_object.GetComponent<Text>();
        // �e�L�X�g�̕\�������ւ���
        score_text.text = "HP "+gg.hp;

    }
}
