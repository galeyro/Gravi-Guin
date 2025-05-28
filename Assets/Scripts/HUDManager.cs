using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public Slider healthSlider;
    public Image fillImage; // ← arrastrar aquí el Fill del Slider
    private PlayerController player;

    void Start()
    {
        player = PlayerController.Instance;
        healthSlider.maxValue = player.maxHealth;
        healthSlider.value = player.health;
    }

    void Update()
    {
        if (player != null)
        {
            float currentHealth = player.health;
            float maxHealth = player.maxHealth;

            healthSlider.value = currentHealth;

            // Calcula el porcentaje
            float healthPercent = currentHealth / maxHealth;

            // Cambia el color según el porcentaje
            if (healthPercent > 0.6f)
            {
                fillImage.color = Color.green;
            }
            else if (healthPercent > 0.3f)
            {
                fillImage.color = Color.yellow;
            }
            else
            {
                fillImage.color = Color.red;
            }
        }
    }
}
