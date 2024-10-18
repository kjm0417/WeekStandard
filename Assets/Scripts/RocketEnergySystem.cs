using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RocketEnergySystem : MonoBehaviour
{
    public float fuel = 100f; //연료
    public readonly float FUELPERSHOOT = 10f; //연료 사용

    [SerializeField] private Image fuelBar;

    private void Update()
    {
        fuel = Mathf.Clamp(fuel, 1f, 100f);
        FuelUp();
    }
    public void UseFuel()
    {
        if(fuel <=0f)
        {
            Debug.Log("연료부족");
            return;
        }
        else
        {
            fuel -= FUELPERSHOOT;
            FuelUI();
        }
    }

    public void FuelUp()
    {
        if (fuel < 100 && fuelBar.fillAmount < 1)
        {
            fuel += 0.1f * Time.deltaTime;
            FuelUI();
            Debug.Log(fuel);
        }
    }

    public void FuelUI()
    {
        if(fuelBar != null)
        {
            fuelBar.fillAmount = fuel / 100f;
        }
    }

    public void ReLoad()
    {
        SceneManager.LoadScene(0);
    }
}
