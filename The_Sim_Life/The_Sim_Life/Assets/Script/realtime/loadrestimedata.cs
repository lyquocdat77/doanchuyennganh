using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadrestimedata : MonoBehaviour
{
    public string nextScene;
    private string TIME_DATA = "time_data";
    private string CHARACTER_DATA = "cha_data";
    private string RESTIME_DATA = "restime_data";
    static DateTime t = DateTime.Now;
    public int solantru;
    private void Awake()
    {
        LoadTimeData();
        LoadCharacterData();
        LoadResTimeData();
        double starttime = (t.ToUniversalTime() - new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
        solantru = ((int)(starttime - gamedata.rtdata.Restime)) / 800;
        Debug.Log(solantru);
        gamedata.chadata.food -= (5 * solantru);
        // Chuyển sang Scene khác sau khi load dữ liệu xong
        Application.LoadLevel(nextScene);
        
        
        
    }

    private void LoadTimeData()
    {
        //Lấy dữ liệu dạng string ở PlayerPrefs
        string t = PlayerPrefs.GetString(TIME_DATA);

        // Nếu chuỗi string null hoặc rỗng thì sẽ tạo một data mới với các giá trị mặc định
        if (string.IsNullOrEmpty(t))
        {
            gamedata.tgdata = new thoigiandata();
            return;

        }
        // Dùng JsonDotNet convert dữ liệu từ string sang object
        gamedata.tgdata = JsonUtility.FromJson<thoigiandata>(t);
    }
    private void LoadCharacterData()
    {
        //Lấy dữ liệu dạng string ở PlayerPrefs
        string ch = PlayerPrefs.GetString(CHARACTER_DATA);

        // Nếu chuỗi string null hoặc rỗng thì sẽ tạo một data mới với các giá trị mặc định
        if (string.IsNullOrEmpty(ch))
        {
            gamedata.chadata = new characterdata();
            return;

        }
        // Dùng JsonDotNet convert dữ liệu từ string sang object
        gamedata.chadata = JsonUtility.FromJson<characterdata>(ch);
    }
    private void LoadResTimeData()
    {
        //Lấy dữ liệu dạng string ở PlayerPrefs
        string t = PlayerPrefs.GetString(RESTIME_DATA);

        // Nếu chuỗi string null hoặc rỗng thì sẽ tạo một data mới với các giá trị mặc định
        if (string.IsNullOrEmpty(t))
        {
            gamedata.rtdata = new restimedata();
            return;

        }
        // Dùng JsonDotNet convert dữ liệu từ string sang object
        gamedata.rtdata = JsonUtility.FromJson<restimedata>(t);
    }
}
