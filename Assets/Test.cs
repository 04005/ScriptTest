using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // �̗�
    private int power = 25; // �U����
    private int mp = 53; // mp

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }

    // �U���p�̊֐�
    public void Magic()
    {
        if (this.mp >= 5) 
        {
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + this.mp);
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }


}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�ϐ��̐錾
        int i;
        int[] array = { 1, 2, 3, 4, 5 };

        Debug.Log("����");
        for (i = 0; i < 5; i++)
        {
            //�R���\�[���ɕϐ��̒��g��\��
            Debug.Log(array[i]);
        }

        Debug.Log("�t��");
        for (i = 4; i >= 0; i--)
        {
            //�R���\�[���ɕϐ��̒��g��\��
            Debug.Log(array[i]);
        }


        Boss boss = new Boss();
        for (i = 0; i < 11; i++) { boss.Magic(); }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
