using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private float nextLevelDuration;

    public List<GameObject> levels;

    private void Start()
    {
        Instance = this;

        levels[0].SetActive(true);
    }

    public void OnLevelFinished()
    {
        StartCoroutine(NextLevel());
    }

    private IEnumerator NextLevel()
    {
        Debug.Log("Next Level");

        yield return new WaitForSeconds(nextLevelDuration);

        levels[0].gameObject.SetActive(false);

        levels[1].gameObject.SetActive(true);
    }
}
