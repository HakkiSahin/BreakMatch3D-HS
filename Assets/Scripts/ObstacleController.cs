using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] private ObstacleType _obstacleType;

    private bool moveStart = false;

    private int startPoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


    void Update()
    {
        if (moveStart)
        {
            for (int i = startPoint; i < transform.childCount - 1; i++)
            {
                if (transform.GetChild(i).transform.localPosition.y >= 2.8)
                {
                    startPoint++;
                    StartCoroutine(ObstacleMove(startPoint));
                }
            }
        }
    }

    private int count = 0;


    public void StartMove()
    {
        if (_obstacleType != null && _obstacleType == ObstacleType.unfixedObstacle)
        {
            StartCoroutine(ObstacleMove(0));
        }
       
    }

    IEnumerator ObstacleMove(int childCount)
    {
        yield return new WaitForSeconds(0.2f);
        float i = 0.0f;
        float rate = .1f;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            transform.GetChild(childCount).transform.localPosition = Vector3.Lerp(
                transform.GetChild(childCount).transform.localPosition,
                new Vector3(transform.GetChild(childCount).transform.localPosition.x,
                    5, transform.GetChild(childCount).transform.localPosition.z), i);


            yield return null;
        }
    }
}

public enum ObstacleType
{
    fixedObstacle,
    unfixedObstacle
}