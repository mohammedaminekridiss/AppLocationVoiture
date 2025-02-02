Présentation de l'application 
Il s'agit d'une application de réservation de voitures de location. elle contient une partie publique déstinée au client et une partie d'administration des données du site.
l'architecture du site est une architecture 3-tiers avec 3 couches : une couche présentation , une couche logique métier (business) et une couche d'accès aux données(avec le framework EntityFramework).
La première couche est un projet webforms et les deux autres sont des bibliothèques de classe(class library).
Le choix de cette architecture permet une séparation claire des fonctionnalités techniques ce qui permet une meilleure lisibilité du code et facilite le maintenance du site .
 
