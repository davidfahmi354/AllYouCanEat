using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FoodSpawner : MonoBehaviour
{
    public GameManager gm;
    public GameObject food;
    public int spawnCounter=0;
    // Start is called before the first frame update
    private void Awake()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnCounter == 0)
        {
            AddFoodObject();
        }
    }

    void AddFoodObject()
    {
        for (int i = 0; i < gm.foodsCount; i++)
        {
            var go = Instantiate(food);
            go.transform.parent = gameObject.transform;
            gm.foodPool.Add(go);
           
            spawnCounter++;
            
        }
    }
}
