#### **Дана задача:**

Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// ["hello","2", "world", ":)"] -> ["2", ":)"]

// ["1234", "1567", "-2", "computer science"] -> ["-2"]

// ["Russia", "Denmark", "Kazan"] -> [ ]

#### **********Описание решения:**********

User согласно запрашиваемому условию вводит данные типа string. 

Затем для обработки этой информации используются методы GetArray и SizeNewArray.

Метод SizeNewArray определяет размер получаемого на выходе массива:  оператором цикла foreach "пробегаемся" по заданному пользователем массиву и, согласно условию задачи, определяем, если значение элемента массива меньше либо равно 3, то проводится запись количества таких элементов на счетчик size.

Метод GetArray получает на выходе новый массив соответсвующий условию. Также с помощью цикла foreach "пробегаемся" по всему массиву и в новый массив записываем значения меньше 3 символов.
