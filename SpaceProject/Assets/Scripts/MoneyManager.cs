using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour {

    public float currentMoney = 0f;
    public Text currentMoneyText;
    

	// Use this for initialization
	void Start () {
        currentMoney = ES2.Load<float>("currentMoney");

        StartCoroutine(ShipTravelNum());
    }
	
	// Update is called once per frame
	void Update () {

        currentMoney += 1f * Time.deltaTime;

        currentMoneyText.text = "$: " + currentMoney.ToString("f0");

        ES2.Save(currentMoney, "currentMoney");
		
	}

    public IEnumerator ShipTravelNum() {

        yield return new WaitForSeconds(Random.Range(10f,20f));

        currentMoney += Random.Range(100f, 1000f);

        StartCoroutine(ShipTravelNum());

    }
}
