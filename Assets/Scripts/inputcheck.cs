using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputcheck : MonoBehaviour
{
    public Vector3 acceleration;//加速度
    public Compass compass;//磁気
    public Quaternion gyro;//ジャイロ
    //なんとなく渡り鳥ARやりたい
    // Start is called before the first frame update
    void Start(){
        Input.compass.enabled = true;
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update(){
        acceleration = Input.acceleration;
        compass = Input.compass;
        gyro = Input.gyro.attitude;
    }
}
