// See https://aka.ms/new-console-template for more information
int num1;
int num2;

Console.WriteLine("Digite o primeiro número:");
num1= int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
num2= int.Parse(Console.ReadLine());

if(num1==num2){
    Console.WriteLine("Os números são iguais");
}
else if(num1!=num2){
    Console.WriteLine("Os números não são iguais");
}else{
    Console.WriteLine("Tente novamente...");
}
