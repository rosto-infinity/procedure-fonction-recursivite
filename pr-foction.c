Différences entre Procédures et Fonctions
Définition :

// Procédure : Une procédure est un bloc de code qui exécute une série d'instructions. Elle peut prendre des paramètres en entrée, mais n'a pas de valeur de retour.
// Fonction : Une fonction est un bloc de code qui effectue un calcul ou une opération et retourne une valeur. Elle peut également prendre des paramètres en entrée.
// Valeur de Retour :

// Procédure : Ne retourne pas de valeur. Elle effectue des actions comme modifier des variables ou afficher des résultats.
// Fonction : Retourne une valeur qui peut être utilisée dans d'autres expressions.
// Utilisation :

// Procédure : Utilisée pour exécuter des tâches spécifiques, comme afficher des messages ou effectuer des opérations sur des données.
// Fonction : Utilisée pour effectuer des calculs et retourner des résultats qui peuvent être utilisés dans des expressions ou des calculs supplémentaires.
// Exemples
// Exemple de Procédure
// Copier
// def afficher_message(message):
//     print(message)

// # Appel de la procédure
// afficher_message("Bonjour, bienvenue dans la programmation !")
// Dans cet exemple, afficher_message est une procédure qui affiche un message à l'écran. Elle ne retourne aucune valeur.

// Exemple de Fonction

def additionner(a, b):
    return a + b

# Appel de la fonction
resultat = additionner(5, 3)
print("Le résultat de l'addition est :", resultat)
// Ici, additionner est une fonction qui prend deux paramètres, a et b, et retourne leur somme. Le résultat peut être utilisé dans d'autres calculs ou affiché.

// Conclusion
// En résumé, les procédures et les fonctions sont des éléments fondamentaux de la programmation. Les procédures sont utilisées pour exécuter des actions sans retourner de valeur, tandis que les fonctions effectuent des calculs et retournent des valeurs qui peuvent être utilisées ultérieurement.