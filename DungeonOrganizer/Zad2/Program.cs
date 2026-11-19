using DungeonOrganizer.Characters;
using DungeonOrganizer.UI;

Player player = new Player("Ada", 100);
Enemy enemy = new Enemy("Goblin", 30);
DungeonOrganizer.Items.Item item = new DungeonOrganizer.Items.Item("Mikstura", 15);
DungeonOrganizer.Items.Weapon weapon = new DungeonOrganizer.Items.Weapon("Sword", 8);

GamePrinter.ShowHeader("Dungeon Organizer");
GamePrinter.ShowCharacter(player.Name, player.Health);
GamePrinter.ShowCharacter(enemy.Name, enemy.Health);
GamePrinter.ShowItem(item.Name, item.Price);
GamePrinter.ShowWeapon(weapon.Name, weapon.Damage);