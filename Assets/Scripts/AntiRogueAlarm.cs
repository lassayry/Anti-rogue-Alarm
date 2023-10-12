using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiRogueAlarm : MonoBehaviour
{
    [SerializeField] private float _speed;

    private AudioSource _alarmSound;
    private float _volumeTargetValue;

    private void Start()
    {
        _alarmSound = GetComponent<AudioSource>();
        _alarmSound.volume = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        _volumeTargetValue = 1;
    }

    private void OnTriggerExit(Collider other)
    {
        _volumeTargetValue = 0;
    }

    private void Update()
    {
        _alarmSound.volume = Mathf.MoveTowards(_alarmSound.volume, _volumeTargetValue, _speed * Time.deltaTime);
    }
}
