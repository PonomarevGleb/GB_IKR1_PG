# Итоговая контрольная работа по основному блоку

## Урок 1. Контрольная работа
**сдавать ссылкой на github**

_Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно._

Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
3. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
2. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
1. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)


Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

---
# Описание решения

- Пройти изначальный массив, проверяя каждый элемент массива на длинну
- При нахождении эелемента длинной **3 или короче** увеличивать счетчик
- *Создать второй строковый массив, в который будет записываться ответ; длина массива равна размеру счетчика*
- Проти изначальный массив еще раз, заполнить итоговый массив нужными элементами
- Вывести итоговый массив