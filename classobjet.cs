public class Objet
{
    // La méthode Open pourrait être implémentée ici.
    public virtual void Open()
    {
        // Logique d'ouverture du coffre commun
    }
}

public class PotionObjet : Objet
{
    public int Force { get; set; }
    public List<Potion> ListPotion { get; set; }

    public override void Open()
    {
        base.Open();
        // Logique spécifique à l'ouverture d'un coffre à potions
    }
}

public class XPObjet : Objet
{
    public string AfterFight { get; set; }
    public List<int> ListXPAfterFight { get; set; }

    public override void Open()
    {
        base.Open();
        // Logique spécifique à l'ouverture d'un coffre à XP
    }
}

public class WeaponObjet : Objet
{
    public int WeaponForce { get; set; }
    public List<Weapon> ListWeaponRoom { get; set; }

    public override void Open()
    {
        base.Open();
        // Logique spécifique à l'ouverture d'un coffre d'armes
    }
}

// Classes supplémentaires pour représenter des potions et des armes, 
// pour lesquelles nous n'avons pas de détails dans le diagramme.
public class Potion
{
    // Propriétés de la potion ici
}

public class Weapon
{
    // Propriétés de l'arme ici
}
