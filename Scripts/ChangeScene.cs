using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //SceneManager�N���X���`���Ă��閼�O��ԁA�V�[���̐؂�ւ��ɕK�v

public class ChangeScene : MonoBehaviour
{
    public string sceneName; //�ړI�ƂȂ�V�[��������ꔄ�ϐ�

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //�V�[����ǂݍ���
    public void Load()
    {
        SceneManager.LoadScene(sceneName);

    }
}
