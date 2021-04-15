using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LogManager : MonoBehaviour
{
    public string fileName;
    public static LogManager instance;

    private void Awake()
    {
        instance = this;
        fileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".txt";
        Logger("启动平台",fileName);
        DontDestroyOnLoad(gameObject);
    }

    private void OnApplicationQuit()
    {
        Logger("平台退出", fileName);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Logger(string message = "云扎堆日志\n", string path = "log.txt")
    {
        path = Path.Combine("Log", path);
        if (!Directory.Exists("Log"))
        {
            Directory.CreateDirectory("Log");
        }

        message += "时间: " + DateTime.Now + "\n";
        File.AppendAllText(path,message);
    }
}
