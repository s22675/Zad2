// See https://aka.ms/new-console-template for more information

using Zadania2;

ContrainerShip ship1 = new ContrainerShip(4, 5, 12);
ContrainerShip ship2 = new ContrainerShip(2, 7, 15);

Product product = new Product(13f);
LiquidProduct liquidProduct = new LiquidProduct(15f, true);
FridgeProduct fridgeProduct = new FridgeProduct(18f, TypeProduct.Banana, 15f);

//Stworzenie kontenera danego typu
FridgeContainer fridgeContainer = new FridgeContainer(150f,15f,  15f, 0f, 190f,  TypeProduct.Banana, 16f);
GasContainer gasContainer = new GasContainer(200f, 40f, 20f, 0f, 200f, 12f);
LiquidContainer liquidContainer = new LiquidContainer(170f, 30f, 25f, 0f, 210f);

//Załadowanie ładunku do danego kontenera
fridgeContainer.LoadCargo(fridgeProduct);
gasContainer.LoadCargo(product);
liquidContainer.LoadCargo(liquidProduct);

//Załadowanie kontenera na statek
ship1.AddContrainer(fridgeContainer);

//Załadowanie listy kontenerów na statek
ship2.AddContrainers(new List<Container>() {gasContainer, liquidContainer});

//Usunięcie kontenera ze statku
ship1.RemoveContrainer(fridgeContainer);

//Rozładowanie kontenera
fridgeContainer.UnloadCargo();

//Zastąpienie kontenera na statku o danym numerze innym kontenerem
ship2.ReplaceContainer(fridgeContainer, "KON-G-2");

//Możliwość przeniesienie kontenera między dwoma statkami
ContrainerShip.MoveCotainerToAnotherShip("KON-C-1", ship2, ship1);

//Wypisanie informacji o danym kontenerze
fridgeContainer.Print();
gasContainer.Print();
liquidContainer.Print();

//Wypisanie informacji o danym statku i jego ładunku
ship1.Print();
ship2.Print();




