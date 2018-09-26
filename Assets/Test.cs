using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 50;
    private int power = 15;
    private int mp = 53;

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //hpを減らす
        this.hp = hp -= damage;
    }

    public void Magic(int use)
    {
        if (this.mp < use)
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
        else
        {
            this.mp = mp -= use;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
    }
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Debug.Log("課題:配列を宣言して出力");

        int[] array = { 1, 2, 3, 4, 5 };

        Debug.Log("順番に表示");

        for(int i = 0; i<5; i++)
        {
            Debug.Log(array[i]);
        }

        Debug.Log("逆順に表示");

        for(int j = 4; j>=0; j--)
        {
            Debug.Log(array[j]);
        }



        //Bossクラスの変数を宣言してインスタンスを生成
        Boss midboss = new Boss();

        midboss.Attack();
        midboss.Defence(10);

        Debug.Log("発展課題");
        for (int k = 1; k <= 11; k++)
        {
            midboss.Magic(5);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
