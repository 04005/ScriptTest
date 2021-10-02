using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // mp

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 攻撃用の関数
    public void Magic()
    {
        if (this.mp >= 5) 
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }


}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //変数の宣言
        int i;
        int[] array = { 1, 2, 3, 4, 5 };

        Debug.Log("順番");
        for (i = 0; i < 5; i++)
        {
            //コンソールに変数の中身を表示
            Debug.Log(array[i]);
        }

        Debug.Log("逆順");
        for (i = 4; i >= 0; i--)
        {
            //コンソールに変数の中身を表示
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
