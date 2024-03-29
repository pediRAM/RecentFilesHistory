![logo](https://raw.githubusercontent.com/pediRAM/RecentFilesHistory/main/Documentation/icon.png)

[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Release](https://img.shields.io/github/release/pediRAM/RecentFilesHistory.svg?sort=semver)](https://github.com/pediRAM/RecentFilesHistory/releases)
[![NuGet](https://img.shields.io/nuget/v/RecentFilesHistory)](https://www.nuget.org/packages/RecentFilesHistory)

# Библиотека RecentFilesHistory
Эта библиотека облегчает доступ к файлам в рабочих приложениях, предоставляя популярные функции, такие как "История файлов", "Последние открытые файлы" и "Последние файлы", известные известными редакторами и приложениями для дизайна.

## Пример использования
![История недавно открытых, сохраненных или закрытых файлов](https://raw.githubusercontent.com/pediRAM/RecentFilesHistory/main/Documentation/demo-window-history-of-recently-opened-closed-or-saved-files.png)

## UML-диаграмма классов
![UML-диаграмма классов](https://raw.githubusercontent.com/pediRAM/RecentFilesHistory/main/Documentation/uml-class-diagramm-of-recent-files-history.png)

## Как это работает
Библиотека включает в себя обобщенный абстрактный класс `RecentlyFilesHistoryManager<T>`, который управляет элементами в коллекции `ObservableCollection<T> Items` с использованием стратегии кэширования LRU (Наименее недавно использованные).

Чтобы добавить файл в историю, просто используйте метод `PutAtFront(item)`. Если элемент уже существует в коллекции, он будет перемещен на первую позицию (считается самым недавним).

Чтобы использовать эту библиотеку, реализуйте обобщенный абстрактный класс, указав тип данных для обобщенного типа, а затем реализуйте методы `Load()` и `Save()`, чтобы управлять историей недавно открытых, сохраненных и закрытых файлов.

## Проект-демонстрация
Вы можете изучить демонстрационный проект, который показывает, как использовать библиотеку для управления путями к файлам (строками).