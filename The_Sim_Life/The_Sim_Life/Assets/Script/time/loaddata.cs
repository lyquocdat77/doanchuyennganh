using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loaddata : MonoBehaviour
{
    public string nextScene;
    private string TIME_DATA = "time_data";
    private string CHARACTER_DATA = "character_data";

    private void Awake()
    {
        LoadTimeData();
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
            gamedata.tgdata = new thoigiandata();
            return;

        }
        // Dùng JsonDotNet convert dữ liệu từ string sang object
        gamedata.tgdata = JsonUtility.FromJson<thoigiandata>(ch);
    }
}
