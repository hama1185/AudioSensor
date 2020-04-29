using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class calculateNote
{
    // Start is called before the first frame update

    // Update is called once per frame
    public int calculateNoteNumber(float freq){
        var value = (69 + 12 * Mathf.Log(freq / 440, 2));
        int notenumber = Mathf.FloorToInt((69 + 12 * Mathf.Log(freq / 440, 2)));
        return notenumber;
    }
    public string detectScale(int notenumber){
        string[] scaleNames = { "ド", "ド♯", "レ", "レ♯", "ミ", "ファ", "ファ♯", "ソ", "ソ♯", "ラ", "ラ♯", "シ" };
        int index = notenumber % 12;
        int level = (notenumber / 12) - 1;//国際式を基準に用いた
        // Debug.Log("index" + index);
        return scaleNames[index] + level.ToString();
    }
}
