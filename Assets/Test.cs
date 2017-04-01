using System.Collections;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //課題
        //配列の宣言
        int[] array = new int[5];
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;
        //昇順
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        //降順
        for (int i = array.Length -1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //発展課題
        Boss lastBoss = new Boss();
        //Magic関数を10回呼び出し
        for (int i = 0; i < 10; i++)
        {
            lastBoss.Magic();
        }
        //Magic関数を10回呼び出した後、更に呼び出し
        lastBoss.Magic();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Boss
{
    private int hp = 100; // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // MP

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

    // 魔法攻撃用の関数
    public void Magic()
    {
        if (mp > 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは"+mp+"。");
        }
        else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}