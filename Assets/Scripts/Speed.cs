using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; //�ǉ�

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
        //Text�I�u�W�F�N�g����R���|�[�l���g���擾����
        Text textObject_text = textObject.GetComponent<Text>();

        //sphere�I�u�W�F�N�g���瑬���i���x�̑傫���j���擾����
        float vel = rb.velocity.x;
        //float�^�𕶎���ɕύX����
        int vell = (int)vel;
        string vel_String = vell.ToString();
        //�\��������e���w�肷��
        textObject_text.text = "Velocity " + vel_String;
    }
}

