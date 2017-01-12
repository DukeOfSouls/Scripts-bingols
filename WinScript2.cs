using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinScript2 : MonoBehaviour
{
    public Transform S1, S2, S3, S4, S5;
    public GameObject[] balls;
    private int index;
    private float size;
    private float wait = 0.5f;

    void Start()
    {
        balls = Resources.LoadAll<GameObject>("prefabBalls");

        StartCoroutine(spawn1());
        StartCoroutine(spawn2());
        StartCoroutine(spawn3());
        StartCoroutine(spawn4());
        StartCoroutine(spawn5());
    }

    IEnumerator spawn1()
    {
        size = Random.Range(0.2f, 0.8f);
        index = Random.Range(0, balls.Length);
        GameObject ball = Instantiate(balls[index]) as GameObject;
        ball.transform.position = S1.transform.position;
        ball.transform.localScale = new Vector3(size, size, size);
        ball.GetComponent<SpriteRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        yield return new WaitForSeconds(wait);
        StartCoroutine(spawn1());
    }

    IEnumerator spawn2()
    {
        size = Random.Range(0.2f, 0.8f);
        index = Random.Range(0, balls.Length);
        GameObject ball = Instantiate(balls[index]) as GameObject;
        ball.transform.position = S2.transform.position;
        ball.transform.localScale = new Vector3(size, size, size);
        ball.GetComponent<SpriteRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        yield return new WaitForSeconds(wait);
        StartCoroutine(spawn2());
    }

    IEnumerator spawn3()
    {
        size = Random.Range(0.2f, 0.8f);
        index = Random.Range(0, balls.Length);
        GameObject ball = Instantiate(balls[index]) as GameObject;
        ball.transform.position = S3.transform.position;
        ball.transform.localScale = new Vector3(size, size, size);
        ball.GetComponent<SpriteRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        yield return new WaitForSeconds(wait);
        StartCoroutine(spawn3());
    }

    IEnumerator spawn4()
    {
        size = Random.Range(0.2f, 0.8f);
        index = Random.Range(0, balls.Length);
        GameObject ball = Instantiate(balls[index]) as GameObject;
        ball.transform.position = S4.transform.position;
        ball.transform.localScale = new Vector3(size, size, size);
        ball.GetComponent<SpriteRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        yield return new WaitForSeconds(wait);
        StartCoroutine(spawn4());
    }

    IEnumerator spawn5()
    {
        size = Random.Range(0.2f, 0.8f);
        index = Random.Range(0, balls.Length);
        GameObject ball = Instantiate(balls[index]) as GameObject;
        ball.transform.position = S5.transform.position;
        ball.transform.localScale = new Vector3(size, size, size);
        ball.GetComponent<SpriteRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        yield return new WaitForSeconds(wait);
        StartCoroutine(spawn5());
    }



}