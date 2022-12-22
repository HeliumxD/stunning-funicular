# Lern-Bericht
Brezel | Nicola Karrer, Carina Sutter, Mirhan Özden, Giovanni Innamorato

## Einleitung

Wir haben ein Programm programmiert, mit dem man Tic Tac Toe spielen kann.

## Was haen wir gelernt?

Wir haben gelernt, wie man den checkForWinner benutzen kann.

## Beschreibung

In diesem Projekt haben wir gelernt, wie wir den void checkForWinner anwenden können. Die checkForWinner Methode schaut und checkt, ob jemand gewonnen hat oder nicht.
Wir haben, wie man im Bild sehen kann, jede Möglichkeit aufgeschrieben, die es gibt, um Tic Tac Toe zu gewinnen. Diese Funktion überprüft jetzt alle Gewinnwege und schaut, ob einer zutrifft.
*Bild von checkForWinner

Wenn zum Beispiel beim ersten A1, das sind die Felder vom Tic Tac Toe, und A2 übereinstimmen und auch noch A2 mit A3, dann ist there_is_a_winner. Dies mussten wir
für jede einzelne Kombination machen, was in diesem Fall 8x sind, da man auf 8 verschiedene Arten gewinnen kann. Geprüft wird dies mit der Bool Funktion. Das
heisst, wenn eben dort ein Gewinner ist, dass es dann dort zu true wird und das Spiel beendet und einen Punkt für den Gewinner zählt. Wenn keines der Möglichkeiten 
zutrifft und alle Felder ausgeüllt sind, zählt das als Unentschieden und dafür haben wir auch einen Punktestand, der diese zählt.
*Code für Punktestand

## Verifikation

Das Bild zeigt die einzelnen Methoden für den checkForWinner Void und der Code zeigt, wie der Punktestand gezählt wird.

# Reflektion zum Arbeitsprozess

Das Pair-programmieren ist sehr gut gegangen.

Wir haben uns ein bisschen zu viel vorgenommen und waren deshalb ein bisschen unter stress.

**VBV**: Nur so viel Aufschreiben wie wir denken, wie viel wir schaffen und später dann mehr hinzufügen, falls wir dann noch Zeit übrig haben.
