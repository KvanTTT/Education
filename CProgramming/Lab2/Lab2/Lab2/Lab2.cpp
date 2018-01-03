// Lab2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdio.h>
#include <string>
#include <iostream>
#include <conio.h>

using namespace std;

// Прототипы функций
void row();				// Новая строка с нумерацией
void readkey();			// Ждем нажатия новой клавиши
string ru(const string);	// Перекодировка ANSI -> OEM
void BitPrint(int i);

int _tmain(int argc, _TCHAR* argv[])
{int x, y, z;
// Префиксный и постфиксный операторы инкремента(++) и декремента(--).
// Каждый компилятор может по-разному вычислять выражения, содержащие
// ++, --.
// Но все-таки компиляторы MicroSoft, Borland, GNU придерживаются следующего
// правила: 
// 1. Читаем все префиксные операторы, выполняем их до вычисления выражения
// 2. Вычисляем выражение БЕЗ учета постфиксных операторов
// 3. Выполняем все постфиксные операторы

// Пример:
// p = -m++ + ++p;

// То же самое, что и:
// p++;
// p = -m + p;
// m++;

// Если P = 0, Q = 1, то вычислите в уме и проверьте следующие результаты Z1, Z2, Z3:
row();	// 1 строка
int Z1, Z2, Z3, P, Q;

P = 0;
Q = 1;
Z1 = ++Q - --P + P++;

P = 0;
Q = 1;
Z2 = -Q-- - P++ * --P;

P = 0;
Q = 1;
Z3 = Q - -P++ + P++;

cout << Z1 << "; " << Z2 << "; " << Z3;


/// В C/C++ (так же, как и на Delphi) с целыми числами можно работать на уровне бит.
/// Байты в целом числе нумеруются от нуля и читаются с правого края.
/// Биты в числе нумеруются от нуля и тоже читаются с правого края.

// Простые унарные операторы:
// Оператор	"~" - это ПОБИТОВОЕ отрицание. (В Delphi это был NOT)
// Например:			3 байт	2 байт	1 байт	0 байт
// int x = 4	это		0000 0000   0000 0000   0000 0000   0000 0100
// int y = ~x	это		1111 1111   1111 1111   1111 1111   1111 1011
// В данном случае y = -5 т.к. под самым последним битом мы понимаем знак 
// числа(для типа int).
// Ввести целое число, применить оператор "~" и вывести результат

row();	// 2 строка
cout << ru("Оператор ~\n");
cout << ru("Введите число: ");
cin >> x;
y = ~x;
BitPrint(x);
cout << "y = " << y << "\n";
BitPrint(y);


// Оператор "!" - это ЛОГИЧЕСКОЕ отрицание
// Это отрицание основано на принципе:
// Отрицание нуля дает единицу, а отрицание любого числа(не равного нулю) дает ноль.
// Ввести целое число, применить оператор "!" и вывести результат

row();	// 3 строка
cout << ru("Оператор !\n");
cout << ru("Введите число: ");
cin >> x;
y = !x;
BitPrint(x);
cout << "y = " << y << "\n";
BitPrint(y);


// Оператор "-" - это унарный минус (смена знака на противоположный).
row();	// 4 строка
cout << ru("Оператор -\n");
cout << ru("Введите число: ");
cin >> x;
y = -x;
cout << "- " << x << " = " << y;


// Простые бинарные операторы:
// Оператор "&": A & B - это побитовая конъюнкция. (В Delphi это было AND).
// (т.е. для каждого бита будет выполнена операция A & B)
// Ввести два числа x и y, применить оператор &: z = x & y, и вывести z

row();	// 5 строка
cout << ru("Оператор &\n");
cout << ru("Введите два числа: ");
cin >> x >> y;
BitPrint(x);
BitPrint(y);
z = x & y;
cout << "z = " << z << "\n";
BitPrint(z);


// Оператор "|": A | B - это побитовая дизъюнкция.  (В Delphi это было OR).
// (т.е. для каждого бита будет выполнена операция A | B)
// Ввести два числа x и y, применить оператор |: z = x | y, и вывести z
row();	// 6 строка
cout << ru("Оператор |\n");
cout << ru("Введите два числа: ");
cin >> x >> y;
BitPrint(x);
BitPrint(y);
z = x | y;
cout << "z = " << z << "\n";
BitPrint(z);


// Внимание! Операторы "&" и "|" - это полные побитовые операторы!
// Т.е. Если задано выражение: A & B или A | B, то результатом операции будет 
// полное вычисление выражения.

// !!!! Существуют также операторы "&&" и "||" - это сокращенные операторы.
// Т.е. Если задано A && B, и если A == 0, тогда выражение НЕ вычисляется, а сразу
// возвращается ноль! Если же A == 1, тогда выражение вычисляется как в случае с
// полным побитовыми оператором "&".
// Аналогично если задано A || B, и A == 1, тогда выражение НЕ вычисляется и 
// результат равен 1, и если A == 0, тогда выражение вычисляется, как и в случае "|".

// Важно очень четко понимать, где использовать ПОЛНЫЕ операторы, а где СОКРАЩЕННЫЕ!
// Если нужно работать с числами на уровне бит, то всегда лучше использовать полные
// операторы.
// Если же вам нужно оптимизировать условие, например if, while и т.д., то лучше
// использовать && и ||

// Пример условия:
int a, b, c;
a = 0;
b = (6+6+6 + 4);
// Здесь если a не равно нулю, то мы делим b на a и сравниваем результат с 22.
// Если же a равно нулю, то результат бинарного выражения:
// (a != 0) будет 0 (или false),
// и вторая часть && уже НЕ будет вычисляться!!! Ошибки деления на ноль НЕ БУДЕТ!!!
// И напротив, если использовать &, то будет ошибка!!!

if((a != 0) && ((b / a) > 22))
{
	// Какой-то код
	cout << "\nALL OK\n";
	getch();
}


// Операторы сдвига.
// Оператор "<<": A << B - это сдвиг всех бит числа A влево на кол-во позиций B. 
// (В Delphi это SHL)
// Т.е. дано char A = 3	это		0000 0011
// и char C = A << 1	это		0000 0110
// Мы просто сдвинули все биты числа A на один разряд влево.
// Нетрудно заметить, что A << B - это то же, что и A * (2 в степени B).
// т.е. A << 4 это то же, что и A * 16

// Оператор ">>": A >> B - это сдвиг всех бит числа A вправо на кол-во позиций B. 
// (В Delphi это SHR)
// Т.е. дано char A = 7	это		0000 0111
// и char C = A >> 1	это		0000 0011
// Мы сдвинули все биты числа A на один разряд вправо и потеряли один разряд.
// Нетрудно заметить, что A >> B - это то же, что и A / (2 в степени B).
// т.е. A >> 3 это то же, что и A / 8

// ! Внимание! Операции "<<" и ">>" выполняются за один такт процессора!
// Чего не скажешь про деление или умножение. Поэтому, если вдруг возникнет
// вопрос оптимизации, то лучше использовать сдвиги, нежели умножение/деление
// на (2 в степени B)

// ! A >> 3		быстрее, чем	A / 8

// Ввести числа x, y, z
// Применить к ним несколько операций <<, >> и вывести на экран результат

row();	// 7 строка
cout << ru("Операторы >> и <<\n");
cout << ru("Введите три числа: ");
cin >> x >> y >> z;
BitPrint(x);
BitPrint(y);
BitPrint(z);
Z1 = ((x >> 3) & (y << 4) | (z >> 1));
cout << ru("Результат: ") << Z1 << "\n";
BitPrint(Z1);


// Оператор "^" - это побитовое исключающее или (в Delphi это XOR).
// Остановимся подробнее на этом операторе.
// Его таблица истинности:
// A	B		A ^ B
// ------------------
// 0	0	   	  0
// 0	1		  1
// 1	0		  1
// 1	1		  0

// Эту таблицу очень просто запомнить, как отрицание таблицы эквивалентности "==".
// "^" - еще в некоторой мат.литературе называют "непохожесть" или 
// "неэквивалентность".
// У этой операции есть два замечательных свойства:
// 1. A ^ A == 0		- всегда!!!
// 2. A ^ B ^ B == A	- всегда!!!
// "^" выполняется за один такт процессора!
// Ввести два числа x,y сделать x ^ y, вывести результат

row();	// 8 строка
cout << ru("Оператор ^\n");
cout << ru("Введите два числа: ");
cin >> x >> y;
BitPrint(x);
BitPrint(y);
z = x ^ y;
cout << "z = " << z << "\n";
BitPrint(z);


// Оператор	"%" - это остаток от деления (в Delphi это MOD).
// Например 3 % 2 == 1, а 8 % 4 == 0
// Введите A, B, Посчитайте A % B, выведите результат

row();	// 9 строка
cout << ru("Оператор %\n");
cout << ru("Введите два числа: \n");
cin >> a >> b;
BitPrint(a);
BitPrint(b);
cout << a << " % " << b << " = " << a%b;
BitPrint(a%b);

// ТЕРНАРНЫЙ оператор A ? B : C - это оператор условия.
// A - Это логическое выражение, а B и C - Это те значения, которые
// может принять левая часть. 
// Т.е. если условие A истинно, то тогда результат выражения B,
// а если A ложно, то результат C.
// Например:
// int a,b,c;	...	c = (a > b) ? a : b;	// Ищет max a, b
// Написать программу поиска min a, b с помощью этого оператора

row();	// 10 строка
cout << ru("Тернарный оператор ?\n");
cout << ru("Введите два числа: \n");
cin >> a >> b;
c = (a < b) ? a : b;
cout << ru("Минимум чисел ") << a << ru(" и ") << b << ru(" = ") << c;

row();
cout << ru("Оператор ,\n");
cout << ru("Введите три числа: \n");
cin >> a >> b >> c;
a = b, b = c;
cout << "a = " << a << " b = " << b << " c = " << c << "\n";

row();
cout << ru("Оператор sizeof: \n");
cout << ru("Введите число: \n");
cin >> a;
cout << "Sizeof(a) = " << sizeof(a);

row();
cout << ru("Оператор разадресации: \n");
cout << ru("Введите число: \n");
cin >> a;
cout << &a;

row();
cout << ru("Оператор &&: \n");
cout << ru("Введите два числа: \n");
cin >> a >> b;
BitPrint(a);
BitPrint(b);
cout << (a && b) << endl;
BitPrint(a && b);

row();
cout << ru("Оператор ||: \n");
cout << ru("Введите два числа: \n");
cin >> a >> b;
BitPrint(a);
BitPrint(b);
cout << (a || b) << endl;
BitPrint(a||b);

row();
cout << ru("Оператор +=: \n");
cout << ru("Введите два числа: \n");
cin >> a >> b;
a += b;
cout << a;

row();
cout << ru("Оператор -=: \n");
cout << ru("Введите два числа: \n");
cin >> a >> b;
a -= b;
cout << a;

row();
cout << ru("Оператор *=: \n");
cout << ru("Введите два числа: \n");
cin >> a >> b;
a *= b;
cout << a;

row();
cout << ru("Оператор /=: \n");
cout << ru("Введите два числа: \n");
cin >> a >> b;
a /= b;
cout << a;

row();
cout << ru("Операторы сравнения: \n");
cout << ru("Введите два числа: \n");
cin >> a >> b;
if (a > b) cout << ru("Число a больше");
else if (a < b) cout << ru("Число b больше");
else cout << ru("Числа равны");
readkey();
}

void row()
{
	static int i = 0;
	cout.flags(ios::dec);
	cout << "\n[" << ++i << "]: ";
}

void readkey()
{	
	cout << ru("\nНажмите любую клавишу для продолжения...");
	getch();
}

string ru(const string arg)
{
   	string s = arg;
	unsigned int i, l;
	l = arg.size();
	for (i = 0; i <= l; i++)
	{
		switch (s[i])
		{
		    case 'ё': s[i] = 240; break;
		    case 'Ё': s[i] = 241; break;
		    case '№': s[i] = 252; break;
		}
		
		if ((s[i] >= 'А') & (s[i] <= 'п'))   s[i] = s[i] - 64;
		if ((s[i] >= 'р') & (s[i] <= 'я'))   s[i] = s[i] - 16;
	}
	return s;
}

void BitPrint(int i){
unsigned int Rab = 1 << (sizeof(int) * 8 - 1);

  while (Rab > 0){
    putchar((i & Rab) == Rab ? '1' : '0'); 
    Rab = Rab >> 1;
  }
  putchar('\n');
}