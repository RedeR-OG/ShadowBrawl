using UnityEngine;

public class camra : MonoBehaviour
{
    public Transform healthBar;
    public Transform soulConter;
    public Transform manaBar;

    private Vector3 healthOffset;
    private Vector3 soulOffset;
    private Vector3 manaOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthOffset = healthBar.position - transform.position;
        soulOffset = soulConter.position - transform.position;
        manaOffset = manaBar.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        healthBar.position = transform.position + healthOffset;
        soulConter.position = transform.position + soulOffset;
        manaBar.position = transform.position + manaOffset;
    }
}
