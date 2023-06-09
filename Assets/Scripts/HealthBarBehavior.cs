using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehavior : MonoBehaviour
{
    [SerializeField] private Image _healthBarSprites;
    private Camera _cam;
    // Start is called before the first frame update

    private void Awake()
    {

        //// Singleton pattern
        //if (Instance != null && Instance != this)
        //{
        //    Destroy(this);
        //}
        //else
        //{
        //    Instance = this;
        //}
    }
    void Start()
    {
        _cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.gameObject.CompareTag("Player"))
            transform.rotation = Quaternion.LookRotation(transform.position - _cam.transform.position);
    }

    public void updateHealthBar(float maxHealth, float currentHealth)
    {
        _healthBarSprites.fillAmount = (currentHealth / maxHealth);
        Debug.Log(currentHealth / maxHealth);
        //Debug.Log(_healthBarSprites.fillAmount);
    }
}