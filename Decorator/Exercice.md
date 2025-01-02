Pour décorer un café avec du lait et du sucre :

- On créer une interface Icafé, avec un prix et une description

- On créer un cas "Café simple", où le prix est à 2€ et la description est "Café simple"

- On créer une classe abstraite CafeDecorateur :
# Pas tout compris ici

- on créer une classe lait hérité de la classe abstraite CafeDecorateur
# public Lait(ICafe cafe) : base(cafe) => Pas comrpis
Ce qu'il fait rajouter 0,5€ au prix du café et qui rajoute "lait" dans la description

- Même chose pour la classe sucre 
# public Lait(ICafe cafe) : base(cafe) => Pas comrpis
ou ici, cela rajoute 0,2€ au prix et rajoute "sucre" dans la description

- L'utilisation à la fin simule un café avec le lait et le sucre