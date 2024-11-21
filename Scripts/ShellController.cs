using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellController : MonoBehaviour
{
    public float deletetaime = 3.0f; //削除する時間設定

    // Start is called before the first frame update
    void Start()
    {
        //だいにひきすうに数字を入れると時間差で消滅
        Destroy(gameObject, deletetaime); //削除設定 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy (gameObject); //何かとぶつかったら消滅
    }
}
