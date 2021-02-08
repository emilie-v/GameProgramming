using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    [SerializeField] GameObject[] vehicles = new GameObject[2];

    public void LoadCars(CarList carList)
    {
        for (int i = 0; i < carList.cars.Count; i++)
        {
            vehicles[i].name = carList.cars[i].carName;
            vehicles[i].transform.position = carList.cars[i].position;
            vehicles[i].transform.rotation = carList.cars[i].rotation;
            vehicles[i].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }

    public CarList SaveCars()
    {
        CarList save = new CarList();
        save.cars = new List<CarInfo>();

        foreach (var vehicle in vehicles)
        {
            CarInfo car = new CarInfo();
            car.carName = vehicle.name;
            car.position = vehicle.transform.position;
            car.rotation = vehicle.transform.rotation;

            save.cars.Add(car);
        }

        return save;
    }
}
