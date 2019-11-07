using UnityEngine;

public class RobotBall : MonoBehaviour
{

    [Header("速度"), Range(0f, 1000f)]
    public float speed = 50f;
    [Header("跳躍"), Range(0f, 1000f)]
    public float jump = 100f;
    [Header("是否在地上")]
    public bool IsGround = false;

    private Rigidbody r2d;


    //use this for initialization
    private void Start()
    {
        r2d = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        walk();
        jump();
    }

    private void OnCollisionEnter(Collision collision)
    {
        IsGround = true;
    }

    ///走路
    ///
    private void walk()
    {
        //向前
        if (Input.GetKey(KeyCode.W))
        { transform.Translate(0, 0, speed * 0.1f * Time.deltaTime); }
        //向後
        if (Input.GetKey(KeyCode.S))
        { transform.Translate(0, 0, speed * -0.1f * Time.deltaTime); }
        //向又
        if (Input.GetKey(KeyCode.D))
        { transform.Translate(speed * 0.1f * Time.deltaTime, 0, 0); }
        //向左
        if (Input.GetKey(KeyCode.A))
        { transform.Translate(speed * -0.1f * Time.deltaTime, 0, 0); }
    }
}
