using PokemonBag.Bag;

BagSlots bagSlots = new BagSlots();
bagSlots.AddItemToBag(21, 1);
bagSlots.AddItemToBag(22, 1);
bagSlots.AddItemToBag(11, 3);
bagSlots.AddItemToBag(12, 1);

bagSlots.AddItemToBag(1, 3);
bagSlots.AddItemToBag(2, 2);
bagSlots.AddItemToBag(101, 2);
bagSlots.AddItemToBag(102, 1);

bagSlots.PrintBag();

bagSlots.AddItemToBag(3, 1);

bagSlots.PrintBag();

bagSlots.AddItemToBag(11, 1);

bagSlots.PrintBag();