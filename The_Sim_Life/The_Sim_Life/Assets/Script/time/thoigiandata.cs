using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class thoigiandata 
{
    public int Time;
    private string TIME_DATA = "time_data";

    public thoigiandata()
    {
        Time = 0;
    }
    // Save dữ liệu
    public void Save(thoigian tg)
    {
        Time = tg.Time;

        // Convert dữ liệu sang dạng string
        string s = JsonUtility.ToJson(this);
        Debug.Log(s);
        // Dùng PlayerPrefs lưu dữ liệu lại
        PlayerPrefs.SetString(TIME_DATA, s);
    }
}
