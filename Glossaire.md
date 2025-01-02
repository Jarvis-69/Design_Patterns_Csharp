# Interface :

Une structure qui définit un contrat (ensemble de méthodes) que les classes doivent implémenter. Elle ne contient aucune implémentation.
Exemple : Une interface IPrinter peut avoir une méthode Print() que toutes les classes d'imprimantes doivent définir.


# Classe concrète :

Une classe qui implémente toutes les méthodes nécessaires et peut être instanciée.
Exemple : Une classe PdfPrinter implémente l'interface IPrinter et peut être utilisée directement.


# Instance :

Une occurrence spécifique d'une classe créée en mémoire.
Exemple : var config = new Configuration(); crée une instance de la classe Configuration.


# Abstraction :

Une technique qui cache les détails d'implémentation tout en exposant uniquement les fonctionnalités essentielles.
Exemple : Une classe Document abstrait les détails spécifiques des imprimantes comme PdfPrinter ou HtmlPrinter.


# Encapsulation :

Un principe où les détails internes d'une classe (attributs, méthodes) sont cachés et accessibles uniquement via des méthodes publiques.
Exemple : Une classe Car peut avoir une méthode publique StartEngine() qui cache la complexité des étapes internes.


# Polymorphisme :

La capacité d'utiliser une seule interface pour différents types.
Exemple : Une méthode Print() peut être utilisée pour des classes différentes comme PdfPrinter et HtmlPrinter.

# Héritage :

Un mécanisme où une classe (dérivée) peut hériter des propriétés et méthodes d'une autre classe (parente).
Exemple : Une classe LuxuryCar peut hériter de la classe Car tout en ajoutant des fonctionnalités spécifiques.