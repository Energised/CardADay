using System;

namespace CardADay.Models;

// Import where language = "en"

public class Card
{
    public Guid Id { get; set; }
    public string Name { get; set; } // {name}
    public string ManaCost { get; set; } // {mana_cost}
    public string ImageUri { get; set; } // {image_uris : {normal}}
    public string Type { get; set; } // {type_line}
    public string Ability { get; set; } // {oracle_text}
    public string FlavorText { get; set; } // {flavor_text}
    public string Power { get; set; } // {power}
    public string Toughness { get; set; } // {toughness}
    public string Artist { get; set; } // {artist}
    public string SetName { get; set; } // {set_name}
    public string ShortSetName { get; set; } // {set}
}