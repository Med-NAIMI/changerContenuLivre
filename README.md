# changerContenuLivre
Énoncé :
On considère un livre stocké chez plusieurs personnes à la fois. N'importe qui
peut demander à écrire une lettre de l'alphabet dans ce livre (y compris des
personnes ne stockant pas le livre chez eux). Néanmoins, pour que la
demande d'écriture soit validée, il faut qu'au minimum la moitié des
personnes stockant le livre soit d'accord pour ajouter cette écriture. Si la
demande obtient la majorité, le livre se met à jour automatiquement partout
où il est stocké. Sinon le livre reste tel quel. On considère que le livre est
initialement vide.
Développer une méthode qui prend en paramètre :
∞ Un entier P, correspondant au nombre de personnes stockant le livre.
∞ Une liste de chaines de caractère L. Chaque chaine contient une lettre
de l'alphabet C et un entier Q séparés par un espace où C la
demande d'écriture et Q le nombre de personne ayant validé cette
demande.
La méthode doit retourner une chaîne de caractères représentant le contenu
du livre.
 Exemple :
Pour :
∞ P = 5.
∞ L = { "b 2", "R 3", "x 5", "A 0", "f 2", "f 5" }.
La méthode retourne "Rxf".
