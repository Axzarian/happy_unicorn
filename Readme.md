# Инструкция для работы с Git и удалёнными репозиториями

## **Что такое Git?**
**Git** - *это одна из реализаций распределённых систем контроля версий, имеющая как и локальные, так и удалённые репозитории. Является самой популярной реализацией систем контроля версий в мире.*

<br>

 ## **Подготовка репозитория**
 >Для создание репозитория необходимо выполнить команду *``git init``*  в папке с репозиторием и у Вас создаться репозиторий (появится скрытая папка .git)
 ---
## **Создание коммитов**
<br>


 ### __Git add__
> Для добавления измений в коммит используется команда *``git add``*. Чтобы использовать команду *``git add``* напишите *``git add <имя файла>``*

<br>

#### **Просмотр состояния репозитория**
> Для того, чтобы посмотреть состояние репозитория используется команда *``git status``*. Для этого необходимо в папке с репозиторием написать *``git status``*, и Вы увидите были ли измения в файлах, или их не было.

<br>

#### **Создание коммитов**
> Для того, чтобы создать коммит(сохранение) необходимо выполнить команду *``git commit``*. Выполняется она так: *``git commit -m "<сообщение к коммиту>``*. Все файлы для коммита должны быть ***ДОБАВЛЕНЫ*** и сообщение к коммиту писать ***ОБЯЗАТЕЛЬНО***.

#### **Перемещение между сохранениями**
> Для того, чтобы перемещаться между коммитами, используется команда *``git checkout``*. Используется она в папке с пепозиторием следующим образом: *``git checkout <номер коммита>``*

<br>

#### **Журнал изменений**
> Для того, чтобы посмтреть все сделанные изменения в репозитории, используется команда *``git log``*. Для этого достаточно выполнить команду *``git log``* в папке с репозиторием
---
## **Ветки в Git**

* ### Создание ветки

Для того, чтобы создать ветку, используется команда *``git branch``*. Делается это следующим образом в папке с репозиторием: *``git branch <название новой ветки>``*

* ### Слияние веток

Для того чтобы дабавить ветку в текущую ветку используется команда *``git merge <name branch>``*

* ### Удаление веток
Для удаления ветки ввести команду ``"git branch -d 'name branch'"``

### **Справочник по командам:** <http://gist.github.com/Jekins/2bf2d0638163f1294637#Emphasis/>

<br>
<br>
<br>

Таблица описаных выше команд
|Команда       |Что делает           |
|--------------|---------------------|
|git init      |создание репозитория |
|git add       |добавления измений в коммит
|git status    |посмотреть состояние репозитория
|git commit    |создать коммит(сохранение)
|git checkout  |перемещаться между коммитами
|git log       |посмтреть все сделанные изменения
|git branch    |создать ветку
|git merge     |дабавить ветку в текущую ветку
|git branch -d |удаления ветки