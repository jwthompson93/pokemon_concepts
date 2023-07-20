// See https://aka.ms/new-console-template for more information
using PokemonBag.Bag;
using PokemonBag.Bag.Types;

BagSlots bagSlots = new BagSlots();
bagSlots.printBag();

bagSlots.addItemToBag(3);

bagSlots.printBag();

bagSlots.addItemToBag(11);

bagSlots.printBag();