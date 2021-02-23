using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string leftKey = "left";
    public string rightKey = "right";
    public string fireKey = "space";

    public bool _readyToFire = false;
    public GameObject _fakeBall;
    public Ball _ball;

    // Start is called before the first frame update
    void Start()
    {
        if(_readyToFire){
            _fakeBall.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(leftKey)){
            transform.Translate(new Vector2(-0.1f, 0f));
        }
        else if (Input.GetKey(rightKey)){
            transform.Translate(new Vector2(0.1f, 0f));
        }
        else if (Input.GetKey(fireKey)){
            if (_readyToFire){
                FireBall();
            }
        }
    }

    void FireBall(){
        _readyToFire = false;
        _fakeBall.SetActive(false);

        Ball newBall = Instantiate(_ball, _fakeBall.transform.position, Quaternion.identity);

        float angle;

        angle = Mathf.Deg2Rad * Random.Range(-50, -30);

        Vector2 force = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        newBall.GetComponent<Rigidbody2D>().AddForce(force * 1.0f);
    }

    public void lostLife(){
        _readyToFire = true;
        _fakeBall.SetActive(true);
    }
}
