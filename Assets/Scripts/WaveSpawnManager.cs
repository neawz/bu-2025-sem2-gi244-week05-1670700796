using UnityEngine;

public class WaveSpawnManager : MonoBehaviour
{
    public Wave[] waveConfigs;
    public WaveController waveController;

    private int currentWaveIndex = 0;
    private float waveEndTime = 0;

    void Start()
    {
        waveController.ChangeWave(waveConfigs[0]);
        waveEndTime = Time.time + waveConfigs[currentWaveIndex].waveInterval;
    }

    void Update()
    {
        if (waveController.IsCompleted() && Time.time >= waveEndTime)
        {
            currentWaveIndex++;
            if (currentWaveIndex < waveConfigs.Length)
            {
                waveController.ChangeWave(waveConfigs[currentWaveIndex]);
            }
            else
            {
                Debug.Log("All Done");
            }
        }
    }
}