using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    [SerializeField] Vector2 range;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject bonus;

    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1.5f);
        Vector2 posEnemy = spawnPos.position + new Vector3(0, Random.Range(-range.y, range.y));
        Vector2 posBonus = spawnPos.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(enemy, posEnemy, Quaternion.identity);
        Instantiate(bonus, posBonus, Quaternion.identity);
        Repeat();
    }
    void Repeat()
    {
        StartCoroutine(Spawn());
    }
}
