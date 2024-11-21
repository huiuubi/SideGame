using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //SceneManagerクラスを定義している名前空間、シーンの切り替えに必要

public class ChangeScene : MonoBehaviour
{
    public string sceneName; //目的となるシーン名を入れ売変数

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //シーンを読み込む
    public void Load()
    {
        SceneManager.LoadScene(sceneName);

    }
}
