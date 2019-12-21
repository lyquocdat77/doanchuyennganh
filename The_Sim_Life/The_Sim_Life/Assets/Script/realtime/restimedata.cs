using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restimedata 
{
    public double Restime;
    private string RESTIME_DATA = "restime_data";


    public restimedata()
    {
        Restime = 0;
    }
    // Save dữ liệu
    public void Save(double rt)
    {
        Restime = rt;

        // Convert dữ liệu sang dạng string
        string s = JsonUtility.ToJson(this);
        Debug.Log(s);
        // Dùng PlayerPrefs lưu dữ liệu lại
        PlayerPrefs.SetString(RESTIME_DATA, s);
    }
}
