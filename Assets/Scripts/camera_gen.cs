using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_gen : MonoBehaviour
{
    public GameObject _block;
    public GameObject _blocks;

    // Start is called before the first frame update
    void Start()
    {
        initBlocks();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void initBlocks(){
        float x = 0f;
        float y = 0f;
        for (int i =0;i<7;i++){
            y= i * 0.6f;
            for (int j=0;j<7;j++){
                x = -7.5f + j * 2.5f;

                GameObject NewBlock = Instantiate<GameObject>(_block, new Vector3(x,y,0.0f), Quaternion.identity);
                NewBlock.transform.SetParent(_blocks.transform);
            }
        }

    }
}
