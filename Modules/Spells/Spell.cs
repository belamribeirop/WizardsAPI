using System.ComponentModel.DataAnnotations;

public class Spell
{
  [Key]
  public int Id { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public IEnumerable<SpellType> Type { get; set; }

}
public enum SpellType
{
  Transfiguration, Charm, Jinx, Hex, Curse, CounterSpell, HealingSpell, CounterCurse
}