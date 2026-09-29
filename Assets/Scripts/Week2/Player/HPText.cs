using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HPText : MonoBehaviour
{
    [SerializeField] private Text hpText;
    [SerializeField] private BasePlayer player;

    void OnEnable()
    {
        player.onHurtEvent.AddListener(OnHurt);
    }

    void OnDisable()
    {
        player.onHurtEvent.AddListener(OnHurt);
    }

    void Start()
    {
        OnHurt(player.GetCurrentHealth());
    }

    void OnHurt(int health)
    {
        hpText.text =  health.ToString();
    }
}
