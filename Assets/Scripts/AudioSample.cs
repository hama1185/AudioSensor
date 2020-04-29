using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSample : MonoBehaviour
{
    // Start is called before the first frame update  
    void Start(){
        foreach(var device in Microphone.devices){
			Debug.Log("Name: " + device);
		}
        var audio = GetComponent<AudioSource>();
        //devicename,loop,lengthSec,frequency
        audio.clip = Microphone.Start(null, true, 10, 44100);
        while(Microphone.GetPosition(null) <= 0){
            audio.Play();
        }
    }

    // Update is called once per frame
    void Update(){
        calculateNote calculatenote = new calculateNote();
        float[] spectrum = new float[1024];
        //spectrum[N] = (N * F/2) / Q
        //Q is arrayMax, F is frequency
        AudioListener.GetSpectrumData(spectrum, 0 , FFTWindow.Rectangular);
        int maxIndex = 0;
        float maxValue = 0.0f;
        for(int i = 0; i < spectrum.Length; i++){
            var value = spectrum[i];
            if(value > maxValue){
                maxValue = value;
                maxIndex = i;
            }
        }
        // Debug.Log(AudioSettings.outputSampleRate);
        var freq = maxIndex * AudioSettings.outputSampleRate / 2 / spectrum.Length;
        if(freq != 0){
            var notenumber = calculatenote.calculateNoteNumber(freq);
            // Debug.Log("notenumber" + notenumber);
            Debug.Log("scale" + calculatenote.detectScale(notenumber));
        }
    }
}
