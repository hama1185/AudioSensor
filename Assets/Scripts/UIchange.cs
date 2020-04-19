using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIchange : MonoBehaviour
{
    public Text accelX;
    public Text accelY;
    public Text accelZ;
    public Text compsX;
    public Text compsY;
    public Text compsZ;
    public Text trueHeading;
    public Text gyroX;
    public Text gyroY;
    public Text gyroZ;
    public Text gyroW;
    public GameObject sensorManager;
    inputcheck inputcheck; 
    // Start is called before the first frame update
    void Start(){
        inputcheck = sensorManager.GetComponent<inputcheck>();
    }

    // Update is called once per frame
    void Update(){
        accelX.text = inputcheck.acceleration.x.ToString();
        accelY.text = inputcheck.acceleration.y.ToString();
        accelZ.text = inputcheck.acceleration.z.ToString();
        compsX.text = inputcheck.compass.rawVector.x.ToString();
        compsY.text = inputcheck.compass.rawVector.y.ToString();
        compsZ.text = inputcheck.compass.rawVector.z.ToString();
        trueHeading.text = inputcheck.compass.trueHeading.ToString();
        gyroX.text = inputcheck.gyro.x.ToString();
        gyroY.text = inputcheck.gyro.y.ToString();
        gyroZ.text = inputcheck.gyro.z.ToString();
        gyroW.text = inputcheck.gyro.w.ToString();
    }
}
