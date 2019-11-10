using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public List<int> inputPool = new List<int>();
    public List<GameObject> foodPool = new List<GameObject>();
    public int foodsCount;
    public int maxFood;
    public int inputCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InputCheck()
    {
        bool same = true;
        for(int i = 0; i < foodsCount; i++)
        {
            if (inputPool[i] == foodPool[i].GetComponent<FoodObject>().typeFood)
                same=true;
            else
            {
                same = false;
                break;
            }
        }
        if (same)
            print("right");
        else
            print("wrong");
        RefreshFood();
    }

    public void RefreshFood()
    {
        foreach(GameObject foods in foodPool)
        {
            foods.GetComponent<FoodObject>().typeFood = Random.Range(0, 4);
        }
    }
}
