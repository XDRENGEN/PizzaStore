using PizzaStore;

Pizza pizza1 = new Pizza(1, "Hawai", "Tomato, Cheese, Pineapple", 80);
Pizza pizza2 = new Pizza(2, "Prosciutto", "Tomato, Cheese, Prosciutto", 100);
Pizza pizza3 = new Pizza(3, "Pepperoni", "Tomato, Cheese, Pepperoni", 100);

Kunde kunde1 = new Kunde("Isabella", "12348765");
Kunde kunde2 = new Kunde("Marie", "87654321");
Kunde kunde3 = new Kunde("Christian", "12345678");
double totalPrice;


//Ordre 1

Ordre ordre1 = new Ordre(pizza1, kunde1);

ordre1.TilføjLevering();

totalPrice = ordre1.CalculateTotalPrice();

Console.WriteLine($"Ordre 1: {ordre1.pizza.Navn}, {ordre1.Kunde.Navn}, {totalPrice} kr.");

//Ordre 2

Ordre ordre2 = new Ordre(pizza2, kunde2);

totalPrice = ordre2.CalculateTotalPrice();

Console.WriteLine($"Ordre 2: {ordre2.pizza.Navn}, {ordre2.Kunde.Navn}, {totalPrice} kr.");

//Order 3

Ordre ordre3 = new Ordre(pizza3, kunde3);

totalPrice = ordre3.CalculateTotalPrice();

Console.WriteLine($"Ordre 3: {ordre3.pizza.Navn}, {ordre3.Kunde.Navn}, {totalPrice} kr.");