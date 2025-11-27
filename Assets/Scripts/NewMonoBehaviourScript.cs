using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private string[] items = new string[]
    {
        "Rune Sword",
        "Health Potion",
        "Magic Staff",
        "Iron Shield",
        "Leather Armor",
        "Silver Ring",
        "Golden Amulet",
        "Boots of Speed",
        "Cloak of Invisibility",
        "Fire Wand"
    };

    void Start()
    {
       Debug.Log("RandomItem script is gestart, items geladen: " + items.Length);
    }

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
           PrintRandomItem();

       if (Input.GetKeyDown(KeyCode.Escape))
           PrintAllItems();
    }

    private void PrintRandomItem()
    {
        int randomIndex = Random.Range(0, items.Length);
        Debug.Log("Random item: " + items[randomIndex]);
    }
    private void PrintAllItems()
    {
        Debug.Log("All items in the list:");
        for (int i = 0; i < items.Length; i++)
        {
            Debug.Log("Item " + i + ": " + items[i]);
        }
    }
}
