Console.WriteLine("Укажите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayString = new string[size];
int A = 0;
int B = 3;

for (int i = 0; i < size; i++){
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());

    if (element.Length <= B){
        arrayString[A] = element;
        A++;
