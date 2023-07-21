// See https://aka.ms/new-console-template for more information
using PokemonBag.Bag;
using PokemonBag.Bag.Types;

BagSlots bagSlots = new BagSlots();
bagSlots.PrintBag();

bagSlots.AddItemToBag(3);

bagSlots.PrintBag();

bagSlots.AddItemToBag(11);

bagSlots.PrintBag();