/*using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    string saveFile = "GameSaveFile";
    CarManager carManager;

    private void Start()
    {
        carManager = FindObjectOfType<CarManager>();

        LoadData();
    }
    public void SaveData()
    {
        CarList saveData = carManager.SaveCars();

        string jsonString = JsonUtility.ToJson(saveData);
        SaveToFile(saveFile, jsonString);
    }

    public void LoadData()
    {
        string jsonString = LoadFromFile(saveFile);
        CarList carList = JsonUtility.FromJson<CarList>(jsonString);

        carManager.LoadCars(carList);
    }

    public string LoadFromFile(string fileName)
    {
        using (var stream = File.OpenText(fileName))
        {
            return stream.ReadToEnd();
        }
    }

    void SaveToFile(string fileName, string jsonString)
    {
        using (var stream = File.OpenWrite(fileName))
        {
            stream.SetLength(0);

            var bytes = Encoding.UTF8.GetBytes(jsonString);

            stream.Write(bytes, 0, bytes.Length);
        }
    }

    void SaveOnline()
    {

    }
}

[Serializable]
public class CarInfo
{
    public string carName;
    public Vector3 position;
    public Quaternion rotation;
}

[Serializable]
public class CarList
{
    public List<CarInfo> cars;
}*/