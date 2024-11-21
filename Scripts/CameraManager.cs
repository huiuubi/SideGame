using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public float leftLimit = 0.0f; //右スクロールのリミット
    public float rightLimit = 0.0f; //左スクロールのリミット
    public float topLimit = 0.0f; //上スクロールリミット
    public float bottomLimit = 0.0f; //下スクロールのリミット

    public GameObject subScreen; //サブスクリーン

    public bool isForseScrollX = false;    //強制スクロールラグ
    public float forseScrollSpeedX = 0.5f; //1秒間で動かすX距離
    public bool isForseScrollY = false;    //Y軸強制スクロールラグ
    public float forseScrollSpeedY = 0.5f; //1秒間で動かすY距離


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); //FindGameObjectWidthTag()で探し出したプレイヤー情報を変数playerに参照させる

        //playerがnullじゃなければ（playerが存在していれば）
        if (player != null)
        {
            //x,y,zにplayerの座標と同じものを代入
            float x = player.transform.position.x;
            float y = player.transform.position.y;
            float z = transform.position.z;

            //横の同期
            
            if (isForseScrollX)
            {
                //横強制スクロール
                x = transform.position.x + (forseScrollSpeedX * Time.deltaTime);
            }
            //両端に制限をかける（カメラがどこまで移動できるかの話)
            if (x < leftLimit)
            {
                x = leftLimit;
            }
            else if (x > rightLimit)
            {
                x = rightLimit;
            }

            //縦の同期
            if (isForseScrollY)
            {
                //縦強制スクロール
                y = transform.position.y +(forseScrollSpeedY * Time.deltaTime);
            }
            //上下に移動制限をつける
            if (y < bottomLimit)
            {
                y = bottomLimit;
            }
            else if (y > topLimit)
            {
                y = topLimit;
            }

            //カメラ位置のVector3を作る
            Vector3 v3 = new Vector3(x, y, z);
            //カメラのポジションを変数v3と同じにする
            transform.position = v3;

            //サブスクリーンスクロール
            if (subScreen != null)
            {
                y = subScreen.transform.position.y;
                z = subScreen.transform.position.z;
                Vector3 v = new Vector3(x / 2.0f, y, z);
                subScreen.transform.position = v;
            }
        }
    }
}
