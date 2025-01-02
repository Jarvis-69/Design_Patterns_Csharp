# Abstract Factory

Permet de créer des objets liés entre eux sans dire exactement comment les créer.

Exemple : Pour une application de voitures, une "usine" peut fabriquer des moteurs et batteries adaptés aux voitures électriques ou essence.

Avantages : Facile à étendre et maintient la cohérence des objets.

-----------------------------------------------------------

# Builder

Construit un objet compliqué étape par étape.

Exemple : Dans un site de vente de voitures, on crée un contrat PDF ou HTML en ajoutant progressivement les infos comme le prix et les options choisies.

Idéal pour : Objets ayant beaucoup de parties ou des formats différents.

-----------------------------------------------------------

# Prototype

Copie un objet existant pour en créer un nouveau.

Exemple : Une "liasse" de documents vierges est clonée pour chaque client, avec la possibilité d’ajouter ou de retirer des documents.

Domaines d’Utilisation : Objets complexes ou coûteux à créer, comme des formulaires ou des configurations.

-----------------------------------------------------------

# Singleton

Assure qu’il n’y ait qu’un seul exemplaire d’une classe.

Exemple : Une application utilise un seul gestionnaire pour accéder aux modèles de documents, ce qui évite les erreurs.

Utilisation : Gestion de paramètres globaux ou de ressources partagées.

-----------------------------------------------------------

# Adapter

Change l’interface d’une classe pour qu’elle soit compatible avec une autre.

Exemple : Un site utilise une bibliothèque pour créer des factures PDF, mais les formats sont incompatibles. L’adapter corrige cela.

Avantages : Intègre facilement des outils externes ou anciens.

-----------------------------------------------------------

# Bridge

Sépare ce que fait un objet de comment il le fait.

Exemple : Pour des formulaires d’immatriculation, on sépare les formats (HTML, PDF) des variations par pays.

Utilisation : Réduit la complexité quand il y a beaucoup de variations.

-----------------------------------------------------------

# Decorator

Ajoute des fonctionnalités à un objet sans le modifier directement.

Exemple : Un catalogue affiche des infos de base, mais pour les voitures haut de gamme, il ajoute des données techniques et des promotions.

Avantages : Ajoute des options facilement sans créer plein de sous-classes.

-----------------------------------------------------------

# Chain of Responsibility

Passe une demande à une chaîne d’objets jusqu’à ce qu’elle soit traitée.

Exemple : Une demande d’infos sur une voiture passe du détail spécifique au général, ou renvoie une erreur si rien n’est trouvé.

Avantages : Flexible pour ajouter ou changer les étapes du traitement.

-----------------------------------------------------------

# Command

Transforme une action en objet pour mieux la gérer.

Exemple : Sur un site d’e-commerce, chaque action (comme ajouter au panier) peut être annulée ou refaite grâce à un objet Command.

Utilisation : Actions annulables, mises en file d’attente, ou journalisées.