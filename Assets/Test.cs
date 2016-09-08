using UnityEngine;
using System.Collections;

//ボスクラス作成
public class Boss{ 
    private int hp = 100;   //体力
    private int power = 25; //攻撃力
    private int mp = 53;//マジックポイント

    //攻撃用の関数
    public void Attack(){
        Debug.Log(this.power + "のダメージを与えた");
    }
    //防御用の関数
    public void Defence(int damage) {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }
    public void Magic() {
        if (mp >= 5){
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        } else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour {
 
    // Use this for initialization
	void Start () {
        //要素数5個を初期化
        int[] array = { 11, 33, 99, 77, 55 };

        //要素の数だけカウントしてデバッグログへ
        for (int i = 0; i < array.Length; i++) {
            Debug.Log(array[i]);
        }
        //次は逆順
        Debug.Log("次は逆順");
        //この方法だと要素数が後から増減したときにエラーが出そう。4の部分をLengthに出来る？
        for (int i = 4; i >= 0; i--)  {
                Debug.Log(array[i]);
            }
        //発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう
        Boss magic = new Boss();
        for(int i = 0; i <= 10; i++) {
            magic.Magic();
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}