# RecentFilesHistory-Bibliothek
Diese Bibliothek erleichtert den einfachen und effizienten Zugriff auf Dateien in Desktop-Anwendungen und spiegelt die beliebte Funktion "Dateiverlauf" bzw. "Zuletzt geöffnete Dateien" oder auch "Neueste Dateien" genannt wieder, welche aus namhaften Editoren und Designanwendungen bekannt sind.

## Beispiel zur Verwendung
![Verlauf von zuletzt geöffneten, geschlossenen oder gespeicherten Dateien](demo-window-history-of-recently-opened-closed-or-saved-files.png)

## UML-Klassendiagramm
![UML-Klassendiagramm](uml-class-diagramm-of-recent-files-history.png)

## Funktionsweise
Die Bibliothek enthält die generische abstrakte Klasse `RecentlyFilesHistoryManager<T>`, die Elemente in der `ObservableCollection<T> Items` mithilfe einer LRU (Least Recently Used) Cache-Politik verwaltet.

Um eine Datei zum Verlauf hinzuzufügen, verwenden Sie einfach die Methode `PutAtFront(item)`. Wenn das Element bereits in der Sammlung vorhanden ist, wird es an die erste Position verschoben (als am aktuellsten betrachtet).

Um diese Bibliothek zu verwenden, implementieren Sie die generische abstrakte Klasse, indem Sie den Datentyp für den generischen Typ angeben. Implementieren Sie dann die Methoden `Load()` und `Save()`, um den Verlauf von kürzlich geöffneten, gespeicherten und geschlossenen Dateien zu verwalten.

## Demoprojekt
Sie können das Demoprojekt erkunden, das zeigt, wie Sie die Bibliothek zum Verwalten von Dateipfaden (Strings) verwenden können.