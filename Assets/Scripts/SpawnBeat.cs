using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnBeat : MonoBehaviour
{
    [SerializeField] Transform rightSpawner;
    [SerializeField] Transform leftSpawner;
    [SerializeField] Transform upSpawner;
    [SerializeField] Transform downSpawner;
    [SerializeField] GameObject beat;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnInRight());
        StartCoroutine(SpawnInLeft());
        StartCoroutine(SpawnInUp());
        StartCoroutine(SpawnInDown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnInRight()
    {
        GameObject thisBeat;
        yield return new WaitForSeconds(1);

        thisBeat = Instantiate(beat, rightSpawner);
        thisBeat.transform.right = Vector2.left;

        yield return new WaitForSeconds(1);

        thisBeat = Instantiate(beat, rightSpawner);
        thisBeat.transform.right = Vector2.left;        
        
        yield return new WaitForSeconds(1);

        thisBeat = Instantiate(beat, rightSpawner);
        thisBeat.transform.right = Vector2.left;

        yield return new WaitForSeconds(1);

        thisBeat = Instantiate(beat, rightSpawner);
        thisBeat.transform.right = Vector2.left;
    }

    IEnumerator SpawnInLeft()
    {
        GameObject thisBeat;

        yield return new WaitForSeconds(2);

        thisBeat = Instantiate(beat, leftSpawner);
        thisBeat.transform.right = Vector2.right;

        yield return new WaitForSeconds(2);

        thisBeat = Instantiate(beat, leftSpawner);
        thisBeat.transform.right = Vector2.right;

        yield return new WaitForSeconds(2);

        thisBeat = Instantiate(beat, leftSpawner);
        thisBeat.transform.right = Vector2.right;

        yield return new WaitForSeconds(2);

        thisBeat = Instantiate(beat, leftSpawner);
        thisBeat.transform.right = Vector2.right;
    }

    IEnumerator SpawnInUp()
    {
        GameObject thisBeat;

        yield return new WaitForSeconds(3);

        thisBeat = Instantiate(beat, upSpawner);
        thisBeat.transform.right = Vector2.down;

        yield return new WaitForSeconds(3);

        thisBeat = Instantiate(beat, upSpawner);
        thisBeat.transform.right = Vector2.down;

        yield return new WaitForSeconds(3);

        thisBeat = Instantiate(beat, upSpawner);
        thisBeat.transform.right = Vector2.down;

        yield return new WaitForSeconds(3);

        thisBeat = Instantiate(beat, upSpawner);
        thisBeat.transform.right = Vector2.down;
    }

    IEnumerator SpawnInDown()
    {
        GameObject thisBeat;

        yield return new WaitForSeconds(4);

        thisBeat = Instantiate(beat, downSpawner);
        thisBeat.transform.right = Vector2.up;

        yield return new WaitForSeconds(4);

        thisBeat = Instantiate(beat, downSpawner);
        thisBeat.transform.right = Vector2.up;

        yield return new WaitForSeconds(4);

        thisBeat = Instantiate(beat, downSpawner);
        thisBeat.transform.right = Vector2.up;

        yield return new WaitForSeconds(4);

        thisBeat = Instantiate(beat, downSpawner);
        thisBeat.transform.right = Vector2.up;
    }

}
