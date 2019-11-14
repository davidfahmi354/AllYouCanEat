using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject pl;
    public Animator anim;
    public List<int> inputPool = new List<int>();
    public List<GameObject> foodPool = new List<GameObject>();
    public int foodsCount;
    public int maxFood;
    public int inputCounter;
    public int wrongCounter;
    public int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        anim = pl.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score\n" + score.ToString();
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
            StartCoroutine(AcceptAnimation());
        else
            StartCoroutine(RejectAnimation());
        RefreshFood();
    }

    public void RefreshFood()
    {
        foreach(GameObject foods in foodPool)
        {
            foods.GetComponent<FoodObject>().typeFood = Random.Range(0, foodsCount);
        }
    }

    IEnumerator AcceptAnimation()
    {
        score++;
        anim.SetTrigger("yes");
        yield return new WaitForSeconds(1);
        anim.SetTrigger("idle");
    }
    IEnumerator RejectAnimation()
    {
        wrongCounter++;
        anim.SetTrigger("no");
        yield return new WaitForSeconds(1);
        anim.SetTrigger("idle");
    }

    void GameOver()
    {

    }


}
