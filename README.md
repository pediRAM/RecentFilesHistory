![](2-no-48-no-more-islamic-republic.png)
## **IRAN IS BLEEDING --- AND THE WORLD IS SILENT**
BEGIN OF UPDATE: 2026-01-18
LAST UPDATEL: 2026-02-18

# Massacre in IRAN
## The Media is Silent!
## BBC and CNN use the narative and political framing of the criminal Islamist Djihadist Mullah Regime of Iran
### 20 Mil. USD have been paid to influencers and PR companies in western countries to relativate, deny, negate and downsize the Crimes of Islamist Djihadist Republic of Iran
### The western Democracies are infiltraded by hundreds of NGOs and Consulting Institutions of Islamist Criminal Republic of Iran

[**The Slaughterer and Tyranny Regime of Mullahs is Slaughtering their protesting Nation and the Media was and is silent for a very long time!**](https://www.youtube.com/watch?v=x36HO4BiPYI)

This Regime has killed at least ~12000+~ 40000+ protestors in 48 hours (8th - 9th Jan. 2026),
after [turning off the internet](https://mastodon.social/@netblocks/115979334965828202), Mobile-net, telephone-net and even electricity and they started to 
disturb the satellite frequencies by military jammers from china, to also [turn off the internet connection through Starlink](https://www.techpolicy.press/what-irans-internet-shutdown-reveals-about-starlink/)!

But some brave people which traveled to abroud smuggled a lot of images and videos, but also figures/statistics collected
by brave doctors in Iran. The figures/numbers currently after ~three~ six weeks of protesting are:
- Death toll: ~60000+~ 94000+ since 2026-01-18 until today 21th Feb. 2026 (secret services estimate numbers over 100000!)
- Blined: ~8000+~ 10000+
- Wounded: 350000+
- Detained: 130000+ (which is decreasing due to daily silent mass executions)

When the family of killed protestors try to get the dead body, [**they have to pay the "bullet-price" of 5000 to 7000 USD for each Bullet!**](https://www.youtube.com/watch?v=dmPnGJG8yQw&t=935s)
An average worker earns about 100 to 200 USD per month!

**The bodies of those whose relatives cannot afford the bullet-price are buried in mass graves without names or any other identifying information or markings at unknown locations.**

Car and ferniture are also confiscated.

Scared from ***Final Shot*** of Regime-Thugs, [many wounded people are scared to go to hospitals or doctors](https://www.bbc.com/news/articles/c5yx015nkplo), so they lie at home and ***die slowly due to Infections or Internal Bleedings***.

**Now(2026-01-18), after 120+ hours of internet-shuttdown, they turn it for some time on to transfere their BitCoins to wallets out of iran!**
[Netblocks.org Iran](https://mastodon.social/@netblocks/115916598029882510)

The regime thugs [**invaded into hospitals by force and killed wounded people by final shot.**](https://www.youtube.com/watch?v=RcxE5OX4TDo&t=74s)

The Doctors and Nurses, resisted against the regime thugs, have [**also been killed or detained with death sentence!**](https://www.bbc.com/news/articles/c5yx015nkplo)

END OF UPDATE.


![logo](https://raw.githubusercontent.com/pediRAM/RecentFilesHistory/main/Documentation/icon.png)

[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Release](https://img.shields.io/github/release/pediRAM/RecentFilesHistory.svg?sort=semver)](https://github.com/pediRAM/RecentFilesHistory/releases)
[![NuGet](https://img.shields.io/nuget/v/RecentFilesHistory)](https://www.nuget.org/packages/RecentFilesHistory)

This is the english documentation. Following translations are available:
- [普通话 (Mandarin) :cn:](https://github.com/pediRAM/RecentFilesHistory/blob/main/Documentation/Mandarin.md)
- [Español :es:](https://github.com/pediRAM/RecentFilesHistory/blob/main/Documentation/Spanish.md)
- [Pусский :ru:](https://github.com/pediRAM/RecentFilesHistory/blob/main/Documentation/Russian.md)
- [Deutsch :de: :austria: :switzerland:](https://github.com/pediRAM/RecentFilesHistory/blob/main/Documentation/German.md)
- [हिंदी :india:](https://github.com/pediRAM/RecentFilesHistory/blob/main/Documentation/Hindi.md)
- [Türkçe :tr:](https://github.com/pediRAM/RecentFilesHistory/blob/main/Documentation/Turkish.md)
- [فارسی :iran: :afghanistan: :tajikistan:](https://github.com/pediRAM/RecentFilesHistory/blob/main/Documentation/Farsi.md)

# RecentFilesHistory Library
This Library Facilitating Easy and Efficient File Access in Desktop Applications, Mirroring Popular Feature like "**Recent Files**" or "**Last Opened Files**" or "**File History**" from Notable Editors and Design Applications. 

Latest opened/saved/closed **N** files (text/image/project/...) are saved with [LRU policy](https://en.wikipedia.org/wiki/Cache_replacement_policies#Least_recently_used_(LRU)).

**N**: N is the configurable capacity.

## Usage Example
![Recent File History](https://raw.githubusercontent.com/pediRAM/RecentFilesHistory/main/Documentation/demo-window-history-of-recently-opened-closed-or-saved-files.png)

## UML Class Diagram
![UML Class Diagram](https://raw.githubusercontent.com/pediRAM/RecentFilesHistory/main/Documentation/uml-class-diagramm-of-recent-files-history.png)

## How It Works
The library includes the generic abstract class `RecentlyFilesHistoryManager<T>`, which manages elements in the `ObservableCollection<T> Items` using an LRU (Least Recently Used) cache policy.

To add a file to the history, simply use the `PutAtFront(item)` method. If the item already exists in the collection, it will be moved to the first position (considered most recent).

To use this library, implement the generic abstract class by specifying the data type for the generic type. Then, implement the `Load()` and `Save()` methods to manage the history of recently opened, saved, and closed files.

## Demo Project

You can explore the [demo WPF desktop project](https://github.com/pediRAM/RecentFilesHistory/tree/main/Source/RecentFilesHistoryDemoWpfApp), which demonstrates how to use the library to manage filepaths (strings).
