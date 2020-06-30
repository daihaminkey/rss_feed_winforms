# RSS feed
RSS feed - фидер RSS-каналов, написанный на языке C# с использованием WinForms.
Поддерживает выдачу информации из нескольких источников (сортированную хронологически), автообновление и сохранение конфигурации в XML-файл.
### Интерфейс
* Для того, чтобы перейти по ссылке на материал, нужно нажать на элемент левой кнопкой мыши.
* Для того, чтобы открыть описание элемента, нужно нажать на элемент правой кнопкой мыши:
![][ScreenshotInterface]

* Конфигурация "из интерфейса" доступна в меню "настройки":
![][ScreenshotSettings]

* Чтобы удалить добавленный фид, достаточно кликнуть по нему в списке:
![][ScreenshotDelete]

* Обновить ленту, не дожидаясь автоматического обновления, можно из меню "файл":
![][ScreenshotUpdate]


### Конфигурация
Конфигурация программы хранится в файле Config.xml в корневом каталоге программы. При первом запуске утилита сгенерирует его стандартный вариант.

Пример изначального файла конфигурации:
```
<?xml version="1.0"?>
<Config xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <Feeds>
    <string>https://habr.com/rss/interesting</string>
  </Feeds>
  <ReloadTimeInMinutes>3</ReloadTimeInMinutes>
  <RenderHtml>true</RenderHtml>
</Config>
```

### Сборка
В решении находится два проекта: ControlsLibrary и RSS_Feed. 
ControlsLibrary содержит пользовательские элементы управления WinForms, которые пришлось вывести в отдельный проект из-за особенностей конструктора WinForms: для того, чтобы корректно отображать кастомные элементы управления, ему нужна их уже собранная версия.
В связи с этим, при запуске RSS_Feed.sln дизайнер может отказаться рендерить формы. Чтобы это исправить, достаточно один раз собрать решение.

### Ссылки
Анимация загрузки сгенерирована с помощью [этого сайта][Loading].

[ScreenshotInterface]:<http://joxi.ru/Vrw6bDacOPDa1A.png>
[ScreenshotSettings]:<http://joxi.ru/EA43XGeIwQYaJ2.png>
[ScreenshotDelete]:<http://joxi.ru/82QxO13Cj576jm.png>
[ScreenshotUpdate]:<http://joxi.ru/5mdavVpIkygPa2.png>
[Loading]:<https://loading.io/>