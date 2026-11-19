using DungeonOrganizer.Characters;
using DungeonOrganizer.Items;
using InventoryItem = DungeonOrganizer.Items.Item;
using MapItem = DungeonOrganizer.World.Item;
using DungeonOrganizer.World;
using DungeonOrganizer.UI;

Player player = new Player("Ada", 100);
Enemy enemy = new Enemy("Goblin", 30);
InventoryItem item = new InventoryItem("Mikstura", 15); // DungeonOrganizer.Items.Item map = new DungeonOrganizer.Items.Item map("Mikstura", 15);
MapItem map = new MapItem("!"); // DungeonOrganizer.World.Item item = new DungeonOrganizer.World.Item("!");
Weapon weapon = new Weapon("Sword", 8);

GamePrinter.ShowHeader("Dungeon Organizer");
GamePrinter.ShowCharacter(player.Name, player.Health);
GamePrinter.ShowCharacter(enemy.Name, enemy.Health);
GamePrinter.ShowItem(item.Name, item.Price);
GamePrinter.ShowWorldItem(map.Symbol);
GamePrinter.ShowWeapon(weapon.Name, weapon.Damage);