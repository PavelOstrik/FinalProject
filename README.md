Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры: 
["hello", "2", "world", ":)"] -> ["2", ":)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []

Описание решения:
Имеется массив строк, необходимо из него сформировать массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив вводим с клавиатуры.
При решении пользуемся исключительно массивами.

1. Установить счетчик index в позицию 0
2. Пока index < длины массива делаем
3. Если длина элемента массива < либо = 3 символам
4. Да: печатаем элемент
5. Увеличить index на 1 и вернуться к шагу 2
6. Нет: перейти к шагу 5 
5. Как только index > длины массива завершаем работу алгоритма

